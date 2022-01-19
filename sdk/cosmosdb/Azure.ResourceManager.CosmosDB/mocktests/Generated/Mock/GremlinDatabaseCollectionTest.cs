// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager.CosmosDB;
using Azure.ResourceManager.CosmosDB.Models;
using Azure.ResourceManager.TestFramework;

namespace Azure.ResourceManager.CosmosDB.Tests.Mock
{
    /// <summary> Test for GremlinDatabase. </summary>
    public partial class GremlinDatabaseCollectionMockTests : MockTestBase
    {
        public GremlinDatabaseCollectionMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task CreateOrUpdate()
        {
            // Example: CosmosDBGremlinDatabaseCreateUpdate
            string databaseName = "databaseName";
            CosmosDB.Models.GremlinDatabaseCreateUpdateOptions createUpdateGremlinDatabaseParameters = new CosmosDB.Models.GremlinDatabaseCreateUpdateOptions(location: "West US", resource: new CosmosDB.Models.GremlinDatabaseResource(id: "databaseName"))
            {
                Options = new CosmosDB.Models.CreateUpdateOptions(),
            };
            createUpdateGremlinDatabaseParameters.Tags.ReplaceWith(new Dictionary<string, string>()
            {
            });

            var databaseAccountId = CosmosDB.DatabaseAccount.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "rg1", "ddb1");
            var collection = GetArmClient().GetDatabaseAccount(databaseAccountId).GetGremlinDatabases();
            await collection.CreateOrUpdateAsync(true, databaseName, createUpdateGremlinDatabaseParameters);
        }

        [RecordedTest]
        public async Task Get()
        {
            // Example: CosmosDBGremlinDatabaseGet
            string databaseName = "databaseName";

            var databaseAccountId = CosmosDB.DatabaseAccount.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "rg1", "ddb1");
            var collection = GetArmClient().GetDatabaseAccount(databaseAccountId).GetGremlinDatabases();
            await collection.GetAsync(databaseName);
        }

        [RecordedTest]
        public async Task GetAll()
        {
            // Example: CosmosDBGremlinDatabaseList

            var databaseAccountId = CosmosDB.DatabaseAccount.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "rgName", "ddb1");
            var collection = GetArmClient().GetDatabaseAccount(databaseAccountId).GetGremlinDatabases();
            await foreach (var _ in collection.GetAllAsync())
            {
            }
        }
    }
}
