// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace CognitiveSearch.Models
{
    internal partial class SearchError
    {
        internal static SearchError DeserializeSearchError(JsonElement element)
        {
            Optional<string> code = default;
            string message = default;
            Optional<IReadOnlyList<SearchError>> details = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("code"))
                {
                    code = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("message"))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("details"))
                {
                    List<SearchError> array = new List<SearchError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(DeserializeSearchError(item));
                        }
                    }
                    details = array;
                    continue;
                }
            }
            return new SearchError(code.HasValue ? code.Value : null, message, new ChangeTrackingList<SearchError>(details));
        }
    }
}
