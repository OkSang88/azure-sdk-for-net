// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
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
    /// <summary> Test for CloudServiceRole. </summary>
    public partial class CloudServiceRoleCollectionMockTests : MockTestBase
    {
        public CloudServiceRoleCollectionMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task GetAsync()
        {
            // Example: Get Cloud Service Role
            var collection = GetArmClient().GetCloudService(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/ConstosoRG/providers/Microsoft.Compute/cloudServices/{{cs-name}}")).GetCloudServiceRoles();
            string roleName = "{role-name}";

            await collection.GetAsync(roleName);
        }

        [RecordedTest]
        public void GetAllAsync()
        {
            // Example: List Roles in a Cloud Service
            var collection = GetArmClient().GetCloudService(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/ConstosoRG/providers/Microsoft.Compute/cloudServices/{{cs-name}}")).GetCloudServiceRoles();

            collection.GetAllAsync();
        }
    }
}
