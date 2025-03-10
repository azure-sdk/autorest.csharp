// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.ResourceManager;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace ExactMatchFlattenInheritance
{
    /// <summary> A class representing the AzureResourceFlattenModel1 data model. </summary>
    public partial class AzureResourceFlattenModel1Data : TrackedResource
    {
        /// <summary> Initializes a new instance of AzureResourceFlattenModel1Data. </summary>
        /// <param name="location"> The location. </param>
        public AzureResourceFlattenModel1Data(Location location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of AzureResourceFlattenModel1Data. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="foo"> New property. </param>
        /// <param name="fooPropertiesFoo"></param>
        /// <param name="idPropertiesId"> ID in CustomModel1. </param>
        internal AzureResourceFlattenModel1Data(ResourceIdentifier id, string name, ResourceType type, IDictionary<string, string> tags, Location location, int? foo, string fooPropertiesFoo, string idPropertiesId) : base(id, name, type, tags, location)
        {
            Foo = foo;
            FooPropertiesFoo = fooPropertiesFoo;
            IdPropertiesId = idPropertiesId;
        }

        /// <summary> New property. </summary>
        public int? Foo { get; set; }
        public string FooPropertiesFoo { get; set; }
        /// <summary> ID in CustomModel1. </summary>
        public string IdPropertiesId { get; set; }
    }
}
