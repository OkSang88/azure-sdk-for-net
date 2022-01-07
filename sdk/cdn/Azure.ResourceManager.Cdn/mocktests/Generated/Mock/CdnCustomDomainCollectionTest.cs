// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Net;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager;
using Azure.ResourceManager.Cdn.Models;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Resources.Models;
using Azure.ResourceManager.TestFramework;

namespace Azure.ResourceManager.Cdn.Tests.Mock
{
    /// <summary> Test for CdnCustomDomain. </summary>
    public partial class CdnCustomDomainCollectionMockTests : MockTestBase
    {
        public CdnCustomDomainCollectionMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task CreateOrUpdateAsync()
        {
            // Example: CustomDomains_Create
            var collection = GetArmClient().GetCdnEndpoint(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/RG/providers/Microsoft.Cdn/profiles/profile1/endpoints/endpoint1")).GetCdnCustomDomains();
            string customDomainName = "www-someDomain-net";
            Cdn.Models.CustomDomainOptions customDomainProperties = new Cdn.Models.CustomDomainOptions()
            {
                HostName = "www.someDomain.net",
            };

            await collection.CreateOrUpdateAsync(customDomainName, customDomainProperties);
        }

        [RecordedTest]
        public async Task GetAsync()
        {
            // Example: CustomDomains_Get
            var collection = GetArmClient().GetCdnEndpoint(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/RG/providers/Microsoft.Cdn/profiles/profile1/endpoints/endpoint1")).GetCdnCustomDomains();
            string customDomainName = "www-someDomain-net";

            await collection.GetAsync(customDomainName);
        }

        [RecordedTest]
        public void GetAllAsync()
        {
            // Example: CustomDomains_ListByEndpoint
            var collection = GetArmClient().GetCdnEndpoint(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/RG/providers/Microsoft.Cdn/profiles/profile1/endpoints/endpoint1")).GetCdnCustomDomains();

            collection.GetAllAsync();
        }
    }
}
