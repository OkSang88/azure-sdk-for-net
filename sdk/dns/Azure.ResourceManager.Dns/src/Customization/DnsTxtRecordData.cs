// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Dns.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Dns
{
    /// <summary> A class representing the DnsTxtRecord data model. </summary>
    public partial class DnsTxtRecordData : DnsBaseRecordData
    {
        /// <summary> Initializes a new instance of DnsTxtRecordData. </summary>
        public DnsTxtRecordData()
        {
            DnsTxtRecords = new ChangeTrackingList<DnsTxtRecordInfo>();
        }

        /// <summary> Initializes a new instance of DnsTxtRecordData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="etag"> The etag of the record set. </param>
        /// <param name="metadata"> The metadata attached to the record set. </param>
        /// <param name="ttl"> The Ttl (time-to-live) of the records in the record set. </param>
        /// <param name="fqdn"> Fully qualified domain name of the record set. </param>
        /// <param name="provisioningState"> provisioning State of the record set. </param>
        /// <param name="targetResource"> A reference to an azure resource from where the dns resource value is taken. </param>
        /// <param name="txtRecords"> The list of TXT records in the record set. </param>
        internal DnsTxtRecordData(ResourceIdentifier id, string name, ResourceType resourceType, ResourceManager.Models.SystemData systemData, ETag? etag, IDictionary<string, string> metadata, long? ttl, string fqdn, string provisioningState, WritableSubResource targetResource, IList<DnsTxtRecordInfo> txtRecords) : base(id, name, resourceType, systemData, etag, metadata, ttl, fqdn, provisioningState, targetResource)
        {
            DnsTxtRecords = txtRecords;
        }

        /// <summary> The list of TXT records in the record set. </summary>
        public IList<DnsTxtRecordInfo> DnsTxtRecords { get; }
    }
}
