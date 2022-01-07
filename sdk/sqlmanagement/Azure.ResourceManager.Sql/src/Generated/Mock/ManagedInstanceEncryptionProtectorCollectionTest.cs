// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Net;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Resources.Models;
using Azure.ResourceManager.Sql;
using Azure.ResourceManager.Sql.Models;
using Azure.ResourceManager.TestFramework;

namespace Azure.ResourceManager.Sql.Tests.Mock
{
    /// <summary> Test for ManagedInstanceEncryptionProtector. </summary>
    public partial class ManagedInstanceEncryptionProtectorCollectionMockTests : MockTestBase
    {
        public ManagedInstanceEncryptionProtectorCollectionMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task CreateOrUpdateAsync()
        {
            // Example: Update the encryption protector to key vault
            var collection = GetArmClient().GetManagedInstance(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/sqlcrudtest-7398/providers/Microsoft.Sql/managedInstances/sqlcrudtest-4645")).GetManagedInstanceEncryptionProtectors();
            Sql.Models.EncryptionProtectorName encryptionProtectorName = new Sql.Models.EncryptionProtectorName("current");
            Sql.ManagedInstanceEncryptionProtectorData parameters = new Sql.ManagedInstanceEncryptionProtectorData()
            {
                ServerKeyName = "someVault_someKey_01234567890123456789012345678901",
                ServerKeyType = new Sql.Models.ServerKeyType("AzureKeyVault"),
                AutoRotationEnabled = false,
            };

            await collection.CreateOrUpdateAsync(encryptionProtectorName, parameters);
        }

        [RecordedTest]
        public async Task CreateOrUpdateAsync2()
        {
            // Example: Update the encryption protector to service managed
            var collection = GetArmClient().GetManagedInstance(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/sqlcrudtest-7398/providers/Microsoft.Sql/managedInstances/sqlcrudtest-4645")).GetManagedInstanceEncryptionProtectors();
            Sql.Models.EncryptionProtectorName encryptionProtectorName = new Sql.Models.EncryptionProtectorName("current");
            Sql.ManagedInstanceEncryptionProtectorData parameters = new Sql.ManagedInstanceEncryptionProtectorData()
            {
                ServerKeyName = "ServiceManaged",
                ServerKeyType = new Sql.Models.ServerKeyType("ServiceManaged"),
            };

            await collection.CreateOrUpdateAsync(encryptionProtectorName, parameters);
        }

        [RecordedTest]
        public async Task GetAsync()
        {
            // Example: Get the encryption protector
            var collection = GetArmClient().GetManagedInstance(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/sqlcrudtest-7398/providers/Microsoft.Sql/managedInstances/sqlcrudtest-4645")).GetManagedInstanceEncryptionProtectors();
            Sql.Models.EncryptionProtectorName encryptionProtectorName = new Sql.Models.EncryptionProtectorName("current");

            await collection.GetAsync(encryptionProtectorName);
        }

        [RecordedTest]
        public void GetAllAsync()
        {
            // Example: List encryption protectors by managed instance
            var collection = GetArmClient().GetManagedInstance(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/sqlcrudtest-7398/providers/Microsoft.Sql/managedInstances/sqlcrudtest-4645")).GetManagedInstanceEncryptionProtectors();

            collection.GetAllAsync();
        }
    }
}
