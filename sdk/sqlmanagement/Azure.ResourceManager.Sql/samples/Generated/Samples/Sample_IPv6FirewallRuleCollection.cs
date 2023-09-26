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
using Azure.ResourceManager.Sql;

namespace Azure.ResourceManager.Sql.Samples
{
    public partial class Sample_IPv6FirewallRuleCollection
    {
        // List IPv6 Firewall Rules
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListIPv6FirewallRules()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2022-11-01-preview/examples/IPv6FirewallRuleList.json
            // this example is just showing the usage of "IPv6FirewallRules_ListByServer" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlServerResource created on azure
            // for more information of creating SqlServerResource, please refer to the document of SqlServerResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "firewallrulecrudtest-12";
            string serverName = "firewallrulecrudtest-6285";
            ResourceIdentifier sqlServerResourceId = SqlServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            SqlServerResource sqlServer = client.GetSqlServerResource(sqlServerResourceId);

            // get the collection of this IPv6FirewallRuleResource
            IPv6FirewallRuleCollection collection = sqlServer.GetIPv6FirewallRules();

            // invoke the operation and iterate over the result
            await foreach (IPv6FirewallRuleResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                IPv6FirewallRuleData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Get IPv6 Firewall Rule
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetIPv6FirewallRule()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2022-11-01-preview/examples/IPv6FirewallRuleGet.json
            // this example is just showing the usage of "IPv6FirewallRules_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlServerResource created on azure
            // for more information of creating SqlServerResource, please refer to the document of SqlServerResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "firewallrulecrudtest-12";
            string serverName = "firewallrulecrudtest-6285";
            ResourceIdentifier sqlServerResourceId = SqlServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            SqlServerResource sqlServer = client.GetSqlServerResource(sqlServerResourceId);

            // get the collection of this IPv6FirewallRuleResource
            IPv6FirewallRuleCollection collection = sqlServer.GetIPv6FirewallRules();

            // invoke the operation
            string firewallRuleName = "firewallrulecrudtest-2304";
            IPv6FirewallRuleResource result = await collection.GetAsync(firewallRuleName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            IPv6FirewallRuleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get IPv6 Firewall Rule
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetIPv6FirewallRule()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2022-11-01-preview/examples/IPv6FirewallRuleGet.json
            // this example is just showing the usage of "IPv6FirewallRules_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlServerResource created on azure
            // for more information of creating SqlServerResource, please refer to the document of SqlServerResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "firewallrulecrudtest-12";
            string serverName = "firewallrulecrudtest-6285";
            ResourceIdentifier sqlServerResourceId = SqlServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            SqlServerResource sqlServer = client.GetSqlServerResource(sqlServerResourceId);

            // get the collection of this IPv6FirewallRuleResource
            IPv6FirewallRuleCollection collection = sqlServer.GetIPv6FirewallRules();

            // invoke the operation
            string firewallRuleName = "firewallrulecrudtest-2304";
            bool result = await collection.ExistsAsync(firewallRuleName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get IPv6 Firewall Rule
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetIPv6FirewallRule()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2022-11-01-preview/examples/IPv6FirewallRuleGet.json
            // this example is just showing the usage of "IPv6FirewallRules_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlServerResource created on azure
            // for more information of creating SqlServerResource, please refer to the document of SqlServerResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "firewallrulecrudtest-12";
            string serverName = "firewallrulecrudtest-6285";
            ResourceIdentifier sqlServerResourceId = SqlServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            SqlServerResource sqlServer = client.GetSqlServerResource(sqlServerResourceId);

            // get the collection of this IPv6FirewallRuleResource
            IPv6FirewallRuleCollection collection = sqlServer.GetIPv6FirewallRules();

            // invoke the operation
            string firewallRuleName = "firewallrulecrudtest-2304";
            NullableResponse<IPv6FirewallRuleResource> response = await collection.GetIfExistsAsync(firewallRuleName);
            IPv6FirewallRuleResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                IPv6FirewallRuleData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // Create an IPv6 firewall rule max/min
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateAnIPv6FirewallRuleMaxMin()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2022-11-01-preview/examples/IPv6FirewallRuleCreate.json
            // this example is just showing the usage of "IPv6FirewallRules_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlServerResource created on azure
            // for more information of creating SqlServerResource, please refer to the document of SqlServerResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "firewallrulecrudtest-12";
            string serverName = "firewallrulecrudtest-6285";
            ResourceIdentifier sqlServerResourceId = SqlServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            SqlServerResource sqlServer = client.GetSqlServerResource(sqlServerResourceId);

            // get the collection of this IPv6FirewallRuleResource
            IPv6FirewallRuleCollection collection = sqlServer.GetIPv6FirewallRules();

            // invoke the operation
            string firewallRuleName = "firewallrulecrudtest-5370";
            IPv6FirewallRuleData data = new IPv6FirewallRuleData()
            {
                StartIPv6Address = "0000:0000:0000:0000:0000:ffff:0000:0003",
                EndIPv6Address = "0000:0000:0000:0000:0000:ffff:0000:0003",
            };
            ArmOperation<IPv6FirewallRuleResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, firewallRuleName, data);
            IPv6FirewallRuleResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            IPv6FirewallRuleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Update an IPv6 firewall rule max/min
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_UpdateAnIPv6FirewallRuleMaxMin()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2022-11-01-preview/examples/IPv6FirewallRuleUpdate.json
            // this example is just showing the usage of "IPv6FirewallRules_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlServerResource created on azure
            // for more information of creating SqlServerResource, please refer to the document of SqlServerResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "firewallrulecrudtest-12";
            string serverName = "firewallrulecrudtest-6285";
            ResourceIdentifier sqlServerResourceId = SqlServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            SqlServerResource sqlServer = client.GetSqlServerResource(sqlServerResourceId);

            // get the collection of this IPv6FirewallRuleResource
            IPv6FirewallRuleCollection collection = sqlServer.GetIPv6FirewallRules();

            // invoke the operation
            string firewallRuleName = "firewallrulecrudtest-3927";
            IPv6FirewallRuleData data = new IPv6FirewallRuleData()
            {
                StartIPv6Address = "0000:0000:0000:0000:0000:ffff:0000:0001",
                EndIPv6Address = "0000:0000:0000:0000:0000:ffff:0000:0001",
            };
            ArmOperation<IPv6FirewallRuleResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, firewallRuleName, data);
            IPv6FirewallRuleResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            IPv6FirewallRuleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
