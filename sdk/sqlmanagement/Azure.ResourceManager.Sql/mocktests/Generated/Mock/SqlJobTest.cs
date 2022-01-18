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
    /// <summary> Test for SqlJob. </summary>
    public partial class SqlJobMockTests : MockTestBase
    {
        public SqlJobMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task Get()
        {
            // Example: Get a job
            var sqlJobId = Sql.SqlJob.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "group1", "server1", "agent1", "job1");
            var sqlJob = GetArmClient().GetSqlJob(sqlJobId);

            await sqlJob.GetAsync();
        }

        [RecordedTest]
        public async Task Delete()
        {
            // Example: Delete a job
            var sqlJobId = Sql.SqlJob.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "group1", "server1", "agent1", "job1");
            var sqlJob = GetArmClient().GetSqlJob(sqlJobId);

            await sqlJob.DeleteAsync(true);
        }

        [RecordedTest]
        public async Task CreateJobExecution()
        {
            // Example: Start a job execution.
            var sqlJobId = Sql.SqlJob.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "group1", "server1", "agent1", "job1");
            var sqlJob = GetArmClient().GetSqlJob(sqlJobId);

            await sqlJob.CreateJobExecutionAsync(true);
        }
    }
}
