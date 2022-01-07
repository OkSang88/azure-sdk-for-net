// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Net;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager;
using Azure.ResourceManager.Network;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Resources.Models;
using Azure.ResourceManager.TestFramework;

namespace Azure.ResourceManager.Network.Tests.Mock
{
    /// <summary> Test for VirtualRouter. </summary>
    public partial class VirtualRouterCollectionMockTests : MockTestBase
    {
        public VirtualRouterCollectionMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task CreateOrUpdateAsync()
        {
            // Example: Create VirtualRouter
            var collection = GetArmClient().GetResourceGroup(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1")).GetVirtualRouters();
            string virtualRouterName = "virtualRouter";
            Network.VirtualRouterData parameters = new Network.VirtualRouterData()
            {
                HostedGateway = new WritableSubResource()
                {
                    Id = new ResourceIdentifier($"/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Network/virtualNetworkGateways/vnetGateway"),
                },
                Location = "West US",
            };

            await collection.CreateOrUpdateAsync(virtualRouterName, parameters);
        }

        [RecordedTest]
        public async Task GetAsync()
        {
            // Example: Get VirtualRouter
            var collection = GetArmClient().GetResourceGroup(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1")).GetVirtualRouters();
            string virtualRouterName = "virtualRouter";
            string expand = null;

            await collection.GetAsync(virtualRouterName, expand);
        }

        [RecordedTest]
        public void GetAllAsync()
        {
            // Example: List all Virtual Router for a given resource group
            var collection = GetArmClient().GetResourceGroup(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1")).GetVirtualRouters();

            collection.GetAllAsync();
        }
    }
}
