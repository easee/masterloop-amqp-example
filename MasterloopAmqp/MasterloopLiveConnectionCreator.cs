using System;
using System.Threading.Tasks;
using Masterloop.Core.Types.LiveConnect;
using Masterloop.Plugin.Application;
using Serilog;

namespace MasterloopAmqp
{
    public class MasterloopLiveConnectionCreator
    {
        public static async Task<LiveConnectionDetails> Create(
            string masterloopHost,
            string masterloopUsername,
            string masterloopPassword,
            string subscriptionKey,
            ILogger logger,
            string template, 
            int[] commandIds,
            int[] observationIds)
        {
            var masterloopApi = new MasterloopServerConnection(new Uri(masterloopHost).Host, masterloopUsername, masterloopPassword);
            LiveConnectionDetails liveConnectionData = null;
            try
            {
                liveConnectionData = await masterloopApi.GetLivePersistentSubscriptionConnectionAsync(subscriptionKey);
            }
            catch (System.Net.WebException exception)
            {
                // Ignored, because the first time this runs, the GET operation fails with 500 Server Error
            }

            if (liveConnectionData == null)
            {
                var res = await masterloopApi.CreateLivePersistentSubscriptionAsync(new LivePersistentSubscriptionRequest
                {
                    TID = template,
                    SubscriptionKey = subscriptionKey,
                    CommandIds = commandIds,
                    ObservationIds = observationIds
                });

                if (res)
                {
                    logger.Information("Persistent subscription created");
                }
                else
                {
                    logger.Information("Persistent subscription created");
                    throw new Exception("Unable to create subscription");
                }

                liveConnectionData = await masterloopApi.GetLivePersistentSubscriptionConnectionAsync(subscriptionKey);
            }

            return liveConnectionData;
        }



        public static async Task<bool> DeleteQueue(
            string masterloopHost,
            string masterloopUsername,
            string masterloopPassword,
            string subscriptionKey)
        {
            var masterloopApi = new MasterloopServerConnection(new Uri(masterloopHost).Host, masterloopUsername, masterloopPassword);
            return await masterloopApi.DeleteLivePersistentSubscriptionAsync(subscriptionKey);
        }
    }
}