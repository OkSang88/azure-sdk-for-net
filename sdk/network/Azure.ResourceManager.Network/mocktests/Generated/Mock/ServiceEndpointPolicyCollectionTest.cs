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
    /// <summary> Test for ServiceEndpointPolicy. </summary>
    public partial class ServiceEndpointPolicyCollectionMockTests : MockTestBase
    {
        public ServiceEndpointPolicyCollectionMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task CreateOrUpdateAsync()
        {
            // Example: Create service endpoint policy
            var collection = GetArmClient().GetResourceGroup(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1")).GetServiceEndpointPolicies();
            string serviceEndpointPolicyName = "testPolicy";
            Network.ServiceEndpointPolicyData parameters = new Network.ServiceEndpointPolicyData()
            {
                Location = "westus",
            };

            await collection.CreateOrUpdateAsync(serviceEndpointPolicyName, parameters);
        }

        [RecordedTest]
        public async Task CreateOrUpdateAsync2()
        {
            // Example: Create service endpoint policy with definition
            var collection = GetArmClient().GetResourceGroup(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1")).GetServiceEndpointPolicies();
            string serviceEndpointPolicyName = "testPolicy";
            Network.ServiceEndpointPolicyData parameters = new Network.ServiceEndpointPolicyData()
            {
                Location = "westus",
            };

            await collection.CreateOrUpdateAsync(serviceEndpointPolicyName, parameters);
        }

        [RecordedTest]
        public async Task GetAsync()
        {
            // Example: Get service endPoint Policy
            var collection = GetArmClient().GetResourceGroup(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1")).GetServiceEndpointPolicies();
            string serviceEndpointPolicyName = "testServiceEndpointPolicy";
            string expand = null;

            await collection.GetAsync(serviceEndpointPolicyName, expand);
        }

        [RecordedTest]
        public void GetAllAsync()
        {
            // Example: List resource group service endpoint policies
            var collection = GetArmClient().GetResourceGroup(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1")).GetServiceEndpointPolicies();

            collection.GetAllAsync();
        }
    }
}
