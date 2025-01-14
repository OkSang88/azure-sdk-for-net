// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.Quantum;

namespace Azure.ResourceManager.Quantum.Models
{
    /// <summary> List of api keys to be generated. </summary>
    public partial class WorkspaceApiKeys
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

        /// <summary> Initializes a new instance of <see cref="WorkspaceApiKeys"/>. </summary>
        public WorkspaceApiKeys()
        {
            Keys = new ChangeTrackingList<WorkspaceKeyType>();
        }

        /// <summary> Initializes a new instance of <see cref="WorkspaceApiKeys"/>. </summary>
        /// <param name="keys"> A list of api key names. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal WorkspaceApiKeys(IList<WorkspaceKeyType> keys, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Keys = keys;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> A list of api key names. </summary>
        public IList<WorkspaceKeyType> Keys { get; }
    }
}
