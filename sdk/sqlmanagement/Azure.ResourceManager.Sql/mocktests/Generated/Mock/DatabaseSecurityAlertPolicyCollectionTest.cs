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
    /// <summary> Test for DatabaseSecurityAlertPolicy. </summary>
    public partial class DatabaseSecurityAlertPolicyCollectionMockTests : MockTestBase
    {
        public DatabaseSecurityAlertPolicyCollectionMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task CreateOrUpdate()
        {
            // Example: Update a database's threat detection policy with all parameters
            Sql.Models.SecurityAlertPolicyName securityAlertPolicyName = new Sql.Models.SecurityAlertPolicyName("Default");
            Sql.DatabaseSecurityAlertPolicyData parameters = new Sql.DatabaseSecurityAlertPolicyData()
            {
                State = Sql.Models.SecurityAlertsPolicyState.Enabled,
                EmailAccountAdmins = true,
                StorageEndpoint = "https://mystorage.blob.core.windows.net",
                StorageAccountAccessKey = "sdlfkjabc+sdlfkjsdlkfsjdfLDKFTERLKFDFKLjsdfksjdflsdkfD2342309432849328476458/3RSD==",
                RetentionDays = 6,
            };

            var sqlDatabaseId = Sql.SqlDatabase.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "securityalert-4799", "securityalert-6440", "testdb");
            var collection = GetArmClient().GetSqlDatabase(sqlDatabaseId).GetDatabaseSecurityAlertPolicies();
            await collection.CreateOrUpdateAsync(true, securityAlertPolicyName, parameters);
        }

        [RecordedTest]
        public async Task CreateOrUpdate2()
        {
            // Example: Update a database's threat detection policy with minimal parameters
            Sql.Models.SecurityAlertPolicyName securityAlertPolicyName = new Sql.Models.SecurityAlertPolicyName("Default");
            Sql.DatabaseSecurityAlertPolicyData parameters = new Sql.DatabaseSecurityAlertPolicyData()
            {
                State = Sql.Models.SecurityAlertsPolicyState.Enabled,
            };

            var sqlDatabaseId = Sql.SqlDatabase.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "securityalert-4799", "securityalert-6440", "testdb");
            var collection = GetArmClient().GetSqlDatabase(sqlDatabaseId).GetDatabaseSecurityAlertPolicies();
            await collection.CreateOrUpdateAsync(true, securityAlertPolicyName, parameters);
        }

        [RecordedTest]
        public async Task Get()
        {
            // Example: Get a database's threat detection policy
            Sql.Models.SecurityAlertPolicyName securityAlertPolicyName = new Sql.Models.SecurityAlertPolicyName("Default");

            var sqlDatabaseId = Sql.SqlDatabase.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "securityalert-6852", "securityalert-2080", "testdb");
            var collection = GetArmClient().GetSqlDatabase(sqlDatabaseId).GetDatabaseSecurityAlertPolicies();
            await collection.GetAsync(securityAlertPolicyName);
        }

        [RecordedTest]
        public async Task GetAll()
        {
            // Example: Get the database's threat detection policies

            var sqlDatabaseId = Sql.SqlDatabase.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "securityalert-6852", "securityalert-2080", "testdb");
            var collection = GetArmClient().GetSqlDatabase(sqlDatabaseId).GetDatabaseSecurityAlertPolicies();
            await foreach (var _ in collection.GetAllAsync())
            {
            }
        }
    }
}
