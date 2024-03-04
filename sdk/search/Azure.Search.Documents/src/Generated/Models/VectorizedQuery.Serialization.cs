// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Documents.Models
{
    public partial class VectorizedQuery : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("vector"u8);
            writer.WriteStartArray();
            foreach (var item in Vector.Span)
            {
                writer.WriteNumberValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
            if (KNearestNeighborsCount.HasValue)
            {
                writer.WritePropertyName("k"u8);
                writer.WriteNumberValue(KNearestNeighborsCount.Value);
            }
            if (FieldsRaw != null)
            {
                writer.WritePropertyName("fields"u8);
                writer.WriteStringValue(FieldsRaw);
            }
            if (Exhaustive.HasValue)
            {
                writer.WritePropertyName("exhaustive"u8);
                writer.WriteBooleanValue(Exhaustive.Value);
            }
            if (Oversampling.HasValue)
            {
                writer.WritePropertyName("oversampling"u8);
                writer.WriteNumberValue(Oversampling.Value);
            }
            writer.WriteEndObject();
        }

        internal static VectorizedQuery DeserializeVectorizedQuery(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ReadOnlyMemory<float> vector = default;
            VectorQueryKind kind = default;
            int? k = default;
            string fields = default;
            bool? exhaustive = default;
            double? oversampling = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("vector"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    int index = 0;
                    float[] array = new float[property.Value.GetArrayLength()];
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array[index] = item.GetSingle();
                        index++;
                    }
                    vector = new ReadOnlyMemory<float>(array);
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = new VectorQueryKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("k"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    k = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("fields"u8))
                {
                    fields = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("exhaustive"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    exhaustive = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("oversampling"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    oversampling = property.Value.GetDouble();
                    continue;
                }
            }
            return new VectorizedQuery(
                kind,
                k,
                fields,
                exhaustive,
                oversampling,
                vector);
        }
    }
}
