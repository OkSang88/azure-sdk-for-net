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
using Azure.ResourceManager.Sql.Models;
using Azure.ResourceManager.TestFramework;

namespace Azure.ResourceManager.Sql.Tests.Mock
{
    /// <summary> Test for SensitivityLabel. </summary>
    public partial class ServerDatabaseSchemaTableColumnSensitivityLabelMockTests : MockTestBase
    {
        public ServerDatabaseSchemaTableColumnSensitivityLabelMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task GetAsync()
        {
            // Example: Gets the sensitivity label of a given column
            var serverDatabaseSchemaTableColumnSensitivityLabel = GetArmClient().GetServerDatabaseSchemaTableColumnSensitivityLabel(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/myRG/providers/Microsoft.Sql/servers/myServer/databases/myDatabase/schemas/dbo/tables/myTable/columns/myColumn/sensitivityLabels/current"));
            Sql.Models.SensitivityLabelSource sensitivityLabelSource = Sql.Models.SensitivityLabelSource.Current;

            await serverDatabaseSchemaTableColumnSensitivityLabel.GetAsync(sensitivityLabelSource);
        }

        [RecordedTest]
        public async Task DeleteAsync()
        {
            // Example: Deletes the sensitivity label of a given column
            var serverDatabaseSchemaTableColumnSensitivityLabel = GetArmClient().GetServerDatabaseSchemaTableColumnSensitivityLabel(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/myRG/providers/Microsoft.Sql/servers/myServer/databases/myDatabase/schemas/dbo/tables/myTable/columns/myColumn/sensitivityLabels/current"));

            await serverDatabaseSchemaTableColumnSensitivityLabel.DeleteAsync();
        }
    }
}
