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
using Azure.ResourceManager.CosmosDB.Models;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Resources.Models;
using Azure.ResourceManager.TestFramework;

namespace Azure.ResourceManager.CosmosDB.Tests.Mock
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
            // Example: Gets private endpoint connection.
            var privateEndpointConnection = GetArmClient().GetPrivateEndpointConnection(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.DocumentDB/databaseAccounts/ddb1/privateEndpointConnections/privateEndpointConnectionName"));

            await privateEndpointConnection.GetAsync();
        }

        [RecordedTest]
        public async Task DeleteAsync()
        {
            // Example: Deletes a private endpoint connection with a given name.
            var privateEndpointConnection = GetArmClient().GetPrivateEndpointConnection(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.DocumentDB/databaseAccounts/ddb1/privateEndpointConnections/privateEndpointConnectionName"));

            await privateEndpointConnection.DeleteAsync();
        }
    }
}
