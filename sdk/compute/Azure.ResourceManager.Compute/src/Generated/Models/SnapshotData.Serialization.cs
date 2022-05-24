// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Compute.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Compute
{
    public partial class SnapshotData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku");
                writer.WriteObjectValue(Sku);
            }
            if (Optional.IsDefined(ExtendedLocation))
            {
                writer.WritePropertyName("extendedLocation");
                writer.WriteObjectValue(ExtendedLocation);
            }
            writer.WritePropertyName("tags");
            writer.WriteStartObject();
            foreach (var item in Tags)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteStringValue(item.Value);
            }
            writer.WriteEndObject();
            writer.WritePropertyName("location");
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(OSType))
            {
                writer.WritePropertyName("osType");
                writer.WriteStringValue(OSType.Value.ToSerialString());
            }
            if (Optional.IsDefined(HyperVGeneration))
            {
                writer.WritePropertyName("hyperVGeneration");
                writer.WriteStringValue(HyperVGeneration.Value.ToString());
            }
            if (Optional.IsDefined(PurchasePlan))
            {
                writer.WritePropertyName("purchasePlan");
                writer.WriteObjectValue(PurchasePlan);
            }
            if (Optional.IsDefined(SupportedCapabilities))
            {
                writer.WritePropertyName("supportedCapabilities");
                writer.WriteObjectValue(SupportedCapabilities);
            }
            if (Optional.IsDefined(CreationData))
            {
                writer.WritePropertyName("creationData");
                writer.WriteObjectValue(CreationData);
            }
            if (Optional.IsDefined(DiskSizeGB))
            {
                writer.WritePropertyName("diskSizeGB");
                writer.WriteNumberValue(DiskSizeGB.Value);
            }
            if (Optional.IsDefined(EncryptionSettingGroup))
            {
                writer.WritePropertyName("encryptionSettingsCollection");
                writer.WriteObjectValue(EncryptionSettingGroup);
            }
            if (Optional.IsDefined(Incremental))
            {
                writer.WritePropertyName("incremental");
                writer.WriteBooleanValue(Incremental.Value);
            }
            if (Optional.IsDefined(Encryption))
            {
                writer.WritePropertyName("encryption");
                writer.WriteObjectValue(Encryption);
            }
            if (Optional.IsDefined(NetworkAccessPolicy))
            {
                writer.WritePropertyName("networkAccessPolicy");
                writer.WriteStringValue(NetworkAccessPolicy.Value.ToString());
            }
            if (Optional.IsDefined(DiskAccessId))
            {
                writer.WritePropertyName("diskAccessId");
                writer.WriteStringValue(DiskAccessId);
            }
            if (Optional.IsDefined(SecurityProfile))
            {
                writer.WritePropertyName("securityProfile");
                writer.WriteObjectValue(SecurityProfile);
            }
            if (Optional.IsDefined(SupportsHibernation))
            {
                writer.WritePropertyName("supportsHibernation");
                writer.WriteBooleanValue(SupportsHibernation.Value);
            }
            if (Optional.IsDefined(PublicNetworkAccess))
            {
                writer.WritePropertyName("publicNetworkAccess");
                writer.WriteStringValue(PublicNetworkAccess.Value.ToString());
            }
            if (Optional.IsDefined(CompletionPercent))
            {
                writer.WritePropertyName("completionPercent");
                writer.WriteNumberValue(CompletionPercent.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static SnapshotData DeserializeSnapshotData(JsonElement element)
        {
            Optional<string> managedBy = default;
            Optional<SnapshotSku> sku = default;
            Optional<ExtendedLocation> extendedLocation = default;
            IDictionary<string, string> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            Optional<DateTimeOffset> timeCreated = default;
            Optional<OperatingSystemTypes> osType = default;
            Optional<HyperVGeneration> hyperVGeneration = default;
            Optional<DiskPurchasePlan> purchasePlan = default;
            Optional<SupportedCapabilities> supportedCapabilities = default;
            Optional<CreationData> creationData = default;
            Optional<int> diskSizeGB = default;
            Optional<long> diskSizeBytes = default;
            Optional<DiskState> diskState = default;
            Optional<string> uniqueId = default;
            Optional<EncryptionSettingGroup> encryptionSettingsCollection = default;
            Optional<string> provisioningState = default;
            Optional<bool> incremental = default;
            Optional<DiskEncryption> encryption = default;
            Optional<NetworkAccessPolicy> networkAccessPolicy = default;
            Optional<string> diskAccessId = default;
            Optional<DiskSecurityProfile> securityProfile = default;
            Optional<bool> supportsHibernation = default;
            Optional<PublicNetworkAccess> publicNetworkAccess = default;
            Optional<float> completionPercent = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("managedBy"))
                {
                    managedBy = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sku"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sku = SnapshotSku.DeserializeSnapshotSku(property.Value);
                    continue;
                }
                if (property.NameEquals("extendedLocation"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    extendedLocation = ExtendedLocation.DeserializeExtendedLocation(property.Value);
                    continue;
                }
                if (property.NameEquals("tags"))
                {
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    location = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("timeCreated"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            timeCreated = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("osType"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            osType = property0.Value.GetString().ToOperatingSystemTypes();
                            continue;
                        }
                        if (property0.NameEquals("hyperVGeneration"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            hyperVGeneration = new HyperVGeneration(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("purchasePlan"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            purchasePlan = DiskPurchasePlan.DeserializeDiskPurchasePlan(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("supportedCapabilities"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            supportedCapabilities = SupportedCapabilities.DeserializeSupportedCapabilities(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("creationData"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            creationData = CreationData.DeserializeCreationData(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("diskSizeGB"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            diskSizeGB = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("diskSizeBytes"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            diskSizeBytes = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("diskState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            diskState = new DiskState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("uniqueId"))
                        {
                            uniqueId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("encryptionSettingsCollection"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            encryptionSettingsCollection = EncryptionSettingGroup.DeserializeEncryptionSettingGroup(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("incremental"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            incremental = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("encryption"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            encryption = DiskEncryption.DeserializeDiskEncryption(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("networkAccessPolicy"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            networkAccessPolicy = new NetworkAccessPolicy(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("diskAccessId"))
                        {
                            diskAccessId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("securityProfile"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            securityProfile = DiskSecurityProfile.DeserializeDiskSecurityProfile(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("supportsHibernation"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            supportsHibernation = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("publicNetworkAccess"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            publicNetworkAccess = new PublicNetworkAccess(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("completionPercent"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            completionPercent = property0.Value.GetSingle();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new SnapshotData(id, name, type, systemData, tags, location, managedBy.Value, sku.Value, extendedLocation.Value, Optional.ToNullable(timeCreated), Optional.ToNullable(osType), Optional.ToNullable(hyperVGeneration), purchasePlan.Value, supportedCapabilities.Value, creationData.Value, Optional.ToNullable(diskSizeGB), Optional.ToNullable(diskSizeBytes), Optional.ToNullable(diskState), uniqueId.Value, encryptionSettingsCollection.Value, provisioningState.Value, Optional.ToNullable(incremental), encryption.Value, Optional.ToNullable(networkAccessPolicy), diskAccessId.Value, securityProfile.Value, Optional.ToNullable(supportsHibernation), Optional.ToNullable(publicNetworkAccess), Optional.ToNullable(completionPercent));
        }
    }
}
