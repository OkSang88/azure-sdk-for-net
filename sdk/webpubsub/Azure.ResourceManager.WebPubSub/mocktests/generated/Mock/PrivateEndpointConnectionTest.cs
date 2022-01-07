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
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Resources.Models;
using Azure.ResourceManager.TestFramework;
using Azure.ResourceManager.WebPubSub.Models;

namespace Azure.ResourceManager.WebPubSub.Tests.Mock
{
    /// <summary> Test for PrivateEndpointConnection. </summary>
    public partial class PrivateEndpointConnectionMockTests : MockTestBase
    {
        public PrivateEndpointConnectionMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task GetAsync()
        {
            // Example: WebPubSubPrivateEndpointConnections_Get
            var privateEndpointConnection = GetArmClient().GetPrivateEndpointConnection(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/myResourceGroup/providers/Microsoft.SignalRService/webPubSub/myWebPubSubService/privateEndpointConnections/mywebpubsubservice.1fa229cd-bf3f-47f0-8c49-afb36723997e"));

            await privateEndpointConnection.GetAsync();
        }

        [RecordedTest]
        public async Task DeleteAsync()
        {
            // Example: WebPubSubPrivateEndpointConnections_Delete
            var privateEndpointConnection = GetArmClient().GetPrivateEndpointConnection(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/myResourceGroup/providers/Microsoft.SignalRService/webPubSub/myWebPubSubService/privateEndpointConnections/mywebpubsubservice.1fa229cd-bf3f-47f0-8c49-afb36723997e"));

            await privateEndpointConnection.DeleteAsync();
        }
    }
}
