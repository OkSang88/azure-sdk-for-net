// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Group contract Properties. </summary>
    public partial class GroupContractProperties
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

        /// <summary> Initializes a new instance of <see cref="GroupContractProperties"/>. </summary>
        /// <param name="displayName"> Group name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="displayName"/> is null. </exception>
        internal GroupContractProperties(string displayName)
        {
            if (displayName == null)
            {
                throw new ArgumentNullException(nameof(displayName));
            }

            DisplayName = displayName;
        }

        /// <summary> Initializes a new instance of <see cref="GroupContractProperties"/>. </summary>
        /// <param name="displayName"> Group name. </param>
        /// <param name="description"> Group description. Can contain HTML formatting tags. </param>
        /// <param name="isBuiltIn"> true if the group is one of the three system groups (Administrators, Developers, or Guests); otherwise false. </param>
        /// <param name="apiManagementGroupType"> Group type. </param>
        /// <param name="externalId"> For external groups, this property contains the id of the group from the external identity provider, e.g. for Azure Active Directory `aad://&lt;tenant&gt;.onmicrosoft.com/groups/&lt;group object id&gt;`; otherwise the value is null. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal GroupContractProperties(string displayName, string description, bool? isBuiltIn, ApiManagementGroupType? apiManagementGroupType, string externalId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            DisplayName = displayName;
            Description = description;
            IsBuiltIn = isBuiltIn;
            ApiManagementGroupType = apiManagementGroupType;
            ExternalId = externalId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="GroupContractProperties"/> for deserialization. </summary>
        internal GroupContractProperties()
        {
        }

        /// <summary> Group name. </summary>
        public string DisplayName { get; }
        /// <summary> Group description. Can contain HTML formatting tags. </summary>
        public string Description { get; }
        /// <summary> true if the group is one of the three system groups (Administrators, Developers, or Guests); otherwise false. </summary>
        public bool? IsBuiltIn { get; }
        /// <summary> Group type. </summary>
        public ApiManagementGroupType? ApiManagementGroupType { get; }
        /// <summary> For external groups, this property contains the id of the group from the external identity provider, e.g. for Azure Active Directory `aad://&lt;tenant&gt;.onmicrosoft.com/groups/&lt;group object id&gt;`; otherwise the value is null. </summary>
        public string ExternalId { get; }
    }
}
