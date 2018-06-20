using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Azure.WebJobs.ServiceBus;
using SpaceWars.Functions.Events.Models;

namespace SpaceWars.Functions.Events
{
    public static class EventHubEventsFunc
    {
        [FunctionName("EventHubEventsFunc")]
        public static void Run(
            [EventHubTrigger("%telemetryHubName%", Connection = "telemetryHub")]ShipTelemetry[] shipTelemetry, 
            TraceWriter log)
        {

            for(int count = 0; count < shipTelemetry.Length; count++)
            {
                log.Warning($"Repair Request. Class: {shipTelemetry[count].ShipClass} \r\n {MessageUtility.GetShipAscii(shipTelemetry[count].ShipClass)} ");
            }
            
        }
    }
}
