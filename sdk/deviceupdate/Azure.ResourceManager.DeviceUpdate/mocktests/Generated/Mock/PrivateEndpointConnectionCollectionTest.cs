// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Net;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager;
using Azure.ResourceManager.DeviceUpdate;
using Azure.ResourceManager.DeviceUpdate.Models;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Resources.Models;
using Azure.ResourceManager.TestFramework;

namespace Azure.ResourceManager.DeviceUpdate.Tests.Mock
{
    /// <summary> Test for PrivateEndpointConnection. </summary>
    public partial class PrivateEndpointConnectionCollectionMockTests : MockTestBase
    {
        public PrivateEndpointConnectionCollectionMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task CreateOrUpdateAsync()
        {
            // Example: PrivateEndpointConnectionCreateOrUpdate
            var collection = GetArmClient().GetDeviceUpdateAccount(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/test-rg/providers/Microsoft.DeviceUpdate/accounts/contoso")).GetPrivateEndpointConnections();
            string privateEndpointConnectionName = "peexample01";
            DeviceUpdate.PrivateEndpointConnectionData privateEndpointConnection = new DeviceUpdate.PrivateEndpointConnectionData()
            {
                PrivateLinkServiceConnectionState = new DeviceUpdate.Models.PrivateLinkServiceConnectionState()
                {
                    Status = new DeviceUpdate.Models.PrivateEndpointServiceConnectionStatus("Approved"),
                    Description = "Auto-Approved",
                },
            };

            await collection.CreateOrUpdateAsync(privateEndpointConnectionName, privateEndpointConnection);
        }

        [RecordedTest]
        public async Task GetAsync()
        {
            // Example: PrivateEndpointConnectionGet
            var collection = GetArmClient().GetDeviceUpdateAccount(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/test-rg/providers/Microsoft.DeviceUpdate/accounts/contoso")).GetPrivateEndpointConnections();
            string privateEndpointConnectionName = "peexample01";

            await collection.GetAsync(privateEndpointConnectionName);
        }

        [RecordedTest]
        public void GetAllAsync()
        {
            // Example: PrivateEndpointConnectionList
            var collection = GetArmClient().GetDeviceUpdateAccount(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/test-rg/providers/Microsoft.DeviceUpdate/accounts/contoso")).GetPrivateEndpointConnections();

            collection.GetAllAsync();
        }
    }
}
