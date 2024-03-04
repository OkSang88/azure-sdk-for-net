// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class PowerQuerySinkMapping : IUtf8JsonSerializable, IJsonModel<PowerQuerySinkMapping>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PowerQuerySinkMapping>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PowerQuerySinkMapping>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PowerQuerySinkMapping>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PowerQuerySinkMapping)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (QueryName != null)
            {
                writer.WritePropertyName("queryName"u8);
                writer.WriteStringValue(QueryName);
            }
            if (!(DataflowSinks is ChangeTrackingList<PowerQuerySink> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("dataflowSinks"u8);
                writer.WriteStartArray();
                foreach (var item in DataflowSinks)
                {
                    writer.WriteObjectValue(item);
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

        PowerQuerySinkMapping IJsonModel<PowerQuerySinkMapping>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PowerQuerySinkMapping>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PowerQuerySinkMapping)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePowerQuerySinkMapping(document.RootElement, options);
        }

        internal static PowerQuerySinkMapping DeserializePowerQuerySinkMapping(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string queryName = default;
            IList<PowerQuerySink> dataflowSinks = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("queryName"u8))
                {
                    queryName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataflowSinks"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PowerQuerySink> array = new List<PowerQuerySink>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PowerQuerySink.DeserializePowerQuerySink(item, options));
                    }
                    dataflowSinks = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PowerQuerySinkMapping(queryName, dataflowSinks ?? new ChangeTrackingList<PowerQuerySink>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PowerQuerySinkMapping>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PowerQuerySinkMapping>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PowerQuerySinkMapping)} does not support '{options.Format}' format.");
            }
        }

        PowerQuerySinkMapping IPersistableModel<PowerQuerySinkMapping>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PowerQuerySinkMapping>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePowerQuerySinkMapping(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PowerQuerySinkMapping)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PowerQuerySinkMapping>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
