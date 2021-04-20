// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Monitory.Query.Models
{
    /// <summary> Represents a metric metadata value. </summary>
    public partial class MetadataValue
    {
        /// <summary> Initializes a new instance of MetadataValue. </summary>
        internal MetadataValue()
        {
        }

        /// <summary> Initializes a new instance of MetadataValue. </summary>
        /// <param name="localizedName"> the name of the metadata. </param>
        /// <param name="value"> the value of the metadata. </param>
        internal MetadataValue(LocalizableString localizedName, string value)
        {
            LocalizedName = localizedName;
            Value = value;
        }
        /// <summary> the value of the metadata. </summary>
        public string Value { get; }
    }
}
