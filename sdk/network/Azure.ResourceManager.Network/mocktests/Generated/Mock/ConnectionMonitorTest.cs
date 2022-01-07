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
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Resources.Models;
using Azure.ResourceManager.TestFramework;

namespace Azure.ResourceManager.Network.Tests.Mock
{
    /// <summary> Test for ConnectionMonitor. </summary>
    public partial class ConnectionMonitorMockTests : MockTestBase
    {
        public ConnectionMonitorMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task GetAsync()
        {
            // Example: Get connection monitor
            var connectionMonitor = GetArmClient().GetConnectionMonitor(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Network/networkWatchers/nw1/connectionMonitors/cm1"));

            await connectionMonitor.GetAsync();
        }

        [RecordedTest]
        public async Task DeleteAsync()
        {
            // Example: Delete connection monitor
            var connectionMonitor = GetArmClient().GetConnectionMonitor(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Network/networkWatchers/nw1/connectionMonitors/cm1"));

            await connectionMonitor.DeleteAsync();
        }

        [RecordedTest]
        public async Task UpdateAsync()
        {
            // Example: Update connection monitor tags
            var connectionMonitor = GetArmClient().GetConnectionMonitor(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Network/networkWatchers/nw1/connectionMonitors/cm1"));
            Network.Models.TagsObject parameters = new Network.Models.TagsObject();

            await connectionMonitor.UpdateAsync(parameters);
        }

        [RecordedTest]
        public async Task StopAsync()
        {
            // Example: Stop connection monitor
            var connectionMonitor = GetArmClient().GetConnectionMonitor(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Network/networkWatchers/nw1/connectionMonitors/cm1"));

            await connectionMonitor.StopAsync();
        }

        [RecordedTest]
        public async Task StartAsync()
        {
            // Example: Start connection monitor
            var connectionMonitor = GetArmClient().GetConnectionMonitor(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Network/networkWatchers/nw1/connectionMonitors/cm1"));

            await connectionMonitor.StartAsync();
        }

        [RecordedTest]
        public async Task QueryAsync()
        {
            // Example: Query connection monitor
            var connectionMonitor = GetArmClient().GetConnectionMonitor(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Network/networkWatchers/nw1/connectionMonitors/cm1"));

            await connectionMonitor.QueryAsync();
        }
    }
}
