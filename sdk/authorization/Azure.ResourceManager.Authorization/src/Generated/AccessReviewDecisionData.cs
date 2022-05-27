// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.Authorization.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Authorization
{
    /// <summary> A class representing the AccessReviewDecision data model. </summary>
    public partial class AccessReviewDecisionData : ResourceData
    {
        /// <summary> Initializes a new instance of AccessReviewDecisionData. </summary>
        internal AccessReviewDecisionData()
        {
        }

        /// <summary> Initializes a new instance of AccessReviewDecisionData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="recommendation"> The feature- generated recommendation shown to the reviewer. </param>
        /// <param name="decision"> The decision on the approval step. This value is initially set to NotReviewed. Approvers can take action of Approve/Deny. </param>
        /// <param name="justification"> Justification provided by approvers for their action. </param>
        /// <param name="reviewedOn"> Date Time when a decision was taken. </param>
        /// <param name="applyResult"> The outcome of applying the decision. </param>
        /// <param name="appliedOn"> The date and time when the review decision was applied. </param>
        /// <param name="principalIdPropertiesAppliedByPrincipalId"> The identity id. </param>
        /// <param name="principalTypePropertiesAppliedByPrincipalType"> The identity type : user/servicePrincipal. </param>
        /// <param name="principalNamePropertiesAppliedByPrincipalName"> The identity display name. </param>
        /// <param name="userPrincipalNamePropertiesAppliedByUserPrincipalName"> The user principal name(if valid). </param>
        /// <param name="principalIdPropertiesReviewedByPrincipalId"> The identity id. </param>
        /// <param name="principalTypePropertiesReviewedByPrincipalType"> The identity type : user/servicePrincipal. </param>
        /// <param name="principalNamePropertiesReviewedByPrincipalName"> The identity display name. </param>
        /// <param name="userPrincipalNamePropertiesReviewedByUserPrincipalName"> The user principal name(if valid). </param>
        /// <param name="typePropertiesResourceType"> The type of resource: azureRole. </param>
        /// <param name="idPropertiesResourceId"> The id of resource associated with a decision record. </param>
        /// <param name="displayNamePropertiesResourceDisplayName"> The display name of resource associated with a decision record. </param>
        /// <param name="typePropertiesPrincipalType"> The type of decision target : User/ServicePrincipal. </param>
        /// <param name="idPropertiesPrincipalId"> The id of principal whose access was reviewed. </param>
        /// <param name="displayNamePropertiesPrincipalDisplayName"> The display name of the user whose access was reviewed. </param>
        internal AccessReviewDecisionData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, AccessRecommendationType? recommendation, AccessReviewResult? decision, string justification, DateTimeOffset? reviewedOn, AccessReviewApplyResult? applyResult, DateTimeOffset? appliedOn, string principalIdPropertiesAppliedByPrincipalId, AccessReviewActorIdentityType? principalTypePropertiesAppliedByPrincipalType, string principalNamePropertiesAppliedByPrincipalName, string userPrincipalNamePropertiesAppliedByUserPrincipalName, string principalIdPropertiesReviewedByPrincipalId, AccessReviewActorIdentityType? principalTypePropertiesReviewedByPrincipalType, string principalNamePropertiesReviewedByPrincipalName, string userPrincipalNamePropertiesReviewedByUserPrincipalName, DecisionResourceType? typePropertiesResourceType, string idPropertiesResourceId, string displayNamePropertiesResourceDisplayName, DecisionTargetType? typePropertiesPrincipalType, string idPropertiesPrincipalId, string displayNamePropertiesPrincipalDisplayName) : base(id, name, resourceType, systemData)
        {
            Recommendation = recommendation;
            Decision = decision;
            Justification = justification;
            ReviewedOn = reviewedOn;
            ApplyResult = applyResult;
            AppliedOn = appliedOn;
            PrincipalIdPropertiesAppliedByPrincipalId = principalIdPropertiesAppliedByPrincipalId;
            PrincipalTypePropertiesAppliedByPrincipalType = principalTypePropertiesAppliedByPrincipalType;
            PrincipalNamePropertiesAppliedByPrincipalName = principalNamePropertiesAppliedByPrincipalName;
            UserPrincipalNamePropertiesAppliedByUserPrincipalName = userPrincipalNamePropertiesAppliedByUserPrincipalName;
            PrincipalIdPropertiesReviewedByPrincipalId = principalIdPropertiesReviewedByPrincipalId;
            PrincipalTypePropertiesReviewedByPrincipalType = principalTypePropertiesReviewedByPrincipalType;
            PrincipalNamePropertiesReviewedByPrincipalName = principalNamePropertiesReviewedByPrincipalName;
            UserPrincipalNamePropertiesReviewedByUserPrincipalName = userPrincipalNamePropertiesReviewedByUserPrincipalName;
            TypePropertiesResourceType = typePropertiesResourceType;
            IdPropertiesResourceId = idPropertiesResourceId;
            DisplayNamePropertiesResourceDisplayName = displayNamePropertiesResourceDisplayName;
            TypePropertiesPrincipalType = typePropertiesPrincipalType;
            IdPropertiesPrincipalId = idPropertiesPrincipalId;
            DisplayNamePropertiesPrincipalDisplayName = displayNamePropertiesPrincipalDisplayName;
        }

        /// <summary> The feature- generated recommendation shown to the reviewer. </summary>
        public AccessRecommendationType? Recommendation { get; }
        /// <summary> The decision on the approval step. This value is initially set to NotReviewed. Approvers can take action of Approve/Deny. </summary>
        public AccessReviewResult? Decision { get; }
        /// <summary> Justification provided by approvers for their action. </summary>
        public string Justification { get; }
        /// <summary> Date Time when a decision was taken. </summary>
        public DateTimeOffset? ReviewedOn { get; }
        /// <summary> The outcome of applying the decision. </summary>
        public AccessReviewApplyResult? ApplyResult { get; }
        /// <summary> The date and time when the review decision was applied. </summary>
        public DateTimeOffset? AppliedOn { get; }
        /// <summary> The identity id. </summary>
        public string PrincipalIdPropertiesAppliedByPrincipalId { get; }
        /// <summary> The identity type : user/servicePrincipal. </summary>
        public AccessReviewActorIdentityType? PrincipalTypePropertiesAppliedByPrincipalType { get; }
        /// <summary> The identity display name. </summary>
        public string PrincipalNamePropertiesAppliedByPrincipalName { get; }
        /// <summary> The user principal name(if valid). </summary>
        public string UserPrincipalNamePropertiesAppliedByUserPrincipalName { get; }
        /// <summary> The identity id. </summary>
        public string PrincipalIdPropertiesReviewedByPrincipalId { get; }
        /// <summary> The identity type : user/servicePrincipal. </summary>
        public AccessReviewActorIdentityType? PrincipalTypePropertiesReviewedByPrincipalType { get; }
        /// <summary> The identity display name. </summary>
        public string PrincipalNamePropertiesReviewedByPrincipalName { get; }
        /// <summary> The user principal name(if valid). </summary>
        public string UserPrincipalNamePropertiesReviewedByUserPrincipalName { get; }
        /// <summary> The type of resource: azureRole. </summary>
        internal DecisionResourceType? TypePropertiesResourceType { get; set; }
        /// <summary> The id of resource associated with a decision record. </summary>
        public string IdPropertiesResourceId { get; }
        /// <summary> The display name of resource associated with a decision record. </summary>
        public string DisplayNamePropertiesResourceDisplayName { get; }
        /// <summary> The type of decision target : User/ServicePrincipal. </summary>
        internal DecisionTargetType? TypePropertiesPrincipalType { get; set; }
        /// <summary> The id of principal whose access was reviewed. </summary>
        public string IdPropertiesPrincipalId { get; }
        /// <summary> The display name of the user whose access was reviewed. </summary>
        public string DisplayNamePropertiesPrincipalDisplayName { get; }
    }
}
