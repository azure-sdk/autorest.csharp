// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.FormRecognizer.Models
{
    public partial class ReadResult
    {
        internal static ReadResult DeserializeReadResult(JsonElement element)
        {
            int page = default;
            float angle = default;
            float width = default;
            float height = default;
            LengthUnit unit = default;
            Optional<Language> language = default;
            Optional<IReadOnlyList<TextLine>> lines = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("page"))
                {
                    page = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("angle"))
                {
                    angle = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("width"))
                {
                    width = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("height"))
                {
                    height = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("unit"))
                {
                    unit = property.Value.GetString().ToLengthUnit();
                    continue;
                }
                if (property.NameEquals("language"))
                {
                    language = new Language(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("lines"))
                {
                    List<TextLine> array = new List<TextLine>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(TextLine.DeserializeTextLine(item));
                        }
                    }
                    lines = array;
                    continue;
                }
            }
            return new ReadResult(page, angle, width, height, unit, language.HasValue ? language.Value : (Language?)null, new ChangeTrackingList<TextLine>(lines));
        }
    }
}
