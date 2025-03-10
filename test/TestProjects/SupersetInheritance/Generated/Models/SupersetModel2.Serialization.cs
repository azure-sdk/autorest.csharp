// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace SupersetInheritance.Models
{
    public partial class SupersetModel2 : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ID))
            {
                writer.WritePropertyName("iD");
                writer.WriteStringValue(ID);
            }
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Type))
            {
                writer.WritePropertyName("type");
                writer.WriteStringValue(Type);
            }
            if (Optional.IsDefined(New))
            {
                writer.WritePropertyName("new");
                writer.WriteStringValue(New);
            }
            writer.WriteEndObject();
        }

        internal static SupersetModel2 DeserializeSupersetModel2(JsonElement element)
        {
            Optional<string> iD = default;
            Optional<string> name = default;
            Optional<string> type = default;
            Optional<string> @new = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("iD"))
                {
                    iD = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("new"))
                {
                    @new = property.Value.GetString();
                    continue;
                }
            }
            return new SupersetModel2(iD.Value, name.Value, type.Value, @new.Value);
        }
    }
}
