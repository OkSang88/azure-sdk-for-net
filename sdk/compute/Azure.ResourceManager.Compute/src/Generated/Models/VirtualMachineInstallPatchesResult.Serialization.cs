// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class VirtualMachineInstallPatchesResult : IUtf8JsonSerializable, IJsonModel<VirtualMachineInstallPatchesResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VirtualMachineInstallPatchesResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<VirtualMachineInstallPatchesResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineInstallPatchesResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VirtualMachineInstallPatchesResult)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Status.HasValue)
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (options.Format != "W" && InstallationActivityId != null)
            {
                writer.WritePropertyName("installationActivityId"u8);
                writer.WriteStringValue(InstallationActivityId);
            }
            if (options.Format != "W" && RebootStatus.HasValue)
            {
                writer.WritePropertyName("rebootStatus"u8);
                writer.WriteStringValue(RebootStatus.Value.ToString());
            }
            if (options.Format != "W" && MaintenanceWindowExceeded.HasValue)
            {
                writer.WritePropertyName("maintenanceWindowExceeded"u8);
                writer.WriteBooleanValue(MaintenanceWindowExceeded.Value);
            }
            if (options.Format != "W" && ExcludedPatchCount.HasValue)
            {
                writer.WritePropertyName("excludedPatchCount"u8);
                writer.WriteNumberValue(ExcludedPatchCount.Value);
            }
            if (options.Format != "W" && NotSelectedPatchCount.HasValue)
            {
                writer.WritePropertyName("notSelectedPatchCount"u8);
                writer.WriteNumberValue(NotSelectedPatchCount.Value);
            }
            if (options.Format != "W" && PendingPatchCount.HasValue)
            {
                writer.WritePropertyName("pendingPatchCount"u8);
                writer.WriteNumberValue(PendingPatchCount.Value);
            }
            if (options.Format != "W" && InstalledPatchCount.HasValue)
            {
                writer.WritePropertyName("installedPatchCount"u8);
                writer.WriteNumberValue(InstalledPatchCount.Value);
            }
            if (options.Format != "W" && FailedPatchCount.HasValue)
            {
                writer.WritePropertyName("failedPatchCount"u8);
                writer.WriteNumberValue(FailedPatchCount.Value);
            }
            if (options.Format != "W" && !(Patches is ChangeTrackingList<PatchInstallationDetail> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("patches"u8);
                writer.WriteStartArray();
                foreach (var item in Patches)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && StartOn.HasValue)
            {
                writer.WritePropertyName("startDateTime"u8);
                writer.WriteStringValue(StartOn.Value, "O");
            }
            if (options.Format != "W" && Error != null)
            {
                writer.WritePropertyName("error"u8);
                writer.WriteObjectValue(Error);
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

        VirtualMachineInstallPatchesResult IJsonModel<VirtualMachineInstallPatchesResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineInstallPatchesResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VirtualMachineInstallPatchesResult)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVirtualMachineInstallPatchesResult(document.RootElement, options);
        }

        internal static VirtualMachineInstallPatchesResult DeserializeVirtualMachineInstallPatchesResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            PatchOperationStatus? status = default;
            string installationActivityId = default;
            VmGuestPatchRebootStatus? rebootStatus = default;
            bool? maintenanceWindowExceeded = default;
            int? excludedPatchCount = default;
            int? notSelectedPatchCount = default;
            int? pendingPatchCount = default;
            int? installedPatchCount = default;
            int? failedPatchCount = default;
            IReadOnlyList<PatchInstallationDetail> patches = default;
            DateTimeOffset? startDateTime = default;
            ComputeApiError error = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new PatchOperationStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("installationActivityId"u8))
                {
                    installationActivityId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("rebootStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rebootStatus = new VmGuestPatchRebootStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("maintenanceWindowExceeded"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maintenanceWindowExceeded = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("excludedPatchCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    excludedPatchCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("notSelectedPatchCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    notSelectedPatchCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("pendingPatchCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    pendingPatchCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("installedPatchCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    installedPatchCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("failedPatchCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    failedPatchCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("patches"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PatchInstallationDetail> array = new List<PatchInstallationDetail>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PatchInstallationDetail.DeserializePatchInstallationDetail(item, options));
                    }
                    patches = array;
                    continue;
                }
                if (property.NameEquals("startDateTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("error"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    error = ComputeApiError.DeserializeComputeApiError(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new VirtualMachineInstallPatchesResult(
                status,
                installationActivityId,
                rebootStatus,
                maintenanceWindowExceeded,
                excludedPatchCount,
                notSelectedPatchCount,
                pendingPatchCount,
                installedPatchCount,
                failedPatchCount,
                patches ?? new ChangeTrackingList<PatchInstallationDetail>(),
                startDateTime,
                error,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<VirtualMachineInstallPatchesResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineInstallPatchesResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(VirtualMachineInstallPatchesResult)} does not support '{options.Format}' format.");
            }
        }

        VirtualMachineInstallPatchesResult IPersistableModel<VirtualMachineInstallPatchesResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineInstallPatchesResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVirtualMachineInstallPatchesResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VirtualMachineInstallPatchesResult)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<VirtualMachineInstallPatchesResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
