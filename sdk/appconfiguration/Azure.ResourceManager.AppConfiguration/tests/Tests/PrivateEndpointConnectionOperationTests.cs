﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Azure.Core.TestFramework;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Network;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.AppConfiguration;
using Azure.ResourceManager.AppConfiguration.Models;

using NUnit.Framework;
using Azure.Core;

namespace Azure.ResourceManager.AppConfiguration.Tests
{
    public class PrivateEndpointConnectionOperationTests : AppConfigurationClientBase
    {
        private ResourceGroupResource ResGroup { get; set; }
        private ConfigurationStoreResource ConfigStore { get; set; }
        private Network.PrivateEndpointResource PrivateEndpointResource { get; set; }
        private AppConfigurationPrivateEndpointConnectionResource Connection { get; set; }

        public PrivateEndpointConnectionOperationTests(bool isAsync)
            : base(isAsync)
        {
        }

        [SetUp]
        public async Task TestSetUp()
        {
            if (Mode == RecordedTestMode.Record || Mode == RecordedTestMode.Playback)
            {
                Initialize();
                string groupName = Recording.GenerateAssetName(ResourceGroupPrefix);
                string VnetName = Recording.GenerateAssetName("vnetname");
                string SubnetName = Recording.GenerateAssetName("subnetname");
                string EndpointName = Recording.GenerateAssetName("endpointxyz");
                ResGroup = (await ArmClient.GetDefaultSubscriptionAsync().Result.GetResourceGroups().CreateOrUpdateAsync(WaitUntil.Completed, groupName, new ResourceGroupData(Location))).Value;
                string configurationStoreName = Recording.GenerateAssetName("testapp-");
                ConfigurationStoreData configurationStoreData = new ConfigurationStoreData(Location, new AppConfigurationSku("Standard"))
                {
                    PublicNetworkAccess = PublicNetworkAccess.Disabled
                };
                ConfigStore = (await ResGroup.GetConfigurationStores().CreateOrUpdateAsync(WaitUntil.Completed, configurationStoreName, configurationStoreData)).Value;
                // Prepare VNet and Private Endpoint
                VirtualNetworkData vnetData = new VirtualNetworkData()
                {
                    Location = "eastus",
                    Subnets = { new SubnetData() { Name = SubnetName, AddressPrefix = "10.0.0.0/24", PrivateEndpointNetworkPolicies = "Disabled" } }
                };
                vnetData.AddressPrefixes.Add("10.0.0.0/16");
                vnetData.DhcpOptionsDnsServers.Add("10.1.1.1");
                vnetData.DhcpOptionsDnsServers.Add("10.1.2.4");
                VirtualNetworkResource vnet = (await ResGroup.GetVirtualNetworks().CreateOrUpdateAsync(WaitUntil.Completed, VnetName, vnetData)).Value;
                PrivateEndpointData privateEndpointData = new PrivateEndpointData()
                {
                    Location = "eastus",
                    PrivateLinkServiceConnections = { new PrivateLinkServiceConnection()
                        {
                            Name ="myconnection",
                            PrivateLinkServiceId = ConfigStore.Data.Id,
                            GroupIds = {"configurationStores"},
                            RequestMessage = "Please approve my connection",
                        }
                        },
                    Subnet = new SubnetData() { Id = new ResourceIdentifier("/subscriptions/" + TestEnvironment.SubscriptionId + "/resourceGroups/" + groupName + "/providers/Microsoft.Network/virtualNetworks/" + VnetName + "/subnets/" + SubnetName) }
                };
                PrivateEndpointResource = (await ResGroup.GetPrivateEndpoints().CreateOrUpdateAsync(WaitUntil.Completed, EndpointName, privateEndpointData)).Value;
                List<AppConfigurationPrivateEndpointConnectionResource> connections = await ConfigStore.GetAppConfigurationPrivateEndpointConnections().GetAllAsync().ToEnumerableAsync();
                Connection = connections.FirstOrDefault();
            }
        }

        [Test]
        public async Task DeleteTest()
        {
            await Connection.DeleteAsync(WaitUntil.Completed);
            var exception = Assert.ThrowsAsync<RequestFailedException>(async () => { AppConfigurationPrivateEndpointConnectionResource connection = await ConfigStore.GetAppConfigurationPrivateEndpointConnections().GetAsync(Connection.Data.Name); });

            Assert.AreEqual(404, exception.Status);
        }

        [Test]
        public async Task GetTest()
        {
            AppConfigurationPrivateEndpointConnectionResource connection = await Connection.GetAsync();
            Assert.IsTrue(Connection.Data.Name.Equals(connection.Data.Name));
        }

        [Ignore("Not available on this resource")]
        [Test]
        public async Task GetAvailableLocationsTest()
        {
            IEnumerable<AzureLocation> locations =  (await Connection.GetAvailableLocationsAsync()).Value;

            Assert.IsNotEmpty(locations);
        }
    }
}
