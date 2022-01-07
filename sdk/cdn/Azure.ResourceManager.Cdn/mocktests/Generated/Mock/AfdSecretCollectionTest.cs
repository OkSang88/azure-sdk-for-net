// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Net;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager;
using Azure.ResourceManager.Cdn;
using Azure.ResourceManager.Cdn.Models;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Resources.Models;
using Azure.ResourceManager.TestFramework;

namespace Azure.ResourceManager.Cdn.Tests.Mock
{
    /// <summary> Test for AfdSecret. </summary>
    public partial class AfdSecretCollectionMockTests : MockTestBase
    {
        public AfdSecretCollectionMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task CreateOrUpdateAsync()
        {
            // Example: Secrets_Create
            var collection = GetArmClient().GetProfile(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/RG/providers/Microsoft.Cdn/profiles/profile1")).GetAfdSecrets();
            string secretName = "secret1";
            Cdn.AfdSecretData secret = new Cdn.AfdSecretData()
            {
                Parameters = new Cdn.Models.CustomerCertificateParameters(secretSource: new WritableSubResource()
                {
                    Id = new ResourceIdentifier($"/subscriptions/00000000-0000-0000-0000-000000000000/resourcegroups/RG/providers/Microsoft.KeyVault/vault/kvName/certificate/certName"),
                })
                {
                    SecretVersion = "67c452f83c804aed80aa3a21e523c226",
                    CertificateAuthority = "Symantec",
                    UseLatestVersion = false,
                    Type = new Cdn.Models.SecretType("CustomerCertificate"),
                },
            };

            await collection.CreateOrUpdateAsync(secretName, secret);
        }

        [RecordedTest]
        public async Task GetAsync()
        {
            // Example: Secrets_Get
            var collection = GetArmClient().GetProfile(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/RG/providers/Microsoft.Cdn/profiles/profile1")).GetAfdSecrets();
            string secretName = "secret1";

            await collection.GetAsync(secretName);
        }

        [RecordedTest]
        public void GetAllAsync()
        {
            // Example: Secrets_ListByProfile
            var collection = GetArmClient().GetProfile(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/RG/providers/Microsoft.Cdn/profiles/profile1")).GetAfdSecrets();

            collection.GetAllAsync();
        }
    }
}
