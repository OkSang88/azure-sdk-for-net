// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Hci.Models
{
    public partial class VirtualMachineInstancePropertiesStorageProfile : IUtf8JsonSerializable, IJsonModel<VirtualMachineInstancePropertiesStorageProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VirtualMachineInstancePropertiesStorageProfile>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<VirtualMachineInstancePropertiesStorageProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineInstancePropertiesStorageProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VirtualMachineInstancePropertiesStorageProfile)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (!(DataDisks is ChangeTrackingList<WritableSubResource> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("dataDisks"u8);
                writer.WriteStartArray();
                foreach (var item in DataDisks)
                {
                    JsonSerializer.Serialize(writer, item);
                }
                writer.WriteEndArray();
            }
            if (ImageReference != null)
            {
                writer.WritePropertyName("imageReference"u8);
                JsonSerializer.Serialize(writer, ImageReference);
            }
            if (OSDisk != null)
            {
                writer.WritePropertyName("osDisk"u8);
                writer.WriteObjectValue(OSDisk);
            }
            if (VmConfigStoragePathId != null)
            {
                writer.WritePropertyName("vmConfigStoragePathId"u8);
                writer.WriteStringValue(VmConfigStoragePathId);
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

        VirtualMachineInstancePropertiesStorageProfile IJsonModel<VirtualMachineInstancePropertiesStorageProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineInstancePropertiesStorageProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VirtualMachineInstancePropertiesStorageProfile)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVirtualMachineInstancePropertiesStorageProfile(document.RootElement, options);
        }

        internal static VirtualMachineInstancePropertiesStorageProfile DeserializeVirtualMachineInstancePropertiesStorageProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<WritableSubResource> dataDisks = default;
            WritableSubResource imageReference = default;
            VirtualMachineInstancePropertiesStorageProfileOSDisk osDisk = default;
            ResourceIdentifier vmConfigStoragePathId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dataDisks"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<WritableSubResource> array = new List<WritableSubResource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(JsonSerializer.Deserialize<WritableSubResource>(item.GetRawText()));
                    }
                    dataDisks = array;
                    continue;
                }
                if (property.NameEquals("imageReference"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    imageReference = JsonSerializer.Deserialize<WritableSubResource>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("osDisk"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    osDisk = VirtualMachineInstancePropertiesStorageProfileOSDisk.DeserializeVirtualMachineInstancePropertiesStorageProfileOSDisk(property.Value, options);
                    continue;
                }
                if (property.NameEquals("vmConfigStoragePathId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    vmConfigStoragePathId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new VirtualMachineInstancePropertiesStorageProfile(dataDisks ?? new ChangeTrackingList<WritableSubResource>(), imageReference, osDisk, vmConfigStoragePathId, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<VirtualMachineInstancePropertiesStorageProfile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineInstancePropertiesStorageProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(VirtualMachineInstancePropertiesStorageProfile)} does not support '{options.Format}' format.");
            }
        }

        VirtualMachineInstancePropertiesStorageProfile IPersistableModel<VirtualMachineInstancePropertiesStorageProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineInstancePropertiesStorageProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVirtualMachineInstancePropertiesStorageProfile(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VirtualMachineInstancePropertiesStorageProfile)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<VirtualMachineInstancePropertiesStorageProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
