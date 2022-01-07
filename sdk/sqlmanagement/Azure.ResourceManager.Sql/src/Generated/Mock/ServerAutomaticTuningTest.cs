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
using Azure.ResourceManager.Sql;
using Azure.ResourceManager.Sql.Models;
using Azure.ResourceManager.TestFramework;

namespace Azure.ResourceManager.Sql.Tests.Mock
{
    /// <summary> Test for ServerAutomaticTuning. </summary>
    public partial class ServerAutomaticTuningMockTests : MockTestBase
    {
        public ServerAutomaticTuningMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task GetAsync()
        {
            // Example: Get a server's automatic tuning settings
            var serverAutomaticTuning = GetArmClient().GetServerAutomaticTuning(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/default-sql-onebox/providers/Microsoft.Sql/servers/testsvr11/automaticTuning/current"));

            await serverAutomaticTuning.GetAsync();
        }

        [RecordedTest]
        public async Task UpdateAsync()
        {
            // Example: Updates server automatic tuning settings with all properties
            var serverAutomaticTuning = GetArmClient().GetServerAutomaticTuning(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/default-sql-onebox/providers/Microsoft.Sql/servers/testsvr11/automaticTuning/current"));
            Sql.ServerAutomaticTuningData parameters = new Sql.ServerAutomaticTuningData()
            {
                DesiredState = Sql.Models.AutomaticTuningServerMode.Auto,
            };

            await serverAutomaticTuning.UpdateAsync(parameters);
        }

        [RecordedTest]
        public async Task UpdateAsync2()
        {
            // Example: Updates server automatic tuning settings with minimal properties
            var serverAutomaticTuning = GetArmClient().GetServerAutomaticTuning(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/default-sql-onebox/providers/Microsoft.Sql/servers/testsvr11/automaticTuning/current"));
            Sql.ServerAutomaticTuningData parameters = new Sql.ServerAutomaticTuningData()
            {
                DesiredState = Sql.Models.AutomaticTuningServerMode.Auto,
            };

            await serverAutomaticTuning.UpdateAsync(parameters);
        }
    }
}
