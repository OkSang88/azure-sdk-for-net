// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Synapse.Models
{
    internal partial class CspWorkspaceAdminProperties : IUtf8JsonSerializable, IJsonModel<CspWorkspaceAdminProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CspWorkspaceAdminProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CspWorkspaceAdminProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CspWorkspaceAdminProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CspWorkspaceAdminProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (InitialWorkspaceAdminObjectId.HasValue)
            {
                writer.WritePropertyName("initialWorkspaceAdminObjectId"u8);
                writer.WriteStringValue(InitialWorkspaceAdminObjectId.Value);
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

        CspWorkspaceAdminProperties IJsonModel<CspWorkspaceAdminProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CspWorkspaceAdminProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CspWorkspaceAdminProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCspWorkspaceAdminProperties(document.RootElement, options);
        }

        internal static CspWorkspaceAdminProperties DeserializeCspWorkspaceAdminProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Guid? initialWorkspaceAdminObjectId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("initialWorkspaceAdminObjectId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    initialWorkspaceAdminObjectId = property.Value.GetGuid();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CspWorkspaceAdminProperties(initialWorkspaceAdminObjectId, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CspWorkspaceAdminProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CspWorkspaceAdminProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CspWorkspaceAdminProperties)} does not support '{options.Format}' format.");
            }
        }

        CspWorkspaceAdminProperties IPersistableModel<CspWorkspaceAdminProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CspWorkspaceAdminProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCspWorkspaceAdminProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CspWorkspaceAdminProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CspWorkspaceAdminProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
