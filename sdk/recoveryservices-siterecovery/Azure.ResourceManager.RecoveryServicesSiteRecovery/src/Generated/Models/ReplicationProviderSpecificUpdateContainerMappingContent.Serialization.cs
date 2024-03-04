// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    [PersistableModelProxy(typeof(UnknownReplicationProviderSpecificUpdateContainerMappingContent))]
    public partial class ReplicationProviderSpecificUpdateContainerMappingContent : IUtf8JsonSerializable, IJsonModel<ReplicationProviderSpecificUpdateContainerMappingContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ReplicationProviderSpecificUpdateContainerMappingContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ReplicationProviderSpecificUpdateContainerMappingContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReplicationProviderSpecificUpdateContainerMappingContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ReplicationProviderSpecificUpdateContainerMappingContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("instanceType"u8);
            writer.WriteStringValue(InstanceType);
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

        ReplicationProviderSpecificUpdateContainerMappingContent IJsonModel<ReplicationProviderSpecificUpdateContainerMappingContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReplicationProviderSpecificUpdateContainerMappingContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ReplicationProviderSpecificUpdateContainerMappingContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeReplicationProviderSpecificUpdateContainerMappingContent(document.RootElement, options);
        }

        internal static ReplicationProviderSpecificUpdateContainerMappingContent DeserializeReplicationProviderSpecificUpdateContainerMappingContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("instanceType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "A2A": return A2AUpdateContainerMappingContent.DeserializeA2AUpdateContainerMappingContent(element, options);
                    case "InMageRcm": return InMageRcmUpdateContainerMappingContent.DeserializeInMageRcmUpdateContainerMappingContent(element, options);
                }
            }
            return UnknownReplicationProviderSpecificUpdateContainerMappingContent.DeserializeUnknownReplicationProviderSpecificUpdateContainerMappingContent(element, options);
        }

        BinaryData IPersistableModel<ReplicationProviderSpecificUpdateContainerMappingContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReplicationProviderSpecificUpdateContainerMappingContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ReplicationProviderSpecificUpdateContainerMappingContent)} does not support '{options.Format}' format.");
            }
        }

        ReplicationProviderSpecificUpdateContainerMappingContent IPersistableModel<ReplicationProviderSpecificUpdateContainerMappingContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReplicationProviderSpecificUpdateContainerMappingContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeReplicationProviderSpecificUpdateContainerMappingContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ReplicationProviderSpecificUpdateContainerMappingContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ReplicationProviderSpecificUpdateContainerMappingContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
