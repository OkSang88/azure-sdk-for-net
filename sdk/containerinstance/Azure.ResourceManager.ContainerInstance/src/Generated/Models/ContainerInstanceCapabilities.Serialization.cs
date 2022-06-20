// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ContainerInstance.Models
{
    public partial class ContainerInstanceCapabilities
    {
        internal static ContainerInstanceCapabilities DeserializeContainerInstanceCapabilities(JsonElement element)
        {
            Optional<string> osType = default;
            Optional<AzureLocation> location = default;
            Optional<string> ipAddressType = default;
            Optional<string> gpu = default;
            Optional<Capabilities> capabilities = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("osType"))
                {
                    osType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("ipAddressType"))
                {
                    ipAddressType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("gpu"))
                {
                    gpu = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("capabilities"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    capabilities = Capabilities.DeserializeCapabilities(property.Value);
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
            }
            return new ContainerInstanceCapabilities(id, name, type, systemData, osType.Value, Optional.ToNullable(location), ipAddressType.Value, gpu.Value, capabilities.Value);
        }
    }
}
