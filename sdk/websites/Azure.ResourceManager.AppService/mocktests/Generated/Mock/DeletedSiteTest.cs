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
    /// <summary> Test for DeletedSite. </summary>
    public partial class DeletedSiteMockTests : MockTestBase
    {
        public DeletedSiteMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task GetAsync()
        {
            // Example: Get Deleted Web App
            var deletedSite = GetArmClient().GetDeletedSite(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/providers/Microsoft.Web/deletedSites/9"));

            await deletedSite.GetAsync();
        }

        [RecordedTest]
        public async Task GetDeletedWebAppSnapshotsAsync()
        {
            // Example: Get Deleted Web App Snapshots
            var deletedSite = GetArmClient().GetDeletedSite(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/providers/Microsoft.Web/deletedSites/9"));

            await deletedSite.GetDeletedWebAppSnapshotsAsync();
        }
    }
}
