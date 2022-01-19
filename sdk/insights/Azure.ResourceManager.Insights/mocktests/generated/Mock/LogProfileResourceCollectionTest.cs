// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.TestFramework;
using Azure.ResourceManager.TestFramework;
using Insights;
using Insights.Models;

namespace Insights.Tests.Mock
{
    /// <summary> Test for LogProfileResource. </summary>
    public partial class LogProfileResourceCollectionMockTests : MockTestBase
    {
        public LogProfileResourceCollectionMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task CreateOrUpdate()
        {
            // Example: Create or update a log profile
            string logProfileName = "Rac46PostSwapRG";
            Insights.LogProfileResourceData parameters = new Insights.LogProfileResourceData(location: "", locations: new List<string>()
{
"global",}, categories: new List<string>()
{
"Write","Delete","Action",}, retentionPolicy: new Insights.Models.RetentionPolicy(enabled: true, days: 3))
            {
                StorageAccountId = "/subscriptions/df602c9c-7aa0-407d-a6fb-eb20c8bd1192/resourceGroups/JohnKemTest/providers/Microsoft.Storage/storageAccounts/johnkemtest8162",
                ServiceBusRuleId = "",
            };
            parameters.Tags.ReplaceWith(new Dictionary<string, string>()
            {
            });

            var collection = GetArmClient().GetSubscription(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000")).GetLogProfileResources();
            await collection.CreateOrUpdateAsync(true, logProfileName, parameters);
        }

        [RecordedTest]
        public async Task Get()
        {
            // Example: Get log profile
            string logProfileName = "default";

            var collection = GetArmClient().GetSubscription(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000")).GetLogProfileResources();
            await collection.GetAsync(logProfileName);
        }

        [RecordedTest]
        public async Task GetAll()
        {
            // Example: List log profiles

            var collection = GetArmClient().GetSubscription(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000")).GetLogProfileResources();
            await foreach (var _ in collection.GetAllAsync())
            {
            }
        }
    }
}
