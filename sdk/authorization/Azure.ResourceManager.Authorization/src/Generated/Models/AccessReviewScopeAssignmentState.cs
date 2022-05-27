// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Authorization.Models
{
    /// <summary> The role assignment state eligible/active to review. </summary>
    internal readonly partial struct AccessReviewScopeAssignmentState : IEquatable<AccessReviewScopeAssignmentState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AccessReviewScopeAssignmentState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AccessReviewScopeAssignmentState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EligibleValue = "eligible";
        private const string ActiveValue = "active";

        /// <summary> eligible. </summary>
        public static AccessReviewScopeAssignmentState Eligible { get; } = new AccessReviewScopeAssignmentState(EligibleValue);
        /// <summary> active. </summary>
        public static AccessReviewScopeAssignmentState Active { get; } = new AccessReviewScopeAssignmentState(ActiveValue);
        /// <summary> Determines if two <see cref="AccessReviewScopeAssignmentState"/> values are the same. </summary>
        public static bool operator ==(AccessReviewScopeAssignmentState left, AccessReviewScopeAssignmentState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AccessReviewScopeAssignmentState"/> values are not the same. </summary>
        public static bool operator !=(AccessReviewScopeAssignmentState left, AccessReviewScopeAssignmentState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AccessReviewScopeAssignmentState"/>. </summary>
        public static implicit operator AccessReviewScopeAssignmentState(string value) => new AccessReviewScopeAssignmentState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AccessReviewScopeAssignmentState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AccessReviewScopeAssignmentState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
