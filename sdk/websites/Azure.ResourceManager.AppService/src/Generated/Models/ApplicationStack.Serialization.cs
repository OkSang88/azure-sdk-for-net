// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class ApplicationStack : IUtf8JsonSerializable, IJsonModel<ApplicationStack>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ApplicationStack>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ApplicationStack>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationStack>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApplicationStack)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Name != null)
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Display != null)
            {
                writer.WritePropertyName("display"u8);
                writer.WriteStringValue(Display);
            }
            if (Dependency != null)
            {
                writer.WritePropertyName("dependency"u8);
                writer.WriteStringValue(Dependency);
            }
            if (!(MajorVersions is ChangeTrackingList<StackMajorVersion> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("majorVersions"u8);
                writer.WriteStartArray();
                foreach (var item in MajorVersions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(Frameworks is ChangeTrackingList<ApplicationStack> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("frameworks"u8);
                writer.WriteStartArray();
                foreach (var item in Frameworks)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(IsDeprecated is ChangeTrackingList<ApplicationStack> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("isDeprecated"u8);
                writer.WriteStartArray();
                foreach (var item in IsDeprecated)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        ApplicationStack IJsonModel<ApplicationStack>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationStack>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApplicationStack)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeApplicationStack(document.RootElement, options);
        }

        internal static ApplicationStack DeserializeApplicationStack(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            string display = default;
            string dependency = default;
            IList<StackMajorVersion> majorVersions = default;
            IList<ApplicationStack> frameworks = default;
            IList<ApplicationStack> isDeprecated = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("display"u8))
                {
                    display = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dependency"u8))
                {
                    dependency = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("majorVersions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<StackMajorVersion> array = new List<StackMajorVersion>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(StackMajorVersion.DeserializeStackMajorVersion(item, options));
                    }
                    majorVersions = array;
                    continue;
                }
                if (property.NameEquals("frameworks"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ApplicationStack> array = new List<ApplicationStack>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DeserializeApplicationStack(item, options));
                    }
                    frameworks = array;
                    continue;
                }
                if (property.NameEquals("isDeprecated"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ApplicationStack> array = new List<ApplicationStack>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DeserializeApplicationStack(item, options));
                    }
                    isDeprecated = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ApplicationStack(
                name,
                display,
                dependency,
                majorVersions ?? new ChangeTrackingList<StackMajorVersion>(),
                frameworks ?? new ChangeTrackingList<ApplicationStack>(),
                isDeprecated ?? new ChangeTrackingList<ApplicationStack>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ApplicationStack>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationStack>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ApplicationStack)} does not support '{options.Format}' format.");
            }
        }

        ApplicationStack IPersistableModel<ApplicationStack>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationStack>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeApplicationStack(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ApplicationStack)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ApplicationStack>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
