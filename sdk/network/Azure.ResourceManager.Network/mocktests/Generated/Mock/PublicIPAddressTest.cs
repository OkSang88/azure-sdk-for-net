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
    /// <summary> Test for PublicIPAddress. </summary>
    public partial class PublicIPAddressMockTests : MockTestBase
    {
        public PublicIPAddressMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task GetAsync()
        {
            // Example: Get public IP address
            var publicIPAddress = GetArmClient().GetPublicIPAddress(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Network/publicIPAddresses/testDNS-ip"));
            string expand = null;

            await publicIPAddress.GetAsync(expand);
        }

        [RecordedTest]
        public async Task DeleteAsync()
        {
            // Example: Delete public IP address
            var publicIPAddress = GetArmClient().GetPublicIPAddress(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Network/publicIPAddresses/test-ip"));

            await publicIPAddress.DeleteAsync();
        }

        [RecordedTest]
        public async Task UpdateAsync()
        {
            // Example: Update public IP address tags
            var publicIPAddress = GetArmClient().GetPublicIPAddress(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Network/publicIPAddresses/test-ip"));
            Network.Models.TagsObject parameters = new Network.Models.TagsObject();

            await publicIPAddress.UpdateAsync(parameters);
        }
    }
}
