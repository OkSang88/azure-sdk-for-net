// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
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
    public partial class AfdSecurityPolicyCollectionMockTests : MockTestBase
    {
        public AfdSecurityPolicyCollectionMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task CreateOrUpdate()
        {
            // Example: SecurityPolicies_Create
            string securityPolicyName = "securityPolicy1";
            Cdn.AfdSecurityPolicyData securityPolicy = new Cdn.AfdSecurityPolicyData()
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

            var profileId = Cdn.Profile.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "RG", "profile1");
            var collection = GetArmClient().GetProfile(profileId).GetAfdSecurityPolicies();
            await collection.CreateOrUpdateAsync(true, securityPolicyName, securityPolicy);
        }

        [RecordedTest]
        public async Task Get()
        {
            // Example: SecurityPolicies_Get
            string securityPolicyName = "securityPolicy1";

            var profileId = Cdn.Profile.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "RG", "profile1");
            var collection = GetArmClient().GetProfile(profileId).GetAfdSecurityPolicies();
            await collection.GetAsync(securityPolicyName);
        }

        [RecordedTest]
        public async Task GetAll()
        {
            // Example: SecurityPolicies_ListByProfile

            var profileId = Cdn.Profile.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "RG", "profile1");
            var collection = GetArmClient().GetProfile(profileId).GetAfdSecurityPolicies();
            await foreach (var _ in collection.GetAllAsync())
            {
            }
        }
    }
}
