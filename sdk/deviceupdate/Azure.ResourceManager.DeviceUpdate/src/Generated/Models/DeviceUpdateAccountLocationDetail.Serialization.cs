// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DeviceUpdate.Models
{
    public partial class DeviceUpdateAccountLocationDetail : IUtf8JsonSerializable, IJsonModel<DeviceUpdateAccountLocationDetail>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DeviceUpdateAccountLocationDetail>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DeviceUpdateAccountLocationDetail>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeviceUpdateAccountLocationDetail>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DeviceUpdateAccountLocationDetail)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Name != null)
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Role.HasValue)
            {
                writer.WritePropertyName("role"u8);
                writer.WriteStringValue(Role.Value.ToString());
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

        DeviceUpdateAccountLocationDetail IJsonModel<DeviceUpdateAccountLocationDetail>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeviceUpdateAccountLocationDetail>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DeviceUpdateAccountLocationDetail)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDeviceUpdateAccountLocationDetail(document.RootElement, options);
        }

        internal static DeviceUpdateAccountLocationDetail DeserializeDeviceUpdateAccountLocationDetail(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            DeviceUpdateAccountLocationRole? role = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("role"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    role = new DeviceUpdateAccountLocationRole(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DeviceUpdateAccountLocationDetail(name, role, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DeviceUpdateAccountLocationDetail>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeviceUpdateAccountLocationDetail>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DeviceUpdateAccountLocationDetail)} does not support '{options.Format}' format.");
            }
        }

        DeviceUpdateAccountLocationDetail IPersistableModel<DeviceUpdateAccountLocationDetail>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeviceUpdateAccountLocationDetail>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDeviceUpdateAccountLocationDetail(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DeviceUpdateAccountLocationDetail)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DeviceUpdateAccountLocationDetail>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
