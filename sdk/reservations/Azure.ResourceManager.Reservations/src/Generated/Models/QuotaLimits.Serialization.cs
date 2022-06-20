// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Reservations;

namespace Azure.ResourceManager.Reservations.Models
{
    internal partial class QuotaLimits
    {
        internal static QuotaLimits DeserializeQuotaLimits(JsonElement element)
        {
            Optional<IReadOnlyList<CurrentQuotaLimitBaseData>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<CurrentQuotaLimitBaseData> array = new List<CurrentQuotaLimitBaseData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CurrentQuotaLimitBaseData.DeserializeCurrentQuotaLimitBaseData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new QuotaLimits(Optional.ToList(value), nextLink.Value);
        }
    }
}
