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
    /// <summary> Test for DatabaseTable. </summary>
    public partial class ManagedInstanceDatabaseSchemaTableCollectionMockTests : MockTestBase
    {
        public ManagedInstanceDatabaseSchemaTableCollectionMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task Get()
        {
            // Example: Get managed database table
            string tableName = "table1";

            var managedInstanceDatabaseSchemaId = Sql.ManagedInstanceDatabaseSchema.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "myRG", "myManagedInstanceName", "myDatabase", "dbo");
            var collection = GetArmClient().GetManagedInstanceDatabaseSchema(managedInstanceDatabaseSchemaId).GetManagedInstanceDatabaseSchemaTables();
            await collection.GetAsync(tableName);
        }

        [RecordedTest]
        public async Task GetAll()
        {
            // Example: List managed database tables
            string filter = null;

            var managedInstanceDatabaseSchemaId = Sql.ManagedInstanceDatabaseSchema.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "myRG", "myManagedInstanceName", "myDatabase", "dbo");
            var collection = GetArmClient().GetManagedInstanceDatabaseSchema(managedInstanceDatabaseSchemaId).GetManagedInstanceDatabaseSchemaTables();
            await foreach (var _ in collection.GetAllAsync(filter))
            {
            }
        }
    }
}
