// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Net;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager;
using Azure.ResourceManager.EventHubs;
using Azure.ResourceManager.EventHubs.Models;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Resources.Models;
using Azure.ResourceManager.TestFramework;

namespace Azure.ResourceManager.EventHubs.Tests.Mock
{
    /// <summary> Test for EventHubNamespace. </summary>
    public partial class EventHubNamespaceCollectionMockTests : MockTestBase
    {
        public EventHubNamespaceCollectionMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task CreateOrUpdateAsync()
        {
            // Example: NamespaceCreate
            var collection = GetArmClient().GetResourceGroup(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/ResurceGroupSample")).GetEventHubNamespaces();
            string namespaceName = "NamespaceSample";
            EventHubs.EventHubNamespaceData parameters = new EventHubs.EventHubNamespaceData(location: "East US")
            {
                Identity = new ResourceIdentity(),
                ClusterArmId = "/subscriptions/SampleSubscription/resourceGroups/ResurceGroupSample/providers/Microsoft.EventHub/clusters/enc-test",
                Encryption = new EventHubs.Models.EventHubEncryption()
                {
                    KeySource = "Microsoft.KeyVault",
                },
            };

            await collection.CreateOrUpdateAsync(namespaceName, parameters);
        }

        [RecordedTest]
        public async Task GetAsync()
        {
            // Example: NameSpaceGet
            var collection = GetArmClient().GetResourceGroup(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/ResurceGroupSample")).GetEventHubNamespaces();
            string namespaceName = "NamespaceSample";

            await collection.GetAsync(namespaceName);
        }

        [RecordedTest]
        public void GetAllAsync()
        {
            // Example: NamespaceListByResourceGroup
            var collection = GetArmClient().GetResourceGroup(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/ResurceGroupSample")).GetEventHubNamespaces();

            collection.GetAllAsync();
        }
    }
}
