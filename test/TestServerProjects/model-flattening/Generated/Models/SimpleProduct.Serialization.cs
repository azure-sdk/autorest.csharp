// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace model_flattening.Models
{
    public partial class SimpleProduct : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("details");
            writer.WriteStartObject();
            if (MaxProductDisplayName != null)
            {
                writer.WritePropertyName("max_product_display_name");
                writer.WriteStringValue(MaxProductDisplayName);
            }
            writer.WritePropertyName("max_product_capacity");
            writer.WriteStringValue(Capacity);
            writer.WritePropertyName("max_product_image");
            writer.WriteStartObject();
            if (OdataValue != null)
            {
                writer.WritePropertyName("@odata.value");
                writer.WriteStringValue(OdataValue);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
            writer.WritePropertyName("base_product_id");
            writer.WriteStringValue(ProductId);
            if (Description != null)
            {
                writer.WritePropertyName("base_product_description");
                writer.WriteStringValue(Description);
            }
            writer.WriteEndObject();
        }
        internal static SimpleProduct DeserializeSimpleProduct(JsonElement element)
        {
            SimpleProduct result = new SimpleProduct();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("details"))
                {
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("max_product_display_name"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            result.MaxProductDisplayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("max_product_capacity"))
                        {
                            result.Capacity = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("max_product_image"))
                        {
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                if (property1.NameEquals("@odata.value"))
                                {
                                    if (property1.Value.ValueKind == JsonValueKind.Null)
                                    {
                                        continue;
                                    }
                                    result.OdataValue = property1.Value.GetString();
                                    continue;
                                }
                            }
                            continue;
                        }
                    }
                    continue;
                }
                if (property.NameEquals("base_product_id"))
                {
                    result.ProductId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("base_product_description"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Description = property.Value.GetString();
                    continue;
                }
            }
            return result;
        }
    }
}
