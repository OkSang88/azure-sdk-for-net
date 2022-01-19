// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager.Compute;
using Azure.ResourceManager.Compute.Models;
using Azure.ResourceManager.TestFramework;

namespace Azure.ResourceManager.Compute.Tests.Mock
{
    /// <summary> Test for CloudService. </summary>
    public partial class CloudServiceMockTests : MockTestBase
    {
        public CloudServiceMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task Get()
        {
            // Example: Get Cloud Service with Multiple Roles and RDP Extension
            var cloudServiceId = Compute.CloudService.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "ConstosoRG", "{cs-name}");
            var cloudService = GetArmClient().GetCloudService(cloudServiceId);

            await cloudService.GetAsync();
        }

        [RecordedTest]
        public async Task Delete()
        {
            // Example: Delete Cloud Service
            var cloudServiceId = Compute.CloudService.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "ConstosoRG", "{cs-name}");
            var cloudService = GetArmClient().GetCloudService(cloudServiceId);

            await cloudService.DeleteAsync(true);
        }

        [RecordedTest]
        public async Task Update()
        {
            // Example: Update existing Cloud Service to add tags
            var cloudServiceId = Compute.CloudService.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "ConstosoRG", "{cs-name}");
            var cloudService = GetArmClient().GetCloudService(cloudServiceId);
            Compute.Models.CloudServiceUpdate parameters = new Compute.Models.CloudServiceUpdate();

            await cloudService.UpdateAsync(true, parameters);
        }

        [RecordedTest]
        public async Task GetInstanceView()
        {
            // Example: Get Cloud Service Instance View with Multiple Roles
            var cloudServiceId = Compute.CloudService.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "ConstosoRG", "{cs-name}");
            var cloudService = GetArmClient().GetCloudService(cloudServiceId);

            await cloudService.GetInstanceViewAsync();
        }

        [RecordedTest]
        public async Task PowerOn()
        {
            // Example: Start Cloud Service
            var cloudServiceId = Compute.CloudService.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "ConstosoRG", "{cs-name}");
            var cloudService = GetArmClient().GetCloudService(cloudServiceId);

            await cloudService.PowerOnAsync(true);
        }

        [RecordedTest]
        public async Task PowerOff()
        {
            // Example: Stop or PowerOff Cloud Service
            var cloudServiceId = Compute.CloudService.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "ConstosoRG", "{cs-name}");
            var cloudService = GetArmClient().GetCloudService(cloudServiceId);

            await cloudService.PowerOffAsync(true);
        }

        [RecordedTest]
        public async Task Restart()
        {
            // Example: Restart Cloud Service Role Instances
            var cloudServiceId = Compute.CloudService.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "ConstosoRG", "{cs-name}");
            var cloudService = GetArmClient().GetCloudService(cloudServiceId);
            Compute.Models.RoleInstances parameters = new Compute.Models.RoleInstances(roleInstancesValue: new List<string>()
{
"ContosoFrontend_IN_0","ContosoBackend_IN_1",});

            await cloudService.RestartAsync(true, parameters);
        }

        [RecordedTest]
        public async Task Reimage()
        {
            // Example: Reimage Cloud Service Role Instances
            var cloudServiceId = Compute.CloudService.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "ConstosoRG", "{cs-name}");
            var cloudService = GetArmClient().GetCloudService(cloudServiceId);
            Compute.Models.RoleInstances parameters = new Compute.Models.RoleInstances(roleInstancesValue: new List<string>()
{
"ContosoFrontend_IN_0","ContosoBackend_IN_1",});

            await cloudService.ReimageAsync(true, parameters);
        }

        [RecordedTest]
        public async Task Rebuild()
        {
            // Example: Rebuild Cloud Service Role Instances
            var cloudServiceId = Compute.CloudService.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "ConstosoRG", "{cs-name}");
            var cloudService = GetArmClient().GetCloudService(cloudServiceId);
            Compute.Models.RoleInstances parameters = new Compute.Models.RoleInstances(roleInstancesValue: new List<string>()
{
"ContosoFrontend_IN_0","ContosoBackend_IN_1",});

            await cloudService.RebuildAsync(true, parameters);
        }

        [RecordedTest]
        public async Task DeleteInstances()
        {
            // Example: Delete Cloud Service Role Instances
            var cloudServiceId = Compute.CloudService.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "ConstosoRG", "{cs-name}");
            var cloudService = GetArmClient().GetCloudService(cloudServiceId);
            Compute.Models.RoleInstances parameters = new Compute.Models.RoleInstances(roleInstancesValue: new List<string>()
{
"ContosoFrontend_IN_0","ContosoBackend_IN_1",});

            await cloudService.DeleteInstancesAsync(true, parameters);
        }

        [RecordedTest]
        public async Task WalkUpdateDomain()
        {
            // Example: Update Cloud Service to specified Domain
            var cloudServiceId = Compute.CloudService.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "ConstosoRG", "{cs-name}");
            var cloudService = GetArmClient().GetCloudService(cloudServiceId);
            int updateDomain = 1;
            Compute.Models.UpdateDomain parameters = null;

            await cloudService.WalkUpdateDomainAsync(true, updateDomain, parameters);
        }

        [RecordedTest]
        public async Task GetUpdateDomain()
        {
            // Example: Get Cloud Service Update Domain
            var cloudServiceId = Compute.CloudService.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "ConstosoRG", "{cs-name}");
            var cloudService = GetArmClient().GetCloudService(cloudServiceId);
            int updateDomain = 1;

            await cloudService.GetUpdateDomainAsync(updateDomain);
        }

        [RecordedTest]
        public async Task GetUpdateDomains()
        {
            // Example: List Update Domains in Cloud Service
            var cloudServiceId = Compute.CloudService.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "ConstosoRG", "{cs-name}");
            var cloudService = GetArmClient().GetCloudService(cloudServiceId);

            await foreach (var _ in cloudService.GetUpdateDomainsAsync())
            {
            }
        }
    }
}
