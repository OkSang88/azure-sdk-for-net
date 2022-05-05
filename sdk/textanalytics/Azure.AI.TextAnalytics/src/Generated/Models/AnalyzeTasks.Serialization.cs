// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Models
{
    internal partial class AnalyzeTasks
    {
        internal static AnalyzeTasks DeserializeAnalyzeTasks(JsonElement element)
        {
            int completed = default;
            int failed = default;
            int inProgress = default;
            int total = default;
            Optional<IReadOnlyList<AnalyzeTextLROResult>> items = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("completed"))
                {
                    completed = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("failed"))
                {
                    failed = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("inProgress"))
                {
                    inProgress = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("total"))
                {
                    total = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("items"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<AnalyzeTextLROResult> array = new List<AnalyzeTextLROResult>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AnalyzeTextLROResult.DeserializeAnalyzeTextLROResult(item));
                    }
                    items = array;
                    continue;
                }
            }
            return new AnalyzeTasks(completed, failed, inProgress, total, Optional.ToList(items));
        }
    }
}
