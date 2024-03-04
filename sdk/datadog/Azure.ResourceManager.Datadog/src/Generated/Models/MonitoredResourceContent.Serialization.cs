// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Datadog.Models
{
    public partial class MonitoredResourceContent : IUtf8JsonSerializable, IJsonModel<MonitoredResourceContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MonitoredResourceContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MonitoredResourceContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitoredResourceContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MonitoredResourceContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Id != null)
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (SendingMetrics.HasValue)
            {
                writer.WritePropertyName("sendingMetrics"u8);
                writer.WriteBooleanValue(SendingMetrics.Value);
            }
            if (ReasonForMetricsStatus != null)
            {
                writer.WritePropertyName("reasonForMetricsStatus"u8);
                writer.WriteStringValue(ReasonForMetricsStatus);
            }
            if (SendingLogs.HasValue)
            {
                writer.WritePropertyName("sendingLogs"u8);
                writer.WriteBooleanValue(SendingLogs.Value);
            }
            if (ReasonForLogsStatus != null)
            {
                writer.WritePropertyName("reasonForLogsStatus"u8);
                writer.WriteStringValue(ReasonForLogsStatus);
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

        MonitoredResourceContent IJsonModel<MonitoredResourceContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitoredResourceContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MonitoredResourceContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMonitoredResourceContent(document.RootElement, options);
        }

        internal static MonitoredResourceContent DeserializeMonitoredResourceContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string id = default;
            bool? sendingMetrics = default;
            string reasonForMetricsStatus = default;
            bool? sendingLogs = default;
            string reasonForLogsStatus = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sendingMetrics"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sendingMetrics = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("reasonForMetricsStatus"u8))
                {
                    reasonForMetricsStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sendingLogs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sendingLogs = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("reasonForLogsStatus"u8))
                {
                    reasonForLogsStatus = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MonitoredResourceContent(
                id,
                sendingMetrics,
                reasonForMetricsStatus,
                sendingLogs,
                reasonForLogsStatus,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MonitoredResourceContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitoredResourceContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MonitoredResourceContent)} does not support '{options.Format}' format.");
            }
        }

        MonitoredResourceContent IPersistableModel<MonitoredResourceContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitoredResourceContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMonitoredResourceContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MonitoredResourceContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MonitoredResourceContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
