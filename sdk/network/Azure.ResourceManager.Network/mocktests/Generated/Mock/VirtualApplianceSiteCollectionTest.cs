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
    /// <summary> Test for VirtualApplianceSite. </summary>
    public partial class VirtualApplianceSiteCollectionMockTests : MockTestBase
    {
        public VirtualApplianceSiteCollectionMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task CreateOrUpdateAsync()
        {
            // Example: Create Network Virtual Appliance Site
            var collection = GetArmClient().GetNetworkVirtualAppliance(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Network/networkVirtualAppliances/nva")).GetVirtualApplianceSites();
            string siteName = "site1";
            Network.VirtualApplianceSiteData parameters = new Network.VirtualApplianceSiteData()
            {
                AddressPrefix = "192.168.1.0/24",
                O365Policy = new Network.Models.Office365PolicyProperties()
                {
                    BreakOutCategories = new Network.Models.BreakOutCategoryPolicies()
                    {
                        Allow = true,
                        Optimize = true,
                        Default = true,
                    },
                },
            };

            await collection.CreateOrUpdateAsync(siteName, parameters);
        }

        [RecordedTest]
        public async Task GetAsync()
        {
            // Example: GetNetwork Virtual Appliance Site
            var collection = GetArmClient().GetNetworkVirtualAppliance(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Network/networkVirtualAppliances/nva")).GetVirtualApplianceSites();
            string siteName = "site1";

            await collection.GetAsync(siteName);
        }

        [RecordedTest]
        public void GetAllAsync()
        {
            // Example: List all Network Virtual Appliance sites for a given Network Virtual Appliance
            var collection = GetArmClient().GetNetworkVirtualAppliance(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Network/networkVirtualAppliances/nva")).GetVirtualApplianceSites();

            collection.GetAllAsync();
        }
    }
}
