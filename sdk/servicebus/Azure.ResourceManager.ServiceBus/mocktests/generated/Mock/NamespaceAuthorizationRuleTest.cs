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
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Resources.Models;
using Azure.ResourceManager.ServiceBus.Models;
using Azure.ResourceManager.TestFramework;

namespace Azure.ResourceManager.ServiceBus.Tests.Mock
{
    /// <summary> Test for ServiceBusAuthorizationRule. </summary>
    public partial class NamespaceAuthorizationRuleMockTests : MockTestBase
    {
        public NamespaceAuthorizationRuleMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task GetAsync()
        {
            // Example: NameSpaceAuthorizationRuleGet
            var namespaceAuthorizationRule = GetArmClient().GetNamespaceAuthorizationRule(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/ArunMonocle/providers/Microsoft.ServiceBus/namespaces/sdk-Namespace-6914/AuthorizationRules/sdk-AuthRules-1788"));

            await namespaceAuthorizationRule.GetAsync();
        }

        [RecordedTest]
        public async Task DeleteAsync()
        {
            // Example: NameSpaceAuthorizationRuleDelete
            var namespaceAuthorizationRule = GetArmClient().GetNamespaceAuthorizationRule(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/ArunMonocle/providers/Microsoft.ServiceBus/namespaces/sdk-namespace-6914/AuthorizationRules/sdk-AuthRules-1788"));

            await namespaceAuthorizationRule.DeleteAsync();
        }

        [RecordedTest]
        public async Task GetKeysAsync()
        {
            // Example: NameSpaceAuthorizationRuleListKey
            var namespaceAuthorizationRule = GetArmClient().GetNamespaceAuthorizationRule(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/ArunMonocle/providers/Microsoft.ServiceBus/namespaces/sdk-namespace-6914/AuthorizationRules/sdk-AuthRules-1788"));

            await namespaceAuthorizationRule.GetKeysAsync();
        }

        [RecordedTest]
        public async Task RegenerateKeysAsync()
        {
            // Example: NameSpaceAuthorizationRuleRegenerateKey
            var namespaceAuthorizationRule = GetArmClient().GetNamespaceAuthorizationRule(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/ArunMonocle/providers/Microsoft.ServiceBus/namespaces/sdk-namespace-6914/AuthorizationRules/sdk-AuthRules-1788"));
            ServiceBus.Models.RegenerateAccessKeyOptions parameters = new ServiceBus.Models.RegenerateAccessKeyOptions(keyType: ServiceBus.Models.KeyType.PrimaryKey);

            await namespaceAuthorizationRule.RegenerateKeysAsync(parameters);
        }
    }
}
