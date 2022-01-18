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
    /// <summary> Test for ServerKey. </summary>
    public partial class ServerKeyMockTests : MockTestBase
    {
        public ServerKeyMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task Get()
        {
            // Example: Get the server key
            var serverKeyId = Sql.ServerKey.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "sqlcrudtest-7398", "sqlcrudtest-4645", "someVault_someKey_01234567890123456789012345678901");
            var serverKey = GetArmClient().GetServerKey(serverKeyId);

            await serverKey.GetAsync();
        }

        [RecordedTest]
        public async Task Delete()
        {
            // Example: Delete the server key
            var serverKeyId = Sql.ServerKey.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "sqlcrudtest-7398", "sqlcrudtest-4645", "someVault_someKey_01234567890123456789012345678901");
            var serverKey = GetArmClient().GetServerKey(serverKeyId);

            await serverKey.DeleteAsync(true);
        }
    }
}
