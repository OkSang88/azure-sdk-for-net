// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;

namespace Azure.ResourceManager.Workloads.Models
{
    internal partial class UnknownSapSizingRecommendationResult
    {
        internal static UnknownSapSizingRecommendationResult DeserializeUnknownSapSizingRecommendationResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            SapDeploymentType deploymentType = "Unknown";
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("deploymentType"u8))
                {
                    deploymentType = new SapDeploymentType(property.Value.GetString());
                    continue;
                }
            }
            return new UnknownSapSizingRecommendationResult(deploymentType);
        }
    }
}
