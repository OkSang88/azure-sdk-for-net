// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    public partial class JarUploadedUserSourceInfo : IUtf8JsonSerializable, IJsonModel<JarUploadedUserSourceInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<JarUploadedUserSourceInfo>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<JarUploadedUserSourceInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<JarUploadedUserSourceInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(JarUploadedUserSourceInfo)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (RuntimeVersion != null)
            {
                writer.WritePropertyName("runtimeVersion"u8);
                writer.WriteStringValue(RuntimeVersion);
            }
            if (JvmOptions != null)
            {
                writer.WritePropertyName("jvmOptions"u8);
                writer.WriteStringValue(JvmOptions);
            }
            if (RelativePath != null)
            {
                writer.WritePropertyName("relativePath"u8);
                writer.WriteStringValue(RelativePath);
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(UserSourceInfoType);
            if (Version != null)
            {
                writer.WritePropertyName("version"u8);
                writer.WriteStringValue(Version);
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

        JarUploadedUserSourceInfo IJsonModel<JarUploadedUserSourceInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<JarUploadedUserSourceInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(JarUploadedUserSourceInfo)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeJarUploadedUserSourceInfo(document.RootElement, options);
        }

        internal static JarUploadedUserSourceInfo DeserializeJarUploadedUserSourceInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string runtimeVersion = default;
            string jvmOptions = default;
            string relativePath = default;
            string type = default;
            string version = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("runtimeVersion"u8))
                {
                    runtimeVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("jvmOptions"u8))
                {
                    jvmOptions = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("relativePath"u8))
                {
                    relativePath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("version"u8))
                {
                    version = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new JarUploadedUserSourceInfo(
                type,
                version,
                serializedAdditionalRawData,
                relativePath,
                runtimeVersion,
                jvmOptions);
        }

        BinaryData IPersistableModel<JarUploadedUserSourceInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<JarUploadedUserSourceInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(JarUploadedUserSourceInfo)} does not support '{options.Format}' format.");
            }
        }

        JarUploadedUserSourceInfo IPersistableModel<JarUploadedUserSourceInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<JarUploadedUserSourceInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeJarUploadedUserSourceInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(JarUploadedUserSourceInfo)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<JarUploadedUserSourceInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
