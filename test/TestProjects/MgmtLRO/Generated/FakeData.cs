// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.ResourceManager;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;
using MgmtLRO.Models;

namespace MgmtLRO
{
    /// <summary> A class representing the Fake data model. </summary>
    public partial class FakeData : TrackedResource
    {
        /// <summary> Initializes a new instance of FakeData. </summary>
        /// <param name="location"> The location. </param>
        public FakeData(Location location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of FakeData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="properties"> The instance view of a resource. </param>
        internal FakeData(ResourceIdentifier id, string name, ResourceType type, IDictionary<string, string> tags, Location location, FakeProperties properties) : base(id, name, type, tags, location)
        {
            Properties = properties;
        }

        /// <summary> The instance view of a resource. </summary>
        public FakeProperties Properties { get; set; }
    }
}
