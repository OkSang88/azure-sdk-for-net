// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Net;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Resources.Models;
using Azure.ResourceManager.TestFramework;

namespace Azure.ResourceManager.Resources.Tests.Mock
{
    /// <summary> Test for Application. </summary>
    public partial class ApplicationCollectionMockTests : MockTestBase
    {
        public ApplicationCollectionMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task CreateOrUpdateAsync()
        {
            // Example: Create or update managed application
            var collection = GetArmClient().GetResourceGroup(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg")).GetApplications();
            string applicationName = "myManagedApplication";
            Resources.ApplicationData parameters = new Resources.ApplicationData(location: "East US 2", kind: "ServiceCatalog")
            {
                ManagedResourceGroupId = "/subscriptions/subid/resourceGroups/myManagedRG",
                ApplicationDefinitionId = "/subscriptions/subid/resourceGroups/rg/providers/Microsoft.Solutions/applicationDefinitions/myAppDef",
            };

            await collection.CreateOrUpdateAsync(applicationName, parameters);
        }

        [RecordedTest]
        public async Task GetAsync()
        {
            // Example: Get a managed application
            var collection = GetArmClient().GetResourceGroup(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg")).GetApplications();
            string applicationName = "myManagedApplication";

            await collection.GetAsync(applicationName);
        }

        [RecordedTest]
        public void GetAllAsync()
        {
            // Example: Lists applications
            var collection = GetArmClient().GetResourceGroup(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg")).GetApplications();

            collection.GetAllAsync();
        }
    }
}
