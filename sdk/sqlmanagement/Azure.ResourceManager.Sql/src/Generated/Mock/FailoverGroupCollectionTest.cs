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
using Azure.ResourceManager.Sql;
using Azure.ResourceManager.Sql.Models;
using Azure.ResourceManager.TestFramework;

namespace Azure.ResourceManager.Sql.Tests.Mock
{
    /// <summary> Test for FailoverGroup. </summary>
    public partial class FailoverGroupCollectionMockTests : MockTestBase
    {
        public FailoverGroupCollectionMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task CreateOrUpdateAsync()
        {
            // Example: Create failover group
            var collection = GetArmClient().GetSqlServer(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/Default/providers/Microsoft.Sql/servers/failover-group-primary-server")).GetFailoverGroups();
            string failoverGroupName = "failover-group-test-3";
            Sql.FailoverGroupData parameters = new Sql.FailoverGroupData()
            {
                ReadWriteEndpoint = new Sql.Models.FailoverGroupReadWriteEndpoint(failoverPolicy: new Sql.Models.ReadWriteEndpointFailoverPolicy("Automatic"))
                {
                    FailoverWithDataLossGracePeriodMinutes = 480,
                },
                ReadOnlyEndpoint = new Sql.Models.FailoverGroupReadOnlyEndpoint()
                {
                    FailoverPolicy = new Sql.Models.ReadOnlyEndpointFailoverPolicy("Disabled"),
                },
            };

            await collection.CreateOrUpdateAsync(failoverGroupName, parameters);
        }

        [RecordedTest]
        public async Task GetAsync()
        {
            // Example: Get failover group
            var collection = GetArmClient().GetSqlServer(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/Default/providers/Microsoft.Sql/servers/failover-group-primary-server")).GetFailoverGroups();
            string failoverGroupName = "failover-group-test";

            await collection.GetAsync(failoverGroupName);
        }

        [RecordedTest]
        public void GetAllAsync()
        {
            // Example: List failover group
            var collection = GetArmClient().GetSqlServer(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/Default/providers/Microsoft.Sql/servers/failover-group-primary-server")).GetFailoverGroups();

            collection.GetAllAsync();
        }
    }
}
