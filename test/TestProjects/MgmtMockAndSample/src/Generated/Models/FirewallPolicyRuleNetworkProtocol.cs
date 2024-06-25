// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace MgmtMockAndSample.Models
{
    /// <summary> The Network protocol of a Rule. </summary>
    public readonly partial struct FirewallPolicyRuleNetworkProtocol : IEquatable<FirewallPolicyRuleNetworkProtocol>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="FirewallPolicyRuleNetworkProtocol"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public FirewallPolicyRuleNetworkProtocol(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string TCPValue = "TCP";
        private const string UDPValue = "UDP";
        private const string AnyValue = "Any";
        private const string IcmpValue = "ICMP";

        /// <summary> TCP. </summary>
        public static FirewallPolicyRuleNetworkProtocol TCP { get; } = new FirewallPolicyRuleNetworkProtocol(TCPValue);
        /// <summary> UDP. </summary>
        public static FirewallPolicyRuleNetworkProtocol UDP { get; } = new FirewallPolicyRuleNetworkProtocol(UDPValue);
        /// <summary> Any. </summary>
        public static FirewallPolicyRuleNetworkProtocol Any { get; } = new FirewallPolicyRuleNetworkProtocol(AnyValue);
        /// <summary> ICMP. </summary>
        public static FirewallPolicyRuleNetworkProtocol Icmp { get; } = new FirewallPolicyRuleNetworkProtocol(IcmpValue);
        /// <summary> Determines if two <see cref="FirewallPolicyRuleNetworkProtocol"/> values are the same. </summary>
        public static bool operator ==(FirewallPolicyRuleNetworkProtocol left, FirewallPolicyRuleNetworkProtocol right) => left.Equals(right);
        /// <summary> Determines if two <see cref="FirewallPolicyRuleNetworkProtocol"/> values are not the same. </summary>
        public static bool operator !=(FirewallPolicyRuleNetworkProtocol left, FirewallPolicyRuleNetworkProtocol right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="FirewallPolicyRuleNetworkProtocol"/>. </summary>
        public static implicit operator FirewallPolicyRuleNetworkProtocol(string value) => new FirewallPolicyRuleNetworkProtocol(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is FirewallPolicyRuleNetworkProtocol other && Equals(other);
        /// <inheritdoc />
        public bool Equals(FirewallPolicyRuleNetworkProtocol other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
