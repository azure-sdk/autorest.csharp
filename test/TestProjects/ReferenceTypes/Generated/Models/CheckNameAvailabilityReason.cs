// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Fake.Models
{
    /// <summary> The reason why the given name is not available. </summary>
    public readonly partial struct CheckNameAvailabilityReason : IEquatable<CheckNameAvailabilityReason>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="CheckNameAvailabilityReason"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CheckNameAvailabilityReason(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InvalidValue = "Invalid";
        private const string AlreadyExistsValue = "AlreadyExists";

        /// <summary> Invalid. </summary>
        public static CheckNameAvailabilityReason Invalid { get; } = new CheckNameAvailabilityReason(InvalidValue);
        /// <summary> AlreadyExists. </summary>
        public static CheckNameAvailabilityReason AlreadyExists { get; } = new CheckNameAvailabilityReason(AlreadyExistsValue);
        /// <summary> Determines if two <see cref="CheckNameAvailabilityReason"/> values are the same. </summary>
        public static bool operator ==(CheckNameAvailabilityReason left, CheckNameAvailabilityReason right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CheckNameAvailabilityReason"/> values are not the same. </summary>
        public static bool operator !=(CheckNameAvailabilityReason left, CheckNameAvailabilityReason right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="CheckNameAvailabilityReason"/>. </summary>
        public static implicit operator CheckNameAvailabilityReason(string value) => new CheckNameAvailabilityReason(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CheckNameAvailabilityReason other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CheckNameAvailabilityReason other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
