// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Net;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager.Sql;
using Azure.ResourceManager.TestFramework;

namespace Azure.ResourceManager.Sql.Tests.Mock
{
    /// <summary> Test for DatabaseSchema. </summary>
    public partial class ServerDatabaseSchemaCollectionMockTests : MockTestBase
    {
        public ServerDatabaseSchemaCollectionMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task Get()
        {
            // Example: Get database schema
            string schemaName = "dbo";

            var sqlDatabaseId = Sql.SqlDatabase.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "myRG", "serverName", "myDatabase");
            var collection = GetArmClient().GetSqlDatabase(sqlDatabaseId).GetServerDatabaseSchemas();
            await collection.GetAsync(schemaName);
        }

        [RecordedTest]
        public async Task GetAll()
        {
            // Example: List database schemas
            string filter = null;

            var sqlDatabaseId = Sql.SqlDatabase.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "myRG", "serverName", "myDatabase");
            var collection = GetArmClient().GetSqlDatabase(sqlDatabaseId).GetServerDatabaseSchemas();
            await foreach (var _ in collection.GetAllAsync(filter))
            {
            }
        }
    }
}
