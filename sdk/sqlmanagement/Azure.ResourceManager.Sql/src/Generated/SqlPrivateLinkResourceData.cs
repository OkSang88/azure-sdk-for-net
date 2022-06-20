// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A class representing the SqlPrivateLinkResource data model. </summary>
    public partial class SqlPrivateLinkResourceData : ResourceData
    {
        /// <summary> Initializes a new instance of SqlPrivateLinkResourceData. </summary>
        public SqlPrivateLinkResourceData()
        {
        }

        /// <summary> Initializes a new instance of SqlPrivateLinkResourceData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> The private link resource group id. </param>
        internal SqlPrivateLinkResourceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, SqlPrivateLinkResourceProperties properties) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
        }

        /// <summary> The private link resource group id. </summary>
        public SqlPrivateLinkResourceProperties Properties { get; }
    }
}
