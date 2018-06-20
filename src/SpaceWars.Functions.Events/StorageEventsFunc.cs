using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using SpaceWars.Functions.Events.Models;
using SpaceWars.Functions.Events.Resources;

namespace SpaceWars.Functions.Events
{
    public static class StorageEventsFunc
    {

        // Valid Queue Trigger Parameter
        // String - [QueueTrigger("maintenancerequest", Connection = "SpaceWarsStorage")]string myQueueItem
        // POCO - [QueueTrigger("maintenancerequest", Connection = "SpaceWarsStorage")]MaintenanceRequest request
        // Byte Array - [QueueTrigger("maintenancerequest", Connection = "SpaceWarsStorage")]Byte[] request
        // Native Queue Class - [QueueTrigger("maintenancerequest", Connection = "SpaceWarsStorage")]CloudQueueMessage request

        [FunctionName("MaintenanceRequestTrigger")]
        public static void Run(
            [QueueTrigger("%SpaceWarsStorageQueue%", Connection = "SpaceWarsStorage")]
                                MaintenanceCheckRequest request, 
            TraceWriter log)
        {
            log.Warning($"Maintenance Request. Designation: {request.ShipDesignation} \r\n {MessageUtility.GetShipAscii(request.ShipClass)} \r\n \r\n");
        }

        

    }
}
