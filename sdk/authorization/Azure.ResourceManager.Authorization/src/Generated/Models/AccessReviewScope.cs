// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Authorization.Models
{
    /// <summary> Descriptor for what needs to be reviewed. </summary>
    internal partial class AccessReviewScope
    {
        /// <summary> Initializes a new instance of AccessReviewScope. </summary>
        internal AccessReviewScope()
        {
        }

        /// <summary> ResourceId in which this review is getting created. </summary>
        public string ResourceId { get; }
        /// <summary> This is used to indicate the role being reviewed. </summary>
        public string RoleDefinitionId { get; }
        /// <summary> The identity type user/servicePrincipal to review. </summary>
        public AccessReviewScopePrincipalType? PrincipalType { get; }
        /// <summary> The role assignment state eligible/active to review. </summary>
        public AccessReviewScopeAssignmentState? AssignmentState { get; }
        /// <summary> Duration users are inactive for. The value should be in ISO  8601 format (http://en.wikipedia.org/wiki/ISO_8601#Durations).This code can be used to convert TimeSpan to a valid interval string: XmlConvert.ToString(new TimeSpan(hours, minutes, seconds)). </summary>
        public TimeSpan? InactiveDuration { get; }
        /// <summary> Flag to indicate whether to expand nested memberships or not. </summary>
        public bool? ExpandNestedMemberships { get; }
    }
}
