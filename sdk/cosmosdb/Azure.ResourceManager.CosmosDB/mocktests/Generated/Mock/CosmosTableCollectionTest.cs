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
    /// <summary> Test for CosmosTable. </summary>
    public partial class CosmosTableCollectionMockTests : MockTestBase
    {
        public CosmosTableCollectionMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task CreateOrUpdate()
        {
            // Example: CosmosDBTableReplace
            string tableName = "tableName";
            CosmosDB.Models.TableCreateUpdateOptions createUpdateTableParameters = new CosmosDB.Models.TableCreateUpdateOptions(location: "West US", resource: new CosmosDB.Models.TableResource(id: "tableName"))
            {
                Options = new CosmosDB.Models.CreateUpdateOptions(),
            };
            createUpdateTableParameters.Tags.ReplaceWith(new Dictionary<string, string>()
            {
            });

            var databaseAccountId = CosmosDB.DatabaseAccount.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "rg1", "ddb1");
            var collection = GetArmClient().GetDatabaseAccount(databaseAccountId).GetCosmosTables();
            await collection.CreateOrUpdateAsync(true, tableName, createUpdateTableParameters);
        }

        [RecordedTest]
        public async Task Get()
        {
            // Example: CosmosDBTableGet
            string tableName = "tableName";

            var databaseAccountId = CosmosDB.DatabaseAccount.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "rg1", "ddb1");
            var collection = GetArmClient().GetDatabaseAccount(databaseAccountId).GetCosmosTables();
            await collection.GetAsync(tableName);
        }

        [RecordedTest]
        public async Task GetAll()
        {
            // Example: CosmosDBTableList

            var databaseAccountId = CosmosDB.DatabaseAccount.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "rgName", "ddb1");
            var collection = GetArmClient().GetDatabaseAccount(databaseAccountId).GetCosmosTables();
            await foreach (var _ in collection.GetAllAsync())
            {
            }
        }
    }
}
