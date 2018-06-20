using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Azure.WebJobs.ServiceBus;
using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace SpaceWars.Functions.MessageGeneration
{
    public class ShipTelemetry
    {
        public string ShipDesignation { get; set; }

        public string ShipClass { get; set; }

        public string Sensor { get; set; }

        public int SensorValue { get; set; }
    }

    public static class EventHubMsgGenFunc
    {
        

        [FunctionName("EventHubMsgGenFunc")]
        public static async Task<HttpResponseMessage> GenerateShiptTelemetry(
            [HttpTrigger(AuthorizationLevel.Anonymous, "post", Route = "GenerateShiptTelemetry/{number:int}")]HttpRequestMessage req,
            [EventHub("%telemetryHubName%", Connection = "telemetryHub")]IAsyncCollector<ShipTelemetry> requests,
            int number,
            TraceWriter log)
        {

            var ships = ShipValues.FleetShips;

            for (int count = 1; count <= number; count++)
            {
                Random random = new Random();
                var randomShipResult = random.Next(0, ships.Count() - 1);

                var randomSensor = random.Next(0, 3);

                var randomSensorValue = random.Next(0, 100);

                var request = new ShipTelemetry()
                {
                    ShipDesignation = ships[randomShipResult].ShipDesignation,
                    ShipClass = ships[randomShipResult].ShipType,
                    Sensor = ShipValues.sensorTypes[randomSensor],
                    SensorValue = randomSensorValue
                };

                await requests.AddAsync(request);
            }

            return req.CreateResponse(HttpStatusCode.OK, number);

        }
    }
}
