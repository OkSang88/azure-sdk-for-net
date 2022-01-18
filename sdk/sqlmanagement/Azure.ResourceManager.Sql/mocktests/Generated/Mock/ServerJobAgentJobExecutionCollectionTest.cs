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
    /// <summary> Test for JobExecution. </summary>
    public partial class ServerJobAgentJobExecutionCollectionMockTests : MockTestBase
    {
        public ServerJobAgentJobExecutionCollectionMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task CreateOrUpdate()
        {
            // Example: Create job execution.
            Guid jobExecutionId = Guid.Parse("5555-6666-7777-8888-999999999999");

            var sqlJobId = Sql.SqlJob.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "group1", "server1", "agent1", "job1");
            var collection = GetArmClient().GetSqlJob(sqlJobId).GetServerJobAgentJobExecutions();
            await collection.CreateOrUpdateAsync(true, jobExecutionId);
        }

        [RecordedTest]
        public async Task Get()
        {
            // Example: Get a job execution.
            Guid jobExecutionId = Guid.Parse("5555-6666-7777-8888-999999999999");

            var sqlJobId = Sql.SqlJob.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "group1", "server1", "agent1", "job1");
            var collection = GetArmClient().GetSqlJob(sqlJobId).GetServerJobAgentJobExecutions();
            await collection.GetAsync(jobExecutionId);
        }

        [RecordedTest]
        public async Task GetAll()
        {
            // Example: List a job's executions.
            DateTimeOffset? createTimeMin = null;
            DateTimeOffset? createTimeMax = null;
            DateTimeOffset? endTimeMin = null;
            DateTimeOffset? endTimeMax = null;
            bool? isActive = null;
            int? skip = null;
            int? top = null;

            var sqlJobId = Sql.SqlJob.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "group1", "server1", "agent1", "job1");
            var collection = GetArmClient().GetSqlJob(sqlJobId).GetServerJobAgentJobExecutions();
            await foreach (var _ in collection.GetAllAsync(createTimeMin, createTimeMax, endTimeMin, endTimeMax, isActive, skip, top))
            {
            }
        }

        [RecordedTest]
        public async Task GetJobTargetExecutions()
        {
            // Example: List job step target executions
            Guid jobExecutionId = Guid.Parse("5555-6666-7777-8888-999999999999");
            DateTimeOffset? createTimeMin = null;
            DateTimeOffset? createTimeMax = null;
            DateTimeOffset? endTimeMin = null;
            DateTimeOffset? endTimeMax = null;
            bool? isActive = null;
            int? skip = null;
            int? top = null;

            var sqlJobId = Sql.SqlJob.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "group1", "server1", "agent1", "job1");
            var collection = GetArmClient().GetSqlJob(sqlJobId).GetServerJobAgentJobExecutions();
            await foreach (var _ in collection.GetJobTargetExecutionsAsync(jobExecutionId, createTimeMin, createTimeMax, endTimeMin, endTimeMax, isActive, skip, top))
            {
            }
        }
    }
}
