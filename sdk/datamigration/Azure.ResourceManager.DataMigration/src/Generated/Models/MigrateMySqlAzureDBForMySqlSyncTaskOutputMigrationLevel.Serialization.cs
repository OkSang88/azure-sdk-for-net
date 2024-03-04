// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class MigrateMySqlAzureDBForMySqlSyncTaskOutputMigrationLevel : IUtf8JsonSerializable, IJsonModel<MigrateMySqlAzureDBForMySqlSyncTaskOutputMigrationLevel>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MigrateMySqlAzureDBForMySqlSyncTaskOutputMigrationLevel>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MigrateMySqlAzureDBForMySqlSyncTaskOutputMigrationLevel>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateMySqlAzureDBForMySqlSyncTaskOutputMigrationLevel>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MigrateMySqlAzureDBForMySqlSyncTaskOutputMigrationLevel)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && StartedOn.HasValue)
            {
                writer.WritePropertyName("startedOn"u8);
                writer.WriteStringValue(StartedOn.Value, "O");
            }
            if (options.Format != "W" && EndedOn.HasValue)
            {
                writer.WritePropertyName("endedOn"u8);
                writer.WriteStringValue(EndedOn.Value, "O");
            }
            if (options.Format != "W" && SourceServerVersion != null)
            {
                writer.WritePropertyName("sourceServerVersion"u8);
                writer.WriteStringValue(SourceServerVersion);
            }
            if (options.Format != "W" && SourceServer != null)
            {
                writer.WritePropertyName("sourceServer"u8);
                writer.WriteStringValue(SourceServer);
            }
            if (options.Format != "W" && TargetServerVersion != null)
            {
                writer.WritePropertyName("targetServerVersion"u8);
                writer.WriteStringValue(TargetServerVersion);
            }
            if (options.Format != "W" && TargetServer != null)
            {
                writer.WritePropertyName("targetServer"u8);
                writer.WriteStringValue(TargetServer);
            }
            if (options.Format != "W" && Id != null)
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            writer.WritePropertyName("resultType"u8);
            writer.WriteStringValue(ResultType);
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

        MigrateMySqlAzureDBForMySqlSyncTaskOutputMigrationLevel IJsonModel<MigrateMySqlAzureDBForMySqlSyncTaskOutputMigrationLevel>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateMySqlAzureDBForMySqlSyncTaskOutputMigrationLevel>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MigrateMySqlAzureDBForMySqlSyncTaskOutputMigrationLevel)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMigrateMySqlAzureDBForMySqlSyncTaskOutputMigrationLevel(document.RootElement, options);
        }

        internal static MigrateMySqlAzureDBForMySqlSyncTaskOutputMigrationLevel DeserializeMigrateMySqlAzureDBForMySqlSyncTaskOutputMigrationLevel(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DateTimeOffset? startedOn = default;
            DateTimeOffset? endedOn = default;
            string sourceServerVersion = default;
            string sourceServer = default;
            string targetServerVersion = default;
            string targetServer = default;
            string id = default;
            string resultType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("startedOn"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startedOn = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endedOn"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    endedOn = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("sourceServerVersion"u8))
                {
                    sourceServerVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceServer"u8))
                {
                    sourceServer = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetServerVersion"u8))
                {
                    targetServerVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetServer"u8))
                {
                    targetServer = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resultType"u8))
                {
                    resultType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MigrateMySqlAzureDBForMySqlSyncTaskOutputMigrationLevel(
                id,
                resultType,
                serializedAdditionalRawData,
                startedOn,
                endedOn,
                sourceServerVersion,
                sourceServer,
                targetServerVersion,
                targetServer);
        }

        BinaryData IPersistableModel<MigrateMySqlAzureDBForMySqlSyncTaskOutputMigrationLevel>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateMySqlAzureDBForMySqlSyncTaskOutputMigrationLevel>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MigrateMySqlAzureDBForMySqlSyncTaskOutputMigrationLevel)} does not support '{options.Format}' format.");
            }
        }

        MigrateMySqlAzureDBForMySqlSyncTaskOutputMigrationLevel IPersistableModel<MigrateMySqlAzureDBForMySqlSyncTaskOutputMigrationLevel>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateMySqlAzureDBForMySqlSyncTaskOutputMigrationLevel>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMigrateMySqlAzureDBForMySqlSyncTaskOutputMigrationLevel(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MigrateMySqlAzureDBForMySqlSyncTaskOutputMigrationLevel)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MigrateMySqlAzureDBForMySqlSyncTaskOutputMigrationLevel>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
