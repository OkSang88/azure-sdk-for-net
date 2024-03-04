// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.AI.OpenAI
{
    public partial class ChatCompletions : IUtf8JsonSerializable, IJsonModel<ChatCompletions>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ChatCompletions>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ChatCompletions>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ChatCompletions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ChatCompletions)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("id"u8);
            writer.WriteStringValue(Id);
            writer.WritePropertyName("created"u8);
            writer.WriteNumberValue(Created, "U");
            writer.WritePropertyName("choices"u8);
            writer.WriteStartArray();
            foreach (var item in Choices)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            if (!(PromptFilterResults is ChangeTrackingList<ContentFilterResultsForPrompt> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("prompt_filter_results"u8);
                writer.WriteStartArray();
                foreach (var item in PromptFilterResults)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (SystemFingerprint != null)
            {
                writer.WritePropertyName("system_fingerprint"u8);
                writer.WriteStringValue(SystemFingerprint);
            }
            writer.WritePropertyName("usage"u8);
            writer.WriteObjectValue(Usage);
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

        ChatCompletions IJsonModel<ChatCompletions>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ChatCompletions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ChatCompletions)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeChatCompletions(document.RootElement, options);
        }

        BinaryData IPersistableModel<ChatCompletions>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ChatCompletions>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ChatCompletions)} does not support '{options.Format}' format.");
            }
        }

        ChatCompletions IPersistableModel<ChatCompletions>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ChatCompletions>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeChatCompletions(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ChatCompletions)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ChatCompletions>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static ChatCompletions FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeChatCompletions(document.RootElement);
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
