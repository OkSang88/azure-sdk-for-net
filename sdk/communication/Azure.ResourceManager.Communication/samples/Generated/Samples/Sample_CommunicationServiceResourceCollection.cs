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
using Azure.ResourceManager.Communication;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Communication.Samples
{
    public partial class Sample_CommunicationServiceResourceCollection
    {
        // List by resource group
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListByResourceGroup()
        {
            // Generated from example definition: specification/communication/resource-manager/Microsoft.Communication/stable/2023-04-01/examples/communicationServices/listByResourceGroup.json
            // this example is just showing the usage of "CommunicationServices_ListByResourceGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "11112222-3333-4444-5555-666677778888";
            string resourceGroupName = "MyResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this CommunicationServiceResource
            CommunicationServiceResourceCollection collection = resourceGroupResource.GetCommunicationServiceResources();

            // invoke the operation and iterate over the result
            await foreach (CommunicationServiceResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                CommunicationServiceResourceData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Get resource
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetResource()
        {
            // Generated from example definition: specification/communication/resource-manager/Microsoft.Communication/stable/2023-04-01/examples/communicationServices/get.json
            // this example is just showing the usage of "CommunicationServices_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "11112222-3333-4444-5555-666677778888";
            string resourceGroupName = "MyResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this CommunicationServiceResource
            CommunicationServiceResourceCollection collection = resourceGroupResource.GetCommunicationServiceResources();

            // invoke the operation
            string communicationServiceName = "MyCommunicationResource";
            CommunicationServiceResource result = await collection.GetAsync(communicationServiceName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CommunicationServiceResourceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get resource
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetResource()
        {
            // Generated from example definition: specification/communication/resource-manager/Microsoft.Communication/stable/2023-04-01/examples/communicationServices/get.json
            // this example is just showing the usage of "CommunicationServices_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "11112222-3333-4444-5555-666677778888";
            string resourceGroupName = "MyResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this CommunicationServiceResource
            CommunicationServiceResourceCollection collection = resourceGroupResource.GetCommunicationServiceResources();

            // invoke the operation
            string communicationServiceName = "MyCommunicationResource";
            bool result = await collection.ExistsAsync(communicationServiceName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get resource
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetResource()
        {
            // Generated from example definition: specification/communication/resource-manager/Microsoft.Communication/stable/2023-04-01/examples/communicationServices/get.json
            // this example is just showing the usage of "CommunicationServices_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "11112222-3333-4444-5555-666677778888";
            string resourceGroupName = "MyResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this CommunicationServiceResource
            CommunicationServiceResourceCollection collection = resourceGroupResource.GetCommunicationServiceResources();

            // invoke the operation
            string communicationServiceName = "MyCommunicationResource";
            NullableResponse<CommunicationServiceResource> response = await collection.GetIfExistsAsync(communicationServiceName);
            CommunicationServiceResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                CommunicationServiceResourceData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // Create or update resource
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateOrUpdateResource()
        {
            // Generated from example definition: specification/communication/resource-manager/Microsoft.Communication/stable/2023-04-01/examples/communicationServices/createOrUpdate.json
            // this example is just showing the usage of "CommunicationServices_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "11112222-3333-4444-5555-666677778888";
            string resourceGroupName = "MyResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this CommunicationServiceResource
            CommunicationServiceResourceCollection collection = resourceGroupResource.GetCommunicationServiceResources();

            // invoke the operation
            string communicationServiceName = "MyCommunicationResource";
            CommunicationServiceResourceData data = new CommunicationServiceResourceData(new AzureLocation("Global"))
            {
                DataLocation = "United States",
            };
            ArmOperation<CommunicationServiceResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, communicationServiceName, data);
            CommunicationServiceResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CommunicationServiceResourceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Create or update resource with managed identity
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateOrUpdateResourceWithManagedIdentity()
        {
            // Generated from example definition: specification/communication/resource-manager/Microsoft.Communication/stable/2023-04-01/examples/communicationServices/createOrUpdateWithSystemAssignedIdentity.json
            // this example is just showing the usage of "CommunicationServices_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "11112222-3333-4444-5555-666677778888";
            string resourceGroupName = "MyResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this CommunicationServiceResource
            CommunicationServiceResourceCollection collection = resourceGroupResource.GetCommunicationServiceResources();

            // invoke the operation
            string communicationServiceName = "MyCommunicationResource";
            CommunicationServiceResourceData data = new CommunicationServiceResourceData(new AzureLocation("Global"))
            {
                Identity = new ManagedServiceIdentity("SystemAssigned"),
                DataLocation = "United States",
            };
            ArmOperation<CommunicationServiceResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, communicationServiceName, data);
            CommunicationServiceResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CommunicationServiceResourceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
