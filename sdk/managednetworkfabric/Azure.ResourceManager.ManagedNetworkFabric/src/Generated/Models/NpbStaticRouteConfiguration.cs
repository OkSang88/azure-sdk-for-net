// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    /// <summary> NPB Static Route Configuration properties. </summary>
    public partial class NpbStaticRouteConfiguration
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

        /// <summary> Initializes a new instance of <see cref="NpbStaticRouteConfiguration"/>. </summary>
        public NpbStaticRouteConfiguration()
        {
            IPv4Routes = new ChangeTrackingList<StaticRouteProperties>();
            IPv6Routes = new ChangeTrackingList<StaticRouteProperties>();
        }

        /// <summary> Initializes a new instance of <see cref="NpbStaticRouteConfiguration"/>. </summary>
        /// <param name="bfdConfiguration"> BFD Configuration properties. </param>
        /// <param name="ipv4Routes"> List of IPv4 Routes. </param>
        /// <param name="ipv6Routes"> List of IPv6 Routes. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NpbStaticRouteConfiguration(BfdConfiguration bfdConfiguration, IList<StaticRouteProperties> ipv4Routes, IList<StaticRouteProperties> ipv6Routes, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            BfdConfiguration = bfdConfiguration;
            IPv4Routes = ipv4Routes;
            IPv6Routes = ipv6Routes;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> BFD Configuration properties. </summary>
        public BfdConfiguration BfdConfiguration { get; set; }
        /// <summary> List of IPv4 Routes. </summary>
        public IList<StaticRouteProperties> IPv4Routes { get; }
        /// <summary> List of IPv6 Routes. </summary>
        public IList<StaticRouteProperties> IPv6Routes { get; }
    }
}
