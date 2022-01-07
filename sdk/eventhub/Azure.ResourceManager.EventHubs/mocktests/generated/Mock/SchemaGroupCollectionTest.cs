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
    /// <summary> Test for SchemaGroup. </summary>
    public partial class SchemaGroupCollectionMockTests : MockTestBase
    {
        public SchemaGroupCollectionMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task CreateOrUpdateAsync()
        {
            // Example: SchemaRegistryCreate
            var collection = GetArmClient().GetEventHubNamespace(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/alitest/providers/Microsoft.EventHub/namespaces/ali-ua-test-eh-system-1")).GetSchemaGroups();
            string schemaGroupName = "testSchemaGroup1";
            EventHubs.SchemaGroupData parameters = new EventHubs.SchemaGroupData()
            {
                SchemaCompatibility = new EventHubs.Models.SchemaCompatibility("Forward"),
                SchemaType = new EventHubs.Models.SchemaType("Avro"),
            };

            await collection.CreateOrUpdateAsync(schemaGroupName, parameters);
        }

        [RecordedTest]
        public async Task GetAsync()
        {
            // Example: SchemaRegistryGet
            var collection = GetArmClient().GetEventHubNamespace(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/alitest/providers/Microsoft.EventHub/namespaces/ali-ua-test-eh-system-1")).GetSchemaGroups();
            string schemaGroupName = "testSchemaGroup1";

            await collection.GetAsync(schemaGroupName);
        }

        [RecordedTest]
        public void GetAllAsync()
        {
            // Example: SchemaRegistryListAll
            var collection = GetArmClient().GetEventHubNamespace(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/alitest/providers/Microsoft.EventHub/namespaces/ali-ua-test-eh-system-1")).GetSchemaGroups();
            int? skip = null;
            int? top = null;

            collection.GetAllAsync(skip, top);
        }
    }
}
