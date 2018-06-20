# SpaceWars-Azure-Messaging

This repository includes the demo code for my presentation on Azure Messaging Options. Slidedeck in the reposoitory and available at https://www.slideshare.net/joshcarlisle/azure-messaging-with-azure-functions 

To run these demos you will need Visual Studio 2017 with the Cloud Workload and Azure Functions Extensions installed. You will also need an Azure Subscription (Trial will work).

You will need to provision the following resources for all the code samples:
- Azure Storage Account (queues)
- Standard Service Bus (not basic - we work with topics)
- Event Hub (not IOT Event Hub)
- Event Grid Topic

Don't forget to update the appsettings with the appropriate connection strings for your azure resources.

The project contains the following projects

- SpaceWars.Functions.MessageGeneration - API Endpoints that generate messages for the demos
- SpaceWars.Functions.Events - Functions that listen for new events
- SpaceWars.ServiceBus.Subscriptions - Utility to create new Subscriptions with Filters

This demo code does NOT include Event Grid Azure Functions. Event Grid requires a publicably accessible endpoint so the demos were done with Functions developed on the Azure Portal - sorry :) 

If you missed my presentation please check back soon for a link to a recorded version.  Questions\comments? Please reach out to me on Twitter at @joshcarlisle. 