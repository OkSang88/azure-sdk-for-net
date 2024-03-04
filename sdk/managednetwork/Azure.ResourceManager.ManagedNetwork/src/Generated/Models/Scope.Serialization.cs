// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.ManagedNetwork.Models
{
    public partial class Scope : IUtf8JsonSerializable, IJsonModel<Scope>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<Scope>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<Scope>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<Scope>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(Scope)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (!(ManagementGroups is ChangeTrackingList<WritableSubResource> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("managementGroups"u8);
                writer.WriteStartArray();
                foreach (var item in ManagementGroups)
                {
                    JsonSerializer.Serialize(writer, item);
                }
                writer.WriteEndArray();
            }
            if (!(Subscriptions is ChangeTrackingList<WritableSubResource> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("subscriptions"u8);
                writer.WriteStartArray();
                foreach (var item in Subscriptions)
                {
                    JsonSerializer.Serialize(writer, item);
                }
                writer.WriteEndArray();
            }
            if (!(VirtualNetworks is ChangeTrackingList<WritableSubResource> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("virtualNetworks"u8);
                writer.WriteStartArray();
                foreach (var item in VirtualNetworks)
                {
                    JsonSerializer.Serialize(writer, item);
                }
                writer.WriteEndArray();
            }
            if (!(Subnets is ChangeTrackingList<WritableSubResource> collection2 && collection2.IsUndefined))
            {
                writer.WritePropertyName("subnets"u8);
                writer.WriteStartArray();
                foreach (var item in Subnets)
                {
                    JsonSerializer.Serialize(writer, item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        Scope IJsonModel<Scope>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<Scope>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(Scope)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeScope(document.RootElement, options);
        }

        internal static Scope DeserializeScope(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<WritableSubResource> managementGroups = default;
            IList<WritableSubResource> subscriptions = default;
            IList<WritableSubResource> virtualNetworks = default;
            IList<WritableSubResource> subnets = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("managementGroups"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<WritableSubResource> array = new List<WritableSubResource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(JsonSerializer.Deserialize<WritableSubResource>(item.GetRawText()));
                    }
                    managementGroups = array;
                    continue;
                }
                if (property.NameEquals("subscriptions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<WritableSubResource> array = new List<WritableSubResource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(JsonSerializer.Deserialize<WritableSubResource>(item.GetRawText()));
                    }
                    subscriptions = array;
                    continue;
                }
                if (property.NameEquals("virtualNetworks"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<WritableSubResource> array = new List<WritableSubResource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(JsonSerializer.Deserialize<WritableSubResource>(item.GetRawText()));
                    }
                    virtualNetworks = array;
                    continue;
                }
                if (property.NameEquals("subnets"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<WritableSubResource> array = new List<WritableSubResource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(JsonSerializer.Deserialize<WritableSubResource>(item.GetRawText()));
                    }
                    subnets = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new Scope(managementGroups ?? new ChangeTrackingList<WritableSubResource>(), subscriptions ?? new ChangeTrackingList<WritableSubResource>(), virtualNetworks ?? new ChangeTrackingList<WritableSubResource>(), subnets ?? new ChangeTrackingList<WritableSubResource>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<Scope>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<Scope>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(Scope)} does not support '{options.Format}' format.");
            }
        }

        Scope IPersistableModel<Scope>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<Scope>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeScope(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(Scope)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<Scope>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
