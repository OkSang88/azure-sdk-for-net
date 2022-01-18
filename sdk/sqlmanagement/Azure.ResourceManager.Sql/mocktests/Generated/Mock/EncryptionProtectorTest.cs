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
    /// <summary> Test for EncryptionProtector. </summary>
    public partial class EncryptionProtectorMockTests : MockTestBase
    {
        public EncryptionProtectorMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task Get()
        {
            // Example: Get the encryption protector
            var encryptionProtectorId = Sql.EncryptionProtector.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "sqlcrudtest-7398", "sqlcrudtest-4645", "current");
            var encryptionProtector = GetArmClient().GetEncryptionProtector(encryptionProtectorId);

            await encryptionProtector.GetAsync();
        }

        [RecordedTest]
        public async Task Revalidate()
        {
            // Example: Revalidates the encryption protector
            var encryptionProtectorId = Sql.EncryptionProtector.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "sqlcrudtest-7398", "sqlcrudtest-4645", "current");
            var encryptionProtector = GetArmClient().GetEncryptionProtector(encryptionProtectorId);

            await encryptionProtector.RevalidateAsync(true);
        }
    }
}
