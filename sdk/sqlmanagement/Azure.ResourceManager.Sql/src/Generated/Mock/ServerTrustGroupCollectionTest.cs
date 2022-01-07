// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Net;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Resources.Models;
using Azure.ResourceManager.Sql;
using Azure.ResourceManager.Sql.Models;
using Azure.ResourceManager.TestFramework;

namespace Azure.ResourceManager.Sql.Tests.Mock
{
    /// <summary> Test for ServerTrustGroup. </summary>
    public partial class ServerTrustGroupCollectionMockTests : MockTestBase
    {
        public ServerTrustGroupCollectionMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task CreateOrUpdateAsync()
        {
            // Example: Create server trust group
            var collection = GetArmClient().GetResourceGroup(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/Default")).GetServerTrustGroups();
            string locationName = "Japan East";
            string serverTrustGroupName = "server-trust-group-test";
            Sql.ServerTrustGroupData parameters = new Sql.ServerTrustGroupData();

            await collection.CreateOrUpdateAsync(locationName, serverTrustGroupName, parameters);
        }

        [RecordedTest]
        public async Task GetAsync()
        {
            // Example: Get server trust group
            var collection = GetArmClient().GetResourceGroup(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/Default")).GetServerTrustGroups();
            string locationName = "Japan East";
            string serverTrustGroupName = "server-trust-group-test";

            await collection.GetAsync(locationName, serverTrustGroupName);
        }

        [RecordedTest]
        public void GetAllAsync()
        {
            // Example: List server trust groups
            var collection = GetArmClient().GetResourceGroup(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/Default")).GetServerTrustGroups();
            string locationName = "Japan East";

            collection.GetAllAsync(locationName);
        }
    }
}
