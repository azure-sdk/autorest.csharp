// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Resources.Models;

namespace Pagination
{
    /// <summary> A class representing the PageSizeIntegerModel data model. </summary>
    public partial class PageSizeIntegerModelData : SubResource
    {
        /// <summary> Initializes a new instance of PageSizeIntegerModelData. </summary>
        public PageSizeIntegerModelData()
        {
        }

        /// <summary> Initializes a new instance of PageSizeIntegerModelData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="type"> Resource type. </param>
        internal PageSizeIntegerModelData(string id, string name, string type) : base(id)
        {
            Name = name;
            Type = type;
        }

        /// <summary> Resource name. </summary>
        public string Name { get; }
        /// <summary> Resource type. </summary>
        public string Type { get; }
    }
}
