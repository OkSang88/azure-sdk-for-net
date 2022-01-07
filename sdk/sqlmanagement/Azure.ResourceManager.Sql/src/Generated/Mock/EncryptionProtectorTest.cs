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
    /// <summary> Test for EncryptionProtector. </summary>
    public partial class EncryptionProtectorMockTests : MockTestBase
    {
        public EncryptionProtectorMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task GetAsync()
        {
            // Example: Get the encryption protector
            var encryptionProtector = GetArmClient().GetEncryptionProtector(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/sqlcrudtest-7398/providers/Microsoft.Sql/servers/sqlcrudtest-4645/encryptionProtector/current"));

            await encryptionProtector.GetAsync();
        }

        [RecordedTest]
        public async Task RevalidateAsync()
        {
            // Example: Revalidates the encryption protector
            var encryptionProtector = GetArmClient().GetEncryptionProtector(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/sqlcrudtest-7398/providers/Microsoft.Sql/servers/sqlcrudtest-4645/encryptionProtector/current"));

            await encryptionProtector.RevalidateAsync();
        }
    }
}
