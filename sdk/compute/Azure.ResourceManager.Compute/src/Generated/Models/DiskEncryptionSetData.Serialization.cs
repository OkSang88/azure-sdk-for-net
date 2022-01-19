// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Compute.Models;

namespace Azure.ResourceManager.Compute
{
    public partial class DiskEncryptionSetData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity");
                writer.WriteObjectValue(Identity);
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
            if (Optional.IsDefined(EncryptionType))
            {
                writer.WritePropertyName("encryptionType");
                writer.WriteStringValue(EncryptionType.Value.ToString());
            }
            if (Optional.IsDefined(ActiveKey))
            {
                writer.WritePropertyName("activeKey");
                writer.WriteObjectValue(ActiveKey);
            }
            if (Optional.IsDefined(RotationToLatestKeyVersionEnabled))
            {
                writer.WritePropertyName("rotationToLatestKeyVersionEnabled");
                writer.WriteBooleanValue(RotationToLatestKeyVersionEnabled.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static DiskEncryptionSetData DeserializeDiskEncryptionSetData(JsonElement element)
        {
            Optional<EncryptionSetIdentity> identity = default;
            IDictionary<string, string> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<DiskEncryptionSetType> encryptionType = default;
            Optional<KeyForDiskEncryptionSet> activeKey = default;
            Optional<IReadOnlyList<KeyForDiskEncryptionSet>> previousKeys = default;
            Optional<string> provisioningState = default;
            Optional<bool> rotationToLatestKeyVersionEnabled = default;
            Optional<DateTimeOffset> lastKeyRotationTimestamp = default;
            Optional<ApiError> autoKeyRotationError = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("identity"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    identity = EncryptionSetIdentity.DeserializeEncryptionSetIdentity(property.Value);
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
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("encryptionType"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            encryptionType = new DiskEncryptionSetType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("activeKey"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            activeKey = KeyForDiskEncryptionSet.DeserializeKeyForDiskEncryptionSet(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("previousKeys"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<KeyForDiskEncryptionSet> array = new List<KeyForDiskEncryptionSet>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(KeyForDiskEncryptionSet.DeserializeKeyForDiskEncryptionSet(item));
                            }
                            previousKeys = array;
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("rotationToLatestKeyVersionEnabled"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            rotationToLatestKeyVersionEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("lastKeyRotationTimestamp"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            lastKeyRotationTimestamp = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("autoKeyRotationError"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            autoKeyRotationError = ApiError.DeserializeApiError(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new DiskEncryptionSetData(id, name, type, tags, location, identity.Value, Optional.ToNullable(encryptionType), activeKey.Value, Optional.ToList(previousKeys), provisioningState.Value, Optional.ToNullable(rotationToLatestKeyVersionEnabled), Optional.ToNullable(lastKeyRotationTimestamp), autoKeyRotationError.Value);
        }
    }
}
