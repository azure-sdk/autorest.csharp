// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Management.Storage.Models
{
    /// <summary> The properties of an ImmutabilityPolicy of a blob container. </summary>
    public partial class ImmutabilityPolicyProperties
    {
        /// <summary> Initializes a new instance of ImmutabilityPolicyProperties. </summary>
        public ImmutabilityPolicyProperties()
        {
            UpdateHistory = new ChangeTrackingList<UpdateHistoryProperty>();
        }

        /// <summary> Initializes a new instance of ImmutabilityPolicyProperties. </summary>
        /// <param name="etag"> ImmutabilityPolicy Etag. </param>
        /// <param name="updateHistory"> The ImmutabilityPolicy update history of the blob container. </param>
        /// <param name="immutabilityPeriodSinceCreationInDays"> The immutability period for the blobs in the container since the policy creation, in days. </param>
        /// <param name="state"> The ImmutabilityPolicy state of a blob container, possible values include: Locked and Unlocked. </param>
        /// <param name="allowProtectedAppendWrites"> This property can only be changed for unlocked time-based retention policies. When enabled, new blocks can be written to an append blob while maintaining immutability protection and compliance. Only new blocks can be added and any existing blocks cannot be modified or deleted. This property cannot be changed with ExtendImmutabilityPolicy API. </param>
        internal ImmutabilityPolicyProperties(string etag, IList<UpdateHistoryProperty> updateHistory, int? immutabilityPeriodSinceCreationInDays, ImmutabilityPolicyState? state, bool? allowProtectedAppendWrites)
        {
            Etag = etag;
            UpdateHistory = updateHistory;
            ImmutabilityPeriodSinceCreationInDays = immutabilityPeriodSinceCreationInDays;
            State = state;
            AllowProtectedAppendWrites = allowProtectedAppendWrites;
        }

        /// <summary> ImmutabilityPolicy Etag. </summary>
        public string Etag { get; }
        /// <summary> The ImmutabilityPolicy update history of the blob container. </summary>
        public IList<UpdateHistoryProperty> UpdateHistory { get; }
        /// <summary> The immutability period for the blobs in the container since the policy creation, in days. </summary>
        public int? ImmutabilityPeriodSinceCreationInDays { get; set; }
        /// <summary> The ImmutabilityPolicy state of a blob container, possible values include: Locked and Unlocked. </summary>
        public ImmutabilityPolicyState? State { get; }
        /// <summary> This property can only be changed for unlocked time-based retention policies. When enabled, new blocks can be written to an append blob while maintaining immutability protection and compliance. Only new blocks can be added and any existing blocks cannot be modified or deleted. This property cannot be changed with ExtendImmutabilityPolicy API. </summary>
        public bool? AllowProtectedAppendWrites { get; set; }
    }
}
