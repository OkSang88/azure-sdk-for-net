// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Net;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager.Cdn;
using Azure.ResourceManager.TestFramework;

namespace Azure.ResourceManager.Cdn.Tests.Mock
{
    /// <summary> Test for AfdRule. </summary>
    public partial class AfdRuleCollectionMockTests : MockTestBase
    {
        public AfdRuleCollectionMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task CreateOrUpdate()
        {
            // Example: Rules_Create
            string ruleName = "rule1";
            Cdn.AfdRuleData rule = new Cdn.AfdRuleData()
            {
                Order = 1,
            };

            var afdRuleSetId = Cdn.AfdRuleSet.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "RG", "profile1", "ruleSet1");
            var collection = GetArmClient().GetAfdRuleSet(afdRuleSetId).GetAfdRules();
            await collection.CreateOrUpdateAsync(true, ruleName, rule);
        }

        [RecordedTest]
        public async Task Get()
        {
            // Example: Rules_Get
            string ruleName = "rule1";

            var afdRuleSetId = Cdn.AfdRuleSet.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "RG", "profile1", "ruleSet1");
            var collection = GetArmClient().GetAfdRuleSet(afdRuleSetId).GetAfdRules();
            await collection.GetAsync(ruleName);
        }

        [RecordedTest]
        public async Task GetAll()
        {
            // Example: Rules_ListByRuleSet

            var afdRuleSetId = Cdn.AfdRuleSet.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "RG", "profile1", "ruleSet1");
            var collection = GetArmClient().GetAfdRuleSet(afdRuleSetId).GetAfdRules();
            await foreach (var _ in collection.GetAllAsync())
            {
            }
        }
    }
}
