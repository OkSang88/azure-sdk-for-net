// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Net;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager.DeviceUpdate;
using Azure.ResourceManager.DeviceUpdate.Models;
using Azure.ResourceManager.TestFramework;

namespace Azure.ResourceManager.DeviceUpdate.Tests.Mock
{
    /// <summary> Test for DeviceUpdateInstance. </summary>
    public partial class DeviceUpdateInstanceCollectionMockTests : MockTestBase
    {
        public DeviceUpdateInstanceCollectionMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task CreateOrUpdate()
        {
            // Example: Creates or updates Instance
            string instanceName = "blue";
            DeviceUpdate.DeviceUpdateInstanceData instance = new DeviceUpdate.DeviceUpdateInstanceData(location: "westus2")
            {
                EnableDiagnostics = false,
                DiagnosticStorageProperties = new DeviceUpdate.Models.DiagnosticStorageProperties(authenticationType: new DeviceUpdate.Models.AuthenticationType("KeyBased"), resourceId: "/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/adu-resource-group/providers/Microsoft.Storage/storageAccounts/testAccount")
                {
                    ConnectionString = "string",
                },
            };

            var deviceUpdateAccountId = DeviceUpdate.DeviceUpdateAccount.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "test-rg", "contoso");
            var collection = GetArmClient().GetDeviceUpdateAccount(deviceUpdateAccountId).GetDeviceUpdateInstances();
            await collection.CreateOrUpdateAsync(true, instanceName, instance);
        }

        [RecordedTest]
        public async Task Get()
        {
            // Example: Gets list of Instances
            string instanceName = "blue";

            var deviceUpdateAccountId = DeviceUpdate.DeviceUpdateAccount.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "test-rg", "contoso");
            var collection = GetArmClient().GetDeviceUpdateAccount(deviceUpdateAccountId).GetDeviceUpdateInstances();
            await collection.GetAsync(instanceName);
        }

        [RecordedTest]
        public async Task GetAll()
        {
            // Example: Gets list of Instances by Account

            var deviceUpdateAccountId = DeviceUpdate.DeviceUpdateAccount.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "test-rg", "contoso");
            var collection = GetArmClient().GetDeviceUpdateAccount(deviceUpdateAccountId).GetDeviceUpdateInstances();
            await foreach (var _ in collection.GetAllAsync())
            {
            }
        }
    }
}
