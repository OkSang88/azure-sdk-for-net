// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> The StoragePermissionScope. </summary>
    public partial class StoragePermissionScope
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

        /// <summary> Initializes a new instance of <see cref="StoragePermissionScope"/>. </summary>
        /// <param name="permissions"> The permissions for the local user. Possible values include: Read (r), Write (w), Delete (d), List (l), and Create (c). </param>
        /// <param name="service"> The service used by the local user, e.g. blob, file. </param>
        /// <param name="resourceName"> The name of resource, normally the container name or the file share name, used by the local user. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="permissions"/>, <paramref name="service"/> or <paramref name="resourceName"/> is null. </exception>
        public StoragePermissionScope(string permissions, string service, string resourceName)
        {
            if (permissions == null)
            {
                throw new ArgumentNullException(nameof(permissions));
            }
            if (service == null)
            {
                throw new ArgumentNullException(nameof(service));
            }
            if (resourceName == null)
            {
                throw new ArgumentNullException(nameof(resourceName));
            }

            Permissions = permissions;
            Service = service;
            ResourceName = resourceName;
        }

        /// <summary> Initializes a new instance of <see cref="StoragePermissionScope"/>. </summary>
        /// <param name="permissions"> The permissions for the local user. Possible values include: Read (r), Write (w), Delete (d), List (l), and Create (c). </param>
        /// <param name="service"> The service used by the local user, e.g. blob, file. </param>
        /// <param name="resourceName"> The name of resource, normally the container name or the file share name, used by the local user. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal StoragePermissionScope(string permissions, string service, string resourceName, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Permissions = permissions;
            Service = service;
            ResourceName = resourceName;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="StoragePermissionScope"/> for deserialization. </summary>
        internal StoragePermissionScope()
        {
        }

        /// <summary> The permissions for the local user. Possible values include: Read (r), Write (w), Delete (d), List (l), and Create (c). </summary>
        public string Permissions { get; set; }
        /// <summary> The service used by the local user, e.g. blob, file. </summary>
        public string Service { get; set; }
        /// <summary> The name of resource, normally the container name or the file share name, used by the local user. </summary>
        public string ResourceName { get; set; }
    }
}
