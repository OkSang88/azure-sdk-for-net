// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Resources.Models;
using Azure.ResourceManager.Sql.Models;
using Azure.ResourceManager.TestFramework;

namespace Azure.ResourceManager.Sql.Tests.Mock
{
    /// <summary> Test for OutboundFirewallRule. </summary>
    public partial class OutboundFirewallRuleMockTests : MockTestBase
    {
        public OutboundFirewallRuleMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task GetAsync()
        {
            // Example: Gets outbound firewall rule.
            var outboundFirewallRule = GetArmClient().GetOutboundFirewallRule(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/sqlcrudtest-7398/providers/Microsoft.Sql/servers/sqlcrudtest-4645/outboundFirewallRules/server.database.windows.net"));

            await outboundFirewallRule.GetAsync();
        }

        [RecordedTest]
        public async Task DeleteAsync()
        {
            // Example: Deletes a outbound firewall rule with a given name.
            var outboundFirewallRule = GetArmClient().GetOutboundFirewallRule(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/sqlcrudtest-7398/providers/Microsoft.Sql/servers/sqlcrudtest-6661/outboundFirewallRules/server.database.windows.net"));

            await outboundFirewallRule.DeleteAsync();
        }
    }
}
