// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class ImageMetadata : IUtf8JsonSerializable, IJsonModel<ImageMetadata>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ImageMetadata>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ImageMetadata>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ImageMetadata>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ImageMetadata)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (CurrentImageVersion != null)
            {
                writer.WritePropertyName("currentImageVersion"u8);
                writer.WriteStringValue(CurrentImageVersion);
            }
            if (LatestImageVersion != null)
            {
                writer.WritePropertyName("latestImageVersion"u8);
                writer.WriteStringValue(LatestImageVersion);
            }
            if (IsLatestOSImageVersion.HasValue)
            {
                writer.WritePropertyName("isLatestOsImageVersion"u8);
                writer.WriteBooleanValue(IsLatestOSImageVersion.Value);
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

        ImageMetadata IJsonModel<ImageMetadata>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ImageMetadata>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ImageMetadata)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeImageMetadata(document.RootElement, options);
        }

        internal static ImageMetadata DeserializeImageMetadata(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string currentImageVersion = default;
            string latestImageVersion = default;
            bool? isLatestOSImageVersion = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("currentImageVersion"u8))
                {
                    currentImageVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("latestImageVersion"u8))
                {
                    latestImageVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isLatestOsImageVersion"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isLatestOSImageVersion = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ImageMetadata(currentImageVersion, latestImageVersion, isLatestOSImageVersion, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ImageMetadata>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ImageMetadata>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ImageMetadata)} does not support '{options.Format}' format.");
            }
        }

        ImageMetadata IPersistableModel<ImageMetadata>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ImageMetadata>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeImageMetadata(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ImageMetadata)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ImageMetadata>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
