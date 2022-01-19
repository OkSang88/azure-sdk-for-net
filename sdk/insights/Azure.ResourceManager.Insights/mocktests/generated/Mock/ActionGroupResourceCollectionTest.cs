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

namespace Insights.Tests.Mock
{
    /// <summary> Test for ActionGroupResource. </summary>
    public partial class ActionGroupResourceCollectionMockTests : MockTestBase
    {
        public ActionGroupResourceCollectionMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task CreateOrUpdate()
        {
            // Example: Create or update an action group
            string actionGroupName = "SampleActionGroup";
            Insights.ActionGroupResourceData actionGroup = new Insights.ActionGroupResourceData(location: "Global")
            {
                GroupShortName = "sample",
                Enabled = true,
            };
            actionGroup.Tags.ReplaceWith(new Dictionary<string, string>()
            {
            });

            var collection = GetArmClient().GetResourceGroup(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/Default-NotificationRules")).GetActionGroupResources();
            await collection.CreateOrUpdateAsync(true, actionGroupName, actionGroup);
        }

        [RecordedTest]
        public async Task Get()
        {
            // Example: Get an action group
            string actionGroupName = "SampleActionGroup";

            var collection = GetArmClient().GetResourceGroup(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/Default-NotificationRules")).GetActionGroupResources();
            await collection.GetAsync(actionGroupName);
        }

        [RecordedTest]
        public async Task GetAll()
        {
            // Example: List action groups

            var collection = GetArmClient().GetResourceGroup(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/Default-NotificationRules")).GetActionGroupResources();
            await foreach (var _ in collection.GetAllAsync())
            {
            }
        }
    }
}
