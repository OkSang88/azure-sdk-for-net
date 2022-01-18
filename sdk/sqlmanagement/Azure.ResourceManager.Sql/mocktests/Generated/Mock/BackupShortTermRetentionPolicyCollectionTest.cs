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
    /// <summary> Test for BackupShortTermRetentionPolicy. </summary>
    public partial class BackupShortTermRetentionPolicyCollectionMockTests : MockTestBase
    {
        public BackupShortTermRetentionPolicyCollectionMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task CreateOrUpdate()
        {
            // Example: Update the short term retention policy for the database.
            Sql.Models.ShortTermRetentionPolicyName policyName = new Sql.Models.ShortTermRetentionPolicyName("default");
            Sql.BackupShortTermRetentionPolicyData parameters = new Sql.BackupShortTermRetentionPolicyData()
            {
                RetentionDays = 7,
                DiffBackupIntervalInHours = new Sql.Models.DiffBackupIntervalInHours(24),
            };

            var sqlDatabaseId = Sql.SqlDatabase.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "resourceGroup", "testsvr", "testdb");
            var collection = GetArmClient().GetSqlDatabase(sqlDatabaseId).GetBackupShortTermRetentionPolicies();
            await collection.CreateOrUpdateAsync(true, policyName, parameters);
        }

        [RecordedTest]
        public async Task Get()
        {
            // Example: Get the short term retention policy for the database.
            Sql.Models.ShortTermRetentionPolicyName policyName = new Sql.Models.ShortTermRetentionPolicyName("default");

            var sqlDatabaseId = Sql.SqlDatabase.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "Default-SQL-SouthEastAsia", "testsvr", "testdb");
            var collection = GetArmClient().GetSqlDatabase(sqlDatabaseId).GetBackupShortTermRetentionPolicies();
            await collection.GetAsync(policyName);
        }

        [RecordedTest]
        public async Task GetAll()
        {
            // Example: Get the short term retention policy for the database.

            var sqlDatabaseId = Sql.SqlDatabase.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "Default-SQL-SouthEastAsia", "testsvr", "testdb");
            var collection = GetArmClient().GetSqlDatabase(sqlDatabaseId).GetBackupShortTermRetentionPolicies();
            await foreach (var _ in collection.GetAllAsync())
            {
            }
        }
    }
}
