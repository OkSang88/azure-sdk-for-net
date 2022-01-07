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
using Azure.ResourceManager.WebPubSub;
using Azure.ResourceManager.WebPubSub.Models;

namespace Azure.ResourceManager.WebPubSub.Tests.Mock
{
    /// <summary> Test for SharedPrivateLink. </summary>
    public partial class SharedPrivateLinkCollectionMockTests : MockTestBase
    {
        public SharedPrivateLinkCollectionMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task CreateOrUpdateAsync()
        {
            // Example: WebPubSubSharedPrivateLinkResources_CreateOrUpdate
            var collection = GetArmClient().GetWebPubSub(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/myResourceGroup/providers/Microsoft.SignalRService/webPubSub/myWebPubSubService")).GetSharedPrivateLinks();
            string sharedPrivateLinkName = null; /* Can't find this parameter in example, please provide value here!*/
            WebPubSub.SharedPrivateLinkData parameters = new WebPubSub.SharedPrivateLinkData()
            {
                GroupId = "sites",
                PrivateLinkResourceId = "/subscriptions/00000000-0000-0000-0000-000000000000/resourcegroups/myResourceGroup/providers/Microsoft.Web/sites/myWebApp",
                RequestMessage = "Please approve",
            };

            await collection.CreateOrUpdateAsync(sharedPrivateLinkName, parameters);
        }

        [RecordedTest]
        public async Task GetAsync()
        {
            // Example: WebPubSubSharedPrivateLinkResources_Get
            var collection = GetArmClient().GetWebPubSub(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/myResourceGroup/providers/Microsoft.SignalRService/webPubSub/myWebPubSubService")).GetSharedPrivateLinks();
            string sharedPrivateLinkName = null; /* Can't find this parameter in example, please provide value here!*/

            await collection.GetAsync(sharedPrivateLinkName);
        }

        [RecordedTest]
        public void GetAllAsync()
        {
            // Example: WebPubSubSharedPrivateLinkResources_List
            var collection = GetArmClient().GetWebPubSub(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/myResourceGroup/providers/Microsoft.SignalRService/webPubSub/myWebPubSubService")).GetSharedPrivateLinks();

            collection.GetAllAsync();
        }
    }
}
