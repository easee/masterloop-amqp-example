using System;
using System.Runtime.InteropServices;
using System.Security.Authentication;
using System.Threading.Tasks;
using Masterloop.Core.Types.LiveConnect;
using Masterloop.EASEECHG.Constants;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging.Abstractions;
using RabbitMQ.Client;
using Serilog;
using Serilog.Events;
using Serilog.Formatting.Compact;

namespace MasterloopAmqp
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            using var log = new LoggerConfiguration()
                .WriteTo.Logger(lc =>
                {
                    lc.MinimumLevel.Information()
                        .MinimumLevel.Override("Microsoft", LogEventLevel.Warning)
                        .Enrich.WithEnvironmentName()
                        .Enrich.WithMachineName()
                        .Enrich.FromLogContext()
                        .WriteTo.Console(new RenderedCompactJsonFormatter());
                })
                .CreateLogger();
            Log.Logger = log;
            try
            {
                var builder = CreateHostBuilder(args);
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    Console.WriteLine("Using console lifetime");
                    builder.UseConsoleLifetime();
                }
                using var host = builder.Build();

                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    await host.StartAsync();
                    Console.WriteLine("Press any key to quit");
                    Console.ReadKey();
                    await host.StopAsync();
                }
                else
                {
                    await host.RunAsync();
                }

                // TODO ! DON'T DO THIS IF YOU WANT TO KEEP MESSAGES WHEN APPLICATION STOPS
                var options = host.Services.GetService<Options>();
                await MasterloopLiveConnectionCreator.DeleteQueue(
                    options.Masterloop.HostName,
                    options.Masterloop.UserName,
                    options.Masterloop.Password,
                    options.Masterloop.PersistentSubscriptionKey);

            }
            catch (Exception e)
            {
                Log.Error(e, "Failed to start host");
                throw;
            }
        }

        private static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration((context, builder) =>
                {
                    builder.SetBasePath(AppContext.BaseDirectory)
                        .AddJsonFile("appSettings.json");
                    builder.AddEnvironmentVariables();
                })
                .UseSerilog()
                .UseConsoleLifetime()
                .ConfigureServices((hostContext, services) =>
                {
                    var options = hostContext.Configuration.Get<Options>();
                    hostContext.Configuration.Bind(options);
                    services.AddSingleton(options);
                    services.AddSingleton(_ =>
                    {
                        var masterloop = options.Masterloop;

                        // TODO , this list is not complete, add your commands/observations here.
                        var liveConnectionData = MasterloopLiveConnectionCreator.Create(
                            masterloop.HostName,
                            masterloop.UserName,
                            masterloop.Password,
                            masterloop.PersistentSubscriptionKey,
                            Log.Logger,
                            masterloop.Template,
                            new[]
                            {
                                Commands.Reboot,
                                Commands.SetSmartCharging,
                                Commands.SetDynamicCurrentOfflineFallback,
                                Commands.SetDynamicCircuitCurrent,
                                Commands.SetMaxCircuitCurrent,
                                Commands.AuthorizeCharging,
                                Commands.DeauthorizeCharging,
                                Commands.SetEnabled,
                                Commands.SetLockCablePermanently,
                                Commands.UpgradeFirmware,
                                Commands.SetMaxChargerCurrent,
                                Commands.SetDynamicChargerCurrent,
                                Commands.SetDynamicChargerCurrent,
                            },
                            new []
                            {
                                Observations.SmartCharging,
                                Observations.CableLocked,
                                Observations.CableRating,
                                Observations.UserIDTokenReversed,
                                Observations.ChargerOpMode,
                                Observations.OutputPhase,
                                Observations.DynamicCircuitCurrentP1,
                                Observations.DynamicCircuitCurrentP2,
                                Observations.DynamicCircuitCurrentP3,
                            }).Result;

                        return liveConnectionData;
                    });

                    services.AddSingleton<IAsyncConnectionFactory>(provider =>
                    {
                        var connectionDetails = provider.GetRequiredService<LiveConnectionDetails>();
                        return new ConnectionFactory
                        {
                            HostName = connectionDetails.Server,
                            Port = connectionDetails.Port,
                            VirtualHost = connectionDetails.VirtualHost,
                            UserName = connectionDetails.Username,
                            Password = connectionDetails.Password,
                            UseBackgroundThreadsForIO = true,
                            DispatchConsumersAsync = true,
                            AutomaticRecoveryEnabled = true,
                            ConsumerDispatchConcurrency = 100,
                            Ssl =
                            {
                                ServerName = connectionDetails.Server,
                                Version = SslProtocols.Tls12,
                                Enabled = connectionDetails.UseSsl
                            },
                        };
                    });
                    services.AddHostedService<MasterloopListenerSenderHost>();
                });
    }
}
