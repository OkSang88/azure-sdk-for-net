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
    /// <summary> Test for SqlStoredProcedure. </summary>
    public partial class SqlStoredProcedureCollectionMockTests : MockTestBase
    {
        public SqlStoredProcedureCollectionMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task CreateOrUpdateAsync()
        {
            // Example: CosmosDBSqlStoredProcedureCreateUpdate
            var collection = GetArmClient().GetSqlContainer(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.DocumentDB/databaseAccounts/ddb1/sqlDatabases/databaseName/containers/containerName")).GetSqlStoredProcedures();
            string storedProcedureName = "storedProcedureName";
            CosmosDB.Models.SqlStoredProcedureCreateUpdateOptions createUpdateSqlStoredProcedureParameters = new CosmosDB.Models.SqlStoredProcedureCreateUpdateOptions(location: "westus", resource: new CosmosDB.Models.SqlStoredProcedureResource(id: "storedProcedureName")
            {
                Body = "body",
            })
            {
                Options = new CosmosDB.Models.CreateUpdateOptions(),
            };

            await collection.CreateOrUpdateAsync(storedProcedureName, createUpdateSqlStoredProcedureParameters);
        }

        [RecordedTest]
        public async Task GetAsync()
        {
            // Example: CosmosDBSqlStoredProcedureGet
            var collection = GetArmClient().GetSqlContainer(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rgName/providers/Microsoft.DocumentDB/databaseAccounts/ddb1/sqlDatabases/databaseName/containers/containerName")).GetSqlStoredProcedures();
            string storedProcedureName = "storedProcedureName";

            await collection.GetAsync(storedProcedureName);
        }

        [RecordedTest]
        public void GetAllAsync()
        {
            // Example: CosmosDBSqlStoredProcedureList
            var collection = GetArmClient().GetSqlContainer(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rgName/providers/Microsoft.DocumentDB/databaseAccounts/ddb1/sqlDatabases/databaseName/containers/containerName")).GetSqlStoredProcedures();

            collection.GetAllAsync();
        }
    }
}
