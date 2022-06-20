// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Workloads.Models;

namespace Azure.ResourceManager.Workloads
{
    public partial class SapCentralServerInstanceData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
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
            if (Optional.IsDefined(MessageServerProperties))
            {
                writer.WritePropertyName("messageServerProperties");
                writer.WriteObjectValue(MessageServerProperties);
            }
            if (Optional.IsDefined(EnqueueServerProperties))
            {
                writer.WritePropertyName("enqueueServerProperties");
                writer.WriteObjectValue(EnqueueServerProperties);
            }
            if (Optional.IsDefined(GatewayServerProperties))
            {
                writer.WritePropertyName("gatewayServerProperties");
                writer.WriteObjectValue(GatewayServerProperties);
            }
            if (Optional.IsDefined(EnqueueReplicationServerProperties))
            {
                writer.WritePropertyName("enqueueReplicationServerProperties");
                writer.WriteObjectValue(EnqueueReplicationServerProperties);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static SapCentralServerInstanceData DeserializeSapCentralServerInstanceData(JsonElement element)
        {
            IDictionary<string, string> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            Optional<string> instanceNo = default;
            Optional<ResourceIdentifier> subnet = default;
            Optional<MessageServerProperties> messageServerProperties = default;
            Optional<EnqueueServerProperties> enqueueServerProperties = default;
            Optional<GatewayServerProperties> gatewayServerProperties = default;
            Optional<EnqueueReplicationServerProperties> enqueueReplicationServerProperties = default;
            Optional<string> kernelVersion = default;
            Optional<string> kernelPatch = default;
            Optional<IReadOnlyList<CentralServerVmDetails>> vmDetails = default;
            Optional<SapVirtualInstanceStatus> status = default;
            Optional<SapHealthState> health = default;
            Optional<SapVirtualInstanceProvisioningState> provisioningState = default;
            Optional<SapVirtualInstanceError> errors = default;
            foreach (var property in element.EnumerateObject())
            {
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
                    location = new AzureLocation(property.Value.GetString());
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
                    type = new ResourceType(property.Value.GetString());
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
                        if (property0.NameEquals("instanceNo"))
                        {
                            instanceNo = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("subnet"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            subnet = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("messageServerProperties"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            messageServerProperties = MessageServerProperties.DeserializeMessageServerProperties(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("enqueueServerProperties"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            enqueueServerProperties = EnqueueServerProperties.DeserializeEnqueueServerProperties(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("gatewayServerProperties"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            gatewayServerProperties = GatewayServerProperties.DeserializeGatewayServerProperties(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("enqueueReplicationServerProperties"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            enqueueReplicationServerProperties = EnqueueReplicationServerProperties.DeserializeEnqueueReplicationServerProperties(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("kernelVersion"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                kernelVersion = null;
                                continue;
                            }
                            kernelVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("kernelPatch"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                kernelPatch = null;
                                continue;
                            }
                            kernelPatch = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("vmDetails"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<CentralServerVmDetails> array = new List<CentralServerVmDetails>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(CentralServerVmDetails.DeserializeCentralServerVmDetails(item));
                            }
                            vmDetails = array;
                            continue;
                        }
                        if (property0.NameEquals("status"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            status = new SapVirtualInstanceStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("health"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            health = new SapHealthState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisioningState = new SapVirtualInstanceProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("errors"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            errors = SapVirtualInstanceError.DeserializeSapVirtualInstanceError(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new SapCentralServerInstanceData(id, name, type, systemData, tags, location, instanceNo.Value, subnet.Value, messageServerProperties.Value, enqueueServerProperties.Value, gatewayServerProperties.Value, enqueueReplicationServerProperties.Value, kernelVersion.Value, kernelPatch.Value, Optional.ToList(vmDetails), Optional.ToNullable(status), Optional.ToNullable(health), Optional.ToNullable(provisioningState), errors.Value);
        }
    }
}
