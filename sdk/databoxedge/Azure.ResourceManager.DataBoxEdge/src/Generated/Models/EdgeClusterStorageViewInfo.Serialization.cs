// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    public partial class EdgeClusterStorageViewInfo : IUtf8JsonSerializable, IJsonModel<EdgeClusterStorageViewInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<EdgeClusterStorageViewInfo>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<EdgeClusterStorageViewInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdgeClusterStorageViewInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EdgeClusterStorageViewInfo)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (ClusterTotalStorageInMB.HasValue)
            {
                writer.WritePropertyName("clusterTotalStorageMb"u8);
                writer.WriteNumberValue(ClusterTotalStorageInMB.Value);
            }
            if (ClusterFreeStorageInMB.HasValue)
            {
                writer.WritePropertyName("clusterFreeStorageMb"u8);
                writer.WriteNumberValue(ClusterFreeStorageInMB.Value);
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

        EdgeClusterStorageViewInfo IJsonModel<EdgeClusterStorageViewInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdgeClusterStorageViewInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EdgeClusterStorageViewInfo)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeEdgeClusterStorageViewInfo(document.RootElement, options);
        }

        internal static EdgeClusterStorageViewInfo DeserializeEdgeClusterStorageViewInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            double? clusterTotalStorageMb = default;
            double? clusterFreeStorageMb = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("clusterTotalStorageMb"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    clusterTotalStorageMb = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("clusterFreeStorageMb"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    clusterFreeStorageMb = property.Value.GetDouble();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new EdgeClusterStorageViewInfo(clusterTotalStorageMb, clusterFreeStorageMb, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<EdgeClusterStorageViewInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdgeClusterStorageViewInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(EdgeClusterStorageViewInfo)} does not support '{options.Format}' format.");
            }
        }

        EdgeClusterStorageViewInfo IPersistableModel<EdgeClusterStorageViewInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdgeClusterStorageViewInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeEdgeClusterStorageViewInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(EdgeClusterStorageViewInfo)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<EdgeClusterStorageViewInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
