// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Storage.Management.Models
{
    public partial class ObjectReplicationPolicyFilter : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (PrefixMatch != null)
            {
                writer.WritePropertyName("prefixMatch");
                writer.WriteStartArray();
                foreach (var item in PrefixMatch)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (MinCreationTime != null)
            {
                writer.WritePropertyName("minCreationTime");
                writer.WriteStringValue(MinCreationTime);
            }
            writer.WriteEndObject();
        }

        internal static ObjectReplicationPolicyFilter DeserializeObjectReplicationPolicyFilter(JsonElement element)
        {
            IList<string> prefixMatch = default;
            string minCreationTime = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("prefixMatch"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(item.GetString());
                        }
                    }
                    prefixMatch = array;
                    continue;
                }
                if (property.NameEquals("minCreationTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minCreationTime = property.Value.GetString();
                    continue;
                }
            }
            return new ObjectReplicationPolicyFilter(prefixMatch, minCreationTime);
        }
    }
}
