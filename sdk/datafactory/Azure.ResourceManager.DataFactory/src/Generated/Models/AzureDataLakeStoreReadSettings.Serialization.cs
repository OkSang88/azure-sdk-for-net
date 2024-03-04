// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class AzureDataLakeStoreReadSettings : IUtf8JsonSerializable, IJsonModel<AzureDataLakeStoreReadSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AzureDataLakeStoreReadSettings>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AzureDataLakeStoreReadSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureDataLakeStoreReadSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureDataLakeStoreReadSettings)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Recursive != null)
            {
                writer.WritePropertyName("recursive"u8);
                JsonSerializer.Serialize(writer, Recursive);
            }
            if (WildcardFolderPath != null)
            {
                writer.WritePropertyName("wildcardFolderPath"u8);
                JsonSerializer.Serialize(writer, WildcardFolderPath);
            }
            if (WildcardFileName != null)
            {
                writer.WritePropertyName("wildcardFileName"u8);
                JsonSerializer.Serialize(writer, WildcardFileName);
            }
            if (FileListPath != null)
            {
                writer.WritePropertyName("fileListPath"u8);
                JsonSerializer.Serialize(writer, FileListPath);
            }
            if (ListAfter != null)
            {
                writer.WritePropertyName("listAfter"u8);
                JsonSerializer.Serialize(writer, ListAfter);
            }
            if (ListBefore != null)
            {
                writer.WritePropertyName("listBefore"u8);
                JsonSerializer.Serialize(writer, ListBefore);
            }
            if (EnablePartitionDiscovery != null)
            {
                writer.WritePropertyName("enablePartitionDiscovery"u8);
                JsonSerializer.Serialize(writer, EnablePartitionDiscovery);
            }
            if (PartitionRootPath != null)
            {
                writer.WritePropertyName("partitionRootPath"u8);
                JsonSerializer.Serialize(writer, PartitionRootPath);
            }
            if (DeleteFilesAfterCompletion != null)
            {
                writer.WritePropertyName("deleteFilesAfterCompletion"u8);
                JsonSerializer.Serialize(writer, DeleteFilesAfterCompletion);
            }
            if (ModifiedDatetimeStart != null)
            {
                writer.WritePropertyName("modifiedDatetimeStart"u8);
                JsonSerializer.Serialize(writer, ModifiedDatetimeStart);
            }
            if (ModifiedDatetimeEnd != null)
            {
                writer.WritePropertyName("modifiedDatetimeEnd"u8);
                JsonSerializer.Serialize(writer, ModifiedDatetimeEnd);
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(StoreReadSettingsType);
            if (MaxConcurrentConnections != null)
            {
                writer.WritePropertyName("maxConcurrentConnections"u8);
                JsonSerializer.Serialize(writer, MaxConcurrentConnections);
            }
            if (DisableMetricsCollection != null)
            {
                writer.WritePropertyName("disableMetricsCollection"u8);
                JsonSerializer.Serialize(writer, DisableMetricsCollection);
            }
            foreach (var item in AdditionalProperties)
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
            writer.WriteEndObject();
        }

        AzureDataLakeStoreReadSettings IJsonModel<AzureDataLakeStoreReadSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureDataLakeStoreReadSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureDataLakeStoreReadSettings)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAzureDataLakeStoreReadSettings(document.RootElement, options);
        }

        internal static AzureDataLakeStoreReadSettings DeserializeAzureDataLakeStoreReadSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DataFactoryElement<bool> recursive = default;
            DataFactoryElement<string> wildcardFolderPath = default;
            DataFactoryElement<string> wildcardFileName = default;
            DataFactoryElement<string> fileListPath = default;
            DataFactoryElement<string> listAfter = default;
            DataFactoryElement<string> listBefore = default;
            DataFactoryElement<bool> enablePartitionDiscovery = default;
            DataFactoryElement<string> partitionRootPath = default;
            DataFactoryElement<bool> deleteFilesAfterCompletion = default;
            DataFactoryElement<string> modifiedDatetimeStart = default;
            DataFactoryElement<string> modifiedDatetimeEnd = default;
            string type = default;
            DataFactoryElement<int> maxConcurrentConnections = default;
            DataFactoryElement<bool> disableMetricsCollection = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("recursive"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recursive = JsonSerializer.Deserialize<DataFactoryElement<bool>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("wildcardFolderPath"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    wildcardFolderPath = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("wildcardFileName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    wildcardFileName = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("fileListPath"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fileListPath = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("listAfter"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    listAfter = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("listBefore"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    listBefore = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("enablePartitionDiscovery"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enablePartitionDiscovery = JsonSerializer.Deserialize<DataFactoryElement<bool>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("partitionRootPath"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    partitionRootPath = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("deleteFilesAfterCompletion"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deleteFilesAfterCompletion = JsonSerializer.Deserialize<DataFactoryElement<bool>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("modifiedDatetimeStart"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    modifiedDatetimeStart = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("modifiedDatetimeEnd"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    modifiedDatetimeEnd = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("maxConcurrentConnections"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxConcurrentConnections = JsonSerializer.Deserialize<DataFactoryElement<int>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("disableMetricsCollection"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    disableMetricsCollection = JsonSerializer.Deserialize<DataFactoryElement<bool>>(property.Value.GetRawText());
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new AzureDataLakeStoreReadSettings(
                type,
                maxConcurrentConnections,
                disableMetricsCollection,
                additionalProperties,
                recursive,
                wildcardFolderPath,
                wildcardFileName,
                fileListPath,
                listAfter,
                listBefore,
                enablePartitionDiscovery,
                partitionRootPath,
                deleteFilesAfterCompletion,
                modifiedDatetimeStart,
                modifiedDatetimeEnd);
        }

        BinaryData IPersistableModel<AzureDataLakeStoreReadSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureDataLakeStoreReadSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AzureDataLakeStoreReadSettings)} does not support '{options.Format}' format.");
            }
        }

        AzureDataLakeStoreReadSettings IPersistableModel<AzureDataLakeStoreReadSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureDataLakeStoreReadSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAzureDataLakeStoreReadSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AzureDataLakeStoreReadSettings)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AzureDataLakeStoreReadSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
