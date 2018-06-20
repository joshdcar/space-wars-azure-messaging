using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.ServiceBus.Messaging;
using Newtonsoft.Json;

namespace SpaceWars.Functions.MessageGeneration
{
    public class RepairRequest
    {

        public string ShipDesignation { get; set; }

        public string ShipClass { get; set; }

        public string RepairTypes { get; set; }

        public int ShipDamagePercentage { get; set; }
    }

    public static class ServiceBusMsgGenFunc
    {
        [FunctionName("GenerateRepairRequests")]
        public static async Task<HttpResponseMessage> GenerateShiptTelemetry(
            [HttpTrigger(AuthorizationLevel.Anonymous, "post", Route = "GenerateRepairRequests/{number:int}")]HttpRequestMessage req,
            [ServiceBus("%serviceBusTopicName%", 
            AccessRights.Manage, Connection = "serviceBus")]IAsyncCollector<BrokeredMessage> requests,
            int number,
            TraceWriter log)
        {

            var ships = ShipValues.FleetShips;

            for (int count = 1; count <= number; count++)
            {
                Random random = new Random();
                var randomShipResult = random.Next(0, ships.Count() - 1);

                var randomRepairType = random.Next(0, 4);

                var randomDamageValue = random.Next(0, 100);

                var request = new RepairRequest()
                {
                    ShipDesignation = ships[randomShipResult].ShipDesignation,
                    ShipClass = ships[randomShipResult].ShipType,
                    RepairTypes = ShipValues.repairTypes[randomRepairType],
                    ShipDamagePercentage = randomDamageValue
                };

                var messageBody = JsonConvert.SerializeObject(request);
                byte[] bytes = Encoding.UTF8.GetBytes(messageBody);
                MemoryStream stream = new MemoryStream(bytes, writable: false);
                var msg = new BrokeredMessage(stream) { ContentType = "application/json" };


                msg.Properties.Add("ShipClass", request.ShipClass);
                msg.Properties.Add("RepairType", request.RepairTypes);

                await requests.AddAsync(msg);
            }

            return req.CreateResponse(HttpStatusCode.OK, number);

        }
    }
}
