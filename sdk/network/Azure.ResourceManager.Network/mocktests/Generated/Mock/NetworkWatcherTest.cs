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
    /// <summary> Test for NetworkWatcher. </summary>
    public partial class NetworkWatcherMockTests : MockTestBase
    {
        public NetworkWatcherMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task GetAsync()
        {
            // Example: Get network watcher
            var networkWatcher = GetArmClient().GetNetworkWatcher(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Network/networkWatchers/nw1"));

            await networkWatcher.GetAsync();
        }

        [RecordedTest]
        public async Task DeleteAsync()
        {
            // Example: Delete network watcher
            var networkWatcher = GetArmClient().GetNetworkWatcher(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Network/networkWatchers/nw1"));

            await networkWatcher.DeleteAsync();
        }

        [RecordedTest]
        public async Task UpdateAsync()
        {
            // Example: Update network watcher tags
            var networkWatcher = GetArmClient().GetNetworkWatcher(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Network/networkWatchers/nw1"));
            Network.Models.TagsObject parameters = new Network.Models.TagsObject();

            await networkWatcher.UpdateAsync(parameters);
        }

        [RecordedTest]
        public async Task GetTopologyAsync()
        {
            // Example: Get Topology
            var networkWatcher = GetArmClient().GetNetworkWatcher(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Network/networkWatchers/nw1"));
            Network.Models.TopologyParameters parameters = new Network.Models.TopologyParameters()
            {
                TargetResourceGroupName = "rg2",
            };

            await networkWatcher.GetTopologyAsync(parameters);
        }

        [RecordedTest]
        public async Task VerifyIPFlowAsync()
        {
            // Example: Ip flow verify
            var networkWatcher = GetArmClient().GetNetworkWatcher(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Network/networkWatchers/nw1"));
            Network.Models.VerificationIPFlowParameters parameters = new Network.Models.VerificationIPFlowParameters(targetResourceId: "/subscriptions/subid/resourceGroups/rg2/providers/Microsoft.Compute/virtualMachines/vm1", direction: new Network.Models.Direction("Outbound"), protocol: new Network.Models.IpFlowProtocol("TCP"), localPort: "80", remotePort: "80", localIPAddress: "10.2.0.4", remoteIPAddress: "121.10.1.1");

            await networkWatcher.VerifyIPFlowAsync(parameters);
        }

        [RecordedTest]
        public async Task GetNextHopAsync()
        {
            // Example: Get next hop
            var networkWatcher = GetArmClient().GetNetworkWatcher(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Network/networkWatchers/nw1"));
            Network.Models.NextHopParameters parameters = new Network.Models.NextHopParameters(targetResourceId: "/subscriptions/subid/resourceGroups/rg2/providers/Microsoft.Compute/virtualMachines/vm1", sourceIPAddress: "10.0.0.5", destinationIPAddress: "10.0.0.10")
            {
                TargetNicResourceId = "/subscriptions/subid/resourceGroups/rg1/providers/Microsoft.Network/networkInterfaces/nic1",
            };

            await networkWatcher.GetNextHopAsync(parameters);
        }

        [RecordedTest]
        public async Task GetVMSecurityRulesAsync()
        {
            // Example: Get security group view
            var networkWatcher = GetArmClient().GetNetworkWatcher(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Network/networkWatchers/nw1"));
            Network.Models.SecurityGroupViewParameters parameters = new Network.Models.SecurityGroupViewParameters(targetResourceId: "/subscriptions/subid/resourceGroups/rg2/providers/Microsoft.Compute/virtualMachines/vm1");

            await networkWatcher.GetVMSecurityRulesAsync(parameters);
        }

        [RecordedTest]
        public async Task GetTroubleshootingAsync()
        {
            // Example: Get troubleshooting
            var networkWatcher = GetArmClient().GetNetworkWatcher(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Network/networkWatchers/nw1"));
            Network.Models.TroubleshootingParameters parameters = new Network.Models.TroubleshootingParameters(targetResourceId: "/subscriptions/subid/resourceGroups/rg2/providers/Microsoft.Compute/virtualMachines/vm1", storageId: "/subscriptions/subid/resourceGroups/rg1/providers/Microsoft.Storage/storageAccounts/st1", storagePath: "https://st1.blob.core.windows.net/cn1");

            await networkWatcher.GetTroubleshootingAsync(parameters);
        }

        [RecordedTest]
        public async Task GetTroubleshootingResultAsync()
        {
            // Example: Get troubleshoot result
            var networkWatcher = GetArmClient().GetNetworkWatcher(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Network/networkWatchers/nw1"));
            Network.Models.QueryTroubleshootingParameters parameters = new Network.Models.QueryTroubleshootingParameters(targetResourceId: "/subscriptions/subid/resourceGroups/rg2/providers/Microsoft.Compute/virtualMachines/vm1");

            await networkWatcher.GetTroubleshootingResultAsync(parameters);
        }

        [RecordedTest]
        public async Task SetFlowLogConfigurationAsync()
        {
            // Example: Configure flow log
            var networkWatcher = GetArmClient().GetNetworkWatcher(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Network/networkWatchers/nw1"));
            Network.Models.FlowLogInformation parameters = new Network.Models.FlowLogInformation(targetResourceId: "/subscriptions/subid/resourceGroups/rg1/providers/Microsoft.Network/networkSecurityGroups/nsg1", storageId: "/subscriptions/subid/resourceGroups/rg1/providers/Microsoft.Storage/storageAccounts/st1", enabled: true);

            await networkWatcher.SetFlowLogConfigurationAsync(parameters);
        }

        [RecordedTest]
        public async Task GetFlowLogStatusAsync()
        {
            // Example: Get flow log status
            var networkWatcher = GetArmClient().GetNetworkWatcher(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Network/networkWatchers/nw1"));
            Network.Models.FlowLogStatusParameters parameters = new Network.Models.FlowLogStatusParameters(targetResourceId: "/subscriptions/subid/resourceGroups/rg1/providers/Microsoft.Network/networkSecurityGroups/nsg1");

            await networkWatcher.GetFlowLogStatusAsync(parameters);
        }

        [RecordedTest]
        public async Task CheckConnectivityAsync()
        {
            // Example: Check connectivity
            var networkWatcher = GetArmClient().GetNetworkWatcher(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Network/networkWatchers/nw1"));
            Network.Models.ConnectivityParameters parameters = new Network.Models.ConnectivityParameters(source: new Network.Models.ConnectivitySource(resourceId: "/subscriptions/subid/resourceGroups/rg2/providers/Microsoft.Compute/virtualMachines/vm1"), destination: new Network.Models.ConnectivityDestination()
            {
                Address = "192.168.100.4",
                Port = 3389,
            })
            {
                PreferredIPVersion = new Network.Models.IPVersion("IPv4"),
            };

            await networkWatcher.CheckConnectivityAsync(parameters);
        }

        [RecordedTest]
        public async Task GetAzureReachabilityReportAsync()
        {
            // Example: Get Azure Reachability Report
            var networkWatcher = GetArmClient().GetNetworkWatcher(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Network/networkWatchers/nw1"));
            Network.Models.AzureReachabilityReportParameters parameters = new Network.Models.AzureReachabilityReportParameters(providerLocation: new Network.Models.AzureReachabilityReportLocation(country: "United States")
            {
                State = "washington",
            }, startTime: DateTimeOffset.Parse("2017-09-07T00:00:00Z"), endTime: DateTimeOffset.Parse("2017-09-10T00:00:00Z"));

            await networkWatcher.GetAzureReachabilityReportAsync(parameters);
        }

        [RecordedTest]
        public async Task GetAvailableProvidersAsync()
        {
            // Example: Get Available Providers List
            var networkWatcher = GetArmClient().GetNetworkWatcher(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Network/networkWatchers/nw1"));
            Network.Models.AvailableProvidersListParameters parameters = new Network.Models.AvailableProvidersListParameters()
            {
                Country = "United States",
                State = "washington",
                City = "seattle",
            };

            await networkWatcher.GetAvailableProvidersAsync(parameters);
        }

        [RecordedTest]
        public async Task GetNetworkConfigurationDiagnosticAsync()
        {
            // Example: Network configuration diagnostic
            var networkWatcher = GetArmClient().GetNetworkWatcher(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Network/networkWatchers/nw1"));
            Network.Models.NetworkConfigurationDiagnosticParameters parameters = new Network.Models.NetworkConfigurationDiagnosticParameters(targetResourceId: "/subscriptions/subid/resourceGroups/rg2/providers/Microsoft.Compute/virtualMachines/vm1", profiles: new List<Network.Models.NetworkConfigurationDiagnosticProfile>()
{
new Network.Models.NetworkConfigurationDiagnosticProfile(direction: new Network.Models.Direction("Inbound"),protocol: "TCP",source: "10.1.0.4",destination: "12.11.12.14",destinationPort: "12100"),});

            await networkWatcher.GetNetworkConfigurationDiagnosticAsync(parameters);
        }
    }
}
