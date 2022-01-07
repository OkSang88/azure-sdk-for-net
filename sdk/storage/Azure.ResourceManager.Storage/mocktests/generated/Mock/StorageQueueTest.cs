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
    /// <summary> Test for StorageQueue. </summary>
    public partial class StorageQueueMockTests : MockTestBase
    {
        public StorageQueueMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task GetAsync()
        {
            // Example: QueueOperationGet
            var storageQueue = GetArmClient().GetStorageQueue(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/res3376/providers/Microsoft.Storage/storageAccounts/sto328/queueServices/default/queues/queue6185"));

            await storageQueue.GetAsync();
        }

        [RecordedTest]
        public async Task DeleteAsync()
        {
            // Example: QueueOperationDelete
            var storageQueue = GetArmClient().GetStorageQueue(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/res3376/providers/Microsoft.Storage/storageAccounts/sto328/queueServices/default/queues/queue6185"));

            await storageQueue.DeleteAsync();
        }

        [RecordedTest]
        public async Task UpdateAsync()
        {
            // Example: QueueOperationPatch
            var storageQueue = GetArmClient().GetStorageQueue(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/res3376/providers/Microsoft.Storage/storageAccounts/sto328/queueServices/default/queues/queue6185"));
            Storage.StorageQueueData queue = new Storage.StorageQueueData();

            await storageQueue.UpdateAsync(queue);
        }
    }
}
