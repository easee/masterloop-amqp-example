using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Masterloop.Core.Types.Base;
using Masterloop.Core.Types.Commands;
using Masterloop.Core.Types.LiveConnect;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using Serilog;

namespace MasterloopAmqp
{
    class MasterloopListenerSenderHost : IHostedService
    {
        private readonly IAsyncConnectionFactory _connectionFactory;
        private readonly LiveConnectionDetails _connectionDetails;
        private readonly IServiceProvider _serviceProvider;
        private IConnection _connection;
        private long _messagesInFlight;

        // These are for receiving
        private List<AsyncEventingBasicConsumer> _consumers = new();
        private List<IModel> channels = new();

        // Use this for sending
        private IModel _sendingModel;

        public MasterloopListenerSenderHost(IAsyncConnectionFactory connectionFactory, LiveConnectionDetails connectionDetails, IServiceProvider serviceProvider)
        {
            _connectionFactory = connectionFactory;
            _connectionDetails = connectionDetails;
            _serviceProvider = serviceProvider;
        }

        private IConnection CreateConnection()
        {
            var connection = _connectionFactory.CreateConnection();
            connection.ConnectionBlocked += (sender, args) =>
                Log.Logger.Warning("Connection blocked: {reason}", args.Reason);
            connection.ConnectionUnblocked += (sender, args) => Log.Warning("Connection unblocked");
            connection.ConnectionShutdown += (sender, args) =>
            {
                if (args.Initiator != ShutdownInitiator.Application || args.ReplyCode != 200)
                {
                    Log.Warning("Connection shutdown: {replyCode}", args.ReplyCode);
                }
            };
            return connection;
        }
        public Task StartAsync(CancellationToken cancellationToken)
        {
            _connection = CreateConnection();

            // Example using 2 consumers, 1 is probably enough 
            AddChannelConsumer();
            AddChannelConsumer();

            // Example of using separate model for sending messages
            _sendingModel = _connection.CreateModel();
            _sendingModel.BasicQos(0, 1000, false);

            return Task.CompletedTask;
        }

        public void SendCommand(string serialNumber, IEnumerable<Command> commands)
        {
            var basicProperties = _sendingModel.CreateBasicProperties();
            basicProperties.DeliveryMode = 2; // non-persistent
            basicProperties.ContentType = "application/json";
            basicProperties.Headers ??= new Dictionary<string, object>();
            var batch = _sendingModel.CreateBasicPublishBatch();
            foreach (var command in commands)
            {
                var routingKey = MessageRoutingKey.GenerateDeviceCommandRoutingKey(serialNumber, command.Id, command.Timestamp);
                var bytes = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(command));
                batch.Add(_connectionDetails.ExchangeName, routingKey, true, basicProperties, new ReadOnlyMemory<byte>(bytes));
            }
            batch.Publish();
            _sendingModel.WaitForConfirmsOrDie(TimeSpan.FromSeconds(5));
        }

        private void AddChannelConsumer()
        {
            var channel = _connection.CreateModel();
            channel.BasicQos(0, 1000, false);
            channels.Add(channel);

            var consumer = new AsyncEventingBasicConsumer(channel);
            consumer.Received += ConsumerOnReceived;
            channel.BasicConsume(queue: _connectionDetails.QueueName, false, $"test-consumer-{_consumers.Count}", consumer);
            _consumers.Add(consumer);
        }

        private async Task ConsumerOnReceived(object sender, BasicDeliverEventArgs ea)
        {
            var consumer = sender as AsyncEventingBasicConsumer;
            Interlocked.Increment(ref _messagesInFlight);
            try
            {
                var routingKey = ea.RoutingKey;

                // An example of handling CommandResponse, register a class which implements IHandleCommandResponses in Setup
                if (MessageRoutingKey.IsDeviceCommandResponse(routingKey))
                {
                    var mid = MessageRoutingKey.ParseMID(routingKey);

                    var json = Encoding.UTF8.GetString(ea.Body.ToArray());

                    CommandResponse commandResponse;
                    try
                    {
                        var jsonSerializerSettings = new JsonSerializerSettings();
                        jsonSerializerSettings.MissingMemberHandling = MissingMemberHandling.Ignore;
                        commandResponse = JsonConvert.DeserializeObject<CommandResponse>(json, jsonSerializerSettings);
                    }
                    catch (Exception e)
                    {
                        Log.Warning(e, "Exception while deserializing command response. Ignoring message: {body}", json);
                        return;
                    }

                    using var handlerScope = _serviceProvider.CreateScope();
                    foreach (var handler in handlerScope.ServiceProvider.GetRequiredService<IEnumerable<IHandleCommandResponses>>())
                    {
                        if (handler.CanHandle(commandResponse))
                            await handler.Handle(mid, commandResponse);
                    }
                }
                else
                {
                    Log.Debug("Message ignored routingKey: {routingKey}, body: {body}", routingKey, Encoding.UTF8.GetString(ea.Body.ToArray()));
                }

                // TODO REMOVE SIMULATION OF 50ms WORK ONLY
                await Task.Delay(50);
                
                consumer.Model.BasicAck(ea.DeliveryTag, false);
            }
            catch (Exception e)
            {
                consumer.Model.BasicNack(ea.DeliveryTag, false, true);
            }
            finally
            {
                Interlocked.Decrement(ref _messagesInFlight);
            }
        }

        public async Task StopAsync(CancellationToken cancellationToken)
        {
            _consumers.ForEach(c => c.Received -= ConsumerOnReceived);
            while (Interlocked.Read(ref _messagesInFlight) > 0)
            {
                await Task.Delay(50, cancellationToken);
            }
            channels.ForEach(c => c.Close());
            channels.ForEach(c => c.Dispose());

            _sendingModel.Close();
            _sendingModel.Dispose();

            _connection?.Dispose();

        }
    }
}
