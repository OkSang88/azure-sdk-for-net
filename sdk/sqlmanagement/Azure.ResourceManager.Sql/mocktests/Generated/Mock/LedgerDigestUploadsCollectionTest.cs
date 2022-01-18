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
    /// <summary> Test for LedgerDigestUploads. </summary>
    public partial class LedgerDigestUploadsCollectionMockTests : MockTestBase
    {
        public LedgerDigestUploadsCollectionMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task CreateOrUpdate()
        {
            // Example: Enables ledger digest upload configuration for a database
            Sql.Models.LedgerDigestUploadsName ledgerDigestUploads = new Sql.Models.LedgerDigestUploadsName("current");
            Sql.LedgerDigestUploadsData parameters = new Sql.LedgerDigestUploadsData()
            {
                DigestStorageEndpoint = "https://MyAccount.blob.core.windows.net",
            };

            var sqlDatabaseId = Sql.SqlDatabase.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "ledgertestrg", "ledgertestserver", "testdb");
            var collection = GetArmClient().GetSqlDatabase(sqlDatabaseId).GetLedgerDigestUploads();
            await collection.CreateOrUpdateAsync(true, ledgerDigestUploads, parameters);
        }

        [RecordedTest]
        public async Task Get()
        {
            // Example: Gets the current ledger digest upload configuration for a database.
            Sql.Models.LedgerDigestUploadsName ledgerDigestUploads = new Sql.Models.LedgerDigestUploadsName("current");

            var sqlDatabaseId = Sql.SqlDatabase.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "ledgertestrg", "ledgertestserver", "testdb");
            var collection = GetArmClient().GetSqlDatabase(sqlDatabaseId).GetLedgerDigestUploads();
            await collection.GetAsync(ledgerDigestUploads);
        }

        [RecordedTest]
        public async Task GetAll()
        {
            // Example: Gets list of ledger digest upload settings on a database.

            var sqlDatabaseId = Sql.SqlDatabase.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "ledgertestrg", "ledgertestserver", "testdb");
            var collection = GetArmClient().GetSqlDatabase(sqlDatabaseId).GetLedgerDigestUploads();
            await foreach (var _ in collection.GetAllAsync())
            {
            }
        }
    }
}
