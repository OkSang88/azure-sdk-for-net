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
    /// <summary> Test for DatabaseAccount. </summary>
    public partial class DatabaseAccountCollectionMockTests : MockTestBase
    {
        public DatabaseAccountCollectionMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task CreateOrUpdateAsync()
        {
            // Example: CosmosDBDatabaseAccountCreateMax
            var collection = GetArmClient().GetResourceGroup(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1")).GetDatabaseAccounts();
            string accountName = "ddb1";
            CosmosDB.Models.DatabaseAccountCreateUpdateOptions createUpdateParameters = new CosmosDB.Models.DatabaseAccountCreateUpdateOptions(location: "westus", locations: new List<CosmosDB.Models.DatabaseAccountLocation>()
{
new CosmosDB.Models.DatabaseAccountLocation()
{
LocationName = "southcentralus", FailoverPriority = 0, IsZoneRedundant = false, },new CosmosDB.Models.DatabaseAccountLocation()
{
LocationName = "eastus", FailoverPriority = 1, IsZoneRedundant = false, },})
            {
                Kind = new CosmosDB.Models.DatabaseAccountKind("MongoDB"),
                Identity = new ResourceIdentity(),
                ConsistencyPolicy = new CosmosDB.Models.ConsistencyPolicy(defaultConsistencyLevel: CosmosDB.Models.DefaultConsistencyLevel.BoundedStaleness)
                {
                    MaxStalenessPrefix = 200,
                    MaxIntervalInSeconds = 10,
                },
                DatabaseAccountOfferType = "Standard",
                IsVirtualNetworkFilterEnabled = true,
                KeyVaultKeyUri = "https://myKeyVault.vault.azure.net",
                DefaultIdentity = "FirstPartyIdentity",
                PublicNetworkAccess = new CosmosDB.Models.PublicNetworkAccess("Enabled"),
                EnableFreeTier = false,
                ApiProperties = new CosmosDB.Models.ApiProperties()
                {
                    ServerVersion = new CosmosDB.Models.ServerVersion("3.2"),
                },
                EnableAnalyticalStorage = true,
                AnalyticalStorageConfiguration = new CosmosDB.Models.AnalyticalStorageConfiguration()
                {
                    SchemaType = new CosmosDB.Models.AnalyticalStorageSchemaType("WellDefined"),
                },
                CreateMode = new CosmosDB.Models.CreateMode("Default"),
                BackupPolicy = new CosmosDB.Models.PeriodicModeBackupPolicy()
                {
                    PeriodicModeProperties = new CosmosDB.Models.PeriodicModeProperties()
                    {
                        BackupIntervalInMinutes = 240,
                        BackupRetentionIntervalInHours = 8,
                    },
                    Type = new CosmosDB.Models.BackupPolicyType("Periodic"),
                },
                NetworkAclBypass = CosmosDB.Models.NetworkAclBypass.AzureServices,
            };
            createUpdateParameters.Tags.ReplaceWith(new Dictionary<string, string>() { });
            await collection.CreateOrUpdateAsync(accountName, createUpdateParameters);
        }

        [RecordedTest]
        public async Task CreateOrUpdateAsync2()
        {
            // Example: CosmosDBDatabaseAccountCreateMin
            var collection = GetArmClient().GetResourceGroup(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1")).GetDatabaseAccounts();
            string accountName = "ddb1";
            CosmosDB.Models.DatabaseAccountCreateUpdateOptions createUpdateParameters = new CosmosDB.Models.DatabaseAccountCreateUpdateOptions(location: "westus", locations: new List<CosmosDB.Models.DatabaseAccountLocation>()
{
new CosmosDB.Models.DatabaseAccountLocation()
{
LocationName = "southcentralus", FailoverPriority = 0, IsZoneRedundant = false, },})
            {
                DatabaseAccountOfferType = "Standard",
                CreateMode = new CosmosDB.Models.CreateMode("Default"),
            };

            await collection.CreateOrUpdateAsync(accountName, createUpdateParameters);
        }

        [RecordedTest]
        public async Task CreateOrUpdateAsync3()
        {
            // Example: CosmosDBRestoreDatabaseAccountCreateUpdate.json
            var collection = GetArmClient().GetResourceGroup(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1")).GetDatabaseAccounts();
            string accountName = "ddb1";
            CosmosDB.Models.DatabaseAccountCreateUpdateOptions createUpdateParameters = new CosmosDB.Models.DatabaseAccountCreateUpdateOptions(location: "westus", locations: new List<CosmosDB.Models.DatabaseAccountLocation>()
{
new CosmosDB.Models.DatabaseAccountLocation()
{
LocationName = "southcentralus", FailoverPriority = 0, IsZoneRedundant = false, },})
            {
                Kind = new CosmosDB.Models.DatabaseAccountKind("GlobalDocumentDB"),
                ConsistencyPolicy = new CosmosDB.Models.ConsistencyPolicy(defaultConsistencyLevel: CosmosDB.Models.DefaultConsistencyLevel.BoundedStaleness)
                {
                    MaxStalenessPrefix = 200,
                    MaxIntervalInSeconds = 10,
                },
                DatabaseAccountOfferType = "Standard",
                KeyVaultKeyUri = "https://myKeyVault.vault.azure.net",
                EnableFreeTier = false,
                ApiProperties = new CosmosDB.Models.ApiProperties()
                {
                    ServerVersion = new CosmosDB.Models.ServerVersion("3.2"),
                },
                EnableAnalyticalStorage = true,
                CreateMode = new CosmosDB.Models.CreateMode("Restore"),
                BackupPolicy = new CosmosDB.Models.ContinuousModeBackupPolicy()
                {
                    Type = new CosmosDB.Models.BackupPolicyType("Continuous"),
                },
                RestoreParameters = new CosmosDB.Models.RestoreParameters()
                {
                    RestoreMode = new CosmosDB.Models.RestoreMode("PointInTime"),
                    RestoreSource = "/subscriptions/subid/providers/Microsoft.DocumentDB/locations/westus/restorableDatabaseAccounts/1a97b4bb-f6a0-430e-ade1-638d781830cc",
                    RestoreTimestampInUtc = DateTimeOffset.Parse("2021-03-11T22:05:09Z"),
                },
            };
            createUpdateParameters.Tags.ReplaceWith(new Dictionary<string, string>() { });
            await collection.CreateOrUpdateAsync(accountName, createUpdateParameters);
        }

        [RecordedTest]
        public async Task GetAsync()
        {
            // Example: CosmosDBDatabaseAccountGet
            var collection = GetArmClient().GetResourceGroup(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1")).GetDatabaseAccounts();
            string accountName = "ddb1";

            await collection.GetAsync(accountName);
        }

        [RecordedTest]
        public void GetAllAsync()
        {
            // Example: CosmosDBDatabaseAccountListByResourceGroup
            var collection = GetArmClient().GetResourceGroup(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1")).GetDatabaseAccounts();

            collection.GetAllAsync();
        }
    }
}
