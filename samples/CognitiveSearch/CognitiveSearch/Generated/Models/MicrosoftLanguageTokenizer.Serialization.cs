// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace CognitiveSearch.Models
{
    public partial class MicrosoftLanguageTokenizer : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (MaxTokenLength != null)
            {
                writer.WritePropertyName("maxTokenLength");
                writer.WriteNumberValue(MaxTokenLength.Value);
            }
            if (IsSearchTokenizer != null)
            {
                writer.WritePropertyName("isSearchTokenizer");
                writer.WriteBooleanValue(IsSearchTokenizer.Value);
            }
            if (Language != null)
            {
                writer.WritePropertyName("language");
                writer.WriteStringValue(Language.Value.ToSerialString());
            }
            writer.WritePropertyName("@odata.type");
            writer.WriteStringValue(OdataType);
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            writer.WriteEndObject();
        }
        internal static MicrosoftLanguageTokenizer DeserializeMicrosoftLanguageTokenizer(JsonElement element)
        {
            MicrosoftLanguageTokenizer result = new MicrosoftLanguageTokenizer();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("maxTokenLength"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.MaxTokenLength = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("isSearchTokenizer"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.IsSearchTokenizer = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("language"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Language = property.Value.GetString().ToMicrosoftTokenizerLanguage();
                    continue;
                }
                if (property.NameEquals("@odata.type"))
                {
                    result.OdataType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    result.Name = property.Value.GetString();
                    continue;
                }
            }
            return result;
        }
    }
}
