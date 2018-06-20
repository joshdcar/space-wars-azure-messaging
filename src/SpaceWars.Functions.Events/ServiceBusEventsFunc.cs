using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.ServiceBus.Messaging;
using SpaceWars.Functions.Events.Models;
using System;

namespace SpaceWars.Functions.Events
{
    public static class ServiceBusEventsFunc
    {
        [FunctionName("ServiceBusFighterRepairEventsFunc")]
        public static void ServiceBusFighterRepairEventsFunc(
            [ServiceBusTrigger("%serviceBusTopicName%", "%serviceBusFighterSubscription%", 
                                AccessRights.Manage, 
                                Connection = "serviceBus")]RepairRequest message, 
            TraceWriter log)
        {
            try
            {
                log.Error($"Repair Request. Class: {message.ShipClass} \r\n {MessageUtility.GetShipAscii(message.ShipClass)} ");


            }
            catch (Exception ex)
            {
                log.Error(ex.ToString());
            }
            
        }


        [FunctionName("ServiceBusTransportRepairEventsFunc")]
        public static void ServiceBusTransportRepairEventsFunc(
            [ServiceBusTrigger("%serviceBusTopicName%", "%serviceBusTransportSubscription%",
                                AccessRights.Manage,
                                Connection = "serviceBus")]RepairRequest request,
            TraceWriter log)
        {
            log.Warning($"Repair Request. Class: {request.ShipClass} \r\n {MessageUtility.GetShipAscii(request.ShipClass)} ");
        }

    }
}
