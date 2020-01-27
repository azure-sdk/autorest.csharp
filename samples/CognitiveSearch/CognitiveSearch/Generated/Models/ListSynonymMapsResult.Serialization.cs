// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace CognitiveSearch.Models
{
    public partial class ListSynonymMapsResult : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (SynonymMaps != null)
            {
                writer.WritePropertyName("value");
                writer.WriteStartArray();
                foreach (var item in SynonymMaps)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }
        internal static ListSynonymMapsResult DeserializeListSynonymMapsResult(JsonElement element)
        {
            ListSynonymMapsResult result = new ListSynonymMapsResult();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.SynonymMaps = new List<SynonymMap>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        result.SynonymMaps.Add(SynonymMap.DeserializeSynonymMap(item));
                    }
                    continue;
                }
            }
            return result;
        }
    }
}
