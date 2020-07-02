// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace paging.Models
{
    /// <summary> The ProductResultValue. </summary>
    public partial class ProductResultValue
    {
        /// <summary> Initializes a new instance of ProductResultValue. </summary>
        internal ProductResultValue()
        {
            Value = new ChangeTrackingList<Product>();
        }

        /// <summary> Initializes a new instance of ProductResultValue. </summary>
        /// <param name="value"> . </param>
        /// <param name="nextLink"> . </param>
        internal ProductResultValue(IReadOnlyList<Product> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        public IReadOnlyList<Product> Value { get; }
        public string NextLink { get; }
    }
}
