// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace CognitiveSearch.Models
{
    public partial class ShingleTokenFilter : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(MaxShingleSize))
            {
                writer.WritePropertyName("maxShingleSize");
                writer.WriteNumberValue(MaxShingleSize.Value);
            }
            if (Optional.IsDefined(MinShingleSize))
            {
                writer.WritePropertyName("minShingleSize");
                writer.WriteNumberValue(MinShingleSize.Value);
            }
            if (Optional.IsDefined(OutputUnigrams))
            {
                writer.WritePropertyName("outputUnigrams");
                writer.WriteBooleanValue(OutputUnigrams.Value);
            }
            if (Optional.IsDefined(OutputUnigramsIfNoShingles))
            {
                writer.WritePropertyName("outputUnigramsIfNoShingles");
                writer.WriteBooleanValue(OutputUnigramsIfNoShingles.Value);
            }
            if (Optional.IsDefined(TokenSeparator))
            {
                writer.WritePropertyName("tokenSeparator");
                writer.WriteStringValue(TokenSeparator);
            }
            if (Optional.IsDefined(FilterToken))
            {
                writer.WritePropertyName("filterToken");
                writer.WriteStringValue(FilterToken);
            }
            writer.WritePropertyName("@odata.type");
            writer.WriteStringValue(OdataType);
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            writer.WriteEndObject();
        }

        internal static ShingleTokenFilter DeserializeShingleTokenFilter(JsonElement element)
        {
            Optional<int> maxShingleSize = default;
            Optional<int> minShingleSize = default;
            Optional<bool> outputUnigrams = default;
            Optional<bool> outputUnigramsIfNoShingles = default;
            Optional<string> tokenSeparator = default;
            Optional<string> filterToken = default;
            string odataType = default;
            string name = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("maxShingleSize"))
                {
                    maxShingleSize = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("minShingleSize"))
                {
                    minShingleSize = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("outputUnigrams"))
                {
                    outputUnigrams = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("outputUnigramsIfNoShingles"))
                {
                    outputUnigramsIfNoShingles = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("tokenSeparator"))
                {
                    tokenSeparator = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("filterToken"))
                {
                    filterToken = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("@odata.type"))
                {
                    odataType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
            }
            return new ShingleTokenFilter(odataType, name, maxShingleSize.HasValue ? maxShingleSize.Value : (int?)null, minShingleSize.HasValue ? minShingleSize.Value : (int?)null, outputUnigrams.HasValue ? outputUnigrams.Value : (bool?)null, outputUnigramsIfNoShingles.HasValue ? outputUnigramsIfNoShingles.Value : (bool?)null, tokenSeparator.HasValue ? tokenSeparator.Value : null, filterToken.HasValue ? filterToken.Value : null);
        }
    }
}
