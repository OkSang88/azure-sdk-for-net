// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Net;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager;
using Azure.ResourceManager.Compute;
using Azure.ResourceManager.Compute.Models;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Resources.Models;
using Azure.ResourceManager.TestFramework;

namespace Azure.ResourceManager.Compute.Tests.Mock
{
    /// <summary> Test for RestorePointGroup. </summary>
    public partial class RestorePointGroupCollectionMockTests : MockTestBase
    {
        public RestorePointGroupCollectionMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task CreateOrUpdateAsync()
        {
            // Example: Create or update a restore point collection.
            var collection = GetArmClient().GetResourceGroup(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/myResourceGroup")).GetRestorePointGroups();
            string restorePointCollectionName = "myRpc";
            Compute.RestorePointGroupData parameters = new Compute.RestorePointGroupData(location: "norwayeast")
            {
                Source = new Compute.Models.RestorePointCollectionSourceProperties()
                {
                    Id = "/subscriptions/{subscription-id}/resourceGroups/myResourceGroup/providers/Microsoft.Compute/virtualMachines/myVM",
                },
            };
            parameters.Tags.ReplaceWith(new System.Collections.Generic.Dictionary<string, string>() { ["myTag1"] = "tagValue1", });
            await collection.CreateOrUpdateAsync(restorePointCollectionName, parameters);
        }

        [RecordedTest]
        public async Task GetAsync()
        {
            // Example: Get a restore point collection (but not the restore points contained in the restore point collection)
            var collection = GetArmClient().GetResourceGroup(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/myResourceGroup")).GetRestorePointGroups();
            string restorePointCollectionName = "myRpc";
            Compute.Models.RestorePointCollectionExpandOptions? expand = null;

            await collection.GetAsync(restorePointCollectionName, expand);
        }

        [RecordedTest]
        public async Task GetAsync2()
        {
            // Example: Get a restore point collection, including the restore points contained in the restore point collection
            var collection = GetArmClient().GetResourceGroup(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/myResourceGroup")).GetRestorePointGroups();
            string restorePointCollectionName = "rpcName";
            Compute.Models.RestorePointCollectionExpandOptions? expand = null;

            await collection.GetAsync(restorePointCollectionName, expand);
        }

        [RecordedTest]
        public void GetAllAsync()
        {
            // Example: Gets the list of restore point collections in a resource group.
            var collection = GetArmClient().GetResourceGroup(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/myResourceGroup")).GetRestorePointGroups();

            collection.GetAllAsync();
        }
    }
}
