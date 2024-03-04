// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;

namespace Azure.AI.FormRecognizer.Models
{
    internal partial class TextLine
    {
        internal static TextLine DeserializeTextLine(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string text = default;
            IReadOnlyList<float> boundingBox = default;
            IReadOnlyList<TextWord> words = default;
            TextAppearance appearance = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("text"u8))
                {
                    text = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("boundingBox"u8))
                {
                    List<float> array = new List<float>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetSingle());
                    }
                    boundingBox = array;
                    continue;
                }
                if (property.NameEquals("words"u8))
                {
                    List<TextWord> array = new List<TextWord>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TextWord.DeserializeTextWord(item));
                    }
                    words = array;
                    continue;
                }
                if (property.NameEquals("appearance"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    appearance = TextAppearance.DeserializeTextAppearance(property.Value);
                    continue;
                }
            }
            return new TextLine(text, boundingBox, words, appearance);
        }
    }
}
