// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class QosIPRange : IUtf8JsonSerializable, IJsonModel<QosIPRange>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<QosIPRange>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<QosIPRange>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<QosIPRange>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(QosIPRange)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (StartIP != null)
            {
                writer.WritePropertyName("startIP"u8);
                writer.WriteStringValue(StartIP);
            }
            if (EndIP != null)
            {
                writer.WritePropertyName("endIP"u8);
                writer.WriteStringValue(EndIP);
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

        QosIPRange IJsonModel<QosIPRange>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<QosIPRange>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(QosIPRange)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeQosIPRange(document.RootElement, options);
        }

        internal static QosIPRange DeserializeQosIPRange(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string startIP = default;
            string endIP = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("startIP"u8))
                {
                    startIP = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("endIP"u8))
                {
                    endIP = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new QosIPRange(startIP, endIP, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<QosIPRange>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<QosIPRange>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(QosIPRange)} does not support '{options.Format}' format.");
            }
        }

        QosIPRange IPersistableModel<QosIPRange>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<QosIPRange>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeQosIPRange(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(QosIPRange)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<QosIPRange>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
