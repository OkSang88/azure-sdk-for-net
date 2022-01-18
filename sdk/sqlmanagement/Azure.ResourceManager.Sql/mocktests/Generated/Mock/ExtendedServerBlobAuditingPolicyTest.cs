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
    /// <summary> Test for ExtendedServerBlobAuditingPolicy. </summary>
    public partial class ExtendedServerBlobAuditingPolicyMockTests : MockTestBase
    {
        public ExtendedServerBlobAuditingPolicyMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task Get()
        {
            // Example: Get a server's blob extended auditing policy
            var extendedServerBlobAuditingPolicyId = Sql.ExtendedServerBlobAuditingPolicy.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "blobauditingtest-4799", "blobauditingtest-6440", "default");
            var extendedServerBlobAuditingPolicy = GetArmClient().GetExtendedServerBlobAuditingPolicy(extendedServerBlobAuditingPolicyId);

            await extendedServerBlobAuditingPolicy.GetAsync();
        }
    }
}
