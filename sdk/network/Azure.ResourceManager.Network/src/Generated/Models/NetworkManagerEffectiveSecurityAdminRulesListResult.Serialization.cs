// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    internal partial class NetworkManagerEffectiveSecurityAdminRulesListResult : IUtf8JsonSerializable, IJsonModel<NetworkManagerEffectiveSecurityAdminRulesListResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NetworkManagerEffectiveSecurityAdminRulesListResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<NetworkManagerEffectiveSecurityAdminRulesListResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkManagerEffectiveSecurityAdminRulesListResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkManagerEffectiveSecurityAdminRulesListResult)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (!(Value is ChangeTrackingList<EffectiveBaseSecurityAdminRule> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteStartArray();
                foreach (var item in Value)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (SkipToken != null)
            {
                writer.WritePropertyName("skipToken"u8);
                writer.WriteStringValue(SkipToken);
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

        NetworkManagerEffectiveSecurityAdminRulesListResult IJsonModel<NetworkManagerEffectiveSecurityAdminRulesListResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkManagerEffectiveSecurityAdminRulesListResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkManagerEffectiveSecurityAdminRulesListResult)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNetworkManagerEffectiveSecurityAdminRulesListResult(document.RootElement, options);
        }

        internal static NetworkManagerEffectiveSecurityAdminRulesListResult DeserializeNetworkManagerEffectiveSecurityAdminRulesListResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<EffectiveBaseSecurityAdminRule> value = default;
            string skipToken = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<EffectiveBaseSecurityAdminRule> array = new List<EffectiveBaseSecurityAdminRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(EffectiveBaseSecurityAdminRule.DeserializeEffectiveBaseSecurityAdminRule(item, options));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("skipToken"u8))
                {
                    skipToken = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new NetworkManagerEffectiveSecurityAdminRulesListResult(value ?? new ChangeTrackingList<EffectiveBaseSecurityAdminRule>(), skipToken, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NetworkManagerEffectiveSecurityAdminRulesListResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkManagerEffectiveSecurityAdminRulesListResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NetworkManagerEffectiveSecurityAdminRulesListResult)} does not support '{options.Format}' format.");
            }
        }

        NetworkManagerEffectiveSecurityAdminRulesListResult IPersistableModel<NetworkManagerEffectiveSecurityAdminRulesListResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkManagerEffectiveSecurityAdminRulesListResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNetworkManagerEffectiveSecurityAdminRulesListResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NetworkManagerEffectiveSecurityAdminRulesListResult)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<NetworkManagerEffectiveSecurityAdminRulesListResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
