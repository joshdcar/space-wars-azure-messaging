using Microsoft.ServiceBus;
using Microsoft.ServiceBus.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceWars.ServiceBus.Subscription
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "[Update with your connection info]";

            const string topicName = "ship-repair-request";

            const string allShipRepairSubscription = "all-ship-repair-requests";
            const string transportRepairsSubscription = "transport-ship-repair-requests";
            const string fighterRepairsSubscription = "fighter-ship-repair-requests";

            // let's create the topic if it doesn't already exist...
            var namespaceManager = NamespaceManager.CreateFromConnectionString(connectionString);
            if (!namespaceManager.TopicExists(topicName))
            {
                var td = new TopicDescription(topicName);
                namespaceManager.CreateTopic(td);
            }

            if (!namespaceManager.SubscriptionExists(topicName, allShipRepairSubscription))
            {
                namespaceManager.CreateSubscription(topicName, allShipRepairSubscription);
            }

            if (!namespaceManager.SubscriptionExists(topicName, transportRepairsSubscription))
            {
                namespaceManager.CreateSubscription(topicName, 
                    transportRepairsSubscription, new SqlFilter("ShipClass LIKE '%Transport'"));
            }

            if (!namespaceManager.SubscriptionExists(topicName, fighterRepairsSubscription))
            {
                namespaceManager.CreateSubscription(topicName, 
                    fighterRepairsSubscription, new SqlFilter("ShipClass LIKE 'Tie%'"));
            }



        }
    }
}
