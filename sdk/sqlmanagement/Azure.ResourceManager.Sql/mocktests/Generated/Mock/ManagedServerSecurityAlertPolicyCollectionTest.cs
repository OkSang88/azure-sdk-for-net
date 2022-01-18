// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Net;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager.Sql;
using Azure.ResourceManager.Sql.Models;
using Azure.ResourceManager.TestFramework;

namespace Azure.ResourceManager.Sql.Tests.Mock
{
    /// <summary> Test for ManagedServerSecurityAlertPolicy. </summary>
    public partial class ManagedServerSecurityAlertPolicyCollectionMockTests : MockTestBase
    {
        public ManagedServerSecurityAlertPolicyCollectionMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task CreateOrUpdate()
        {
            // Example: Update a managed server's threat detection policy with all parameters
            Sql.Models.SecurityAlertPolicyName securityAlertPolicyName = new Sql.Models.SecurityAlertPolicyName("Default");
            Sql.ManagedServerSecurityAlertPolicyData parameters = new Sql.ManagedServerSecurityAlertPolicyData()
            {
                State = Sql.Models.SecurityAlertsPolicyState.Enabled,
                EmailAccountAdmins = true,
                StorageEndpoint = "https://mystorage.blob.core.windows.net",
                StorageAccountAccessKey = "sdlfkjabc+sdlfkjsdlkfsjdfLDKFTERLKFDFKLjsdfksjdflsdkfD2342309432849328476458/3RSD==",
                RetentionDays = 5,
            };

            var managedInstanceId = Sql.ManagedInstance.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "securityalert-4799", "securityalert-6440");
            var collection = GetArmClient().GetManagedInstance(managedInstanceId).GetManagedServerSecurityAlertPolicies();
            await collection.CreateOrUpdateAsync(true, securityAlertPolicyName, parameters);
        }

        [RecordedTest]
        public async Task CreateOrUpdate2()
        {
            // Example: Update a managed server's threat detection policy with minimal parameters
            Sql.Models.SecurityAlertPolicyName securityAlertPolicyName = new Sql.Models.SecurityAlertPolicyName("Default");
            Sql.ManagedServerSecurityAlertPolicyData parameters = new Sql.ManagedServerSecurityAlertPolicyData()
            {
                State = Sql.Models.SecurityAlertsPolicyState.Enabled,
            };

            var managedInstanceId = Sql.ManagedInstance.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "securityalert-4799", "securityalert-6440");
            var collection = GetArmClient().GetManagedInstance(managedInstanceId).GetManagedServerSecurityAlertPolicies();
            await collection.CreateOrUpdateAsync(true, securityAlertPolicyName, parameters);
        }

        [RecordedTest]
        public async Task Get()
        {
            // Example: Get a managed server's threat detection policy
            Sql.Models.SecurityAlertPolicyName securityAlertPolicyName = new Sql.Models.SecurityAlertPolicyName("Default");

            var managedInstanceId = Sql.ManagedInstance.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "securityalert-4799", "securityalert-6440");
            var collection = GetArmClient().GetManagedInstance(managedInstanceId).GetManagedServerSecurityAlertPolicies();
            await collection.GetAsync(securityAlertPolicyName);
        }

        [RecordedTest]
        public async Task GetAll()
        {
            // Example: Get the managed server's threat detection policies

            var managedInstanceId = Sql.ManagedInstance.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "securityalert-4799", "securityalert-6440");
            var collection = GetArmClient().GetManagedInstance(managedInstanceId).GetManagedServerSecurityAlertPolicies();
            await foreach (var _ in collection.GetAllAsync())
            {
            }
        }
    }
}
