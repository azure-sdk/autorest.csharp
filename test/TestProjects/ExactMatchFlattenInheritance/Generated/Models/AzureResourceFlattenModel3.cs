// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace ExactMatchFlattenInheritance.Models
{
    /// <summary> This model is x-ms-azure-resource, has flatten properties, and all reference type properties are in flatten properties. </summary>
    public partial class AzureResourceFlattenModel3 : TrackedResource
    {
        /// <summary> Initializes a new instance of AzureResourceFlattenModel3. </summary>
        /// <param name="location"> The location. </param>
        public AzureResourceFlattenModel3(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of AzureResourceFlattenModel3. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="foo"> New property. </param>
        internal AzureResourceFlattenModel3(ResourceIdentifier id, string name, ResourceType type, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, int? foo) : base(id, name, type, systemData, tags, location)
        {
            Foo = foo;
        }

        /// <summary> New property. </summary>
        public int? Foo { get; set; }
    }
}
