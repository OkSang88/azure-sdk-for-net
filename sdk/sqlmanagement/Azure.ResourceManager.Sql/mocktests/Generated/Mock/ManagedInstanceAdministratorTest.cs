// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager.Sql;
using Azure.ResourceManager.TestFramework;

namespace Azure.ResourceManager.Sql.Tests.Mock
{
    /// <summary> Test for ManagedInstanceAdministrator. </summary>
    public partial class ManagedInstanceAdministratorMockTests : MockTestBase
    {
        public ManagedInstanceAdministratorMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task Get()
        {
            // Example: Get administrator of managed instance
            var managedInstanceAdministratorId = Sql.ManagedInstanceAdministrator.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "Default-SQL-SouthEastAsia", "managedInstance", "ActiveDirectory");
            var managedInstanceAdministrator = GetArmClient().GetManagedInstanceAdministrator(managedInstanceAdministratorId);

            await managedInstanceAdministrator.GetAsync();
        }

        [RecordedTest]
        public async Task Delete()
        {
            // Example: Delete administrator of managed instance
            var managedInstanceAdministratorId = Sql.ManagedInstanceAdministrator.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "Default-SQL-SouthEastAsia", "managedInstance", "ActiveDirectory");
            var managedInstanceAdministrator = GetArmClient().GetManagedInstanceAdministrator(managedInstanceAdministratorId);

            await managedInstanceAdministrator.DeleteAsync(true);
        }
    }
}
