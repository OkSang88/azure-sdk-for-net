// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.AppContainers;

namespace Azure.ResourceManager.AppContainers.Models
{
    internal partial class ConnectedEnvironmentStoragesCollection : IUtf8JsonSerializable, IJsonModel<ConnectedEnvironmentStoragesCollection>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ConnectedEnvironmentStoragesCollection>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ConnectedEnvironmentStoragesCollection>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectedEnvironmentStoragesCollection>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConnectedEnvironmentStoragesCollection)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("value"u8);
            writer.WriteStartArray();
            foreach (var item in Value)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
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

        ConnectedEnvironmentStoragesCollection IJsonModel<ConnectedEnvironmentStoragesCollection>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectedEnvironmentStoragesCollection>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConnectedEnvironmentStoragesCollection)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeConnectedEnvironmentStoragesCollection(document.RootElement, options);
        }

        internal static ConnectedEnvironmentStoragesCollection DeserializeConnectedEnvironmentStoragesCollection(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<ContainerAppConnectedEnvironmentStorageData> value = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    List<ContainerAppConnectedEnvironmentStorageData> array = new List<ContainerAppConnectedEnvironmentStorageData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContainerAppConnectedEnvironmentStorageData.DeserializeContainerAppConnectedEnvironmentStorageData(item, options));
                    }
                    value = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ConnectedEnvironmentStoragesCollection(value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ConnectedEnvironmentStoragesCollection>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectedEnvironmentStoragesCollection>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ConnectedEnvironmentStoragesCollection)} does not support '{options.Format}' format.");
            }
        }

        ConnectedEnvironmentStoragesCollection IPersistableModel<ConnectedEnvironmentStoragesCollection>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectedEnvironmentStoragesCollection>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeConnectedEnvironmentStoragesCollection(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ConnectedEnvironmentStoragesCollection)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ConnectedEnvironmentStoragesCollection>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
