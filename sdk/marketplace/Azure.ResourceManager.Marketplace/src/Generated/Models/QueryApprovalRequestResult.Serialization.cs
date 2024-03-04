// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.ResourceManager.Marketplace.Models
{
    public partial class QueryApprovalRequestResult : IUtf8JsonSerializable, IJsonModel<QueryApprovalRequestResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<QueryApprovalRequestResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<QueryApprovalRequestResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<QueryApprovalRequestResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(QueryApprovalRequestResult)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (UniqueOfferId != null)
            {
                writer.WritePropertyName("uniqueOfferId"u8);
                writer.WriteStringValue(UniqueOfferId);
            }
            if (!(PlansDetails is ChangeTrackingDictionary<string, PrivateStorePlanDetails> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("plansDetails"u8);
                writer.WriteStartObject();
                foreach (var item in PlansDetails)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (ETag.HasValue)
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            if (MessageCode.HasValue)
            {
                writer.WritePropertyName("messageCode"u8);
                writer.WriteNumberValue(MessageCode.Value);
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

        QueryApprovalRequestResult IJsonModel<QueryApprovalRequestResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<QueryApprovalRequestResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(QueryApprovalRequestResult)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeQueryApprovalRequestResult(document.RootElement, options);
        }

        internal static QueryApprovalRequestResult DeserializeQueryApprovalRequestResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string uniqueOfferId = default;
            IReadOnlyDictionary<string, PrivateStorePlanDetails> plansDetails = default;
            ETag? etag = default;
            long? messageCode = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("uniqueOfferId"u8))
                {
                    uniqueOfferId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("plansDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, PrivateStorePlanDetails> dictionary = new Dictionary<string, PrivateStorePlanDetails>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, PrivateStorePlanDetails.DeserializePrivateStorePlanDetails(property0.Value, options));
                    }
                    plansDetails = dictionary;
                    continue;
                }
                if (property.NameEquals("etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("messageCode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    messageCode = property.Value.GetInt64();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new QueryApprovalRequestResult(uniqueOfferId, plansDetails ?? new ChangeTrackingDictionary<string, PrivateStorePlanDetails>(), etag, messageCode, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<QueryApprovalRequestResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<QueryApprovalRequestResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(QueryApprovalRequestResult)} does not support '{options.Format}' format.");
            }
        }

        QueryApprovalRequestResult IPersistableModel<QueryApprovalRequestResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<QueryApprovalRequestResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeQueryApprovalRequestResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(QueryApprovalRequestResult)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<QueryApprovalRequestResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
