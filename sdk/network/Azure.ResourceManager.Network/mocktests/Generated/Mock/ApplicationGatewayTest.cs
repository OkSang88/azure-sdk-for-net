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
    /// <summary> Test for ApplicationGateway. </summary>
    public partial class ApplicationGatewayMockTests : MockTestBase
    {
        public ApplicationGatewayMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task GetAsync()
        {
            // Example: Get ApplicationGateway
            var applicationGateway = GetArmClient().GetApplicationGateway(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Network/applicationGateways/appgw"));

            await applicationGateway.GetAsync();
        }

        [RecordedTest]
        public async Task DeleteAsync()
        {
            // Example: Delete ApplicationGateway
            var applicationGateway = GetArmClient().GetApplicationGateway(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Network/applicationGateways/appgw"));

            await applicationGateway.DeleteAsync();
        }

        [RecordedTest]
        public async Task UpdateAsync()
        {
            // Example: Update Application Gateway tags
            var applicationGateway = GetArmClient().GetApplicationGateway(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Network/applicationGateways/AppGw"));
            Network.Models.TagsObject parameters = new Network.Models.TagsObject();

            await applicationGateway.UpdateAsync(parameters);
        }

        [RecordedTest]
        public async Task StartAsync()
        {
            // Example: Start Application Gateway
            var applicationGateway = GetArmClient().GetApplicationGateway(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Network/applicationGateways/appgw"));

            await applicationGateway.StartAsync();
        }

        [RecordedTest]
        public async Task StopAsync()
        {
            // Example: Stop Application Gateway
            var applicationGateway = GetArmClient().GetApplicationGateway(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Network/applicationGateways/appgw"));

            await applicationGateway.StopAsync();
        }

        [RecordedTest]
        public async Task BackendHealthAsync()
        {
            // Example: Get Backend Health
            var applicationGateway = GetArmClient().GetApplicationGateway(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/appgw/providers/Microsoft.Network/applicationGateways/appgw"));
            string expand = null;

            await applicationGateway.BackendHealthAsync(expand);
        }

        [RecordedTest]
        public async Task BackendHealthOnDemandAsync()
        {
            // Example: Test Backend Health
            var applicationGateway = GetArmClient().GetApplicationGateway(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Network/applicationGateways/appgw"));
            Network.Models.ApplicationGatewayOnDemandProbe probeRequest = new Network.Models.ApplicationGatewayOnDemandProbe()
            {
                Protocol = new Network.Models.ApplicationGatewayProtocol("Http"),
                Path = "/",
                Timeout = 30,
                PickHostNameFromBackendHttpSettings = true,
                BackendAddressPool = new WritableSubResource()
                {
                    Id = new ResourceIdentifier($"/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Network/applicationGateways/appgw/backendaddressPools/MFAnalyticsPool"),
                },
                BackendHttpSettings = new WritableSubResource()
                {
                    Id = new ResourceIdentifier($"/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Network/applicationGateways/appgw/backendHttpSettingsCollection/MFPoolSettings"),
                },
            };
            string expand = null;

            await applicationGateway.BackendHealthOnDemandAsync(probeRequest, expand);
        }

        [RecordedTest]
        public void GetApplicationGatewayPrivateLinkResourcesAsync()
        {
            // Example: Lists all private link resources on application gateway
            var applicationGateway = GetArmClient().GetApplicationGateway(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Network/applicationGateways/appgw"));

            applicationGateway.GetApplicationGatewayPrivateLinkResourcesAsync();
        }
    }
}
