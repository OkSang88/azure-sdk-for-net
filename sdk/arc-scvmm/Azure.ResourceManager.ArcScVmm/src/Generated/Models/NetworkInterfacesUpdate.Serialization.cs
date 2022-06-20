// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ArcScVmm.Models
{
    public partial class NetworkInterfacesUpdate : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(MacAddress))
            {
                writer.WritePropertyName("macAddress");
                writer.WriteStringValue(MacAddress);
            }
            if (Optional.IsDefined(VirtualNetworkId))
            {
                writer.WritePropertyName("virtualNetworkId");
                writer.WriteStringValue(VirtualNetworkId);
            }
            if (Optional.IsDefined(IPv4AddressType))
            {
                writer.WritePropertyName("ipv4AddressType");
                writer.WriteStringValue(IPv4AddressType.Value.ToString());
            }
            if (Optional.IsDefined(IPv6AddressType))
            {
                writer.WritePropertyName("ipv6AddressType");
                writer.WriteStringValue(IPv6AddressType.Value.ToString());
            }
            if (Optional.IsDefined(MacAddressType))
            {
                writer.WritePropertyName("macAddressType");
                writer.WriteStringValue(MacAddressType.Value.ToString());
            }
            if (Optional.IsDefined(NicId))
            {
                writer.WritePropertyName("nicId");
                writer.WriteStringValue(NicId);
            }
            writer.WriteEndObject();
        }
    }
}
