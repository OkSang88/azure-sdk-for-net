// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    /// <summary> The IP Prefix patch resource definition. </summary>
    public partial class NetworkFabricIPPrefixPatch : NetworkRackPatch
    {
        /// <summary> Initializes a new instance of <see cref="NetworkFabricIPPrefixPatch"/>. </summary>
        public NetworkFabricIPPrefixPatch()
        {
            IPPrefixRules = new ChangeTrackingList<IPPrefixRule>();
        }

        /// <summary> Initializes a new instance of <see cref="NetworkFabricIPPrefixPatch"/>. </summary>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="annotation"> Switch configuration description. </param>
        /// <param name="ipPrefixRules"> The list of IP Prefix Rules. </param>
        internal NetworkFabricIPPrefixPatch(IDictionary<string, string> tags, IDictionary<string, BinaryData> serializedAdditionalRawData, string annotation, IList<IPPrefixRule> ipPrefixRules) : base(tags, serializedAdditionalRawData)
        {
            Annotation = annotation;
            IPPrefixRules = ipPrefixRules;
        }

        /// <summary> Switch configuration description. </summary>
        public string Annotation { get; set; }
        /// <summary> The list of IP Prefix Rules. </summary>
        public IList<IPPrefixRule> IPPrefixRules { get; }
    }
}
