// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.WebPubSub.Fakes;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.QualityTools.Testing.Fakes.Shims;
using NUnit.Framework;

namespace Azure.ResourceManager.WebPubSub.Tests.Scenario
{
    public class ExtensionTests
    {
        [Test]
        public void ArmClientMockTests()
        {
            using (ShimsContext.Create())
            {
                WebPubSub webPubSub = null;
                WebPubSubHub webPubSubHub = null;
                ShimArmClientExtensions.GetWebPubSubArmClientResourceIdentifier = (armClient, ResourceIdentifier) => { return webPubSub; };
                ShimArmClientExtensions.GetWebPubSubHubArmClientResourceIdentifier = (armClient, ResourceIdentifier) => { return webPubSubHub; };
            }
        }

        [Test]
        public void ResourceGroupExtensionMockTests()
        {
            using (ShimsContext.Create())
            {
                WebPubSubCollection webpubsub = null;
                ShimResourceGroupExtensions.GetWebPubSubsResourceGroup =
                    (resourceGroup) =>
                    {
                        return webpubsub;
                    };
            }
        }

        [Test]
        public void SubscriptionMockTests()
        {
            using (ShimsContext.Create())
            {
                ShimSubscriptionExtensions.GetUsagesAsyncSubscriptionStringCancellationToken = () => { };
                ShimSubscriptionExtensions.GetWebPubSubsSubscriptionCancellationToken = () => { };
            }
        }
    }
}
