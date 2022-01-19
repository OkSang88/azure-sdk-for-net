// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.TestFramework;
using Azure.ResourceManager.Sql;
using Azure.ResourceManager.Sql.Models;
using Azure.ResourceManager.TestFramework;

namespace Azure.ResourceManager.Sql.Tests.Mock
{
    /// <summary> Test for InstancePool. </summary>
    public partial class InstancePoolCollectionMockTests : MockTestBase
    {
        public InstancePoolCollectionMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task CreateOrUpdate()
        {
            // Example: Create an instance pool with all properties.
            string instancePoolName = "testIP";
            Sql.InstancePoolData parameters = new Sql.InstancePoolData(location: "japaneast")
            {
                Sku = new Sql.Models.Sku(name: "GP_Gen5")
                {
                    Tier = "GeneralPurpose",
                    Family = "Gen5",
                },
                SubnetId = "/subscriptions/00000000-1111-2222-3333-444444444444/resourceGroups/group1/providers/Microsoft.Network/virtualNetworks/myvnet/subnets/mysubnet1",
                VCores = 8,
                LicenseType = new Sql.Models.InstancePoolLicenseType("LicenseIncluded"),
            };
            parameters.Tags.ReplaceWith(new Dictionary<string, string>()
            {
                ["a"] = "b",
            });

            var collection = GetArmClient().GetResourceGroup(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/group1")).GetInstancePools();
            await collection.CreateOrUpdateAsync(true, instancePoolName, parameters);
        }

        [RecordedTest]
        public async Task CreateOrUpdate2()
        {
            // Example: Create an instance pool with min properties.
            string instancePoolName = "testIP";
            Sql.InstancePoolData parameters = new Sql.InstancePoolData(location: "japaneast")
            {
                Sku = new Sql.Models.Sku(name: "GP_Gen5")
                {
                    Tier = "GeneralPurpose",
                    Family = "Gen5",
                },
                SubnetId = "/subscriptions/00000000-1111-2222-3333-444444444444/resourceGroups/group1/providers/Microsoft.Network/virtualNetworks/myvnet/subnets/mysubnet1",
                VCores = 8,
                LicenseType = new Sql.Models.InstancePoolLicenseType("LicenseIncluded"),
            };

            var collection = GetArmClient().GetResourceGroup(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/group1")).GetInstancePools();
            await collection.CreateOrUpdateAsync(true, instancePoolName, parameters);
        }

        [RecordedTest]
        public async Task Get()
        {
            // Example: Get an instance pool
            string instancePoolName = "testIP";

            var collection = GetArmClient().GetResourceGroup(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/group1")).GetInstancePools();
            await collection.GetAsync(instancePoolName);
        }

        [RecordedTest]
        public async Task GetAll()
        {
            // Example: List instance pools by resource group

            var collection = GetArmClient().GetResourceGroup(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/group1")).GetInstancePools();
            await foreach (var _ in collection.GetAllAsync())
            {
            }
        }
    }
}
