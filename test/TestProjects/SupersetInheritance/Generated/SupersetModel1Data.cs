// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;

namespace SupersetInheritance
{
    /// <summary> A class representing the SupersetModel1 data model. </summary>
    public partial class SupersetModel1Data : Resource
    {
        /// <summary> Initializes a new instance of SupersetModel1Data. </summary>
        public SupersetModel1Data()
        {
        }

        /// <summary> Initializes a new instance of SupersetModel1Data. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="new"></param>
        internal SupersetModel1Data(ResourceIdentifier id, string name, ResourceType type, SystemData systemData, string @new) : base(id, name, type, systemData)
        {
            New = @new;
        }

        /// <summary> Gets or sets the new. </summary>
        public string New { get; set; }
    }
}
