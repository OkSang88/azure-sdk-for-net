// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.TestFramework;
using Azure.ResourceManager.Cdn;
using Azure.ResourceManager.Cdn.Models;
using Azure.ResourceManager.Resources.Models;
using Azure.ResourceManager.TestFramework;

namespace Azure.ResourceManager.Cdn.Tests.Mock
{
    /// <summary> Test for AfdSecurityPolicy. </summary>
    public partial class AfdSecurityPolicyMockTests : MockTestBase
    {
        public AfdSecurityPolicyMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task Get()
        {
            // Example: SecurityPolicies_Get
            var afdSecurityPolicyId = Cdn.AfdSecurityPolicy.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "RG", "profile1", "securityPolicy1");
            var afdSecurityPolicy = GetArmClient().GetAfdSecurityPolicy(afdSecurityPolicyId);

            await afdSecurityPolicy.GetAsync();
        }

        [RecordedTest]
        public async Task Delete()
        {
            // Example: SecurityPolicies_Delete
            var afdSecurityPolicyId = Cdn.AfdSecurityPolicy.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "RG", "profile1", "securityPolicy1");
            var afdSecurityPolicy = GetArmClient().GetAfdSecurityPolicy(afdSecurityPolicyId);

            await afdSecurityPolicy.DeleteAsync(true);
        }

        [RecordedTest]
        public async Task Update()
        {
            // Example: SecurityPolicies_Patch
            var afdSecurityPolicyId = Cdn.AfdSecurityPolicy.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "RG", "profile1", "securityPolicy1");
            var afdSecurityPolicy = GetArmClient().GetAfdSecurityPolicy(afdSecurityPolicyId);
            Cdn.Models.SecurityPolicyProperties securityPolicyProperties = new Cdn.Models.SecurityPolicyProperties()
            {
                Parameters = new Cdn.Models.SecurityPolicyWebApplicationFirewallParameters()
                {
                    WafPolicy = new WritableSubResource()
                    {
                        Id = new ResourceIdentifier($"/subscriptions/00000000-0000-0000-0000-000000000000/resourcegroups/RG/providers/Microsoft.Network/frontdoorwebapplicationfirewallpolicies/wafTest"),
                    },
                    Type = new Cdn.Models.SecurityPolicyType("WebApplicationFirewall"),
                },
            };

            await afdSecurityPolicy.UpdateAsync(true, securityPolicyProperties);
        }
    }
}
