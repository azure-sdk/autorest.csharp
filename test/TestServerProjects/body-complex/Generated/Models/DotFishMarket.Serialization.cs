// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace body_complex.Models
{
    public partial class DotFishMarket
    {
        internal static DotFishMarket DeserializeDotFishMarket(JsonElement element)
        {
            Optional<DotSalmon> sampleSalmon = default;
            Optional<IReadOnlyList<DotSalmon>> salmons = default;
            Optional<DotFish> sampleFish = default;
            Optional<IReadOnlyList<DotFish>> fishes = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sampleSalmon"))
                {
                    sampleSalmon = DotSalmon.DeserializeDotSalmon(property.Value);
                    continue;
                }
                if (property.NameEquals("salmons"))
                {
                    List<DotSalmon> array = new List<DotSalmon>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(DotSalmon.DeserializeDotSalmon(item));
                        }
                    }
                    salmons = array;
                    continue;
                }
                if (property.NameEquals("sampleFish"))
                {
                    sampleFish = DotFish.DeserializeDotFish(property.Value);
                    continue;
                }
                if (property.NameEquals("fishes"))
                {
                    List<DotFish> array = new List<DotFish>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(DotFish.DeserializeDotFish(item));
                        }
                    }
                    fishes = array;
                    continue;
                }
            }
            return new DotFishMarket(sampleSalmon.HasValue ? sampleSalmon.Value : null, new ChangeTrackingList<DotSalmon>(salmons), sampleFish.HasValue ? sampleFish.Value : null, new ChangeTrackingList<DotFish>(fishes));
        }
    }
}
