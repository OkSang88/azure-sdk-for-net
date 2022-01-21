// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager.TestFramework;
using Azure.ResourceManager.WebPubSub;
using Azure.ResourceManager.WebPubSub.Models;

namespace Azure.ResourceManager.WebPubSub.Tests.Mock
{
    /// <summary> Test for WebPubSub. </summary>
    public partial class WebPubSubMockTests : MockTestBase
    {
        public WebPubSubMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task Get()
        {
            // Example: WebPubSub_Get
            var webPubSubId = WebPubSub.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "myResourceGroup", "myWebPubSubService");
            var webPubSub = GetArmClient().GetWebPubSub(webPubSubId);

            await webPubSub.GetAsync();
        }

        [RecordedTest]
        public async Task Delete()
        {
            // Example: WebPubSub_Delete
            var webPubSubId = WebPubSub.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "myResourceGroup", "myWebPubSubService");
            var webPubSub = GetArmClient().GetWebPubSub(webPubSubId);

            await webPubSub.DeleteAsync(true);
        }

        [RecordedTest]
        public async Task Update()
        {
            // Example: WebPubSub_Update
            var webPubSubId = WebPubSub.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "myResourceGroup", "myWebPubSubService");
            var webPubSub = GetArmClient().GetWebPubSub(webPubSubId);
            WebPubSubData parameters = new WebPubSubData(location: "eastus")
            {
                Sku = new WebPubSubSku(name: "Standard_S1")
                {
                    Tier = new WebPubSubSkuTier("Standard"),
                    Capacity = 1,
                },
                Identity = new ManagedIdentity()
                {
                    Type = new ManagedIdentityType("SystemAssigned"),
                },
                Tls = new WebPubSubTlsSettings()
                {
                    ClientCertEnabled = false,
                },
                LiveTraceConfiguration = new LiveTraceConfiguration()
                {
                    Enabled = "false",
                },
                NetworkAcls = new WebPubSubNetworkAcls()
                {
                    DefaultAction = new AclAction("Deny"),
                    PublicNetwork = new NetworkAcl(),
                },
                PublicNetworkAccess = "Enabled",
                DisableLocalAuth = false,
                DisableAadAuth = false,
            };
            parameters.Tags.ReplaceWith(new Dictionary<string, string>()
            {
                ["key1"] = "value1",
            });

            await webPubSub.UpdateAsync(true, parameters);
        }

        [RecordedTest]
        public async Task GetKeys()
        {
            // Example: WebPubSub_ListKeys
            var webPubSubId = WebPubSub.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "myResourceGroup", "myWebPubSubService");
            var webPubSub = GetArmClient().GetWebPubSub(webPubSubId);

            await webPubSub.GetKeysAsync();
        }

        [RecordedTest]
        public async Task RegenerateKey()
        {
            // Example: WebPubSub_RegenerateKey
            var webPubSubId = WebPubSub.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "myResourceGroup", "myWebPubSubService");
            var webPubSub = GetArmClient().GetWebPubSub(webPubSubId);
            RegenerateKeyParameters parameters = new RegenerateKeyParameters()
            {
                KeyType = new KeyType("Primary"),
            };

            await webPubSub.RegenerateKeyAsync(true, parameters);
        }

        [RecordedTest]
        public async Task Restart()
        {
            // Example: WebPubSub_Restart
            var webPubSubId = WebPubSub.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "myResourceGroup", "myWebPubSubService");
            var webPubSub = GetArmClient().GetWebPubSub(webPubSubId);

            await webPubSub.RestartAsync(true);
        }

        [RecordedTest]
        public async Task GetSkus()
        {
            // Example: WebPubSub_ListSkus
            var webPubSubId = WebPubSub.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "myResourceGroup", "myWebPubSubService");
            var webPubSub = GetArmClient().GetWebPubSub(webPubSubId);

            await foreach (var _ in webPubSub.GetSkusAsync())
            {
            }
        }

        [RecordedTest]
        public async Task GetWebPubSubPrivateLinkResources()
        {
            // Example: WebPubSubPrivateLinkResources_List
            var webPubSubId = WebPubSub.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "myResourceGroup", "myWebPubSubService");
            var webPubSub = GetArmClient().GetWebPubSub(webPubSubId);

            await foreach (var _ in webPubSub.GetWebPubSubPrivateLinkResourcesAsync())
            {
            }
        }
    }
}
