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
using Azure.ResourceManager.TestFramework;
using DnsManagementClient;
using DnsManagementClient.Models;

namespace DnsManagementClient.Tests.Mock
{
    /// <summary> Test for RecordSet. </summary>
    public partial class DnsZoneCAAMockTests : MockTestBase
    {
        public DnsZoneCAAMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task GetAsync()
        {
            // Example: Get A recordset
            var dnsZoneCAA = GetArmClient().GetDnsZoneCAA(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Network/dnsZones/zone1/A/record1"));

            await dnsZoneCAA.GetAsync();
        }

        [RecordedTest]
        public async Task GetAsync2()
        {
            // Example: Get AAAA recordset
            var dnsZoneCAA = GetArmClient().GetDnsZoneCAA(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Network/dnsZones/zone1/AAAA/record1"));

            await dnsZoneCAA.GetAsync();
        }

        [RecordedTest]
        public async Task GetAsync3()
        {
            // Example: Get CAA recordset
            var dnsZoneCAA = GetArmClient().GetDnsZoneCAA(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Network/dnsZones/zone1/CAA/record1"));

            await dnsZoneCAA.GetAsync();
        }

        [RecordedTest]
        public async Task GetAsync4()
        {
            // Example: Get CNAME recordset
            var dnsZoneCAA = GetArmClient().GetDnsZoneCAA(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Network/dnsZones/zone1/CNAME/record1"));

            await dnsZoneCAA.GetAsync();
        }

        [RecordedTest]
        public async Task GetAsync5()
        {
            // Example: Get MX recordset
            var dnsZoneCAA = GetArmClient().GetDnsZoneCAA(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Network/dnsZones/zone1/MX/record1"));

            await dnsZoneCAA.GetAsync();
        }

        [RecordedTest]
        public async Task GetAsync6()
        {
            // Example: Get NS recordset
            var dnsZoneCAA = GetArmClient().GetDnsZoneCAA(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Network/dnsZones/zone1/NS/record1"));

            await dnsZoneCAA.GetAsync();
        }

        [RecordedTest]
        public async Task GetAsync7()
        {
            // Example: Get PTR recordset
            var dnsZoneCAA = GetArmClient().GetDnsZoneCAA(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Network/dnsZones/0.0.127.in-addr.arpa/PTR/1"));

            await dnsZoneCAA.GetAsync();
        }

        [RecordedTest]
        public async Task GetAsync8()
        {
            // Example: Get SOA recordset
            var dnsZoneCAA = GetArmClient().GetDnsZoneCAA(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Network/dnsZones/zone1/SOA/@"));

            await dnsZoneCAA.GetAsync();
        }

        [RecordedTest]
        public async Task GetAsync9()
        {
            // Example: Get SRV recordset
            var dnsZoneCAA = GetArmClient().GetDnsZoneCAA(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Network/dnsZones/zone1/SRV/record1"));

            await dnsZoneCAA.GetAsync();
        }

        [RecordedTest]
        public async Task GetAsync10()
        {
            // Example: Get TXT recordset
            var dnsZoneCAA = GetArmClient().GetDnsZoneCAA(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Network/dnsZones/zone1/TXT/record1"));

            await dnsZoneCAA.GetAsync();
        }

        [RecordedTest]
        public async Task DeleteAsync()
        {
            // Example: Delete A recordset
            var dnsZoneCAA = GetArmClient().GetDnsZoneCAA(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Network/dnsZones/zone1/A/record1"));
            string ifMatch = null;

            await dnsZoneCAA.DeleteAsync(ifMatch);
        }

        [RecordedTest]
        public async Task DeleteAsync2()
        {
            // Example: Delete AAAA recordset
            var dnsZoneCAA = GetArmClient().GetDnsZoneCAA(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Network/dnsZones/zone1/AAAA/record1"));
            string ifMatch = null;

            await dnsZoneCAA.DeleteAsync(ifMatch);
        }

        [RecordedTest]
        public async Task DeleteAsync3()
        {
            // Example: Delete CAA recordset
            var dnsZoneCAA = GetArmClient().GetDnsZoneCAA(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Network/dnsZones/zone1/CAA/record1"));
            string ifMatch = null;

            await dnsZoneCAA.DeleteAsync(ifMatch);
        }

        [RecordedTest]
        public async Task DeleteAsync4()
        {
            // Example: Delete CNAME recordset
            var dnsZoneCAA = GetArmClient().GetDnsZoneCAA(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Network/dnsZones/zone1/A/record1"));
            string ifMatch = null;

            await dnsZoneCAA.DeleteAsync(ifMatch);
        }

        [RecordedTest]
        public async Task DeleteAsync5()
        {
            // Example: Delete MX recordset
            var dnsZoneCAA = GetArmClient().GetDnsZoneCAA(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Network/dnsZones/zone1/A/record1"));
            string ifMatch = null;

            await dnsZoneCAA.DeleteAsync(ifMatch);
        }

        [RecordedTest]
        public async Task DeleteAsync6()
        {
            // Example: Delete NS recordset
            var dnsZoneCAA = GetArmClient().GetDnsZoneCAA(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Network/dnsZones/zone1/A/record1"));
            string ifMatch = null;

            await dnsZoneCAA.DeleteAsync(ifMatch);
        }

        [RecordedTest]
        public async Task DeleteAsync7()
        {
            // Example: Delete PTR recordset
            var dnsZoneCAA = GetArmClient().GetDnsZoneCAA(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Network/dnsZones/0.0.127.in-addr.arpa/PTR/1"));
            string ifMatch = null;

            await dnsZoneCAA.DeleteAsync(ifMatch);
        }

        [RecordedTest]
        public async Task DeleteAsync8()
        {
            // Example: Delete SRV recordset
            var dnsZoneCAA = GetArmClient().GetDnsZoneCAA(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Network/dnsZones/zone1/SRV/record1"));
            string ifMatch = null;

            await dnsZoneCAA.DeleteAsync(ifMatch);
        }

        [RecordedTest]
        public async Task DeleteAsync9()
        {
            // Example: Delete TXT recordset
            var dnsZoneCAA = GetArmClient().GetDnsZoneCAA(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Network/dnsZones/zone1/TXT/record1"));
            string ifMatch = null;

            await dnsZoneCAA.DeleteAsync(ifMatch);
        }

        [RecordedTest]
        public async Task UpdateAsync()
        {
            // Example: Patch A recordset
            var dnsZoneCAA = GetArmClient().GetDnsZoneCAA(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Network/dnsZones/zone1/A/record1"));
            DnsManagementClient.RecordSetData parameters = new DnsManagementClient.RecordSetData();
            string ifMatch = null;

            await dnsZoneCAA.UpdateAsync(parameters, ifMatch);
        }

        [RecordedTest]
        public async Task UpdateAsync2()
        {
            // Example: Patch AAAA recordset
            var dnsZoneCAA = GetArmClient().GetDnsZoneCAA(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Network/dnsZones/zone1/AAAA/record1"));
            DnsManagementClient.RecordSetData parameters = new DnsManagementClient.RecordSetData();
            string ifMatch = null;

            await dnsZoneCAA.UpdateAsync(parameters, ifMatch);
        }

        [RecordedTest]
        public async Task UpdateAsync3()
        {
            // Example: Patch CAA recordset
            var dnsZoneCAA = GetArmClient().GetDnsZoneCAA(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Network/dnsZones/zone1/CAA/record1"));
            DnsManagementClient.RecordSetData parameters = new DnsManagementClient.RecordSetData();
            string ifMatch = null;

            await dnsZoneCAA.UpdateAsync(parameters, ifMatch);
        }

        [RecordedTest]
        public async Task UpdateAsync4()
        {
            // Example: Patch CNAME recordset
            var dnsZoneCAA = GetArmClient().GetDnsZoneCAA(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Network/dnsZones/zone1/CNAME/record1"));
            DnsManagementClient.RecordSetData parameters = new DnsManagementClient.RecordSetData();
            string ifMatch = null;

            await dnsZoneCAA.UpdateAsync(parameters, ifMatch);
        }

        [RecordedTest]
        public async Task UpdateAsync5()
        {
            // Example: Patch MX recordset
            var dnsZoneCAA = GetArmClient().GetDnsZoneCAA(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Network/dnsZones/zone1/MX/record1"));
            DnsManagementClient.RecordSetData parameters = new DnsManagementClient.RecordSetData();
            string ifMatch = null;

            await dnsZoneCAA.UpdateAsync(parameters, ifMatch);
        }

        [RecordedTest]
        public async Task UpdateAsync6()
        {
            // Example: Patch NS recordset
            var dnsZoneCAA = GetArmClient().GetDnsZoneCAA(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Network/dnsZones/zone1/NS/record1"));
            DnsManagementClient.RecordSetData parameters = new DnsManagementClient.RecordSetData();
            string ifMatch = null;

            await dnsZoneCAA.UpdateAsync(parameters, ifMatch);
        }

        [RecordedTest]
        public async Task UpdateAsync7()
        {
            // Example: Patch PTR recordset
            var dnsZoneCAA = GetArmClient().GetDnsZoneCAA(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Network/dnsZones/0.0.127.in-addr.arpa/PTR/1"));
            DnsManagementClient.RecordSetData parameters = new DnsManagementClient.RecordSetData();
            string ifMatch = null;

            await dnsZoneCAA.UpdateAsync(parameters, ifMatch);
        }

        [RecordedTest]
        public async Task UpdateAsync8()
        {
            // Example: Patch SOA recordset
            var dnsZoneCAA = GetArmClient().GetDnsZoneCAA(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Network/dnsZones/zone1/SOA/@"));
            DnsManagementClient.RecordSetData parameters = new DnsManagementClient.RecordSetData();
            string ifMatch = null;

            await dnsZoneCAA.UpdateAsync(parameters, ifMatch);
        }

        [RecordedTest]
        public async Task UpdateAsync9()
        {
            // Example: Patch SRV recordset
            var dnsZoneCAA = GetArmClient().GetDnsZoneCAA(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Network/dnsZones/zone1/SRV/record1"));
            DnsManagementClient.RecordSetData parameters = new DnsManagementClient.RecordSetData();
            string ifMatch = null;

            await dnsZoneCAA.UpdateAsync(parameters, ifMatch);
        }

        [RecordedTest]
        public async Task UpdateAsync10()
        {
            // Example: Patch TXT recordset
            var dnsZoneCAA = GetArmClient().GetDnsZoneCAA(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Network/dnsZones/zone1/TXT/record1"));
            DnsManagementClient.RecordSetData parameters = new DnsManagementClient.RecordSetData();
            string ifMatch = null;

            await dnsZoneCAA.UpdateAsync(parameters, ifMatch);
        }
    }
}
