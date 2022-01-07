// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Net;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Resources.Models;
using Azure.ResourceManager.TestFramework;

namespace Azure.ResourceManager.AppService.Tests.Mock
{
    /// <summary> Test for StaticSiteBuildARMResource. </summary>
    public partial class StaticSiteBuildARMResourceCollectionMockTests : MockTestBase
    {
        public StaticSiteBuildARMResourceCollectionMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task GetAsync()
        {
            // Example: Get a static site build
            var collection = GetArmClient().GetStaticSiteARMResource(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg/providers/Microsoft.Web/staticSites/testStaticSite0")).GetStaticSiteBuildARMResources();
            string environmentName = "12";

            await collection.GetAsync(environmentName);
        }

        [RecordedTest]
        public void GetAllAsync()
        {
            // Example: Get all builds for a static site
            var collection = GetArmClient().GetStaticSiteARMResource(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg/providers/Microsoft.Web/staticSites/testStaticSite0")).GetStaticSiteBuildARMResources();

            collection.GetAllAsync();
        }
    }
}
