// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace SupersetInheritance.Models
{
    /// <summary> The SupersetModel3. </summary>
    public partial class SupersetModel3
    {
        /// <summary> Initializes a new instance of SupersetModel3. </summary>
        public SupersetModel3()
        {
        }

        /// <summary> Initializes a new instance of SupersetModel3. </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <param name="new"></param>
        internal SupersetModel3(int? id, string name, string type, string @new)
        {
            Id = id;
            Name = name;
            Type = type;
            New = @new;
        }

        public int? Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string New { get; set; }
    }
}
