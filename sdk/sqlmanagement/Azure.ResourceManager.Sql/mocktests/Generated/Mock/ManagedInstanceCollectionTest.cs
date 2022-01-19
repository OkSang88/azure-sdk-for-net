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
    /// <summary> Test for ManagedInstance. </summary>
    public partial class ManagedInstanceCollectionMockTests : MockTestBase
    {
        public ManagedInstanceCollectionMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task CreateOrUpdate()
        {
            // Example: Create managed instance with all properties
            string managedInstanceName = "testinstance";
            Sql.ManagedInstanceData parameters = new Sql.ManagedInstanceData(location: "Japan East")
            {
                Sku = new Sql.Models.Sku(name: "GP_Gen5")
                {
                    Tier = "GeneralPurpose",
                },
                AdministratorLogin = "dummylogin",
                AdministratorLoginPassword = "PLACEHOLDER",
                SubnetId = "/subscriptions/20D7082A-0FC7-4468-82BD-542694D5042B/resourceGroups/testrg/providers/Microsoft.Network/virtualNetworks/vnet1/subnets/subnet1",
                LicenseType = new Sql.Models.ManagedInstanceLicenseType("LicenseIncluded"),
                VCores = 8,
                StorageSizeInGB = 1024,
                Collation = "SQL_Latin1_General_CP1_CI_AS",
                DnsZonePartner = "/subscriptions/20D7082A-0FC7-4468-82BD-542694D5042B/resourceGroups/testrg/providers/Microsoft.Sql/managedInstances/testinstance",
                PublicDataEndpointEnabled = false,
                ProxyOverride = new Sql.Models.ManagedInstanceProxyOverride("Redirect"),
                TimezoneId = "UTC",
                InstancePoolId = "/subscriptions/20D7082A-0FC7-4468-82BD-542694D5042B/resourceGroups/testrg/providers/Microsoft.Sql/instancePools/pool1",
                MaintenanceConfigurationId = "/subscriptions/20D7082A-0FC7-4468-82BD-542694D5042B/providers/Microsoft.Maintenance/publicMaintenanceConfigurations/SQL_JapanEast_MI_1",
                MinimalTlsVersion = "1.2",
                StorageAccountType = new Sql.Models.StorageAccountType("GRS"),
                Administrators = new Sql.Models.ManagedInstanceExternalAdministrator()
                {
                    PrincipalType = new Sql.Models.PrincipalType("User"),
                    Login = "bob@contoso.com",
                    Sid = Guid.Parse("00000011-1111-2222-2222-123456789111"),
                    TenantId = Guid.Parse("00000011-1111-2222-2222-123456789111"),
                    AzureADOnlyAuthentication = true,
                },
            };
            parameters.Tags.ReplaceWith(new Dictionary<string, string>()
            {
                ["tagKey1"] = "TagValue1",
            });

            var collection = GetArmClient().GetResourceGroup(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/testrg")).GetManagedInstances();
            await collection.CreateOrUpdateAsync(true, managedInstanceName, parameters);
        }

        [RecordedTest]
        public async Task CreateOrUpdate2()
        {
            // Example: Create managed instance with minimal properties
            string managedInstanceName = "testinstance";
            Sql.ManagedInstanceData parameters = new Sql.ManagedInstanceData(location: "Japan East")
            {
                Sku = new Sql.Models.Sku(name: "GP_Gen4")
                {
                    Tier = "GeneralPurpose",
                },
                AdministratorLogin = "dummylogin",
                AdministratorLoginPassword = "PLACEHOLDER",
                SubnetId = "/subscriptions/20D7082A-0FC7-4468-82BD-542694D5042B/resourceGroups/testrg/providers/Microsoft.Network/virtualNetworks/vnet1/subnets/subnet1",
                LicenseType = new Sql.Models.ManagedInstanceLicenseType("LicenseIncluded"),
                VCores = 8,
                StorageSizeInGB = 1024,
            };

            var collection = GetArmClient().GetResourceGroup(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/testrg")).GetManagedInstances();
            await collection.CreateOrUpdateAsync(true, managedInstanceName, parameters);
        }

        [RecordedTest]
        public async Task Get()
        {
            // Example: Get managed instance
            string managedInstanceName = "testinstance";
            string expand = null;

            var collection = GetArmClient().GetResourceGroup(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/testrg")).GetManagedInstances();
            await collection.GetAsync(managedInstanceName, expand);
        }

        [RecordedTest]
        public async Task Get2()
        {
            // Example: Get managed instance with $expand=administrators
            string managedInstanceName = "testinstance";
            string expand = null;

            var collection = GetArmClient().GetResourceGroup(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/testrg")).GetManagedInstances();
            await collection.GetAsync(managedInstanceName, expand);
        }

        [RecordedTest]
        public async Task GetAll()
        {
            // Example: List managed instances by resource group
            string expand = null;

            var collection = GetArmClient().GetResourceGroup(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/Test1")).GetManagedInstances();
            await foreach (var _ in collection.GetAllAsync(expand))
            {
            }
        }

        [RecordedTest]
        public async Task GetAll2()
        {
            // Example: List managed instances by resource group with $expand=administrators
            string expand = null;

            var collection = GetArmClient().GetResourceGroup(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/Test1")).GetManagedInstances();
            await foreach (var _ in collection.GetAllAsync(expand))
            {
            }
        }
    }
}
