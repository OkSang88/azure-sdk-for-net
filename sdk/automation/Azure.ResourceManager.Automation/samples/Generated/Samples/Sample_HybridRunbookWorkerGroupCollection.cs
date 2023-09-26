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
using Azure.ResourceManager.Automation;
using Azure.ResourceManager.Automation.Models;

namespace Azure.ResourceManager.Automation.Samples
{
    public partial class Sample_HybridRunbookWorkerGroupCollection
    {
        // Get a hybrid worker group
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetAHybridWorkerGroup()
        {
            // Generated from example definition: specification/automation/resource-manager/Microsoft.Automation/stable/2022-02-22/examples/getHybridRunbookWorkerGroup.json
            // this example is just showing the usage of "HybridRunbookWorkerGroup_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AutomationAccountResource created on azure
            // for more information of creating AutomationAccountResource, please refer to the document of AutomationAccountResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg";
            string automationAccountName = "testaccount";
            ResourceIdentifier automationAccountResourceId = AutomationAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, automationAccountName);
            AutomationAccountResource automationAccount = client.GetAutomationAccountResource(automationAccountResourceId);

            // get the collection of this HybridRunbookWorkerGroupResource
            HybridRunbookWorkerGroupCollection collection = automationAccount.GetHybridRunbookWorkerGroups();

            // invoke the operation
            string hybridRunbookWorkerGroupName = "TestHybridGroup";
            HybridRunbookWorkerGroupResource result = await collection.GetAsync(hybridRunbookWorkerGroupName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            HybridRunbookWorkerGroupData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get a hybrid worker group
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetAHybridWorkerGroup()
        {
            // Generated from example definition: specification/automation/resource-manager/Microsoft.Automation/stable/2022-02-22/examples/getHybridRunbookWorkerGroup.json
            // this example is just showing the usage of "HybridRunbookWorkerGroup_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AutomationAccountResource created on azure
            // for more information of creating AutomationAccountResource, please refer to the document of AutomationAccountResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg";
            string automationAccountName = "testaccount";
            ResourceIdentifier automationAccountResourceId = AutomationAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, automationAccountName);
            AutomationAccountResource automationAccount = client.GetAutomationAccountResource(automationAccountResourceId);

            // get the collection of this HybridRunbookWorkerGroupResource
            HybridRunbookWorkerGroupCollection collection = automationAccount.GetHybridRunbookWorkerGroups();

            // invoke the operation
            string hybridRunbookWorkerGroupName = "TestHybridGroup";
            bool result = await collection.ExistsAsync(hybridRunbookWorkerGroupName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get a hybrid worker group
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetAHybridWorkerGroup()
        {
            // Generated from example definition: specification/automation/resource-manager/Microsoft.Automation/stable/2022-02-22/examples/getHybridRunbookWorkerGroup.json
            // this example is just showing the usage of "HybridRunbookWorkerGroup_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AutomationAccountResource created on azure
            // for more information of creating AutomationAccountResource, please refer to the document of AutomationAccountResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg";
            string automationAccountName = "testaccount";
            ResourceIdentifier automationAccountResourceId = AutomationAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, automationAccountName);
            AutomationAccountResource automationAccount = client.GetAutomationAccountResource(automationAccountResourceId);

            // get the collection of this HybridRunbookWorkerGroupResource
            HybridRunbookWorkerGroupCollection collection = automationAccount.GetHybridRunbookWorkerGroups();

            // invoke the operation
            string hybridRunbookWorkerGroupName = "TestHybridGroup";
            NullableResponse<HybridRunbookWorkerGroupResource> response = await collection.GetIfExistsAsync(hybridRunbookWorkerGroupName);
            HybridRunbookWorkerGroupResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                HybridRunbookWorkerGroupData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // Create a hybrid worker group
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateAHybridWorkerGroup()
        {
            // Generated from example definition: specification/automation/resource-manager/Microsoft.Automation/stable/2022-02-22/examples/putHybridRunbookWorkerGroup.json
            // this example is just showing the usage of "HybridRunbookWorkerGroup_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AutomationAccountResource created on azure
            // for more information of creating AutomationAccountResource, please refer to the document of AutomationAccountResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg";
            string automationAccountName = "testaccount";
            ResourceIdentifier automationAccountResourceId = AutomationAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, automationAccountName);
            AutomationAccountResource automationAccount = client.GetAutomationAccountResource(automationAccountResourceId);

            // get the collection of this HybridRunbookWorkerGroupResource
            HybridRunbookWorkerGroupCollection collection = automationAccount.GetHybridRunbookWorkerGroups();

            // invoke the operation
            string hybridRunbookWorkerGroupName = "TestHybridGroup";
            HybridRunbookWorkerGroupCreateOrUpdateContent content = new HybridRunbookWorkerGroupCreateOrUpdateContent()
            {
                CredentialName = "myRunAsCredentialName",
            };
            ArmOperation<HybridRunbookWorkerGroupResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, hybridRunbookWorkerGroupName, content);
            HybridRunbookWorkerGroupResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            HybridRunbookWorkerGroupData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // List hybrid worker groups by Automation Account
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListHybridWorkerGroupsByAutomationAccount()
        {
            // Generated from example definition: specification/automation/resource-manager/Microsoft.Automation/stable/2022-02-22/examples/listHybridRunbookWorkerGroup.json
            // this example is just showing the usage of "HybridRunbookWorkerGroup_ListByAutomationAccount" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AutomationAccountResource created on azure
            // for more information of creating AutomationAccountResource, please refer to the document of AutomationAccountResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg";
            string automationAccountName = "testaccount";
            ResourceIdentifier automationAccountResourceId = AutomationAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, automationAccountName);
            AutomationAccountResource automationAccount = client.GetAutomationAccountResource(automationAccountResourceId);

            // get the collection of this HybridRunbookWorkerGroupResource
            HybridRunbookWorkerGroupCollection collection = automationAccount.GetHybridRunbookWorkerGroups();

            // invoke the operation and iterate over the result
            await foreach (HybridRunbookWorkerGroupResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                HybridRunbookWorkerGroupData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
