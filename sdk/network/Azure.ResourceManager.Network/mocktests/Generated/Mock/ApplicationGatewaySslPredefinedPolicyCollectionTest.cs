// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Net;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Resources.Models;
using Azure.ResourceManager.TestFramework;

namespace Azure.ResourceManager.Network.Tests.Mock
{
    /// <summary> Test for ApplicationGatewaySslPredefinedPolicy. </summary>
    public partial class ApplicationGatewaySslPredefinedPolicyCollectionMockTests : MockTestBase
    {
        public ApplicationGatewaySslPredefinedPolicyCollectionMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task GetAsync()
        {
            // Example: Get Available Ssl Predefined Policy by name
            var collection = GetArmClient().GetApplicationGatewayAvailableSslOptions(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/providers/Microsoft.Network/applicationGatewayAvailableSslOptions/default")).GetApplicationGatewaySslPredefinedPolicies();
            string predefinedPolicyName = "AppGwSslPolicy20150501";

            await collection.GetAsync(predefinedPolicyName);
        }

        [RecordedTest]
        public void GetAllAsync()
        {
            // Example: Get Available Ssl Predefined Policies
            var collection = GetArmClient().GetApplicationGatewayAvailableSslOptions(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/providers/Microsoft.Network/applicationGatewayAvailableSslOptions/default")).GetApplicationGatewaySslPredefinedPolicies();

            collection.GetAllAsync();
        }
    }
}
