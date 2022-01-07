// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
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
    /// <summary> Test for SqlContainer. </summary>
    public partial class SqlContainerMockTests : MockTestBase
    {
        public SqlContainerMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task GetAsync()
        {
            // Example: CosmosDBSqlContainerGet
            var sqlContainer = GetArmClient().GetSqlContainer(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rgName/providers/Microsoft.DocumentDB/databaseAccounts/ddb1/sqlDatabases/databaseName/containers/containerName"));

            await sqlContainer.GetAsync();
        }

        [RecordedTest]
        public async Task DeleteAsync()
        {
            // Example: CosmosDBSqlContainerDelete
            var sqlContainer = GetArmClient().GetSqlContainer(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.DocumentDB/databaseAccounts/ddb1/sqlDatabases/databaseName/containers/containerName"));

            await sqlContainer.DeleteAsync();
        }

        [RecordedTest]
        public async Task RetrieveContinuousBackupInformationAsync()
        {
            // Example: CosmosDBSqlContainerBackupInformation
            var sqlContainer = GetArmClient().GetSqlContainer(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rgName/providers/Microsoft.DocumentDB/databaseAccounts/ddb1/sqlDatabases/databaseName/containers/containerName"));
            CosmosDB.Models.ContinuousBackupRestoreLocation location = new CosmosDB.Models.ContinuousBackupRestoreLocation()
            {
                Location = "North Europe",
            };

            await sqlContainer.RetrieveContinuousBackupInformationAsync(location);
        }

        [RecordedTest]
        public async Task DatabaseAccountSqlDatabaseContainerThroughputSettingGetAsync()
        {
            // Example: CosmosDBSqlContainerThroughputGet
            var databaseAccountSqlDatabaseContainerThroughputSetting = GetArmClient().GetDatabaseAccountSqlDatabaseContainerThroughputSetting(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.DocumentDB/databaseAccounts/ddb1/sqlDatabases/databaseName/containers/containerName/throughputSettings/default"));

            await databaseAccountSqlDatabaseContainerThroughputSetting.GetAsync();
        }

        [RecordedTest]
        public async Task DatabaseAccountSqlDatabaseContainerThroughputSettingMigrateSqlContainerToAutoscaleAsync()
        {
            // Example: CosmosDBSqlContainerMigrateToAutoscale
            var databaseAccountSqlDatabaseContainerThroughputSetting = GetArmClient().GetDatabaseAccountSqlDatabaseContainerThroughputSetting(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.DocumentDB/databaseAccounts/ddb1/sqlDatabases/databaseName/containers/containerName/throughputSettings/default"));

            await databaseAccountSqlDatabaseContainerThroughputSetting.MigrateSqlContainerToAutoscaleAsync();
        }

        [RecordedTest]
        public async Task DatabaseAccountSqlDatabaseContainerThroughputSettingMigrateSqlContainerToManualThroughputAsync()
        {
            // Example: CosmosDBSqlContainerMigrateToManualThroughput
            var databaseAccountSqlDatabaseContainerThroughputSetting = GetArmClient().GetDatabaseAccountSqlDatabaseContainerThroughputSetting(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.DocumentDB/databaseAccounts/ddb1/sqlDatabases/databaseName/containers/containerName/throughputSettings/default"));

            await databaseAccountSqlDatabaseContainerThroughputSetting.MigrateSqlContainerToManualThroughputAsync();
        }
    }
}
