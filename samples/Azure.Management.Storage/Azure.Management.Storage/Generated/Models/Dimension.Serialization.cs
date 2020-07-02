// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Storage.Models
{
    public partial class Dimension
    {
        internal static Dimension DeserializeDimension(JsonElement element)
        {
            Optional<string> name = default;
            Optional<string> displayName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("displayName"))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
            }
            return new Dimension(name.HasValue ? name.Value : null, displayName.HasValue ? displayName.Value : null);
        }
    }
}
