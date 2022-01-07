// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Net;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager;
using Azure.ResourceManager.AppService;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Resources.Models;
using Azure.ResourceManager.TestFramework;

namespace Azure.ResourceManager.AppService.Tests.Mock
{
    /// <summary> Test for KubeEnvironment. </summary>
    public partial class KubeEnvironmentCollectionMockTests : MockTestBase
    {
        public KubeEnvironmentCollectionMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task CreateOrUpdateAsync()
        {
            // Example: Create kube environments
            var collection = GetArmClient().GetResourceGroup(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/examplerg")).GetKubeEnvironments();
            string name = "testkubeenv";
            AppService.KubeEnvironmentData kubeEnvironmentEnvelope = new AppService.KubeEnvironmentData(location: "East US")
            {
                StaticIp = "1.2.3.4",
            };

            await collection.CreateOrUpdateAsync(name, kubeEnvironmentEnvelope);
        }

        [RecordedTest]
        public async Task GetAsync()
        {
            // Example: Get kube environments by name
            var collection = GetArmClient().GetResourceGroup(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/examplerg")).GetKubeEnvironments();
            string name = "jlaw-demo1";

            await collection.GetAsync(name);
        }

        [RecordedTest]
        public void GetAllAsync()
        {
            // Example: List kube environments by resource group
            var collection = GetArmClient().GetResourceGroup(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/examplerg")).GetKubeEnvironments();

            collection.GetAllAsync();
        }
    }
}
