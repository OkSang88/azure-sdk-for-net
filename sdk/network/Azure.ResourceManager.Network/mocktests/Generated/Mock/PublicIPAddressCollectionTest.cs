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
    /// <summary> Test for PublicIPAddress. </summary>
    public partial class PublicIPAddressCollectionMockTests : MockTestBase
    {
        public PublicIPAddressCollectionMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task CreateOrUpdateAsync()
        {
            // Example: Create public IP address DNS
            var collection = GetArmClient().GetResourceGroup(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1")).GetPublicIPAddresses();
            string publicIpAddressName = "test-ip";
            Network.PublicIPAddressData parameters = new Network.PublicIPAddressData()
            {
                DnsSettings = new Network.Models.PublicIPAddressDnsSettings()
                {
                    DomainNameLabel = "dnslbl",
                },
                Location = "eastus",
            };

            await collection.CreateOrUpdateAsync(publicIpAddressName, parameters);
        }

        [RecordedTest]
        public async Task CreateOrUpdateAsync2()
        {
            // Example: Create public IP address allocation method
            var collection = GetArmClient().GetResourceGroup(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1")).GetPublicIPAddresses();
            string publicIpAddressName = "test-ip";
            Network.PublicIPAddressData parameters = new Network.PublicIPAddressData()
            {
                Sku = new Network.Models.PublicIPAddressSku()
                {
                    Name = new Network.Models.PublicIPAddressSkuName("Standard"),
                    Tier = new Network.Models.PublicIPAddressSkuTier("Global"),
                },
                PublicIPAllocationMethod = new Network.Models.IPAllocationMethod("Static"),
                PublicIPAddressVersion = new Network.Models.IPVersion("IPv4"),
                IdleTimeoutInMinutes = 10,
                Location = "eastus",
            };

            await collection.CreateOrUpdateAsync(publicIpAddressName, parameters);
        }

        [RecordedTest]
        public async Task CreateOrUpdateAsync3()
        {
            // Example: Create public IP address defaults
            var collection = GetArmClient().GetResourceGroup(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1")).GetPublicIPAddresses();
            string publicIpAddressName = "test-ip";
            Network.PublicIPAddressData parameters = new Network.PublicIPAddressData()
            {
                Location = "eastus",
            };

            await collection.CreateOrUpdateAsync(publicIpAddressName, parameters);
        }

        [RecordedTest]
        public async Task GetAsync()
        {
            // Example: Get public IP address
            var collection = GetArmClient().GetResourceGroup(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1")).GetPublicIPAddresses();
            string publicIpAddressName = "testDNS-ip";
            string expand = null;

            await collection.GetAsync(publicIpAddressName, expand);
        }

        [RecordedTest]
        public void GetAllAsync()
        {
            // Example: List resource group public IP addresses
            var collection = GetArmClient().GetResourceGroup(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1")).GetPublicIPAddresses();

            collection.GetAllAsync();
        }
    }
}
