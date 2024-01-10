// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure;

namespace Azure.AI.Vision.ImageAnalysis
{
    public partial class ImageMetadata
    {
        internal static ImageMetadata DeserializeImageMetadata(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int height = default;
            int width = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("height"u8))
                {
                    height = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("width"u8))
                {
                    width = property.Value.GetInt32();
                    continue;
                }
            }
            return new ImageMetadata(height, width);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static ImageMetadata FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeImageMetadata(document.RootElement);
        }
    }
}
