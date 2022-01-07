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
    /// <summary> Test for WebPubSub. </summary>
    public partial class WebPubSubCollectionMockTests : MockTestBase
    {
        public WebPubSubCollectionMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task CreateOrUpdateAsync()
        {
            // Example: WebPubSub_CreateOrUpdate
            var collection = GetArmClient().GetResourceGroup(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/myResourceGroup")).GetWebPubSubs();
            string resourceName = "myWebPubSubService";
            WebPubSub.WebPubSubData parameters = new WebPubSub.WebPubSubData(location: "eastus")
            {
                Sku = new WebPubSub.Models.WebPubSubSku(name: "Standard_S1")
                {
                    Tier = new WebPubSub.Models.WebPubSubSkuTier("Standard"),
                    Capacity = 1,
                },
                Identity = new WebPubSub.Models.ManagedIdentity()
                {
                    Type = new WebPubSub.Models.ManagedIdentityType("SystemAssigned"),
                },
                Tls = new WebPubSub.Models.WebPubSubTlsSettings()
                {
                    ClientCertEnabled = false,
                },
                LiveTraceConfiguration = new WebPubSub.Models.LiveTraceConfiguration()
                {
                    Enabled = "false",
                },
                NetworkAcls = new WebPubSub.Models.WebPubSubNetworkAcls()
                {
                    DefaultAction = new WebPubSub.Models.AclAction("Deny"),
                    PublicNetwork = new WebPubSub.Models.NetworkAcl(),
                },
                PublicNetworkAccess = "Enabled",
                DisableLocalAuth = false,
                DisableAadAuth = false,
            };
            parameters.Tags.ReplaceWith(new System.Collections.Generic.Dictionary<string, string>() { ["key1"] = "value1", });
            await collection.CreateOrUpdateAsync(resourceName, parameters);
        }

        [RecordedTest]
        public async Task GetAsync()
        {
            // Example: WebPubSub_Get
            var collection = GetArmClient().GetResourceGroup(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/myResourceGroup")).GetWebPubSubs();
            string resourceName = "myWebPubSubService";

            await collection.GetAsync(resourceName);
        }

        [RecordedTest]
        public void GetAllAsync()
        {
            // Example: WebPubSub_ListByResourceGroup
            var collection = GetArmClient().GetResourceGroup(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/myResourceGroup")).GetWebPubSubs();

            collection.GetAllAsync();
        }
    }
}
