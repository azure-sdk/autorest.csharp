// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using MgmtLRO.Models;

namespace MgmtLRO
{
    /// <summary> A class representing the Fake data model. </summary>
    public partial class FakeData : TrackedResource
    {
        /// <summary> Initializes a new instance of FakeData. </summary>
        /// <param name="location"> The location. </param>
        public FakeData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of FakeData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="properties"> The instance view of a resource. </param>
        internal FakeData(ResourceIdentifier id, string name, ResourceType type, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, FakeProperties properties) : base(id, name, type, systemData, tags, location)
        {
            Properties = properties;
        }

        /// <summary> The instance view of a resource. </summary>
        public FakeProperties Properties { get; set; }
    }
}
