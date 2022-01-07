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
    /// <summary> Test for LoadBalancer. </summary>
    public partial class LoadBalancerCollectionMockTests : MockTestBase
    {
        public LoadBalancerCollectionMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task CreateOrUpdateAsync()
        {
            // Example: Create load balancer
            var collection = GetArmClient().GetResourceGroup(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1")).GetLoadBalancers();
            string loadBalancerName = "lb";
            Network.LoadBalancerData parameters = new Network.LoadBalancerData()
            {
                Location = "eastus",
            };

            await collection.CreateOrUpdateAsync(loadBalancerName, parameters);
        }

        [RecordedTest]
        public async Task CreateOrUpdateAsync2()
        {
            // Example: Create load balancer with Frontend IP in Zone 1
            var collection = GetArmClient().GetResourceGroup(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1")).GetLoadBalancers();
            string loadBalancerName = "lb";
            Network.LoadBalancerData parameters = new Network.LoadBalancerData()
            {
                Sku = new Network.Models.LoadBalancerSku()
                {
                    Name = new Network.Models.LoadBalancerSkuName("Standard"),
                },
                Location = "eastus",
            };

            await collection.CreateOrUpdateAsync(loadBalancerName, parameters);
        }

        [RecordedTest]
        public async Task CreateOrUpdateAsync3()
        {
            // Example: Create load balancer with Gateway Load Balancer Consumer configured
            var collection = GetArmClient().GetResourceGroup(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1")).GetLoadBalancers();
            string loadBalancerName = "lb";
            Network.LoadBalancerData parameters = new Network.LoadBalancerData()
            {
                Sku = new Network.Models.LoadBalancerSku()
                {
                    Name = new Network.Models.LoadBalancerSkuName("Standard"),
                },
                Location = "eastus",
            };

            await collection.CreateOrUpdateAsync(loadBalancerName, parameters);
        }

        [RecordedTest]
        public async Task CreateOrUpdateAsync4()
        {
            // Example: Create load balancer with Gateway Load Balancer Provider configured with one Backend Pool
            var collection = GetArmClient().GetResourceGroup(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1")).GetLoadBalancers();
            string loadBalancerName = "lb";
            Network.LoadBalancerData parameters = new Network.LoadBalancerData()
            {
                Sku = new Network.Models.LoadBalancerSku()
                {
                    Name = new Network.Models.LoadBalancerSkuName("Premium"),
                },
                Location = "eastus",
            };

            await collection.CreateOrUpdateAsync(loadBalancerName, parameters);
        }

        [RecordedTest]
        public async Task CreateOrUpdateAsync5()
        {
            // Example: Create load balancer with Gateway Load Balancer Provider configured with two Backend Pool
            var collection = GetArmClient().GetResourceGroup(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1")).GetLoadBalancers();
            string loadBalancerName = "lb";
            Network.LoadBalancerData parameters = new Network.LoadBalancerData()
            {
                Sku = new Network.Models.LoadBalancerSku()
                {
                    Name = new Network.Models.LoadBalancerSkuName("Premium"),
                },
                Location = "eastus",
            };

            await collection.CreateOrUpdateAsync(loadBalancerName, parameters);
        }

        [RecordedTest]
        public async Task CreateOrUpdateAsync6()
        {
            // Example: Create load balancer with Global Tier and one regional load balancer in its backend pool
            var collection = GetArmClient().GetResourceGroup(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1")).GetLoadBalancers();
            string loadBalancerName = "lb";
            Network.LoadBalancerData parameters = new Network.LoadBalancerData()
            {
                Sku = new Network.Models.LoadBalancerSku()
                {
                    Name = new Network.Models.LoadBalancerSkuName("Standard"),
                    Tier = new Network.Models.LoadBalancerSkuTier("Global"),
                },
                Location = "eastus",
            };

            await collection.CreateOrUpdateAsync(loadBalancerName, parameters);
        }

        [RecordedTest]
        public async Task CreateOrUpdateAsync7()
        {
            // Example: Create load balancer with Standard SKU
            var collection = GetArmClient().GetResourceGroup(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1")).GetLoadBalancers();
            string loadBalancerName = "lb";
            Network.LoadBalancerData parameters = new Network.LoadBalancerData()
            {
                Sku = new Network.Models.LoadBalancerSku()
                {
                    Name = new Network.Models.LoadBalancerSkuName("Standard"),
                },
                Location = "eastus",
            };

            await collection.CreateOrUpdateAsync(loadBalancerName, parameters);
        }

        [RecordedTest]
        public async Task CreateOrUpdateAsync8()
        {
            // Example: Create load balancer with inbound nat pool
            var collection = GetArmClient().GetResourceGroup(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1")).GetLoadBalancers();
            string loadBalancerName = "lb";
            Network.LoadBalancerData parameters = new Network.LoadBalancerData()
            {
                Sku = new Network.Models.LoadBalancerSku()
                {
                    Name = new Network.Models.LoadBalancerSkuName("Standard"),
                },
                Location = "eastus",
            };

            await collection.CreateOrUpdateAsync(loadBalancerName, parameters);
        }

        [RecordedTest]
        public async Task CreateOrUpdateAsync9()
        {
            // Example: Create load balancer with outbound rules
            var collection = GetArmClient().GetResourceGroup(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1")).GetLoadBalancers();
            string loadBalancerName = "lb";
            Network.LoadBalancerData parameters = new Network.LoadBalancerData()
            {
                Sku = new Network.Models.LoadBalancerSku()
                {
                    Name = new Network.Models.LoadBalancerSkuName("Standard"),
                },
                Location = "eastus",
            };

            await collection.CreateOrUpdateAsync(loadBalancerName, parameters);
        }

        [RecordedTest]
        public async Task GetAsync()
        {
            // Example: Get load balancer
            var collection = GetArmClient().GetResourceGroup(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1")).GetLoadBalancers();
            string loadBalancerName = "lb";
            string expand = null;

            await collection.GetAsync(loadBalancerName, expand);
        }

        [RecordedTest]
        public void GetAllAsync()
        {
            // Example: List load balancers in resource group
            var collection = GetArmClient().GetResourceGroup(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1")).GetLoadBalancers();

            collection.GetAllAsync();
        }
    }
}
