// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Dns.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Dns
{
    public partial class DnsZoneData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(ZoneType))
            {
                writer.WritePropertyName("zoneType"u8);
                writer.WriteStringValue(ZoneType.Value.ToSerialString());
            }
            if (Optional.IsCollectionDefined(RegistrationVirtualNetworks))
            {
                writer.WritePropertyName("registrationVirtualNetworks"u8);
                writer.WriteStartArray();
                foreach (var item in RegistrationVirtualNetworks)
                {
                    JsonSerializer.Serialize(writer, item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ResolutionVirtualNetworks))
            {
                writer.WritePropertyName("resolutionVirtualNetworks"u8);
                writer.WriteStartArray();
                foreach (var item in ResolutionVirtualNetworks)
                {
                    JsonSerializer.Serialize(writer, item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static DnsZoneData DeserializeDnsZoneData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ETag> etag = default;
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<long> maxNumberOfRecordSets = default;
            Optional<long?> maxNumberOfRecordsPerRecordSet = default;
            Optional<long> numberOfRecordSets = default;
            Optional<IReadOnlyList<string>> nameServers = default;
            Optional<DnsZoneType> zoneType = default;
            Optional<IList<WritableSubResource>> registrationVirtualNetworks = default;
            Optional<IList<WritableSubResource>> resolutionVirtualNetworks = default;
            Optional<IReadOnlyList<SigningKey>> signingKeys = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("maxNumberOfRecordSets"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            maxNumberOfRecordSets = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("maxNumberOfRecordsPerRecordSet"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                maxNumberOfRecordsPerRecordSet = null;
                                continue;
                            }
                            maxNumberOfRecordsPerRecordSet = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("numberOfRecordSets"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            numberOfRecordSets = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("nameServers"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            nameServers = array;
                            continue;
                        }
                        if (property0.NameEquals("zoneType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            zoneType = property0.Value.GetString().ToDnsZoneType();
                            continue;
                        }
                        if (property0.NameEquals("registrationVirtualNetworks"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<WritableSubResource> array = new List<WritableSubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(JsonSerializer.Deserialize<WritableSubResource>(item.GetRawText()));
                            }
                            registrationVirtualNetworks = array;
                            continue;
                        }
                        if (property0.NameEquals("resolutionVirtualNetworks"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<WritableSubResource> array = new List<WritableSubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(JsonSerializer.Deserialize<WritableSubResource>(item.GetRawText()));
                            }
                            resolutionVirtualNetworks = array;
                            continue;
                        }
                        if (property0.NameEquals("signingKeys"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<SigningKey> array = new List<SigningKey>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(SigningKey.DeserializeSigningKey(item));
                            }
                            signingKeys = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new DnsZoneData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, Optional.ToNullable(etag), Optional.ToNullable(maxNumberOfRecordSets), Optional.ToNullable(maxNumberOfRecordsPerRecordSet), Optional.ToNullable(numberOfRecordSets), Optional.ToList(nameServers), Optional.ToNullable(zoneType), Optional.ToList(registrationVirtualNetworks), Optional.ToList(resolutionVirtualNetworks), Optional.ToList(signingKeys));
        }
    }
}
