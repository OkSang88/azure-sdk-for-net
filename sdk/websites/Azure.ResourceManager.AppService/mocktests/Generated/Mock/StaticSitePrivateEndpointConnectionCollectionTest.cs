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
    /// <summary> Test for RemotePrivateEndpointConnectionARMResource. </summary>
    public partial class StaticSitePrivateEndpointConnectionCollectionMockTests : MockTestBase
    {
        public StaticSitePrivateEndpointConnectionCollectionMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task CreateOrUpdateAsync()
        {
            // Example: Approves or rejects a private endpoint connection for a site.
            var collection = GetArmClient().GetStaticSiteARMResource(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg/providers/Microsoft.Web/staticSites/testSite")).GetStaticSitePrivateEndpointConnections();
            string privateEndpointConnectionName = "connection";
            AppService.Models.PrivateLinkConnectionApprovalRequestResource privateEndpointWrapper = new AppService.Models.PrivateLinkConnectionApprovalRequestResource()
            {
                PrivateLinkServiceConnectionState = new AppService.Models.PrivateLinkConnectionState()
                {
                    Status = "Approved",
                    Description = "Approved by admin.",
                    ActionsRequired = "",
                },
            };

            await collection.CreateOrUpdateAsync(privateEndpointConnectionName, privateEndpointWrapper);
        }

        [RecordedTest]
        public async Task GetAsync()
        {
            // Example: Get a private endpoint connection for a site.
            var collection = GetArmClient().GetStaticSiteARMResource(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg/providers/Microsoft.Web/staticSites/testSite")).GetStaticSitePrivateEndpointConnections();
            string privateEndpointConnectionName = "connection";

            await collection.GetAsync(privateEndpointConnectionName);
        }

        [RecordedTest]
        public void GetAllAsync()
        {
            // Example: Get a list of private endpoint connections associated with a site.
            var collection = GetArmClient().GetStaticSiteARMResource(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg/providers/Microsoft.Web/staticSites/testStaticSite0")).GetStaticSitePrivateEndpointConnections();

            collection.GetAllAsync();
        }
    }
}
