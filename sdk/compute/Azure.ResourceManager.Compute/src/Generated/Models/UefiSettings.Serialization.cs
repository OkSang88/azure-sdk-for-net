// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class UefiSettings : IUtf8JsonSerializable, IJsonModel<UefiSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<UefiSettings>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<UefiSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UefiSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(UefiSettings)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (IsSecureBootEnabled.HasValue)
            {
                writer.WritePropertyName("secureBootEnabled"u8);
                writer.WriteBooleanValue(IsSecureBootEnabled.Value);
            }
            if (IsVirtualTpmEnabled.HasValue)
            {
                writer.WritePropertyName("vTpmEnabled"u8);
                writer.WriteBooleanValue(IsVirtualTpmEnabled.Value);
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

        UefiSettings IJsonModel<UefiSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UefiSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(UefiSettings)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeUefiSettings(document.RootElement, options);
        }

        internal static UefiSettings DeserializeUefiSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool? secureBootEnabled = default;
            bool? vTpmEnabled = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("secureBootEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    secureBootEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("vTpmEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    vTpmEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new UefiSettings(secureBootEnabled, vTpmEnabled, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<UefiSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UefiSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(UefiSettings)} does not support '{options.Format}' format.");
            }
        }

        UefiSettings IPersistableModel<UefiSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UefiSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeUefiSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(UefiSettings)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<UefiSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
