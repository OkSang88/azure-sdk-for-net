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
    /// <summary> Test for ManagedInstanceLongTermRetentionBackup. </summary>
    public partial class SubscriptionLongTermRetentionManagedInstanceBackupMockTests : MockTestBase
    {
        public SubscriptionLongTermRetentionManagedInstanceBackupMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task Get()
        {
            // Example: Get the long term retention backup of a managed database.
            var subscriptionLongTermRetentionManagedInstanceBackupId = Sql.SubscriptionLongTermRetentionManagedInstanceBackup.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "japaneast", "testInstance", "testDatabase", "55555555-6666-7777-8888-999999999999;131637960820000000");
            var subscriptionLongTermRetentionManagedInstanceBackup = GetArmClient().GetSubscriptionLongTermRetentionManagedInstanceBackup(subscriptionLongTermRetentionManagedInstanceBackupId);

            await subscriptionLongTermRetentionManagedInstanceBackup.GetAsync();
        }

        [RecordedTest]
        public async Task Delete()
        {
            // Example: Delete the long term retention backup.
            var subscriptionLongTermRetentionManagedInstanceBackupId = Sql.SubscriptionLongTermRetentionManagedInstanceBackup.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "japaneast", "testInstance", "testDatabase", "55555555-6666-7777-8888-999999999999;131637960820000000");
            var subscriptionLongTermRetentionManagedInstanceBackup = GetArmClient().GetSubscriptionLongTermRetentionManagedInstanceBackup(subscriptionLongTermRetentionManagedInstanceBackupId);

            await subscriptionLongTermRetentionManagedInstanceBackup.DeleteAsync(true);
        }
    }
}
