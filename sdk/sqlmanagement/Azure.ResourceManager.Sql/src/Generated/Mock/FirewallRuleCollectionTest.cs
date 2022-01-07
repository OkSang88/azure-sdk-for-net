// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Net;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Resources.Models;
using Azure.ResourceManager.Sql;
using Azure.ResourceManager.Sql.Models;
using Azure.ResourceManager.TestFramework;

namespace Azure.ResourceManager.Sql.Tests.Mock
{
    /// <summary> Test for FirewallRule. </summary>
    public partial class FirewallRuleCollectionMockTests : MockTestBase
    {
        public FirewallRuleCollectionMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task CreateOrUpdateAsync()
        {
            // Example: Create a firewall rule max/min
            var collection = GetArmClient().GetSqlServer(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/firewallrulecrudtest-12/providers/Microsoft.Sql/servers/firewallrulecrudtest-6285")).GetFirewallRules();
            string firewallRuleName = "firewallrulecrudtest-5370";
            Sql.FirewallRuleData parameters = new Sql.FirewallRuleData()
            {
                StartIpAddress = "0.0.0.3",
                EndIpAddress = "0.0.0.3",
            };

            await collection.CreateOrUpdateAsync(firewallRuleName, parameters);
        }

        [RecordedTest]
        public async Task CreateOrUpdateAsync2()
        {
            // Example: Update a firewall rule max/min
            var collection = GetArmClient().GetSqlServer(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/firewallrulecrudtest-12/providers/Microsoft.Sql/servers/firewallrulecrudtest-6285")).GetFirewallRules();
            string firewallRuleName = "firewallrulecrudtest-3927";
            Sql.FirewallRuleData parameters = new Sql.FirewallRuleData()
            {
                StartIpAddress = "0.0.0.1",
                EndIpAddress = "0.0.0.1",
            };

            await collection.CreateOrUpdateAsync(firewallRuleName, parameters);
        }

        [RecordedTest]
        public async Task GetAsync()
        {
            // Example: Get Firewall Rule
            var collection = GetArmClient().GetSqlServer(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/firewallrulecrudtest-12/providers/Microsoft.Sql/servers/firewallrulecrudtest-6285")).GetFirewallRules();
            string firewallRuleName = "firewallrulecrudtest-2304";

            await collection.GetAsync(firewallRuleName);
        }

        [RecordedTest]
        public void GetAllAsync()
        {
            // Example: List Firewall Rules
            var collection = GetArmClient().GetSqlServer(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/firewallrulecrudtest-12/providers/Microsoft.Sql/servers/firewallrulecrudtest-6285")).GetFirewallRules();

            collection.GetAllAsync();
        }
    }
}
