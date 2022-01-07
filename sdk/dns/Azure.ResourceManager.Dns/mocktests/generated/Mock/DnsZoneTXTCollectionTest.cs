// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
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
    public partial class DnsZoneTXTCollectionMockTests : MockTestBase
    {
        public DnsZoneTXTCollectionMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task CreateOrUpdateAsync()
        {
            // Example: Create A recordset
            var collection = GetArmClient().GetZone(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Network/dnsZones/zone1/A/record1")).GetDnsZoneTXTs();
            DnsManagementClient.Models.RecordType recordType = DnsManagementClient.Models.RecordType.A;
            string relativeRecordSetName = "record1";
            DnsManagementClient.RecordSetData parameters = new DnsManagementClient.RecordSetData()
            {
                TTL = 3600,
            };
            string ifMatch = null;
            string ifNoneMatch = null;

            await collection.CreateOrUpdateAsync(recordType, relativeRecordSetName, parameters, ifMatch, ifNoneMatch);
        }

        [RecordedTest]
        public async Task CreateOrUpdateAsync2()
        {
            // Example: Create A recordset with alias target resource
            var collection = GetArmClient().GetZone(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Network/dnsZones/zone1/A/record1")).GetDnsZoneTXTs();
            DnsManagementClient.Models.RecordType recordType = DnsManagementClient.Models.RecordType.A;
            string relativeRecordSetName = "record1";
            DnsManagementClient.RecordSetData parameters = new DnsManagementClient.RecordSetData()
            {
                TTL = 3600,
                TargetResource = new WritableSubResource()
                {
                    Id = new ResourceIdentifier($"/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/test/providers/Microsoft.Network/trafficManagerProfiles/testpp2"),
                },
            };
            string ifMatch = null;
            string ifNoneMatch = null;

            await collection.CreateOrUpdateAsync(recordType, relativeRecordSetName, parameters, ifMatch, ifNoneMatch);
        }

        [RecordedTest]
        public async Task CreateOrUpdateAsync3()
        {
            // Example: Create AAAA recordset
            var collection = GetArmClient().GetZone(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Network/dnsZones/zone1/AAAA/record1")).GetDnsZoneTXTs();
            DnsManagementClient.Models.RecordType recordType = DnsManagementClient.Models.RecordType.Aaaa;
            string relativeRecordSetName = "record1";
            DnsManagementClient.RecordSetData parameters = new DnsManagementClient.RecordSetData()
            {
                TTL = 3600,
            };
            string ifMatch = null;
            string ifNoneMatch = null;

            await collection.CreateOrUpdateAsync(recordType, relativeRecordSetName, parameters, ifMatch, ifNoneMatch);
        }

        [RecordedTest]
        public async Task CreateOrUpdateAsync4()
        {
            // Example: Create CAA recordset
            var collection = GetArmClient().GetZone(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Network/dnsZones/zone1/CAA/record1")).GetDnsZoneTXTs();
            DnsManagementClient.Models.RecordType recordType = DnsManagementClient.Models.RecordType.CAA;
            string relativeRecordSetName = "record1";
            DnsManagementClient.RecordSetData parameters = new DnsManagementClient.RecordSetData()
            {
                TTL = 3600,
            };
            string ifMatch = null;
            string ifNoneMatch = null;

            await collection.CreateOrUpdateAsync(recordType, relativeRecordSetName, parameters, ifMatch, ifNoneMatch);
        }

        [RecordedTest]
        public async Task CreateOrUpdateAsync5()
        {
            // Example: Create CNAME recordset
            var collection = GetArmClient().GetZone(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Network/dnsZones/zone1/CNAME/record1")).GetDnsZoneTXTs();
            DnsManagementClient.Models.RecordType recordType = DnsManagementClient.Models.RecordType.Cname;
            string relativeRecordSetName = "record1";
            DnsManagementClient.RecordSetData parameters = new DnsManagementClient.RecordSetData()
            {
                TTL = 3600,
                CnameRecord = new DnsManagementClient.Models.CnameRecord()
                {
                    Cname = "contoso.com",
                },
            };
            string ifMatch = null;
            string ifNoneMatch = null;

            await collection.CreateOrUpdateAsync(recordType, relativeRecordSetName, parameters, ifMatch, ifNoneMatch);
        }

        [RecordedTest]
        public async Task CreateOrUpdateAsync6()
        {
            // Example: Create MX recordset
            var collection = GetArmClient().GetZone(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Network/dnsZones/zone1/MX/record1")).GetDnsZoneTXTs();
            DnsManagementClient.Models.RecordType recordType = DnsManagementClient.Models.RecordType.MX;
            string relativeRecordSetName = "record1";
            DnsManagementClient.RecordSetData parameters = new DnsManagementClient.RecordSetData()
            {
                TTL = 3600,
            };
            string ifMatch = null;
            string ifNoneMatch = null;

            await collection.CreateOrUpdateAsync(recordType, relativeRecordSetName, parameters, ifMatch, ifNoneMatch);
        }

        [RecordedTest]
        public async Task CreateOrUpdateAsync7()
        {
            // Example: Create NS recordset
            var collection = GetArmClient().GetZone(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Network/dnsZones/zone1/NS/record1")).GetDnsZoneTXTs();
            DnsManagementClient.Models.RecordType recordType = DnsManagementClient.Models.RecordType.NS;
            string relativeRecordSetName = "record1";
            DnsManagementClient.RecordSetData parameters = new DnsManagementClient.RecordSetData()
            {
                TTL = 3600,
            };
            string ifMatch = null;
            string ifNoneMatch = null;

            await collection.CreateOrUpdateAsync(recordType, relativeRecordSetName, parameters, ifMatch, ifNoneMatch);
        }

        [RecordedTest]
        public async Task CreateOrUpdateAsync8()
        {
            // Example: Create PTR recordset
            var collection = GetArmClient().GetZone(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Network/dnsZones/0.0.127.in-addr.arpa/PTR/1")).GetDnsZoneTXTs();
            DnsManagementClient.Models.RecordType recordType = DnsManagementClient.Models.RecordType.PTR;
            string relativeRecordSetName = "1";
            DnsManagementClient.RecordSetData parameters = new DnsManagementClient.RecordSetData()
            {
                TTL = 3600,
            };
            string ifMatch = null;
            string ifNoneMatch = null;

            await collection.CreateOrUpdateAsync(recordType, relativeRecordSetName, parameters, ifMatch, ifNoneMatch);
        }

        [RecordedTest]
        public async Task CreateOrUpdateAsync9()
        {
            // Example: Create SOA recordset
            var collection = GetArmClient().GetZone(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Network/dnsZones/zone1/SOA/@")).GetDnsZoneTXTs();
            DnsManagementClient.Models.RecordType recordType = DnsManagementClient.Models.RecordType.SOA;
            string relativeRecordSetName = "@";
            DnsManagementClient.RecordSetData parameters = new DnsManagementClient.RecordSetData()
            {
                TTL = 3600,
                SoaRecord = new DnsManagementClient.Models.SoaRecord()
                {
                    Host = "ns1.contoso.com",
                    Email = "hostmaster.contoso.com",
                    SerialNumber = 1,
                    RefreshTime = 3600,
                    RetryTime = 300,
                    ExpireTime = 2419200,
                    MinimumTtl = 300,
                },
            };
            string ifMatch = null;
            string ifNoneMatch = null;

            await collection.CreateOrUpdateAsync(recordType, relativeRecordSetName, parameters, ifMatch, ifNoneMatch);
        }

        [RecordedTest]
        public async Task CreateOrUpdateAsync10()
        {
            // Example: Create SRV recordset
            var collection = GetArmClient().GetZone(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Network/dnsZones/zone1/SRV/record1")).GetDnsZoneTXTs();
            DnsManagementClient.Models.RecordType recordType = DnsManagementClient.Models.RecordType.SRV;
            string relativeRecordSetName = "record1";
            DnsManagementClient.RecordSetData parameters = new DnsManagementClient.RecordSetData()
            {
                TTL = 3600,
            };
            string ifMatch = null;
            string ifNoneMatch = null;

            await collection.CreateOrUpdateAsync(recordType, relativeRecordSetName, parameters, ifMatch, ifNoneMatch);
        }

        [RecordedTest]
        public async Task CreateOrUpdateAsync11()
        {
            // Example: Create TXT recordset
            var collection = GetArmClient().GetZone(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Network/dnsZones/zone1/TXT/record1")).GetDnsZoneTXTs();
            DnsManagementClient.Models.RecordType recordType = DnsManagementClient.Models.RecordType.TXT;
            string relativeRecordSetName = "record1";
            DnsManagementClient.RecordSetData parameters = new DnsManagementClient.RecordSetData()
            {
                TTL = 3600,
            };
            string ifMatch = null;
            string ifNoneMatch = null;

            await collection.CreateOrUpdateAsync(recordType, relativeRecordSetName, parameters, ifMatch, ifNoneMatch);
        }

        [RecordedTest]
        public async Task GetAsync()
        {
            // Example: Get A recordset
            var collection = GetArmClient().GetZone(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Network/dnsZones/zone1/A/record1")).GetDnsZoneTXTs();
            DnsManagementClient.Models.RecordType recordType = DnsManagementClient.Models.RecordType.A;
            string relativeRecordSetName = "record1";

            await collection.GetAsync(recordType, relativeRecordSetName);
        }

        [RecordedTest]
        public async Task GetAsync2()
        {
            // Example: Get AAAA recordset
            var collection = GetArmClient().GetZone(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Network/dnsZones/zone1/AAAA/record1")).GetDnsZoneTXTs();
            DnsManagementClient.Models.RecordType recordType = DnsManagementClient.Models.RecordType.Aaaa;
            string relativeRecordSetName = "record1";

            await collection.GetAsync(recordType, relativeRecordSetName);
        }

        [RecordedTest]
        public async Task GetAsync3()
        {
            // Example: Get CAA recordset
            var collection = GetArmClient().GetZone(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Network/dnsZones/zone1/CAA/record1")).GetDnsZoneTXTs();
            DnsManagementClient.Models.RecordType recordType = DnsManagementClient.Models.RecordType.CAA;
            string relativeRecordSetName = "record1";

            await collection.GetAsync(recordType, relativeRecordSetName);
        }

        [RecordedTest]
        public async Task GetAsync4()
        {
            // Example: Get CNAME recordset
            var collection = GetArmClient().GetZone(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Network/dnsZones/zone1/CNAME/record1")).GetDnsZoneTXTs();
            DnsManagementClient.Models.RecordType recordType = DnsManagementClient.Models.RecordType.Cname;
            string relativeRecordSetName = "record1";

            await collection.GetAsync(recordType, relativeRecordSetName);
        }

        [RecordedTest]
        public async Task GetAsync5()
        {
            // Example: Get MX recordset
            var collection = GetArmClient().GetZone(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Network/dnsZones/zone1/MX/record1")).GetDnsZoneTXTs();
            DnsManagementClient.Models.RecordType recordType = DnsManagementClient.Models.RecordType.MX;
            string relativeRecordSetName = "record1";

            await collection.GetAsync(recordType, relativeRecordSetName);
        }

        [RecordedTest]
        public async Task GetAsync6()
        {
            // Example: Get NS recordset
            var collection = GetArmClient().GetZone(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Network/dnsZones/zone1/NS/record1")).GetDnsZoneTXTs();
            DnsManagementClient.Models.RecordType recordType = DnsManagementClient.Models.RecordType.NS;
            string relativeRecordSetName = "record1";

            await collection.GetAsync(recordType, relativeRecordSetName);
        }

        [RecordedTest]
        public async Task GetAsync7()
        {
            // Example: Get PTR recordset
            var collection = GetArmClient().GetZone(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Network/dnsZones/0.0.127.in-addr.arpa/PTR/1")).GetDnsZoneTXTs();
            DnsManagementClient.Models.RecordType recordType = DnsManagementClient.Models.RecordType.PTR;
            string relativeRecordSetName = "1";

            await collection.GetAsync(recordType, relativeRecordSetName);
        }

        [RecordedTest]
        public async Task GetAsync8()
        {
            // Example: Get SOA recordset
            var collection = GetArmClient().GetZone(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Network/dnsZones/zone1/SOA/@")).GetDnsZoneTXTs();
            DnsManagementClient.Models.RecordType recordType = DnsManagementClient.Models.RecordType.SOA;
            string relativeRecordSetName = "@";

            await collection.GetAsync(recordType, relativeRecordSetName);
        }

        [RecordedTest]
        public async Task GetAsync9()
        {
            // Example: Get SRV recordset
            var collection = GetArmClient().GetZone(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Network/dnsZones/zone1/SRV/record1")).GetDnsZoneTXTs();
            DnsManagementClient.Models.RecordType recordType = DnsManagementClient.Models.RecordType.SRV;
            string relativeRecordSetName = "record1";

            await collection.GetAsync(recordType, relativeRecordSetName);
        }

        [RecordedTest]
        public async Task GetAsync10()
        {
            // Example: Get TXT recordset
            var collection = GetArmClient().GetZone(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Network/dnsZones/zone1/TXT/record1")).GetDnsZoneTXTs();
            DnsManagementClient.Models.RecordType recordType = DnsManagementClient.Models.RecordType.TXT;
            string relativeRecordSetName = "record1";

            await collection.GetAsync(recordType, relativeRecordSetName);
        }

        [RecordedTest]
        public void GetAllAsync()
        {
            // Example: List A recordsets
            var collection = GetArmClient().GetZone(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Network/dnsZones/zone1/A")).GetDnsZoneTXTs();
            DnsManagementClient.Models.RecordType recordType = DnsManagementClient.Models.RecordType.A;
            int? top = null;
            string recordsetnamesuffix = null;

            collection.GetAllAsync(recordType, top, recordsetnamesuffix);
        }

        [RecordedTest]
        public void GetAllAsync2()
        {
            // Example: List AAAA recordsets
            var collection = GetArmClient().GetZone(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Network/dnsZones/zone1/AAAA")).GetDnsZoneTXTs();
            DnsManagementClient.Models.RecordType recordType = DnsManagementClient.Models.RecordType.Aaaa;
            int? top = null;
            string recordsetnamesuffix = null;

            collection.GetAllAsync(recordType, top, recordsetnamesuffix);
        }

        [RecordedTest]
        public void GetAllAsync3()
        {
            // Example: List CAA recordsets
            var collection = GetArmClient().GetZone(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Network/dnsZones/zone1/CAA")).GetDnsZoneTXTs();
            DnsManagementClient.Models.RecordType recordType = DnsManagementClient.Models.RecordType.CAA;
            int? top = null;
            string recordsetnamesuffix = null;

            collection.GetAllAsync(recordType, top, recordsetnamesuffix);
        }

        [RecordedTest]
        public void GetAllAsync4()
        {
            // Example: List CNAME recordsets
            var collection = GetArmClient().GetZone(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Network/dnsZones/zone1/CNAME")).GetDnsZoneTXTs();
            DnsManagementClient.Models.RecordType recordType = DnsManagementClient.Models.RecordType.Cname;
            int? top = null;
            string recordsetnamesuffix = null;

            collection.GetAllAsync(recordType, top, recordsetnamesuffix);
        }

        [RecordedTest]
        public void GetAllAsync5()
        {
            // Example: List MX recordsets
            var collection = GetArmClient().GetZone(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Network/dnsZones/zone1/MX")).GetDnsZoneTXTs();
            DnsManagementClient.Models.RecordType recordType = DnsManagementClient.Models.RecordType.MX;
            int? top = null;
            string recordsetnamesuffix = null;

            collection.GetAllAsync(recordType, top, recordsetnamesuffix);
        }

        [RecordedTest]
        public void GetAllAsync6()
        {
            // Example: List NS recordsets
            var collection = GetArmClient().GetZone(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Network/dnsZones/zone1/NS")).GetDnsZoneTXTs();
            DnsManagementClient.Models.RecordType recordType = DnsManagementClient.Models.RecordType.NS;
            int? top = null;
            string recordsetnamesuffix = null;

            collection.GetAllAsync(recordType, top, recordsetnamesuffix);
        }

        [RecordedTest]
        public void GetAllAsync7()
        {
            // Example: List PTR recordsets
            var collection = GetArmClient().GetZone(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Network/dnsZones/0.0.127.in-addr.arpa/PTR")).GetDnsZoneTXTs();
            DnsManagementClient.Models.RecordType recordType = DnsManagementClient.Models.RecordType.PTR;
            int? top = null;
            string recordsetnamesuffix = null;

            collection.GetAllAsync(recordType, top, recordsetnamesuffix);
        }

        [RecordedTest]
        public void GetAllAsync8()
        {
            // Example: List SOA recordsets
            var collection = GetArmClient().GetZone(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Network/dnsZones/zone1/SOA")).GetDnsZoneTXTs();
            DnsManagementClient.Models.RecordType recordType = DnsManagementClient.Models.RecordType.SOA;
            int? top = null;
            string recordsetnamesuffix = null;

            collection.GetAllAsync(recordType, top, recordsetnamesuffix);
        }

        [RecordedTest]
        public void GetAllAsync9()
        {
            // Example: List SRV recordsets
            var collection = GetArmClient().GetZone(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Network/dnsZones/zone1/SRV")).GetDnsZoneTXTs();
            DnsManagementClient.Models.RecordType recordType = DnsManagementClient.Models.RecordType.SRV;
            int? top = null;
            string recordsetnamesuffix = null;

            collection.GetAllAsync(recordType, top, recordsetnamesuffix);
        }

        [RecordedTest]
        public void GetAllAsync10()
        {
            // Example: List TXT recordsets
            var collection = GetArmClient().GetZone(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Network/dnsZones/zone1/TXT")).GetDnsZoneTXTs();
            DnsManagementClient.Models.RecordType recordType = DnsManagementClient.Models.RecordType.TXT;
            int? top = null;
            string recordsetnamesuffix = null;

            collection.GetAllAsync(recordType, top, recordsetnamesuffix);
        }
    }
}
