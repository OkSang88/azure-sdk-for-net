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
using Azure.ResourceManager.Storage;
using Azure.ResourceManager.Storage.Models;
using Azure.ResourceManager.TestFramework;

namespace Azure.ResourceManager.Storage.Tests.Mock
{
    /// <summary> Test for FileShare. </summary>
    public partial class FileShareMockTests : MockTestBase
    {
        public FileShareMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task GetAsync()
        {
            // Example: GetShareStats
            var fileShare = GetArmClient().GetFileShare(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/res9871/providers/Microsoft.Storage/storageAccounts/sto6217/fileServices/default/shares/share1634"));
            string expand = "stats";
            string xMsSnapshot = null;

            await fileShare.GetAsync(expand, xMsSnapshot);
        }

        [RecordedTest]
        public async Task GetAsync2()
        {
            // Example: GetShares
            var fileShare = GetArmClient().GetFileShare(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/res9871/providers/Microsoft.Storage/storageAccounts/sto6217/fileServices/default/shares/share1634"));
            string expand = null;
            string xMsSnapshot = null;

            await fileShare.GetAsync(expand, xMsSnapshot);
        }

        [RecordedTest]
        public async Task DeleteAsync()
        {
            // Example: DeleteShares
            var fileShare = GetArmClient().GetFileShare(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/res4079/providers/Microsoft.Storage/storageAccounts/sto4506/fileServices/default/shares/share9689"));
            string xMsSnapshot = null;
            string include = null;

            await fileShare.DeleteAsync(xMsSnapshot, include);
        }

        [RecordedTest]
        public async Task UpdateAsync()
        {
            // Example: UpdateShareAcls
            var fileShare = GetArmClient().GetFileShare(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/res3376/providers/Microsoft.Storage/storageAccounts/sto328/fileServices/default/shares/share6185"));
            Storage.FileShareData fileShare2 = new Storage.FileShareData();

            await fileShare.UpdateAsync(fileShare2);
        }

        [RecordedTest]
        public async Task UpdateAsync2()
        {
            // Example: UpdateShares
            var fileShare = GetArmClient().GetFileShare(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/res3376/providers/Microsoft.Storage/storageAccounts/sto328/fileServices/default/shares/share6185"));
            Storage.FileShareData fileShare2 = new Storage.FileShareData();

            await fileShare.UpdateAsync(fileShare2);
        }

        [RecordedTest]
        public async Task RestoreAsync()
        {
            // Example: RestoreShares
            var fileShare = GetArmClient().GetFileShare(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/res3376/providers/Microsoft.Storage/storageAccounts/sto328/fileServices/default/shares/share1249"));
            Storage.Models.DeletedShare deletedShare = new Storage.Models.DeletedShare(deletedShareName: "share1249", deletedShareVersion: "1234567890");

            await fileShare.RestoreAsync(deletedShare);
        }

        [RecordedTest]
        public async Task LeaseAsync()
        {
            // Example: Acquire a lease on a share
            var fileShare = GetArmClient().GetFileShare(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/res3376/providers/Microsoft.Storage/storageAccounts/sto328/fileServices/default/shares/share124"));
            string xMsSnapshot = null;
            Storage.Models.LeaseShareRequest parameters = new Storage.Models.LeaseShareRequest(action: new Storage.Models.LeaseShareAction("Acquire"))
            {
                LeaseId = null,
                BreakPeriod = null,
                LeaseDuration = -1,
                ProposedLeaseId = null,
            };

            await fileShare.LeaseAsync(xMsSnapshot, parameters);
        }

        [RecordedTest]
        public async Task LeaseAsync2()
        {
            // Example: Break a lease on a share
            var fileShare = GetArmClient().GetFileShare(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/res3376/providers/Microsoft.Storage/storageAccounts/sto328/fileServices/default/shares/share12"));
            string xMsSnapshot = null;
            Storage.Models.LeaseShareRequest parameters = new Storage.Models.LeaseShareRequest(action: new Storage.Models.LeaseShareAction("Break"))
            {
                LeaseId = "8698f513-fa75-44a1-b8eb-30ba336af27d",
                BreakPeriod = null,
                LeaseDuration = null,
                ProposedLeaseId = null,
            };

            await fileShare.LeaseAsync(xMsSnapshot, parameters);
        }
    }
}
