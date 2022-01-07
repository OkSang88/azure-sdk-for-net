// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Net;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager;
using Azure.ResourceManager.Network;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Resources.Models;
using Azure.ResourceManager.TestFramework;

namespace Azure.ResourceManager.Network.Tests.Mock
{
    /// <summary> Test for ApplicationSecurityGroup. </summary>
    public partial class ApplicationSecurityGroupCollectionMockTests : MockTestBase
    {
        public ApplicationSecurityGroupCollectionMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task CreateOrUpdateAsync()
        {
            // Example: Create application security group
            var collection = GetArmClient().GetResourceGroup(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1")).GetApplicationSecurityGroups();
            string applicationSecurityGroupName = "test-asg";
            Network.ApplicationSecurityGroupData parameters = new Network.ApplicationSecurityGroupData()
            {
                Location = "westus",
            };

            await collection.CreateOrUpdateAsync(applicationSecurityGroupName, parameters);
        }

        [RecordedTest]
        public async Task GetAsync()
        {
            // Example: Get application security group
            var collection = GetArmClient().GetResourceGroup(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1")).GetApplicationSecurityGroups();
            string applicationSecurityGroupName = "test-asg";

            await collection.GetAsync(applicationSecurityGroupName);
        }

        [RecordedTest]
        public void GetAllAsync()
        {
            // Example: List load balancers in resource group
            var collection = GetArmClient().GetResourceGroup(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1")).GetApplicationSecurityGroups();

            collection.GetAllAsync();
        }
    }
}
