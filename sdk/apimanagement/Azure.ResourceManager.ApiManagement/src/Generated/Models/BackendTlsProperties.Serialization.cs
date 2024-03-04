// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    public partial class BackendTlsProperties : IUtf8JsonSerializable, IJsonModel<BackendTlsProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BackendTlsProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<BackendTlsProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackendTlsProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BackendTlsProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (ShouldValidateCertificateChain.HasValue)
            {
                writer.WritePropertyName("validateCertificateChain"u8);
                writer.WriteBooleanValue(ShouldValidateCertificateChain.Value);
            }
            if (ShouldValidateCertificateName.HasValue)
            {
                writer.WritePropertyName("validateCertificateName"u8);
                writer.WriteBooleanValue(ShouldValidateCertificateName.Value);
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

        BackendTlsProperties IJsonModel<BackendTlsProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackendTlsProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BackendTlsProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBackendTlsProperties(document.RootElement, options);
        }

        internal static BackendTlsProperties DeserializeBackendTlsProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool? validateCertificateChain = default;
            bool? validateCertificateName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("validateCertificateChain"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    validateCertificateChain = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("validateCertificateName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    validateCertificateName = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new BackendTlsProperties(validateCertificateChain, validateCertificateName, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BackendTlsProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackendTlsProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BackendTlsProperties)} does not support '{options.Format}' format.");
            }
        }

        BackendTlsProperties IPersistableModel<BackendTlsProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackendTlsProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBackendTlsProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BackendTlsProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<BackendTlsProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
