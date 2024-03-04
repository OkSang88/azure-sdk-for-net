// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.IoT.TimeSeriesInsights
{
    public partial class TimeSeriesInsightsEventProperty : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Name != null)
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (PropertyValueType.HasValue)
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(PropertyValueType.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static TimeSeriesInsightsEventProperty DeserializeTimeSeriesInsightsEventProperty(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            TimeSeriesPropertyType? type = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new TimeSeriesPropertyType(property.Value.GetString());
                    continue;
                }
            }
            return new TimeSeriesInsightsEventProperty(name, type);
        }
    }
}
