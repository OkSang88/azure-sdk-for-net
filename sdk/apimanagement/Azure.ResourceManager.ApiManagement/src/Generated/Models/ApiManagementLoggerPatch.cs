// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.ApiManagement;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Logger update contract. </summary>
    public partial class ApiManagementLoggerPatch
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ApiManagementLoggerPatch"/>. </summary>
        public ApiManagementLoggerPatch()
        {
            Credentials = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="ApiManagementLoggerPatch"/>. </summary>
        /// <param name="loggerType"> Logger type. </param>
        /// <param name="description"> Logger description. </param>
        /// <param name="credentials"> Logger credentials. </param>
        /// <param name="isBuffered"> Whether records are buffered in the logger before publishing. Default is assumed to be true. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ApiManagementLoggerPatch(LoggerType? loggerType, string description, IDictionary<string, string> credentials, bool? isBuffered, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            LoggerType = loggerType;
            Description = description;
            Credentials = credentials;
            IsBuffered = isBuffered;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Logger type. </summary>
        public LoggerType? LoggerType { get; set; }
        /// <summary> Logger description. </summary>
        public string Description { get; set; }
        /// <summary> Logger credentials. </summary>
        public IDictionary<string, string> Credentials { get; }
        /// <summary> Whether records are buffered in the logger before publishing. Default is assumed to be true. </summary>
        public bool? IsBuffered { get; set; }
    }
}
