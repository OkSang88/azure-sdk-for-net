// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager.Insights;
using Azure.ResourceManager.Insights.Models;
using Azure.ResourceManager.TestFramework;

namespace Azure.ResourceManager.Insights.Tests.Mock
{
    /// <summary> Test for AutoscaleSettingResource. </summary>
    public partial class AutoscaleSettingResourceMockTests : MockTestBase
    {
        public AutoscaleSettingResourceMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task Get()
        {
            // Example: Get an autoscale setting
            var autoscaleSettingResourceId = Insights.AutoscaleSettingResource.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "TestingMetricsScaleSet", "MySetting");
            var autoscaleSettingResource = GetArmClient().GetAutoscaleSettingResource(autoscaleSettingResourceId);

            await autoscaleSettingResource.GetAsync();
        }

        [RecordedTest]
        public async Task Delete()
        {
            // Example: Delete an autoscale setting
            var autoscaleSettingResourceId = Insights.AutoscaleSettingResource.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "TestingMetricsScaleSet", "MySetting");
            var autoscaleSettingResource = GetArmClient().GetAutoscaleSettingResource(autoscaleSettingResourceId);

            await autoscaleSettingResource.DeleteAsync(true);
        }

        [RecordedTest]
        public async Task Update()
        {
            // Example: Patch an autoscale setting
            var autoscaleSettingResourceId = Insights.AutoscaleSettingResource.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "TestingMetricsScaleSet", "MySetting");
            var autoscaleSettingResource = GetArmClient().GetAutoscaleSettingResource(autoscaleSettingResourceId);
            Insights.Models.AutoscaleSettingResourcePatch autoscaleSettingResource2 = new Insights.Models.AutoscaleSettingResourcePatch()
            {
                Enabled = true,
                TargetResourceUri = "/subscriptions/b67f7fec-69fc-4974-9099-a26bd6ffeda3/resourceGroups/TestingMetricsScaleSet/providers/Microsoft.Compute/virtualMachineScaleSets/testingsc",
            };

            await autoscaleSettingResource.UpdateAsync(autoscaleSettingResource2);
        }
    }
}
