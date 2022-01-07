// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Net;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager;
using Azure.ResourceManager.Network;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Resources.Models;
using Azure.ResourceManager.TestFramework;

namespace Azure.ResourceManager.Network.Tests.Mock
{
    /// <summary> Test for ExpressRouteCircuitPeering. </summary>
    public partial class ExpressRouteCircuitPeeringCollectionMockTests : MockTestBase
    {
        public ExpressRouteCircuitPeeringCollectionMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task CreateOrUpdateAsync()
        {
            // Example: Create ExpressRouteCircuit Peerings
            var collection = GetArmClient().GetExpressRouteCircuit(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Network/expressRouteCircuits/circuitName")).GetExpressRouteCircuitPeerings();
            string peeringName = "AzurePrivatePeering";
            Network.ExpressRouteCircuitPeeringData peeringParameters = new Network.ExpressRouteCircuitPeeringData()
            {
                PeerASN = 200,
                PrimaryPeerAddressPrefix = "192.168.16.252/30",
                SecondaryPeerAddressPrefix = "192.168.18.252/30",
                VlanId = 200,
            };

            await collection.CreateOrUpdateAsync(peeringName, peeringParameters);
        }

        [RecordedTest]
        public async Task GetAsync()
        {
            // Example: Get ExpressRouteCircuit Peering
            var collection = GetArmClient().GetExpressRouteCircuit(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Network/expressRouteCircuits/circuitName")).GetExpressRouteCircuitPeerings();
            string peeringName = "MicrosoftPeering";

            await collection.GetAsync(peeringName);
        }

        [RecordedTest]
        public void GetAllAsync()
        {
            // Example: List ExpressRouteCircuit Peerings
            var collection = GetArmClient().GetExpressRouteCircuit(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Network/expressRouteCircuits/circuitName")).GetExpressRouteCircuitPeerings();

            collection.GetAllAsync();
        }
    }
}
