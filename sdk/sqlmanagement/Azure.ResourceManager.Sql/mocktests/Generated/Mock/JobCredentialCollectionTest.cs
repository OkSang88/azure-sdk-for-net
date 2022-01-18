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
    /// <summary> Test for JobCredential. </summary>
    public partial class JobCredentialCollectionMockTests : MockTestBase
    {
        public JobCredentialCollectionMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task CreateOrUpdate()
        {
            // Example: Create or update a credential
            string credentialName = "cred1";
            Sql.JobCredentialData parameters = new Sql.JobCredentialData()
            {
                Username = "myuser",
                Password = "<password>",
            };

            var jobAgentId = Sql.JobAgent.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "group1", "server1", "agent1");
            var collection = GetArmClient().GetJobAgent(jobAgentId).GetJobCredentials();
            await collection.CreateOrUpdateAsync(true, credentialName, parameters);
        }

        [RecordedTest]
        public async Task Get()
        {
            // Example: Get a credential
            string credentialName = "cred1";

            var jobAgentId = Sql.JobAgent.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "group1", "server1", "agent1");
            var collection = GetArmClient().GetJobAgent(jobAgentId).GetJobCredentials();
            await collection.GetAsync(credentialName);
        }

        [RecordedTest]
        public async Task GetAll()
        {
            // Example: List credentials in a job agent

            var jobAgentId = Sql.JobAgent.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "group1", "server1", "agent1");
            var collection = GetArmClient().GetJobAgent(jobAgentId).GetJobCredentials();
            await foreach (var _ in collection.GetAllAsync())
            {
            }
        }
    }
}
