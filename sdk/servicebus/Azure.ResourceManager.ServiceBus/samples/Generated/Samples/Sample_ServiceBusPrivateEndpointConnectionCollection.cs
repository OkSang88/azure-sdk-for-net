// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.ServiceBus;
using Azure.ResourceManager.ServiceBus.Models;

namespace Azure.ResourceManager.ServiceBus.Samples
{
    public partial class Sample_ServiceBusPrivateEndpointConnectionCollection
    {
        // NameSpaceCreate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_NameSpaceCreate()
        {
            // Generated from example definition: specification/servicebus/resource-manager/Microsoft.ServiceBus/preview/2022-10-01-preview/examples/NameSpaces/PrivateEndPointConnectionList.json
            // this example is just showing the usage of "PrivateEndpointConnections_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceBusNamespaceResource created on azure
            // for more information of creating ServiceBusNamespaceResource, please refer to the document of ServiceBusNamespaceResource
            string subscriptionId = "subID";
            string resourceGroupName = "SDK-ServiceBus-4794";
            string namespaceName = "sdk-Namespace-5828";
            ResourceIdentifier serviceBusNamespaceResourceId = ServiceBusNamespaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName);
            ServiceBusNamespaceResource serviceBusNamespace = client.GetServiceBusNamespaceResource(serviceBusNamespaceResourceId);

            // get the collection of this ServiceBusPrivateEndpointConnectionResource
            ServiceBusPrivateEndpointConnectionCollection collection = serviceBusNamespace.GetServiceBusPrivateEndpointConnections();

            // invoke the operation and iterate over the result
            await foreach (ServiceBusPrivateEndpointConnectionResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ServiceBusPrivateEndpointConnectionData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // NameSpacePrivateEndPointConnectionCreate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_NameSpacePrivateEndPointConnectionCreate()
        {
            // Generated from example definition: specification/servicebus/resource-manager/Microsoft.ServiceBus/preview/2022-10-01-preview/examples/NameSpaces/PrivateEndPointConnectionCreate.json
            // this example is just showing the usage of "PrivateEndpointConnections_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceBusNamespaceResource created on azure
            // for more information of creating ServiceBusNamespaceResource, please refer to the document of ServiceBusNamespaceResource
            string subscriptionId = "subID";
            string resourceGroupName = "ArunMonocle";
            string namespaceName = "sdk-Namespace-2924";
            ResourceIdentifier serviceBusNamespaceResourceId = ServiceBusNamespaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName);
            ServiceBusNamespaceResource serviceBusNamespace = client.GetServiceBusNamespaceResource(serviceBusNamespaceResourceId);

            // get the collection of this ServiceBusPrivateEndpointConnectionResource
            ServiceBusPrivateEndpointConnectionCollection collection = serviceBusNamespace.GetServiceBusPrivateEndpointConnections();

            // invoke the operation
            string privateEndpointConnectionName = "privateEndpointConnectionName";
            ServiceBusPrivateEndpointConnectionData data = new ServiceBusPrivateEndpointConnectionData()
            {
                PrivateEndpointId = new ResourceIdentifier("/subscriptions/dbedb4e0-40e6-4145-81f3-f1314c150774/resourceGroups/SDK-ServiceBus-8396/providers/Microsoft.Network/privateEndpoints/sdk-Namespace-2847"),
                ConnectionState = new ServiceBusPrivateLinkServiceConnectionState()
                {
                    Status = ServiceBusPrivateLinkConnectionStatus.Rejected,
                    Description = "testing",
                },
                ProvisioningState = ServiceBusPrivateEndpointConnectionProvisioningState.Succeeded,
            };
            ArmOperation<ServiceBusPrivateEndpointConnectionResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, privateEndpointConnectionName, data);
            ServiceBusPrivateEndpointConnectionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ServiceBusPrivateEndpointConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // NameSpacePrivateEndPointConnectionGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_NameSpacePrivateEndPointConnectionGet()
        {
            // Generated from example definition: specification/servicebus/resource-manager/Microsoft.ServiceBus/preview/2022-10-01-preview/examples/NameSpaces/PrivateEndPointConnectionGet.json
            // this example is just showing the usage of "PrivateEndpointConnections_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceBusNamespaceResource created on azure
            // for more information of creating ServiceBusNamespaceResource, please refer to the document of ServiceBusNamespaceResource
            string subscriptionId = "subID";
            string resourceGroupName = "SDK-ServiceBus-4794";
            string namespaceName = "sdk-Namespace-5828";
            ResourceIdentifier serviceBusNamespaceResourceId = ServiceBusNamespaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName);
            ServiceBusNamespaceResource serviceBusNamespace = client.GetServiceBusNamespaceResource(serviceBusNamespaceResourceId);

            // get the collection of this ServiceBusPrivateEndpointConnectionResource
            ServiceBusPrivateEndpointConnectionCollection collection = serviceBusNamespace.GetServiceBusPrivateEndpointConnections();

            // invoke the operation
            string privateEndpointConnectionName = "privateEndpointConnectionName";
            ServiceBusPrivateEndpointConnectionResource result = await collection.GetAsync(privateEndpointConnectionName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ServiceBusPrivateEndpointConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // NameSpacePrivateEndPointConnectionGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_NameSpacePrivateEndPointConnectionGet()
        {
            // Generated from example definition: specification/servicebus/resource-manager/Microsoft.ServiceBus/preview/2022-10-01-preview/examples/NameSpaces/PrivateEndPointConnectionGet.json
            // this example is just showing the usage of "PrivateEndpointConnections_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceBusNamespaceResource created on azure
            // for more information of creating ServiceBusNamespaceResource, please refer to the document of ServiceBusNamespaceResource
            string subscriptionId = "subID";
            string resourceGroupName = "SDK-ServiceBus-4794";
            string namespaceName = "sdk-Namespace-5828";
            ResourceIdentifier serviceBusNamespaceResourceId = ServiceBusNamespaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName);
            ServiceBusNamespaceResource serviceBusNamespace = client.GetServiceBusNamespaceResource(serviceBusNamespaceResourceId);

            // get the collection of this ServiceBusPrivateEndpointConnectionResource
            ServiceBusPrivateEndpointConnectionCollection collection = serviceBusNamespace.GetServiceBusPrivateEndpointConnections();

            // invoke the operation
            string privateEndpointConnectionName = "privateEndpointConnectionName";
            bool result = await collection.ExistsAsync(privateEndpointConnectionName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // NameSpacePrivateEndPointConnectionGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_NameSpacePrivateEndPointConnectionGet()
        {
            // Generated from example definition: specification/servicebus/resource-manager/Microsoft.ServiceBus/preview/2022-10-01-preview/examples/NameSpaces/PrivateEndPointConnectionGet.json
            // this example is just showing the usage of "PrivateEndpointConnections_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceBusNamespaceResource created on azure
            // for more information of creating ServiceBusNamespaceResource, please refer to the document of ServiceBusNamespaceResource
            string subscriptionId = "subID";
            string resourceGroupName = "SDK-ServiceBus-4794";
            string namespaceName = "sdk-Namespace-5828";
            ResourceIdentifier serviceBusNamespaceResourceId = ServiceBusNamespaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName);
            ServiceBusNamespaceResource serviceBusNamespace = client.GetServiceBusNamespaceResource(serviceBusNamespaceResourceId);

            // get the collection of this ServiceBusPrivateEndpointConnectionResource
            ServiceBusPrivateEndpointConnectionCollection collection = serviceBusNamespace.GetServiceBusPrivateEndpointConnections();

            // invoke the operation
            string privateEndpointConnectionName = "privateEndpointConnectionName";
            NullableResponse<ServiceBusPrivateEndpointConnectionResource> response = await collection.GetIfExistsAsync(privateEndpointConnectionName);
            ServiceBusPrivateEndpointConnectionResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ServiceBusPrivateEndpointConnectionData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
