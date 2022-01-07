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
using Azure.ResourceManager.Storage.Models;
using Azure.ResourceManager.TestFramework;

namespace Azure.ResourceManager.Storage.Tests.Mock
{
    /// <summary> Test for Table. </summary>
    public partial class TableMockTests : MockTestBase
    {
        public TableMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task GetAsync()
        {
            // Example: TableOperationGet
            var table = GetArmClient().GetTable(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/res3376/providers/Microsoft.Storage/storageAccounts/sto328/tableServices/default/tables/table6185"));

            await table.GetAsync();
        }

        [RecordedTest]
        public async Task DeleteAsync()
        {
            // Example: TableOperationDelete
            var table = GetArmClient().GetTable(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/res3376/providers/Microsoft.Storage/storageAccounts/sto328/tableServices/default/tables/table6185"));

            await table.DeleteAsync();
        }

        [RecordedTest]
        public async Task UpdateAsync()
        {
            // Example: TableOperationPatch
            var table = GetArmClient().GetTable(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/res3376/providers/Microsoft.Storage/storageAccounts/sto328/tableServices/default/tables/table6185"));

            await table.UpdateAsync();
        }
    }
}
