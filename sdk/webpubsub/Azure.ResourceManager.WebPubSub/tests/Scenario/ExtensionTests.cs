// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Azure.Core;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.WebPubSub.Fakes;
using Azure.ResourceManager.WebPubSub.Models;
using Azure.ResourceManager.WebPubSub.Tests.Helpers;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.QualityTools.Testing.Fakes.Shims;
using NUnit.Framework;

namespace Azure.ResourceManager.WebPubSub.Tests.Scenario
{
    public class ExtensionTests : WebPubHubServiceClientTestBase
    {
        public ExtensionTests(bool isAsync) : base(isAsync)
        {
        }

        [Test]
        public void ArmClientMockTests()
        {
            using (ShimsContext.Create())
            {
                WebPubSub webPubSub = null;
                WebPubSubHub webPubSubHub = null;
                PrivateEndpointConnection privateEndpointConnection = null;
                SharedPrivateLink sharedPrivateLink = null;
                ShimArmClientExtensions.GetWebPubSubArmClientResourceIdentifier = (armClient, ResourceIdentifier) => { return webPubSub; };
                ShimArmClientExtensions.GetWebPubSubHubArmClientResourceIdentifier = (armClient, ResourceIdentifier) => { return webPubSubHub; };
                ShimArmClientExtensions.GetPrivateEndpointConnectionArmClientResourceIdentifier = (armClient, ResourceIdentifier) => { return privateEndpointConnection; };
                ShimArmClientExtensions.GetSharedPrivateLinkArmClientResourceIdentifier = (armClient, ResourceIdentifier) => { return sharedPrivateLink; };
            }
        }

        [Test]
        public void ArmClientMockTest2()
        {
            using (ShimsContext.Create())
            {
                ShimArmClientExtensions.GetWebPubSubArmClientResourceIdentifier =
                    (armClient, id) =>
                        {
                            // This delegate will replace the original GetWebPubSub() method
                            WebPubSub webPubSub = armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new WebPubSub(clientOptions, credential, uri, pipeline, id));
                            webPubSub.Data.Sku = new WebPubSubSku("Gen2");
                            webPubSub.Data.Location = AzureLocation.EastUS2;
                            return webPubSub;
                        };
                ArmClient armClient = GetArmClient();
                ResourceIdentifier id = null;
                var webPubSub =  armClient.GetWebPubSub(id);
                Assert.IsNotNull(webPubSub);
                Assert.AreEqual("Gen2",webPubSub.Data.Sku.ToString());
                Assert.AreEqual("EastUS2", webPubSub.Data.Location.ToString());
            }
        }

        [Test]
        public void ResourceGroupExtensionMockTests()
        {
            using (ShimsContext.Create())
            {
                WebPubSubCollection collection = null;
                ShimResourceGroupExtensions.GetWebPubSubsResourceGroup = (resourceGroup) => { return collection; };

                ShimResourceGroupExtensions.GetWebPubSubsResourceGroup = (resourceGroup) => { return new WebPubSubCollection(resourceGroup); };
            }
        }

        //[Test]
        //public void SubscriptionMockTests()
        //{
        //    using (ShimsContext.Create())
        //    {
        //        ShimSubscriptionExtensions.GetWebPubSubsSubscriptionCancellationToken = (subscription, CancellationToken) => { return null; };
        //        ShimSubscriptionExtensions.GetUsagesAsyncSubscriptionStringCancellationToken = (subscription, str, CancellationToken) => { return null; };
        //    }
        //}
    }
}
