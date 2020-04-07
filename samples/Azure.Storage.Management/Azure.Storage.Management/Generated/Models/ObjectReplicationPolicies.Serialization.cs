// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Storage.Management.Models
{
    public partial class ObjectReplicationPolicies
    {
        internal static ObjectReplicationPolicies DeserializeObjectReplicationPolicies(JsonElement element)
        {
            IReadOnlyList<ObjectReplicationPolicy> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ObjectReplicationPolicy> array = new List<ObjectReplicationPolicy>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(ObjectReplicationPolicy.DeserializeObjectReplicationPolicy(item));
                        }
                    }
                    value = array;
                    continue;
                }
            }
            return new ObjectReplicationPolicies(value);
        }
    }
}
