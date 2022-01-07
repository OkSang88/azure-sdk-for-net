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
    /// <summary> Test for VirtualHubRouteTableV2. </summary>
    public partial class VirtualHubRouteTableV2MockTests : MockTestBase
    {
        public VirtualHubRouteTableV2MockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task GetAsync()
        {
            // Example: VirtualHubVirtualHubRouteTableV2Get
            var virtualHubRouteTableV2 = GetArmClient().GetVirtualHubRouteTableV2(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Network/virtualHubs/virtualHub1/routeTables/virtualHubRouteTable1a"));

            await virtualHubRouteTableV2.GetAsync();
        }

        [RecordedTest]
        public async Task DeleteAsync()
        {
            // Example: VirtualHubRouteTableV2Delete
            var virtualHubRouteTableV2 = GetArmClient().GetVirtualHubRouteTableV2(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Network/virtualHubs/virtualHub1/routeTables/virtualHubRouteTable1a"));

            await virtualHubRouteTableV2.DeleteAsync();
        }
    }
}
