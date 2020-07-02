// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace CognitiveSearch.Models
{
    public partial class AnalyzeRequest : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("text");
            writer.WriteStringValue(Text);
            if (Optional.IsDefined(Analyzer))
            {
                writer.WritePropertyName("analyzer");
                writer.WriteStringValue(Analyzer.Value.ToString());
            }
            if (Optional.IsDefined(Tokenizer))
            {
                writer.WritePropertyName("tokenizer");
                writer.WriteStringValue(Tokenizer.Value.ToString());
            }
            if (Optional.IsDefined(TokenFilters))
            {
                writer.WritePropertyName("tokenFilters");
                writer.WriteStartArray();
                foreach (var item in TokenFilters)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(CharFilters))
            {
                writer.WritePropertyName("charFilters");
                writer.WriteStartArray();
                foreach (var item in CharFilters)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }
    }
}
