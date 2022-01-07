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
using Azure.ResourceManager.EventHubs.Models;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Resources.Models;
using Azure.ResourceManager.TestFramework;

namespace Azure.ResourceManager.EventHubs.Tests.Mock
{
    /// <summary> Test for NetworkRuleSet. </summary>
    public partial class NetworkRuleSetMockTests : MockTestBase
    {
        public NetworkRuleSetMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task GetAsync()
        {
            // Example: NameSpaceNetworkRuleSetGet
            var networkRuleSet = GetArmClient().GetNetworkRuleSet(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/ResourceGroup/providers/Microsoft.EventHub/namespaces/sdk-Namespace-6019/networkRuleSets/default"));

            await networkRuleSet.GetAsync();
        }
    }
}
