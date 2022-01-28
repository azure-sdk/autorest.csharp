// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace SupersetInheritance
{
    /// <summary> A class representing the SupersetModel4 data model. </summary>
    public partial class SupersetModel4Data : TrackedResource
    {
        /// <summary> Initializes a new instance of SupersetModel4Data. </summary>
        /// <param name="location"> The location. </param>
        public SupersetModel4Data(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of SupersetModel4Data. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="new"></param>
        internal SupersetModel4Data(ResourceIdentifier id, string name, ResourceType type, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, string @new) : base(id, name, type, systemData, tags, location)
        {
            New = @new;
        }

        /// <summary> Gets or sets the new. </summary>
        public string New { get; set; }
    }
}
