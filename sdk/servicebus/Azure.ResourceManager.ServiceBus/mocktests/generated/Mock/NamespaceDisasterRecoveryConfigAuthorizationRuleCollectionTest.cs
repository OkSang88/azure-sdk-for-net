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
using Azure.ResourceManager.ServiceBus.Models;
using Azure.ResourceManager.TestFramework;

namespace Azure.ResourceManager.ServiceBus.Tests.Mock
{
    /// <summary> Test for ServiceBusAuthorizationRule. </summary>
    public partial class NamespaceDisasterRecoveryConfigAuthorizationRuleCollectionMockTests : MockTestBase
    {
        public NamespaceDisasterRecoveryConfigAuthorizationRuleCollectionMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task GetAsync()
        {
            // Example: DisasterRecoveryConfigsAuthorizationRuleGet
            var collection = GetArmClient().GetDisasterRecovery(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/exampleResourceGroup/providers/Microsoft.ServiceBus/namespaces/sdk-Namespace-9080/disasterRecoveryConfigs/sdk-DisasterRecovery-4879")).GetNamespaceDisasterRecoveryConfigAuthorizationRules();
            string authorizationRuleName = "sdk-Authrules-4879";

            await collection.GetAsync(authorizationRuleName);
        }

        [RecordedTest]
        public void GetAllAsync()
        {
            // Example: NameSpaceAuthorizationRuleListAll
            var collection = GetArmClient().GetDisasterRecovery(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/exampleResourceGroup/providers/Microsoft.ServiceBus/namespaces/sdk-Namespace-9080/disasterRecoveryConfigs/sdk-DisasterRecovery-4047")).GetNamespaceDisasterRecoveryConfigAuthorizationRules();

            collection.GetAllAsync();
        }
    }
}
