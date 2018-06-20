using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Host;

namespace SpaceWars.Functions.MessageGeneration
{
    public class MaintenanceCheckRequest
    {

        public string ShipDesignation { get; set; }

        public string ShipClass { get; set; }

        public int Priority { get; set; }
    }

    public static class StgMsgGenFunc
    {

        [FunctionName("StgMsgGenFunc")]
        public static async Task<HttpResponseMessage> ScheduleMaintenanceRequests(
            [HttpTrigger(AuthorizationLevel.Anonymous, "post", Route = "ScheduleMaintenanceRequests/{number:int}")]HttpRequestMessage req,
            [Queue("%maintenanceQueue%", Connection = "RequestStorage")]IAsyncCollector<MaintenanceCheckRequest> requests,
            int number,
            TraceWriter log)
        {
            var results = new List<MaintenanceCheckRequest>();
            var ships = ShipValues.FleetShips;

            for(int count = 1; count <=number; count++)
            {
                Random randomShip = new Random();
                var randomShipResult = randomShip.Next(0, ships.Count()-1);

                Random randomPriority = new Random();
                var randomPriorityResult = randomShip.Next(1, 10);

                var request = new MaintenanceCheckRequest()
                {
                    ShipDesignation = ships[randomShipResult].ShipDesignation,
                    ShipClass = ships[randomShipResult].ShipType,
                    Priority = randomPriorityResult
                };

                await requests.AddAsync(request);
                results.Add(request);
            }


            return req.CreateResponse(HttpStatusCode.OK, results);
        }
    }
}
