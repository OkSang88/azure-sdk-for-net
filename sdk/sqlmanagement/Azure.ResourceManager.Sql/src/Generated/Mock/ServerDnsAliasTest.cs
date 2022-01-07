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
using Azure.ResourceManager.Sql.Models;
using Azure.ResourceManager.TestFramework;

namespace Azure.ResourceManager.Sql.Tests.Mock
{
    /// <summary> Test for ServerDnsAlias. </summary>
    public partial class ServerDnsAliasMockTests : MockTestBase
    {
        public ServerDnsAliasMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task GetAsync()
        {
            // Example: Get server DNS alias
            var serverDnsAlias = GetArmClient().GetServerDnsAlias(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/Default/providers/Microsoft.Sql/servers/dns-alias-server/dnsAliases/dns-alias-name-1"));

            await serverDnsAlias.GetAsync();
        }

        [RecordedTest]
        public async Task DeleteAsync()
        {
            // Example: Delete server DNS alias
            var serverDnsAlias = GetArmClient().GetServerDnsAlias(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/Default/providers/Microsoft.Sql/servers/dns-alias-server/dnsAliases/dns-alias-name-1"));

            await serverDnsAlias.DeleteAsync();
        }

        [RecordedTest]
        public async Task AcquireAsync()
        {
            // Example: Acquire server DNS alias
            var serverDnsAlias = GetArmClient().GetServerDnsAlias(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/Default/providers/Microsoft.Sql/servers/dns-alias-new-server/dnsAliases/dns-alias-name-1"));
            Sql.Models.ServerDnsAliasAcquisition parameters = new Sql.Models.ServerDnsAliasAcquisition(oldServerDnsAliasId: "/subscriptions/00000000-1111-2222-3333-444444444444/resourceGroups/Default/providers/Microsoft.Sql/servers/dns-alias-old-server/dnsAliases/dns-alias-name-1");

            await serverDnsAlias.AcquireAsync(parameters);
        }
    }
}
