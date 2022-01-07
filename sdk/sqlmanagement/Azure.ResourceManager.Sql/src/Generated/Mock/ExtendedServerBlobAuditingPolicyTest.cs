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
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Resources.Models;
using Azure.ResourceManager.Sql.Models;
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
        public async Task GetAsync()
        {
            // Example: Get a server's blob extended auditing policy
            var extendedServerBlobAuditingPolicy = GetArmClient().GetExtendedServerBlobAuditingPolicy(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/blobauditingtest-4799/providers/Microsoft.Sql/servers/blobauditingtest-6440/extendedAuditingSettings/default"));

            await extendedServerBlobAuditingPolicy.GetAsync();
        }
    }
}
