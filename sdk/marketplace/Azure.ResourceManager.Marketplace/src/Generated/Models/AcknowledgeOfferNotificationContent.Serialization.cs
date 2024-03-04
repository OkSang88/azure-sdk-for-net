// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Marketplace.Models
{
    public partial class AcknowledgeOfferNotificationContent : IUtf8JsonSerializable, IJsonModel<AcknowledgeOfferNotificationContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AcknowledgeOfferNotificationContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AcknowledgeOfferNotificationContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AcknowledgeOfferNotificationContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AcknowledgeOfferNotificationContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (IsAcknowledgeActionFlagEnabled.HasValue)
            {
                writer.WritePropertyName("acknowledge"u8);
                writer.WriteBooleanValue(IsAcknowledgeActionFlagEnabled.Value);
            }
            if (IsDismissActionFlagEnabled.HasValue)
            {
                writer.WritePropertyName("dismiss"u8);
                writer.WriteBooleanValue(IsDismissActionFlagEnabled.Value);
            }
            if (IsRemoveOfferActionFlagEnabled.HasValue)
            {
                writer.WritePropertyName("removeOffer"u8);
                writer.WriteBooleanValue(IsRemoveOfferActionFlagEnabled.Value);
            }
            if (!(AddPlans is ChangeTrackingList<string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("addPlans"u8);
                writer.WriteStartArray();
                foreach (var item in AddPlans)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(RemovePlans is ChangeTrackingList<string> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("removePlans"u8);
                writer.WriteStartArray();
                foreach (var item in RemovePlans)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
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

        AcknowledgeOfferNotificationContent IJsonModel<AcknowledgeOfferNotificationContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AcknowledgeOfferNotificationContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AcknowledgeOfferNotificationContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAcknowledgeOfferNotificationContent(document.RootElement, options);
        }

        internal static AcknowledgeOfferNotificationContent DeserializeAcknowledgeOfferNotificationContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool? acknowledge = default;
            bool? dismiss = default;
            bool? removeOffer = default;
            IList<string> addPlans = default;
            IList<string> removePlans = default;
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
                        if (property0.NameEquals("acknowledge"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            acknowledge = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("dismiss"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            dismiss = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("removeOffer"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            removeOffer = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("addPlans"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            addPlans = array;
                            continue;
                        }
                        if (property0.NameEquals("removePlans"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            removePlans = array;
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
            return new AcknowledgeOfferNotificationContent(
                acknowledge,
                dismiss,
                removeOffer,
                addPlans ?? new ChangeTrackingList<string>(),
                removePlans ?? new ChangeTrackingList<string>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AcknowledgeOfferNotificationContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AcknowledgeOfferNotificationContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AcknowledgeOfferNotificationContent)} does not support '{options.Format}' format.");
            }
        }

        AcknowledgeOfferNotificationContent IPersistableModel<AcknowledgeOfferNotificationContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AcknowledgeOfferNotificationContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAcknowledgeOfferNotificationContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AcknowledgeOfferNotificationContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AcknowledgeOfferNotificationContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
