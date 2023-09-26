// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.ApplicationInsights;
using Azure.ResourceManager.ApplicationInsights.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.ApplicationInsights.Samples
{
    public partial class Sample_WorkbookTemplateCollection
    {
        // WorkbookTemplatesList
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_WorkbookTemplatesList()
        {
            // Generated from example definition: specification/applicationinsights/resource-manager/Microsoft.Insights/stable/2020-11-20/examples/WorkbookTemplatesList.json
            // this example is just showing the usage of "WorkbookTemplates_ListByResourceGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "6b643656-33eb-422f-aee8-3ac145d124af";
            string resourceGroupName = "my-resource-group";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this WorkbookTemplateResource
            WorkbookTemplateCollection collection = resourceGroupResource.GetWorkbookTemplates();

            // invoke the operation and iterate over the result
            await foreach (WorkbookTemplateResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                WorkbookTemplateData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // WorkbookTemplateGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_WorkbookTemplateGet()
        {
            // Generated from example definition: specification/applicationinsights/resource-manager/Microsoft.Insights/stable/2020-11-20/examples/WorkbookTemplateGet.json
            // this example is just showing the usage of "WorkbookTemplates_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "6b643656-33eb-422f-aee8-3ac145d124af";
            string resourceGroupName = "my-resource-group";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this WorkbookTemplateResource
            WorkbookTemplateCollection collection = resourceGroupResource.GetWorkbookTemplates();

            // invoke the operation
            string resourceName = "my-resource-name";
            WorkbookTemplateResource result = await collection.GetAsync(resourceName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            WorkbookTemplateData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // WorkbookTemplateGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_WorkbookTemplateGet()
        {
            // Generated from example definition: specification/applicationinsights/resource-manager/Microsoft.Insights/stable/2020-11-20/examples/WorkbookTemplateGet.json
            // this example is just showing the usage of "WorkbookTemplates_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "6b643656-33eb-422f-aee8-3ac145d124af";
            string resourceGroupName = "my-resource-group";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this WorkbookTemplateResource
            WorkbookTemplateCollection collection = resourceGroupResource.GetWorkbookTemplates();

            // invoke the operation
            string resourceName = "my-resource-name";
            bool result = await collection.ExistsAsync(resourceName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // WorkbookTemplateGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_WorkbookTemplateGet()
        {
            // Generated from example definition: specification/applicationinsights/resource-manager/Microsoft.Insights/stable/2020-11-20/examples/WorkbookTemplateGet.json
            // this example is just showing the usage of "WorkbookTemplates_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "6b643656-33eb-422f-aee8-3ac145d124af";
            string resourceGroupName = "my-resource-group";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this WorkbookTemplateResource
            WorkbookTemplateCollection collection = resourceGroupResource.GetWorkbookTemplates();

            // invoke the operation
            string resourceName = "my-resource-name";
            NullableResponse<WorkbookTemplateResource> response = await collection.GetIfExistsAsync(resourceName);
            WorkbookTemplateResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                WorkbookTemplateData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // WorkbookTemplateAdd
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_WorkbookTemplateAdd()
        {
            // Generated from example definition: specification/applicationinsights/resource-manager/Microsoft.Insights/stable/2020-11-20/examples/WorkbookTemplateAdd.json
            // this example is just showing the usage of "WorkbookTemplates_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "my-resource-group";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this WorkbookTemplateResource
            WorkbookTemplateCollection collection = resourceGroupResource.GetWorkbookTemplates();

            // invoke the operation
            string resourceName = "testtemplate2";
            WorkbookTemplateData data = new WorkbookTemplateData(new AzureLocation("west us"))
            {
                Priority = 1,
                Author = "Contoso",
                TemplateData = BinaryData.FromObjectAsJson(new Dictionary<string, object>()
                {
                    ["$schema"] = "https://github.com/Microsoft/Application-Insights-Workbooks/blob/master/schema/workbook.json",
                    ["items"] = new object[] { new Dictionary<string, object>()
{
["name"] = "text - 2",
["type"] = "1",
["content"] = new Dictionary<string, object>()
{
["json"] = "## New workbook\n---\n\nWelcome to your new workbook.  This area will display text formatted as markdown.\n\n\nWe've included a basic analytics query to get you started. Use the `Edit` button below each section to configure it or add more sections."}}, new Dictionary<string, object>()
{
["name"] = "query - 2",
["type"] = "3",
["content"] = new Dictionary<string, object>()
{
["exportToExcelOptions"] = "visible",
["query"] = "union withsource=TableName *\n| summarize Count=count() by TableName\n| render barchart",
["queryType"] = "0",
["resourceType"] = "microsoft.operationalinsights/workspaces",
["size"] = "1",
["version"] = "KqlItem/1.0"}} },
                    ["styleSettings"] = new Dictionary<string, object>()
                    {
                    },
                    ["version"] = "Notebook/1.0"
                }),
                Galleries =
{
new WorkbookTemplateGallery()
{
Name = "Simple Template",
Category = "Failures",
WorkbookTemplateGalleryType = "tsg",
Order = 100,
ResourceType = "microsoft.insights/components",
}
},
                Tags =
{
},
            };
            ArmOperation<WorkbookTemplateResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, resourceName, data);
            WorkbookTemplateResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            WorkbookTemplateData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
