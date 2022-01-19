// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class VMGalleryApplication : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Tags))
            {
                writer.WritePropertyName("tags");
                writer.WriteStringValue(Tags);
            }
            if (Optional.IsDefined(Order))
            {
                writer.WritePropertyName("order");
                writer.WriteNumberValue(Order.Value);
            }
            writer.WritePropertyName("packageReferenceId");
            writer.WriteStringValue(PackageReferenceId);
            if (Optional.IsDefined(ConfigurationReference))
            {
                writer.WritePropertyName("configurationReference");
                writer.WriteStringValue(ConfigurationReference);
            }
            writer.WriteEndObject();
        }

        internal static VMGalleryApplication DeserializeVMGalleryApplication(JsonElement element)
        {
            Optional<string> tags = default;
            Optional<int> order = default;
            string packageReferenceId = default;
            Optional<string> configurationReference = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tags"))
                {
                    tags = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("order"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    order = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("packageReferenceId"))
                {
                    packageReferenceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("configurationReference"))
                {
                    configurationReference = property.Value.GetString();
                    continue;
                }
            }
            return new VMGalleryApplication(tags.Value, Optional.ToNullable(order), packageReferenceId, configurationReference.Value);
        }
    }
}
