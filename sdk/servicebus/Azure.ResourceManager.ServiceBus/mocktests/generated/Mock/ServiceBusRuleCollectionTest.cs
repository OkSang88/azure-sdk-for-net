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
using Azure.ResourceManager.ServiceBus;
using Azure.ResourceManager.ServiceBus.Models;
using Azure.ResourceManager.TestFramework;

namespace Azure.ResourceManager.ServiceBus.Tests.Mock
{
    /// <summary> Test for ServiceBusRule. </summary>
    public partial class ServiceBusRuleCollectionMockTests : MockTestBase
    {
        public ServiceBusRuleCollectionMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task CreateOrUpdateAsync()
        {
            // Example: RulesCreateCorrelationFilter
            var collection = GetArmClient().GetServiceBusSubscription(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/resourceGroupName/providers/Microsoft.ServiceBus/namespaces/sdk-Namespace-1319/topics/sdk-Topics-2081/subscriptions/00000000-0000-0000-0000-000000000000")).GetServiceBusRules();
            string ruleName = "sdk-Rules-6571";
            ServiceBus.ServiceBusRuleData parameters = new ServiceBus.ServiceBusRuleData()
            {
                FilterType = ServiceBus.Models.FilterType.CorrelationFilter,
                CorrelationFilter = new ServiceBus.Models.CorrelationFilter(),
            };

            await collection.CreateOrUpdateAsync(ruleName, parameters);
        }

        [RecordedTest]
        public async Task CreateOrUpdateAsync2()
        {
            // Example: RulesCreateOrUpdate
            var collection = GetArmClient().GetServiceBusSubscription(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/resourceGroupName/providers/Microsoft.ServiceBus/namespaces/sdk-Namespace-1319/topics/sdk-Topics-2081/subscriptions/00000000-0000-0000-0000-000000000000")).GetServiceBusRules();
            string ruleName = "sdk-Rules-6571";
            ServiceBus.ServiceBusRuleData parameters = new ServiceBus.ServiceBusRuleData();

            await collection.CreateOrUpdateAsync(ruleName, parameters);
        }

        [RecordedTest]
        public async Task CreateOrUpdateAsync3()
        {
            // Example: RulesCreateSqlFilter
            var collection = GetArmClient().GetServiceBusSubscription(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/resourceGroupName/providers/Microsoft.ServiceBus/namespaces/sdk-Namespace-1319/topics/sdk-Topics-2081/subscriptions/00000000-0000-0000-0000-000000000000")).GetServiceBusRules();
            string ruleName = "sdk-Rules-6571";
            ServiceBus.ServiceBusRuleData parameters = new ServiceBus.ServiceBusRuleData()
            {
                FilterType = ServiceBus.Models.FilterType.SqlFilter,
                SqlFilter = new ServiceBus.Models.SqlFilter()
                {
                    SqlExpression = "myproperty=test",
                },
            };

            await collection.CreateOrUpdateAsync(ruleName, parameters);
        }

        [RecordedTest]
        public async Task GetAsync()
        {
            // Example: RulesGet
            var collection = GetArmClient().GetServiceBusSubscription(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/ArunMonocle/providers/Microsoft.ServiceBus/namespaces/sdk-Namespace-1319/topics/sdk-Topics-2081/subscriptions/00000000-0000-0000-0000-000000000000")).GetServiceBusRules();
            string ruleName = "sdk-Rules-6571";

            await collection.GetAsync(ruleName);
        }

        [RecordedTest]
        public void GetAllAsync()
        {
            // Example: RulesListBySubscriptions
            var collection = GetArmClient().GetServiceBusSubscription(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/ArunMonocle/providers/Microsoft.ServiceBus/namespaces/sdk-Namespace-1319/topics/sdk-Topics-2081/subscriptions/00000000-0000-0000-0000-000000000000")).GetServiceBusRules();
            int? skip = null;
            int? top = null;

            collection.GetAllAsync(skip, top);
        }
    }
}
