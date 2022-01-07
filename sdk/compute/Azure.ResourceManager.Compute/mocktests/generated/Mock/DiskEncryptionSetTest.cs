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
using Azure.ResourceManager.Compute.Models;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Resources.Models;
using Azure.ResourceManager.TestFramework;

namespace Azure.ResourceManager.Compute.Tests.Mock
{
    /// <summary> Test for DiskEncryptionSet. </summary>
    public partial class DiskEncryptionSetMockTests : MockTestBase
    {
        public DiskEncryptionSetMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task GetAsync()
        {
            // Example: Get information about a disk encryption set.
            var diskEncryptionSet = GetArmClient().GetDiskEncryptionSet(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/myResourceGroup/providers/Microsoft.Compute/diskEncryptionSets/myDiskEncryptionSet"));

            await diskEncryptionSet.GetAsync();
        }

        [RecordedTest]
        public async Task DeleteAsync()
        {
            // Example: Delete a disk encryption set.
            var diskEncryptionSet = GetArmClient().GetDiskEncryptionSet(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/myResourceGroup/providers/Microsoft.Compute/diskEncryptionSets/myDiskEncryptionSet"));

            await diskEncryptionSet.DeleteAsync();
        }

        [RecordedTest]
        public async Task UpdateAsync()
        {
            // Example: Update a disk encryption set with rotationToLatestKeyVersionEnabled set to true - Succeeded
            var diskEncryptionSet = GetArmClient().GetDiskEncryptionSet(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/myResourceGroup/providers/Microsoft.Compute/diskEncryptionSets/myDiskEncryptionSet"));
            Compute.Models.DiskEncryptionSetUpdate diskEncryptionSet2 = new Compute.Models.DiskEncryptionSetUpdate()
            {
                Identity = new Compute.Models.EncryptionSetIdentity()
                {
                    Type = new Compute.Models.DiskEncryptionSetIdentityType("SystemAssigned"),
                },
                EncryptionType = new Compute.Models.DiskEncryptionSetType("EncryptionAtRestWithCustomerKey"),
                ActiveKey = new Compute.Models.KeyForDiskEncryptionSet(keyUrl: "https://myvaultdifferentsub.vault-int.azure-int.net/keys/keyName/keyVersion1"),
                RotationToLatestKeyVersionEnabled = true,
            };

            await diskEncryptionSet.UpdateAsync(diskEncryptionSet2);
        }

        [RecordedTest]
        public async Task UpdateAsync2()
        {
            // Example: Update a disk encryption set with rotationToLatestKeyVersionEnabled set to true - Updating
            var diskEncryptionSet = GetArmClient().GetDiskEncryptionSet(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/myResourceGroup/providers/Microsoft.Compute/diskEncryptionSets/myDiskEncryptionSet"));
            Compute.Models.DiskEncryptionSetUpdate diskEncryptionSet2 = new Compute.Models.DiskEncryptionSetUpdate()
            {
                Identity = new Compute.Models.EncryptionSetIdentity()
                {
                    Type = new Compute.Models.DiskEncryptionSetIdentityType("SystemAssigned"),
                },
                EncryptionType = new Compute.Models.DiskEncryptionSetType("EncryptionAtRestWithCustomerKey"),
                ActiveKey = new Compute.Models.KeyForDiskEncryptionSet(keyUrl: "https://myvaultdifferentsub.vault-int.azure-int.net/keys/keyName/keyVersion1"),
                RotationToLatestKeyVersionEnabled = true,
            };

            await diskEncryptionSet.UpdateAsync(diskEncryptionSet2);
        }

        [RecordedTest]
        public async Task UpdateAsync3()
        {
            // Example: Update a disk encryption set.
            var diskEncryptionSet = GetArmClient().GetDiskEncryptionSet(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/myResourceGroup/providers/Microsoft.Compute/diskEncryptionSets/myDiskEncryptionSet"));
            Compute.Models.DiskEncryptionSetUpdate diskEncryptionSet2 = new Compute.Models.DiskEncryptionSetUpdate()
            {
                EncryptionType = new Compute.Models.DiskEncryptionSetType("EncryptionAtRestWithCustomerKey"),
                ActiveKey = new Compute.Models.KeyForDiskEncryptionSet(keyUrl: "https://myvmvault.vault-int.azure-int.net/keys/keyName/keyVersion")
                {
                    SourceVault = new WritableSubResource()
                    {
                        Id = new ResourceIdentifier($"/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/myResourceGroup/providers/Microsoft.KeyVault/vaults/myVMVault"),
                    },
                },
            };

            await diskEncryptionSet.UpdateAsync(diskEncryptionSet2);
        }

        [RecordedTest]
        public void GetAssociatedResourcesAsync()
        {
            // Example: List all resources that are encrypted with this disk encryption set.
            var diskEncryptionSet = GetArmClient().GetDiskEncryptionSet(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/myResourceGroup/providers/Microsoft.Compute/diskEncryptionSets/myDiskEncryptionSet"));

            diskEncryptionSet.GetAssociatedResourcesAsync();
        }
    }
}
