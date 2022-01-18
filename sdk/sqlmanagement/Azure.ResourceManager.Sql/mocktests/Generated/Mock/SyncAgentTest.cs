// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager.Sql;
using Azure.ResourceManager.TestFramework;

namespace Azure.ResourceManager.Sql.Tests.Mock
{
    /// <summary> Test for SyncAgent. </summary>
    public partial class SyncAgentMockTests : MockTestBase
    {
        public SyncAgentMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task Get()
        {
            // Example: Get a sync agent
            var syncAgentId = Sql.SyncAgent.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "syncagentcrud-65440", "syncagentcrud-8475", "syncagentcrud-3187");
            var syncAgent = GetArmClient().GetSyncAgent(syncAgentId);

            await syncAgent.GetAsync();
        }

        [RecordedTest]
        public async Task Delete()
        {
            // Example: Delete a sync agent
            var syncAgentId = Sql.SyncAgent.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "syncagentcrud-65440", "syncagentcrud-8475", "syncagentcrud-3187");
            var syncAgent = GetArmClient().GetSyncAgent(syncAgentId);

            await syncAgent.DeleteAsync(true);
        }

        [RecordedTest]
        public async Task GenerateKey()
        {
            // Example: Generate a sync agent key
            var syncAgentId = Sql.SyncAgent.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "syncagentcrud-65440", "syncagentcrud-8475", "syncagentcrud-3187");
            var syncAgent = GetArmClient().GetSyncAgent(syncAgentId);

            await syncAgent.GenerateKeyAsync();
        }

        [RecordedTest]
        public async Task GetLinkedDatabases()
        {
            // Example: Get sync agent linked databases
            var syncAgentId = Sql.SyncAgent.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "syncagentcrud-65440", "syncagentcrud-8475", "syncagentcrud-3187");
            var syncAgent = GetArmClient().GetSyncAgent(syncAgentId);

            await foreach (var _ in syncAgent.GetLinkedDatabasesAsync())
            {
            }
        }
    }
}
