// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    internal partial class CosmosDbSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(CollectionsThroughput))
            {
                writer.WritePropertyName("collectionsThroughput");
                writer.WriteNumberValue(CollectionsThroughput.Value);
            }
            writer.WriteEndObject();
        }

        internal static CosmosDbSettings DeserializeCosmosDbSettings(JsonElement element)
        {
            Optional<int> collectionsThroughput = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("collectionsThroughput"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    collectionsThroughput = property.Value.GetInt32();
                    continue;
                }
            }
            return new CosmosDbSettings(Optional.ToNullable(collectionsThroughput));
        }
    }
}
