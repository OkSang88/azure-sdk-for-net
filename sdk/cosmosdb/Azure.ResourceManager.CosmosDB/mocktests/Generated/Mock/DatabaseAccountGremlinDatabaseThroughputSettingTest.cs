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
    /// <summary> Test for ThroughputSettings. </summary>
    public partial class DatabaseAccountGremlinDatabaseThroughputSettingMockTests : MockTestBase
    {
        public DatabaseAccountGremlinDatabaseThroughputSettingMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task GetAsync()
        {
            // Example: CosmosDBGremlinDatabaseThroughputGet
            var databaseAccountGremlinDatabaseThroughputSetting = GetArmClient().GetDatabaseAccountGremlinDatabaseThroughputSetting(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.DocumentDB/databaseAccounts/ddb1/gremlinDatabases/databaseName/throughputSettings/default"));

            await databaseAccountGremlinDatabaseThroughputSetting.GetAsync();
        }

        [RecordedTest]
        public async Task MigrateGremlinDatabaseToAutoscaleAsync()
        {
            // Example: CosmosDBGremlinDatabaseMigrateToAutoscale
            var databaseAccountGremlinDatabaseThroughputSetting = GetArmClient().GetDatabaseAccountGremlinDatabaseThroughputSetting(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.DocumentDB/databaseAccounts/ddb1/gremlinDatabases/databaseName/throughputSettings/default"));

            await databaseAccountGremlinDatabaseThroughputSetting.MigrateGremlinDatabaseToAutoscaleAsync();
        }

        [RecordedTest]
        public async Task MigrateGremlinDatabaseToManualThroughputAsync()
        {
            // Example: CosmosDBGremlinDatabaseMigrateToManualThroughput
            var databaseAccountGremlinDatabaseThroughputSetting = GetArmClient().GetDatabaseAccountGremlinDatabaseThroughputSetting(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.DocumentDB/databaseAccounts/ddb1/gremlinDatabases/databaseName/throughputSettings/default"));

            await databaseAccountGremlinDatabaseThroughputSetting.MigrateGremlinDatabaseToManualThroughputAsync();
        }
    }
}
