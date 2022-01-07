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
using Azure.ResourceManager.EdgeOrder.Models;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Resources.Models;
using Azure.ResourceManager.TestFramework;

namespace Azure.ResourceManager.EdgeOrder.Tests.Mock
{
    /// <summary> Test for AddressResource. </summary>
    public partial class AddressResourceMockTests : MockTestBase
    {
        public AddressResourceMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task GetAsync()
        {
            // Example: GetAddressByName
            var addressResource = GetArmClient().GetAddressResource(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/TestRG/providers/Microsoft.EdgeOrder/addresses/TestMSAddressName"));

            await addressResource.GetAsync();
        }

        [RecordedTest]
        public async Task DeleteAsync()
        {
            // Example: DeleteAddressByName
            var addressResource = GetArmClient().GetAddressResource(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/TestRG/providers/Microsoft.EdgeOrder/addresses/TestAddressName1"));

            await addressResource.DeleteAsync();
        }

        [RecordedTest]
        public async Task UpdateAsync()
        {
            // Example: UpdateAddress
            var addressResource = GetArmClient().GetAddressResource(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/TestRG/providers/Microsoft.EdgeOrder/addresses/TestAddressName2"));
            EdgeOrder.Models.AddressUpdateParameter addressUpdateParameter = new EdgeOrder.Models.AddressUpdateParameter()
            {
                ShippingAddress = new EdgeOrder.Models.ShippingAddress(streetAddress1: "16 TOWNSEND STT", country: "US")
                {
                    StreetAddress2 = "UNIT 1",
                    City = "San Francisco",
                    StateOrProvince = "CA",
                    PostalCode = "94107",
                    CompanyName = "Microsoft",
                    AddressType = new EdgeOrder.Models.AddressType("None"),
                },
                ContactDetails = new EdgeOrder.Models.ContactDetails(contactName: "Petr Cech", phone: "1234567890", emailList: new List<string>()
{
"ssemcr@microsoft.com",})
                {
                    PhoneExtension = "",
                },
            };
            string ifMatch = null;

            await addressResource.UpdateAsync(addressUpdateParameter, ifMatch);
        }
    }
}
