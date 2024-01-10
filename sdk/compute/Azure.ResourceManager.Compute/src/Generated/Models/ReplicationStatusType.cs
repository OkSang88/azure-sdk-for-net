// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The ReplicationStatusType. </summary>
    public readonly partial struct ReplicationStatusType : IEquatable<ReplicationStatusType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ReplicationStatusType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ReplicationStatusType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ReplicationStatusValue = "ReplicationStatus";
        private const string UefiSettingsValue = "UefiSettings";

        /// <summary> ReplicationStatus. </summary>
        public static ReplicationStatusType ReplicationStatus { get; } = new ReplicationStatusType(ReplicationStatusValue);
        /// <summary> UefiSettings. </summary>
        public static ReplicationStatusType UefiSettings { get; } = new ReplicationStatusType(UefiSettingsValue);
        /// <summary> Determines if two <see cref="ReplicationStatusType"/> values are the same. </summary>
        public static bool operator ==(ReplicationStatusType left, ReplicationStatusType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ReplicationStatusType"/> values are not the same. </summary>
        public static bool operator !=(ReplicationStatusType left, ReplicationStatusType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ReplicationStatusType"/>. </summary>
        public static implicit operator ReplicationStatusType(string value) => new ReplicationStatusType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ReplicationStatusType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ReplicationStatusType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
