// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
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
    /// <summary> Test for StaticSiteUserProvidedFunctionAppARMResource. </summary>
    public partial class StaticSiteBuildUserProvidedFunctionAppMockTests : MockTestBase
    {
        public StaticSiteBuildUserProvidedFunctionAppMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task GetAsync()
        {
            // Example: Get details of the user provided function app registered with a static site build.
            var staticSiteBuildUserProvidedFunctionApp = GetArmClient().GetStaticSiteBuildUserProvidedFunctionApp(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg/providers/Microsoft.Web/staticSites/testStaticSite0/builds/default/userProvidedFunctionApps/testFunctionApp"));

            await staticSiteBuildUserProvidedFunctionApp.GetAsync();
        }

        [RecordedTest]
        public async Task DeleteAsync()
        {
            // Example: Detach the user provided function app from the static site build.
            var staticSiteBuildUserProvidedFunctionApp = GetArmClient().GetStaticSiteBuildUserProvidedFunctionApp(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg/providers/Microsoft.Web/staticSites/testStaticSite0/builds/12/userProvidedFunctionApps/testFunctionApp"));

            await staticSiteBuildUserProvidedFunctionApp.DeleteAsync();
        }
    }
}
