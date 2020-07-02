// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Network.Management.Interface.Models
{
    public partial class Route : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Etag))
            {
                writer.WritePropertyName("etag");
                writer.WriteStringValue(Etag);
            }
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(AddressPrefix))
            {
                writer.WritePropertyName("addressPrefix");
                writer.WriteStringValue(AddressPrefix);
            }
            if (Optional.IsDefined(NextHopType))
            {
                writer.WritePropertyName("nextHopType");
                writer.WriteStringValue(NextHopType.Value.ToString());
            }
            if (Optional.IsDefined(NextHopIpAddress))
            {
                writer.WritePropertyName("nextHopIpAddress");
                writer.WriteStringValue(NextHopIpAddress);
            }
            if (Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState");
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static Route DeserializeRoute(JsonElement element)
        {
            Optional<string> name = default;
            Optional<string> etag = default;
            Optional<string> id = default;
            Optional<string> addressPrefix = default;
            Optional<RouteNextHopType> nextHopType = default;
            Optional<string> nextHopIpAddress = default;
            Optional<ProvisioningState> provisioningState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("etag"))
                {
                    etag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("addressPrefix"))
                        {
                            addressPrefix = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("nextHopType"))
                        {
                            nextHopType = new RouteNextHopType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("nextHopIpAddress"))
                        {
                            nextHopIpAddress = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            provisioningState = new ProvisioningState(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new Route(id.HasValue ? id.Value : null, name.HasValue ? name.Value : null, etag.HasValue ? etag.Value : null, addressPrefix.HasValue ? addressPrefix.Value : null, nextHopType.HasValue ? nextHopType.Value : (RouteNextHopType?)null, nextHopIpAddress.HasValue ? nextHopIpAddress.Value : null, provisioningState.HasValue ? provisioningState.Value : (ProvisioningState?)null);
        }
    }
}
