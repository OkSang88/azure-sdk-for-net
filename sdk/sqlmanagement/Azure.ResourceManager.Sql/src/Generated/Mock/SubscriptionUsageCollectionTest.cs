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
using Azure.ResourceManager.Sql.Models;
using Azure.ResourceManager.TestFramework;

namespace Azure.ResourceManager.Sql.Tests.Mock
{
    /// <summary> Test for SubscriptionUsage. </summary>
    public partial class SubscriptionUsageCollectionMockTests : MockTestBase
    {
        public SubscriptionUsageCollectionMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task GetAsync()
        {
            // Example: Get specific subscription usage in the given location.
            var collection = GetArmClient().GetSubscription(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000")).GetSubscriptionUsages();
            string locationName = "WestUS";
            string usageName = "ServerQuota";

            await collection.GetAsync(locationName, usageName);
        }

        [RecordedTest]
        public void GetAllAsync()
        {
            // Example: List subscription usages in the given location.
            var collection = GetArmClient().GetSubscription(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000")).GetSubscriptionUsages();
            string locationName = "WestUS";

            collection.GetAllAsync(locationName);
        }
    }
}
