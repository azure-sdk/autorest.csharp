// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using ExactMatchFlattenInheritance.Models;

namespace ExactMatchFlattenInheritance
{
    /// <summary> A class representing the CustomModel3 data model. </summary>
    public partial class CustomModel3Data : AzureResourceFlattenModel7
    {
        /// <summary> Initializes a new instance of CustomModel3Data. </summary>
        public CustomModel3Data()
        {
        }

        /// <summary> Initializes a new instance of CustomModel3Data. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <param name="foo"></param>
        internal CustomModel3Data(string id, string name, string type, string foo) : base(id, name, type)
        {
            Foo = foo;
        }

        public string Foo { get; set; }
    }
}
