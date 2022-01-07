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
using Azure.ResourceManager.KeyVault.Models;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Resources.Models;
using Azure.ResourceManager.TestFramework;

namespace Azure.ResourceManager.KeyVault.Tests.Mock
{
    /// <summary> Test for DeletedVault. </summary>
    public partial class DeletedVaultMockTests : MockTestBase
    {
        public DeletedVaultMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task GetAsync()
        {
            // Example: Retrieve a deleted vault
            var deletedVault = GetArmClient().GetDeletedVault(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/providers/Microsoft.KeyVault/locations/westus/deletedVaults/sample-vault"));

            await deletedVault.GetAsync();
        }

        [RecordedTest]
        public async Task PurgeDeletedAsync()
        {
            // Example: Purge a deleted vault
            var deletedVault = GetArmClient().GetDeletedVault(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/providers/Microsoft.KeyVault/locations/westus/deletedVaults/sample-vault"));

            await deletedVault.PurgeDeletedAsync();
        }
    }
}
