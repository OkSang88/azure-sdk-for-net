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
    /// <summary> Test for ManagedInstanceLongTermRetentionBackup. </summary>
    public partial class ResourceGroupLongTermRetentionManagedInstanceBackupMockTests : MockTestBase
    {
        public ResourceGroupLongTermRetentionManagedInstanceBackupMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task GetAsync()
        {
            // Example: Get the long term retention backup.
            var resourceGroupLongTermRetentionManagedInstanceBackup = GetArmClient().GetResourceGroupLongTermRetentionManagedInstanceBackup(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/testResourceGroup/providers/Microsoft.Sql/locations/japaneast/longTermRetentionManagedInstances/testInstance/longTermRetentionDatabases/testDatabase/longTermRetentionManagedInstanceBackups/55555555-6666-7777-8888-999999999999;131637960820000000"));

            await resourceGroupLongTermRetentionManagedInstanceBackup.GetAsync();
        }

        [RecordedTest]
        public async Task DeleteAsync()
        {
            // Example: Delete the long term retention backup.
            var resourceGroupLongTermRetentionManagedInstanceBackup = GetArmClient().GetResourceGroupLongTermRetentionManagedInstanceBackup(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/testResourceGroup/providers/Microsoft.Sql/locations/japaneast/longTermRetentionManagedInstances/testInstance/longTermRetentionDatabases/testDatabase/longTermRetentionManagedInstanceBackups/55555555-6666-7777-8888-999999999999;131637960820000000"));

            await resourceGroupLongTermRetentionManagedInstanceBackup.DeleteAsync();
        }
    }
}
