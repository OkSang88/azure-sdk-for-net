// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Net;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager.Sql;
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
        public async Task CreateOrUpdate()
        {
            // Example: Create a firewall rule max/min
            string firewallRuleName = "firewallrulecrudtest-5370";
            Sql.FirewallRuleData parameters = new Sql.FirewallRuleData()
            {
                StartIpAddress = "0.0.0.3",
                EndIpAddress = "0.0.0.3",
            };

            var sqlServerId = Sql.SqlServer.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "firewallrulecrudtest-12", "firewallrulecrudtest-6285");
            var collection = GetArmClient().GetSqlServer(sqlServerId).GetFirewallRules();
            await collection.CreateOrUpdateAsync(true, firewallRuleName, parameters);
        }

        [RecordedTest]
        public async Task CreateOrUpdate2()
        {
            // Example: Update a firewall rule max/min
            string firewallRuleName = "firewallrulecrudtest-3927";
            Sql.FirewallRuleData parameters = new Sql.FirewallRuleData()
            {
                StartIpAddress = "0.0.0.1",
                EndIpAddress = "0.0.0.1",
            };

            var sqlServerId = Sql.SqlServer.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "firewallrulecrudtest-12", "firewallrulecrudtest-6285");
            var collection = GetArmClient().GetSqlServer(sqlServerId).GetFirewallRules();
            await collection.CreateOrUpdateAsync(true, firewallRuleName, parameters);
        }

        [RecordedTest]
        public async Task Get()
        {
            // Example: Get Firewall Rule
            string firewallRuleName = "firewallrulecrudtest-2304";

            var sqlServerId = Sql.SqlServer.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "firewallrulecrudtest-12", "firewallrulecrudtest-6285");
            var collection = GetArmClient().GetSqlServer(sqlServerId).GetFirewallRules();
            await collection.GetAsync(firewallRuleName);
        }

        [RecordedTest]
        public async Task GetAll()
        {
            // Example: List Firewall Rules

            var sqlServerId = Sql.SqlServer.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "firewallrulecrudtest-12", "firewallrulecrudtest-6285");
            var collection = GetArmClient().GetSqlServer(sqlServerId).GetFirewallRules();
            await foreach (var _ in collection.GetAllAsync())
            {
            }
        }
    }
}
