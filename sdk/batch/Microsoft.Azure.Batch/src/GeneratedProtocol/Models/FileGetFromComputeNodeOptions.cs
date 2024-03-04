// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Additional parameters for GetFromComputeNode operation.
    /// </summary>
    public partial class FileGetFromComputeNodeOptions
    {
        /// <summary>
        /// Initializes a new instance of the FileGetFromComputeNodeOptions
        /// class.
        /// </summary>
        public FileGetFromComputeNodeOptions()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FileGetFromComputeNodeOptions
        /// class.
        /// </summary>
        /// <param name="timeout">The maximum time that the server can spend
        /// processing the request, in seconds. The default is 30 seconds. If
        /// the value is larger than 30, the default will be used
        /// instead.</param>
        /// <param name="clientRequestId">The caller-generated request
        /// identity, in the form of a GUID with no decoration such as curly
        /// braces, e.g. 9C4D50EE-2D56-4CD3-8152-34347DC9F2B0.</param>
        /// <param name="returnClientRequestId">Whether the server should
        /// return the client-request-id in the response.</param>
        /// <param name="ocpDate">The time the request was issued. Client
        /// libraries typically set this to the current system clock time; set
        /// it explicitly if you are calling the REST API directly.</param>
        /// <param name="ocpRange">The byte range to be retrieved. The default
        /// is to retrieve the entire file. The format is
        /// bytes=startRange-endRange.</param>
        /// <param name="ifModifiedSince">A timestamp indicating the last
        /// modified time of the resource known to the client. The operation
        /// will be performed only if the resource on the service has been
        /// modified since the specified time.</param>
        /// <param name="ifUnmodifiedSince">A timestamp indicating the last
        /// modified time of the resource known to the client. The operation
        /// will be performed only if the resource on the service has not been
        /// modified since the specified time.</param>
        public FileGetFromComputeNodeOptions(int? timeout = default(int?), System.Guid? clientRequestId = default(System.Guid?), bool? returnClientRequestId = default(bool?), System.DateTime? ocpDate = default(System.DateTime?), string ocpRange = default(string), System.DateTime? ifModifiedSince = default(System.DateTime?), System.DateTime? ifUnmodifiedSince = default(System.DateTime?))
        {
            Timeout = timeout;
            ClientRequestId = clientRequestId;
            ReturnClientRequestId = returnClientRequestId;
            OcpDate = ocpDate;
            OcpRange = ocpRange;
            IfModifiedSince = ifModifiedSince;
            IfUnmodifiedSince = ifUnmodifiedSince;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the maximum time that the server can spend processing
        /// the request, in seconds. The default is 30 seconds. If the value is
        /// larger than 30, the default will be used instead.
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        public int? Timeout { get; set; }

        /// <summary>
        /// Gets or sets the caller-generated request identity, in the form of
        /// a GUID with no decoration such as curly braces, e.g.
        /// 9C4D50EE-2D56-4CD3-8152-34347DC9F2B0.
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        public System.Guid? ClientRequestId { get; set; }

        /// <summary>
        /// Gets or sets whether the server should return the client-request-id
        /// in the response.
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        public bool? ReturnClientRequestId { get; set; }

        /// <summary>
        /// Gets or sets the time the request was issued. Client libraries
        /// typically set this to the current system clock time; set it
        /// explicitly if you are calling the REST API directly.
        /// </summary>
        [JsonConverter(typeof(DateTimeRfc1123JsonConverter))]
        [Newtonsoft.Json.JsonIgnore]
        public System.DateTime? OcpDate { get; set; }

        /// <summary>
        /// Gets or sets the byte range to be retrieved. The default is to
        /// retrieve the entire file. The format is bytes=startRange-endRange.
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        public string OcpRange { get; set; }

        /// <summary>
        /// Gets or sets a timestamp indicating the last modified time of the
        /// resource known to the client. The operation will be performed only
        /// if the resource on the service has been modified since the
        /// specified time.
        /// </summary>
        [JsonConverter(typeof(DateTimeRfc1123JsonConverter))]
        [Newtonsoft.Json.JsonIgnore]
        public System.DateTime? IfModifiedSince { get; set; }

        /// <summary>
        /// Gets or sets a timestamp indicating the last modified time of the
        /// resource known to the client. The operation will be performed only
        /// if the resource on the service has not been modified since the
        /// specified time.
        /// </summary>
        [JsonConverter(typeof(DateTimeRfc1123JsonConverter))]
        [Newtonsoft.Json.JsonIgnore]
        public System.DateTime? IfUnmodifiedSince { get; set; }

    }
}
