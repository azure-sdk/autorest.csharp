// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace MgmtParent
{
    /// <summary> A class representing the DedicatedHost data model. </summary>
    public partial class DedicatedHostData : TrackedResource
    {
        /// <summary> Initializes a new instance of DedicatedHostData. </summary>
        /// <param name="location"> The location. </param>
        public DedicatedHostData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of DedicatedHostData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="foo"> specifies the foo. </param>
        internal DedicatedHostData(ResourceIdentifier id, string name, ResourceType type, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, string foo) : base(id, name, type, systemData, tags, location)
        {
            Foo = foo;
        }

        /// <summary> specifies the foo. </summary>
        public string Foo { get; set; }
    }
}
