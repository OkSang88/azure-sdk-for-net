// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MySql.Models
{
    public partial class MySqlTopQueryStatisticsInput : IUtf8JsonSerializable, IJsonModel<MySqlTopQueryStatisticsInput>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MySqlTopQueryStatisticsInput>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MySqlTopQueryStatisticsInput>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MySqlTopQueryStatisticsInput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MySqlTopQueryStatisticsInput)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            writer.WritePropertyName("numberOfTopQueries"u8);
            writer.WriteNumberValue(NumberOfTopQueries);
            writer.WritePropertyName("aggregationFunction"u8);
            writer.WriteStringValue(AggregationFunction);
            writer.WritePropertyName("observedMetric"u8);
            writer.WriteStringValue(ObservedMetric);
            writer.WritePropertyName("observationStartTime"u8);
            writer.WriteStringValue(ObservationStartOn, "O");
            writer.WritePropertyName("observationEndTime"u8);
            writer.WriteStringValue(ObservationEndOn, "O");
            writer.WritePropertyName("aggregationWindow"u8);
            writer.WriteStringValue(AggregationWindow);
            writer.WriteEndObject();
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

        MySqlTopQueryStatisticsInput IJsonModel<MySqlTopQueryStatisticsInput>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MySqlTopQueryStatisticsInput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MySqlTopQueryStatisticsInput)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMySqlTopQueryStatisticsInput(document.RootElement, options);
        }

        internal static MySqlTopQueryStatisticsInput DeserializeMySqlTopQueryStatisticsInput(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int numberOfTopQueries = default;
            string aggregationFunction = default;
            string observedMetric = default;
            DateTimeOffset observationStartTime = default;
            DateTimeOffset observationEndTime = default;
            string aggregationWindow = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("numberOfTopQueries"u8))
                        {
                            numberOfTopQueries = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("aggregationFunction"u8))
                        {
                            aggregationFunction = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("observedMetric"u8))
                        {
                            observedMetric = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("observationStartTime"u8))
                        {
                            observationStartTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("observationEndTime"u8))
                        {
                            observationEndTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("aggregationWindow"u8))
                        {
                            aggregationWindow = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MySqlTopQueryStatisticsInput(
                numberOfTopQueries,
                aggregationFunction,
                observedMetric,
                observationStartTime,
                observationEndTime,
                aggregationWindow,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MySqlTopQueryStatisticsInput>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MySqlTopQueryStatisticsInput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MySqlTopQueryStatisticsInput)} does not support '{options.Format}' format.");
            }
        }

        MySqlTopQueryStatisticsInput IPersistableModel<MySqlTopQueryStatisticsInput>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MySqlTopQueryStatisticsInput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMySqlTopQueryStatisticsInput(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MySqlTopQueryStatisticsInput)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MySqlTopQueryStatisticsInput>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
