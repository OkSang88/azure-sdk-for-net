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
    /// <summary> Test for ExpressRouteCircuitConnection. </summary>
    public partial class ExpressRouteCircuitConnectionMockTests : MockTestBase
    {
        public ExpressRouteCircuitConnectionMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task GetAsync()
        {
            // Example: ExpressRouteCircuitConnectionGet
            var expressRouteCircuitConnection = GetArmClient().GetExpressRouteCircuitConnection(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Network/expressRouteCircuits/ExpressRouteARMCircuitA/peerings/AzurePrivatePeering/connections/circuitConnectionUSAUS"));

            await expressRouteCircuitConnection.GetAsync();
        }

        [RecordedTest]
        public async Task DeleteAsync()
        {
            // Example: Delete ExpressRouteCircuit
            var expressRouteCircuitConnection = GetArmClient().GetExpressRouteCircuitConnection(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Network/expressRouteCircuits/ExpressRouteARMCircuitA/peerings/AzurePrivatePeering/connections/circuitConnectionUSAUS"));

            await expressRouteCircuitConnection.DeleteAsync();
        }
    }
}
