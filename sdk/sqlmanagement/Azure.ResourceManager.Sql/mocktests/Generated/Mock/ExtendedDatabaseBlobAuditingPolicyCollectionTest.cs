// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Net;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager.Sql;
using Azure.ResourceManager.Sql.Models;
using Azure.ResourceManager.TestFramework;

namespace Azure.ResourceManager.Sql.Tests.Mock
{
    /// <summary> Test for ExtendedDatabaseBlobAuditingPolicy. </summary>
    public partial class ExtendedDatabaseBlobAuditingPolicyCollectionMockTests : MockTestBase
    {
        public ExtendedDatabaseBlobAuditingPolicyCollectionMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task CreateOrUpdate()
        {
            // Example: Create or update an extended database's azure monitor auditing policy with minimal parameters
            Sql.Models.BlobAuditingPolicyName blobAuditingPolicyName = new Sql.Models.BlobAuditingPolicyName("default");
            Sql.ExtendedDatabaseBlobAuditingPolicyData parameters = new Sql.ExtendedDatabaseBlobAuditingPolicyData()
            {
                IsAzureMonitorTargetEnabled = true,
                State = Sql.Models.BlobAuditingPolicyState.Enabled,
            };

            var sqlDatabaseId = Sql.SqlDatabase.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "blobauditingtest-4799", "blobauditingtest-6440", "testdb");
            var collection = GetArmClient().GetSqlDatabase(sqlDatabaseId).GetExtendedDatabaseBlobAuditingPolicies();
            await collection.CreateOrUpdateAsync(true, blobAuditingPolicyName, parameters);
        }

        [RecordedTest]
        public async Task CreateOrUpdate2()
        {
            // Example: Create or update an extended database's blob auditing policy with all parameters
            Sql.Models.BlobAuditingPolicyName blobAuditingPolicyName = new Sql.Models.BlobAuditingPolicyName("default");
            Sql.ExtendedDatabaseBlobAuditingPolicyData parameters = new Sql.ExtendedDatabaseBlobAuditingPolicyData()
            {
                PredicateExpression = "statement = 'select 1'",
                RetentionDays = 6,
                IsStorageSecondaryKeyInUse = false,
                IsAzureMonitorTargetEnabled = true,
                QueueDelayMs = 4000,
                State = Sql.Models.BlobAuditingPolicyState.Enabled,
                StorageEndpoint = "https://mystorage.blob.core.windows.net",
                StorageAccountAccessKey = "sdlfkjabc+sdlfkjsdlkfsjdfLDKFTERLKFDFKLjsdfksjdflsdkfD2342309432849328476458/3RSD==",
                StorageAccountSubscriptionId = Guid.Parse("00000000-1234-0000-5678-000000000000"),
            };

            var sqlDatabaseId = Sql.SqlDatabase.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "blobauditingtest-4799", "blobauditingtest-6440", "testdb");
            var collection = GetArmClient().GetSqlDatabase(sqlDatabaseId).GetExtendedDatabaseBlobAuditingPolicies();
            await collection.CreateOrUpdateAsync(true, blobAuditingPolicyName, parameters);
        }

        [RecordedTest]
        public async Task CreateOrUpdate3()
        {
            // Example: Create or update an extended database's blob auditing policy with minimal parameters
            Sql.Models.BlobAuditingPolicyName blobAuditingPolicyName = new Sql.Models.BlobAuditingPolicyName("default");
            Sql.ExtendedDatabaseBlobAuditingPolicyData parameters = new Sql.ExtendedDatabaseBlobAuditingPolicyData()
            {
                State = Sql.Models.BlobAuditingPolicyState.Enabled,
                StorageEndpoint = "https://mystorage.blob.core.windows.net",
                StorageAccountAccessKey = "sdlfkjabc+sdlfkjsdlkfsjdfLDKFTERLKFDFKLjsdfksjdflsdkfD2342309432849328476458/3RSD==",
            };

            var sqlDatabaseId = Sql.SqlDatabase.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "blobauditingtest-4799", "blobauditingtest-6440", "testdb");
            var collection = GetArmClient().GetSqlDatabase(sqlDatabaseId).GetExtendedDatabaseBlobAuditingPolicies();
            await collection.CreateOrUpdateAsync(true, blobAuditingPolicyName, parameters);
        }

        [RecordedTest]
        public async Task Get()
        {
            // Example: Get an extended database's blob auditing policy
            Sql.Models.BlobAuditingPolicyName blobAuditingPolicyName = new Sql.Models.BlobAuditingPolicyName("default");

            var sqlDatabaseId = Sql.SqlDatabase.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "blobauditingtest-6852", "blobauditingtest-2080", "testdb");
            var collection = GetArmClient().GetSqlDatabase(sqlDatabaseId).GetExtendedDatabaseBlobAuditingPolicies();
            await collection.GetAsync(blobAuditingPolicyName);
        }

        [RecordedTest]
        public async Task GetAll()
        {
            // Example: List extended auditing settings of a database

            var sqlDatabaseId = Sql.SqlDatabase.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "blobauditingtest-6852", "blobauditingtest-2080", "testdb");
            var collection = GetArmClient().GetSqlDatabase(sqlDatabaseId).GetExtendedDatabaseBlobAuditingPolicies();
            await foreach (var _ in collection.GetAllAsync())
            {
            }
        }
    }
}
