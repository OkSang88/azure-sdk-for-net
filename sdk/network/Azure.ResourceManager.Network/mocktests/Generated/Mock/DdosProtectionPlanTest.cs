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
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Resources.Models;
using Azure.ResourceManager.TestFramework;

namespace Azure.ResourceManager.Network.Tests.Mock
{
    /// <summary> Test for DdosProtectionPlan. </summary>
    public partial class DdosProtectionPlanMockTests : MockTestBase
    {
        public DdosProtectionPlanMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task GetAsync()
        {
            // Example: Get DDoS protection plan
            var ddosProtectionPlan = GetArmClient().GetDdosProtectionPlan(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Network/ddosProtectionPlans/test-plan"));

            await ddosProtectionPlan.GetAsync();
        }

        [RecordedTest]
        public async Task DeleteAsync()
        {
            // Example: Delete DDoS protection plan
            var ddosProtectionPlan = GetArmClient().GetDdosProtectionPlan(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Network/ddosProtectionPlans/test-plan"));

            await ddosProtectionPlan.DeleteAsync();
        }

        [RecordedTest]
        public async Task UpdateAsync()
        {
            // Example: DDoS protection plan Update tags
            var ddosProtectionPlan = GetArmClient().GetDdosProtectionPlan(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Network/ddosProtectionPlans/test-plan"));
            Network.Models.TagsObject parameters = new Network.Models.TagsObject();

            await ddosProtectionPlan.UpdateAsync(parameters);
        }
    }
}
