// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Models
{
    public partial class MetricWholeSeriesDetectionCondition : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (ConditionOperator.HasValue)
            {
                writer.WritePropertyName("conditionOperator"u8);
                writer.WriteStringValue(ConditionOperator.Value.ToString());
            }
            if (SmartDetectionCondition != null)
            {
                writer.WritePropertyName("smartDetectionCondition"u8);
                writer.WriteObjectValue(SmartDetectionCondition);
            }
            if (HardThresholdCondition != null)
            {
                writer.WritePropertyName("hardThresholdCondition"u8);
                writer.WriteObjectValue(HardThresholdCondition);
            }
            if (ChangeThresholdCondition != null)
            {
                writer.WritePropertyName("changeThresholdCondition"u8);
                writer.WriteObjectValue(ChangeThresholdCondition);
            }
            writer.WriteEndObject();
        }

        internal static MetricWholeSeriesDetectionCondition DeserializeMetricWholeSeriesDetectionCondition(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DetectionConditionOperator? conditionOperator = default;
            SmartDetectionCondition smartDetectionCondition = default;
            HardThresholdCondition hardThresholdCondition = default;
            ChangeThresholdCondition changeThresholdCondition = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("conditionOperator"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    conditionOperator = new DetectionConditionOperator(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("smartDetectionCondition"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    smartDetectionCondition = Models.SmartDetectionCondition.DeserializeSmartDetectionCondition(property.Value);
                    continue;
                }
                if (property.NameEquals("hardThresholdCondition"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    hardThresholdCondition = Models.HardThresholdCondition.DeserializeHardThresholdCondition(property.Value);
                    continue;
                }
                if (property.NameEquals("changeThresholdCondition"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    changeThresholdCondition = Models.ChangeThresholdCondition.DeserializeChangeThresholdCondition(property.Value);
                    continue;
                }
            }
            return new MetricWholeSeriesDetectionCondition(conditionOperator, smartDetectionCondition, hardThresholdCondition, changeThresholdCondition);
        }
    }
}
