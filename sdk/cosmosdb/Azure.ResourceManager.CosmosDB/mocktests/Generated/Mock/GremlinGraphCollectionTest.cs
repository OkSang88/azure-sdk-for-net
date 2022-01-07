// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
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
    /// <summary> Test for GremlinGraph. </summary>
    public partial class GremlinGraphCollectionMockTests : MockTestBase
    {
        public GremlinGraphCollectionMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task CreateOrUpdateAsync()
        {
            // Example: CosmosDBGremlinGraphCreateUpdate
            var collection = GetArmClient().GetGremlinDatabase(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.DocumentDB/databaseAccounts/ddb1/gremlinDatabases/databaseName")).GetGremlinGraphs();
            string graphName = "graphName";
            CosmosDB.Models.GremlinGraphCreateUpdateOptions createUpdateGremlinGraphParameters = new CosmosDB.Models.GremlinGraphCreateUpdateOptions(location: "West US", resource: new CosmosDB.Models.GremlinGraphResource(id: "graphName")
            {
                IndexingPolicy = new CosmosDB.Models.IndexingPolicy()
                {
                    Automatic = true,
                    IndexingMode = new CosmosDB.Models.IndexingMode("consistent"),
                },
                PartitionKey = new CosmosDB.Models.ContainerPartitionKey()
                {
                    Kind = new CosmosDB.Models.PartitionKind("Hash"),
                },
                DefaultTtl = 100,
                UniqueKeyPolicy = new CosmosDB.Models.UniqueKeyPolicy(),
                ConflictResolutionPolicy = new CosmosDB.Models.ConflictResolutionPolicy()
                {
                    Mode = new CosmosDB.Models.ConflictResolutionMode("LastWriterWins"),
                    ConflictResolutionPath = "/path",
                },
            })
            {
                Options = new CosmosDB.Models.CreateUpdateOptions(),
            };
            createUpdateGremlinGraphParameters.Tags.ReplaceWith(new System.Collections.Generic.Dictionary<string, string>() { });
            await collection.CreateOrUpdateAsync(graphName, createUpdateGremlinGraphParameters);
        }

        [RecordedTest]
        public async Task GetAsync()
        {
            // Example: CosmosDBGremlinGraphGet
            var collection = GetArmClient().GetGremlinDatabase(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rgName/providers/Microsoft.DocumentDB/databaseAccounts/ddb1/gremlinDatabases/databaseName")).GetGremlinGraphs();
            string graphName = "graphName";

            await collection.GetAsync(graphName);
        }

        [RecordedTest]
        public void GetAllAsync()
        {
            // Example: CosmosDBGremlinGraphList
            var collection = GetArmClient().GetGremlinDatabase(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rgName/providers/Microsoft.DocumentDB/databaseAccounts/ddb1/gremlinDatabases/databaseName")).GetGremlinGraphs();

            collection.GetAllAsync();
        }
    }
}
