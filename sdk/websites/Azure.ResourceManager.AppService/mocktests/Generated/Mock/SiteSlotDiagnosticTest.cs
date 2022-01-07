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
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Resources.Models;
using Azure.ResourceManager.TestFramework;

namespace Azure.ResourceManager.AppService.Tests.Mock
{
    /// <summary> Test for DiagnosticCategory. </summary>
    public partial class SiteSlotDiagnosticMockTests : MockTestBase
    {
        public SiteSlotDiagnosticMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task GetAsync()
        {
            // Example: Get App Diagnostic Category
            var siteSlotDiagnostic = GetArmClient().GetSiteSlotDiagnostic(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/Sample-WestUSResourceGroup/providers/Microsoft.Web/sites/SampleApp/slots/Production/diagnostics/availability"));

            await siteSlotDiagnostic.GetAsync();
        }

        [RecordedTest]
        public async Task GetAsync2()
        {
            // Example: Get App Slot Diagnostic Category
            var siteSlotDiagnostic = GetArmClient().GetSiteSlotDiagnostic(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/Sample-WestUSResourceGroup/providers/Microsoft.Web/sites/SampleApp/slots/staging/diagnostics/availability"));

            await siteSlotDiagnostic.GetAsync();
        }
    }
}
