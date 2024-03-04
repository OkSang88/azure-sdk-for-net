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

namespace Azure.Analytics.Defender.Easm
{
    public partial class HostCore : IUtf8JsonSerializable, IJsonModel<HostCore>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HostCore>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<HostCore>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HostCore>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HostCore)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Host != null)
            {
                writer.WritePropertyName("host"u8);
                writer.WriteStringValue(Host);
            }
            if (Domain != null)
            {
                writer.WritePropertyName("domain"u8);
                writer.WriteStringValue(Domain);
            }
            if (FirstSeen.HasValue)
            {
                writer.WritePropertyName("firstSeen"u8);
                writer.WriteStringValue(FirstSeen.Value, "O");
            }
            if (LastSeen.HasValue)
            {
                writer.WritePropertyName("lastSeen"u8);
                writer.WriteStringValue(LastSeen.Value, "O");
            }
            if (Count.HasValue)
            {
                writer.WritePropertyName("count"u8);
                writer.WriteNumberValue(Count.Value);
            }
            if (BlacklistCauseFirstSeen.HasValue)
            {
                writer.WritePropertyName("blacklistCauseFirstSeen"u8);
                writer.WriteStringValue(BlacklistCauseFirstSeen.Value, "O");
            }
            if (BlacklistCauseLastSeen.HasValue)
            {
                writer.WritePropertyName("blacklistCauseLastSeen"u8);
                writer.WriteStringValue(BlacklistCauseLastSeen.Value, "O");
            }
            if (BlacklistCauseCount.HasValue)
            {
                writer.WritePropertyName("blacklistCauseCount"u8);
                writer.WriteNumberValue(BlacklistCauseCount.Value);
            }
            if (BlacklistResourceFirstSeen.HasValue)
            {
                writer.WritePropertyName("blacklistResourceFirstSeen"u8);
                writer.WriteStringValue(BlacklistResourceFirstSeen.Value, "O");
            }
            if (BlacklistResourceLastSeen.HasValue)
            {
                writer.WritePropertyName("blacklistResourceLastSeen"u8);
                writer.WriteStringValue(BlacklistResourceLastSeen.Value, "O");
            }
            if (BlacklistResourceCount.HasValue)
            {
                writer.WritePropertyName("blacklistResourceCount"u8);
                writer.WriteNumberValue(BlacklistResourceCount.Value);
            }
            if (BlacklistSequenceFirstSeen.HasValue)
            {
                writer.WritePropertyName("blacklistSequenceFirstSeen"u8);
                writer.WriteStringValue(BlacklistSequenceFirstSeen.Value, "O");
            }
            if (BlacklistSequenceLastSeen.HasValue)
            {
                writer.WritePropertyName("blacklistSequenceLastSeen"u8);
                writer.WriteStringValue(BlacklistSequenceLastSeen.Value, "O");
            }
            if (BlacklistSequenceCount.HasValue)
            {
                writer.WritePropertyName("blacklistSequenceCount"u8);
                writer.WriteNumberValue(BlacklistSequenceCount.Value);
            }
            if (PhishCauseCount.HasValue)
            {
                writer.WritePropertyName("phishCauseCount"u8);
                writer.WriteNumberValue(PhishCauseCount.Value);
            }
            if (MalwareCauseCount.HasValue)
            {
                writer.WritePropertyName("malwareCauseCount"u8);
                writer.WriteNumberValue(MalwareCauseCount.Value);
            }
            if (SpamCauseCount.HasValue)
            {
                writer.WritePropertyName("spamCauseCount"u8);
                writer.WriteNumberValue(SpamCauseCount.Value);
            }
            if (ScamCauseCount.HasValue)
            {
                writer.WritePropertyName("scamCauseCount"u8);
                writer.WriteNumberValue(ScamCauseCount.Value);
            }
            if (PhishResourceCount.HasValue)
            {
                writer.WritePropertyName("phishResourceCount"u8);
                writer.WriteNumberValue(PhishResourceCount.Value);
            }
            if (MalwareResourceCount.HasValue)
            {
                writer.WritePropertyName("malwareResourceCount"u8);
                writer.WriteNumberValue(MalwareResourceCount.Value);
            }
            if (SpamResourceCount.HasValue)
            {
                writer.WritePropertyName("spamResourceCount"u8);
                writer.WriteNumberValue(SpamResourceCount.Value);
            }
            if (ScamResourceCount.HasValue)
            {
                writer.WritePropertyName("scamResourceCount"u8);
                writer.WriteNumberValue(ScamResourceCount.Value);
            }
            if (PhishSequenceCount.HasValue)
            {
                writer.WritePropertyName("phishSequenceCount"u8);
                writer.WriteNumberValue(PhishSequenceCount.Value);
            }
            if (MalwareSequenceCount.HasValue)
            {
                writer.WritePropertyName("malwareSequenceCount"u8);
                writer.WriteNumberValue(MalwareSequenceCount.Value);
            }
            if (SpamSequenceCount.HasValue)
            {
                writer.WritePropertyName("spamSequenceCount"u8);
                writer.WriteNumberValue(SpamSequenceCount.Value);
            }
            if (ScamSequenceCount.HasValue)
            {
                writer.WritePropertyName("scamSequenceCount"u8);
                writer.WriteNumberValue(ScamSequenceCount.Value);
            }
            if (AlexaRank.HasValue)
            {
                writer.WritePropertyName("alexaRank"u8);
                writer.WriteNumberValue(AlexaRank.Value);
            }
            if (HostReputationScore.HasValue)
            {
                writer.WritePropertyName("hostReputationScore"u8);
                writer.WriteNumberValue(HostReputationScore.Value);
            }
            if (HostPhishReputationScore.HasValue)
            {
                writer.WritePropertyName("hostPhishReputationScore"u8);
                writer.WriteNumberValue(HostPhishReputationScore.Value);
            }
            if (HostMalwareReputationScore.HasValue)
            {
                writer.WritePropertyName("hostMalwareReputationScore"u8);
                writer.WriteNumberValue(HostMalwareReputationScore.Value);
            }
            if (HostSpamReputationScore.HasValue)
            {
                writer.WritePropertyName("hostSpamReputationScore"u8);
                writer.WriteNumberValue(HostSpamReputationScore.Value);
            }
            if (HostScamReputationScore.HasValue)
            {
                writer.WritePropertyName("hostScamReputationScore"u8);
                writer.WriteNumberValue(HostScamReputationScore.Value);
            }
            if (DomainReputationScore.HasValue)
            {
                writer.WritePropertyName("domainReputationScore"u8);
                writer.WriteNumberValue(DomainReputationScore.Value);
            }
            if (DomainPhishReputationScore.HasValue)
            {
                writer.WritePropertyName("domainPhishReputationScore"u8);
                writer.WriteNumberValue(DomainPhishReputationScore.Value);
            }
            if (DomainMalwareReputationScore.HasValue)
            {
                writer.WritePropertyName("domainMalwareReputationScore"u8);
                writer.WriteNumberValue(DomainMalwareReputationScore.Value);
            }
            if (DomainSpamReputationScore.HasValue)
            {
                writer.WritePropertyName("domainSpamReputationScore"u8);
                writer.WriteNumberValue(DomainSpamReputationScore.Value);
            }
            if (DomainScamReputationScore.HasValue)
            {
                writer.WritePropertyName("domainScamReputationScore"u8);
                writer.WriteNumberValue(DomainScamReputationScore.Value);
            }
            if (Uuid != null)
            {
                writer.WritePropertyName("uuid"u8);
                writer.WriteStringValue(Uuid);
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

        HostCore IJsonModel<HostCore>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HostCore>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HostCore)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHostCore(document.RootElement, options);
        }

        internal static HostCore DeserializeHostCore(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string host = default;
            string domain = default;
            DateTimeOffset? firstSeen = default;
            DateTimeOffset? lastSeen = default;
            long? count = default;
            DateTimeOffset? blacklistCauseFirstSeen = default;
            DateTimeOffset? blacklistCauseLastSeen = default;
            long? blacklistCauseCount = default;
            DateTimeOffset? blacklistResourceFirstSeen = default;
            DateTimeOffset? blacklistResourceLastSeen = default;
            long? blacklistResourceCount = default;
            DateTimeOffset? blacklistSequenceFirstSeen = default;
            DateTimeOffset? blacklistSequenceLastSeen = default;
            long? blacklistSequenceCount = default;
            long? phishCauseCount = default;
            long? malwareCauseCount = default;
            long? spamCauseCount = default;
            long? scamCauseCount = default;
            long? phishResourceCount = default;
            long? malwareResourceCount = default;
            long? spamResourceCount = default;
            long? scamResourceCount = default;
            long? phishSequenceCount = default;
            long? malwareSequenceCount = default;
            long? spamSequenceCount = default;
            long? scamSequenceCount = default;
            int? alexaRank = default;
            int? hostReputationScore = default;
            int? hostPhishReputationScore = default;
            int? hostMalwareReputationScore = default;
            int? hostSpamReputationScore = default;
            int? hostScamReputationScore = default;
            int? domainReputationScore = default;
            int? domainPhishReputationScore = default;
            int? domainMalwareReputationScore = default;
            int? domainSpamReputationScore = default;
            int? domainScamReputationScore = default;
            string uuid = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("host"u8))
                {
                    host = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("domain"u8))
                {
                    domain = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("firstSeen"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    firstSeen = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastSeen"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastSeen = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("count"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    count = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("blacklistCauseFirstSeen"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    blacklistCauseFirstSeen = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("blacklistCauseLastSeen"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    blacklistCauseLastSeen = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("blacklistCauseCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    blacklistCauseCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("blacklistResourceFirstSeen"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    blacklistResourceFirstSeen = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("blacklistResourceLastSeen"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    blacklistResourceLastSeen = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("blacklistResourceCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    blacklistResourceCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("blacklistSequenceFirstSeen"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    blacklistSequenceFirstSeen = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("blacklistSequenceLastSeen"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    blacklistSequenceLastSeen = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("blacklistSequenceCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    blacklistSequenceCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("phishCauseCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    phishCauseCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("malwareCauseCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    malwareCauseCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("spamCauseCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    spamCauseCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("scamCauseCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scamCauseCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("phishResourceCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    phishResourceCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("malwareResourceCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    malwareResourceCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("spamResourceCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    spamResourceCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("scamResourceCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scamResourceCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("phishSequenceCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    phishSequenceCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("malwareSequenceCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    malwareSequenceCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("spamSequenceCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    spamSequenceCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("scamSequenceCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scamSequenceCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("alexaRank"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    alexaRank = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("hostReputationScore"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    hostReputationScore = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("hostPhishReputationScore"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    hostPhishReputationScore = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("hostMalwareReputationScore"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    hostMalwareReputationScore = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("hostSpamReputationScore"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    hostSpamReputationScore = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("hostScamReputationScore"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    hostScamReputationScore = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("domainReputationScore"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    domainReputationScore = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("domainPhishReputationScore"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    domainPhishReputationScore = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("domainMalwareReputationScore"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    domainMalwareReputationScore = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("domainSpamReputationScore"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    domainSpamReputationScore = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("domainScamReputationScore"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    domainScamReputationScore = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("uuid"u8))
                {
                    uuid = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new HostCore(
                host,
                domain,
                firstSeen,
                lastSeen,
                count,
                blacklistCauseFirstSeen,
                blacklistCauseLastSeen,
                blacklistCauseCount,
                blacklistResourceFirstSeen,
                blacklistResourceLastSeen,
                blacklistResourceCount,
                blacklistSequenceFirstSeen,
                blacklistSequenceLastSeen,
                blacklistSequenceCount,
                phishCauseCount,
                malwareCauseCount,
                spamCauseCount,
                scamCauseCount,
                phishResourceCount,
                malwareResourceCount,
                spamResourceCount,
                scamResourceCount,
                phishSequenceCount,
                malwareSequenceCount,
                spamSequenceCount,
                scamSequenceCount,
                alexaRank,
                hostReputationScore,
                hostPhishReputationScore,
                hostMalwareReputationScore,
                hostSpamReputationScore,
                hostScamReputationScore,
                domainReputationScore,
                domainPhishReputationScore,
                domainMalwareReputationScore,
                domainSpamReputationScore,
                domainScamReputationScore,
                uuid,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<HostCore>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HostCore>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(HostCore)} does not support '{options.Format}' format.");
            }
        }

        HostCore IPersistableModel<HostCore>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HostCore>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeHostCore(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(HostCore)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<HostCore>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static HostCore FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeHostCore(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
