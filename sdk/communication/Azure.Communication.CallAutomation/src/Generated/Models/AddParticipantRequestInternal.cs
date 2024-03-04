// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Communication;

namespace Azure.Communication.CallAutomation
{
    /// <summary> The request payload for adding participant to the call. </summary>
    internal partial class AddParticipantRequestInternal
    {
        /// <summary> Initializes a new instance of <see cref="AddParticipantRequestInternal"/>. </summary>
        /// <param name="participantToAdd"> The participant to invite. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="participantToAdd"/> is null. </exception>
        public AddParticipantRequestInternal(CommunicationIdentifierModel participantToAdd)
        {
            if (participantToAdd == null)
            {
                throw new ArgumentNullException(nameof(participantToAdd));
            }

            ParticipantToAdd = participantToAdd;
        }

        /// <summary> Initializes a new instance of <see cref="AddParticipantRequestInternal"/>. </summary>
        /// <param name="sourceCallerIdNumber">
        /// The source caller Id, a phone number, that's shown to the PSTN participant being invited.
        /// Required only when inviting a PSTN participant.
        /// </param>
        /// <param name="sourceDisplayName">
        /// (Optional) The display name of the source that is associated with this invite operation when
        /// adding a PSTN participant or teams user.  Note: Will not update the display name in the roster.
        /// </param>
        /// <param name="participantToAdd"> The participant to invite. </param>
        /// <param name="invitationTimeoutInSeconds">
        /// Gets or sets the timeout to wait for the invited participant to pickup.
        /// The maximum value of this is 180 seconds
        /// </param>
        /// <param name="operationContext"> Used by customers when calling mid-call actions to correlate the request to the response event. </param>
        /// <param name="customCallingContext"> Used by customer to send custom calling context to targets. </param>
        /// <param name="operationCallbackUri">
        /// Set a callback URI that overrides the default callback URI set by CreateCall/AnswerCall for this operation.
        /// This setup is per-action. If this is not set, the default callback URI set by CreateCall/AnswerCall will be used.
        /// </param>
        internal AddParticipantRequestInternal(PhoneNumberIdentifierModel sourceCallerIdNumber, string sourceDisplayName, CommunicationIdentifierModel participantToAdd, int? invitationTimeoutInSeconds, string operationContext, CustomCallingContextInternal customCallingContext, string operationCallbackUri)
        {
            SourceCallerIdNumber = sourceCallerIdNumber;
            SourceDisplayName = sourceDisplayName;
            ParticipantToAdd = participantToAdd;
            InvitationTimeoutInSeconds = invitationTimeoutInSeconds;
            OperationContext = operationContext;
            CustomCallingContext = customCallingContext;
            OperationCallbackUri = operationCallbackUri;
        }

        /// <summary>
        /// The source caller Id, a phone number, that's shown to the PSTN participant being invited.
        /// Required only when inviting a PSTN participant.
        /// </summary>
        public PhoneNumberIdentifierModel SourceCallerIdNumber { get; set; }
        /// <summary>
        /// (Optional) The display name of the source that is associated with this invite operation when
        /// adding a PSTN participant or teams user.  Note: Will not update the display name in the roster.
        /// </summary>
        public string SourceDisplayName { get; set; }
        /// <summary> The participant to invite. </summary>
        public CommunicationIdentifierModel ParticipantToAdd { get; }
        /// <summary>
        /// Gets or sets the timeout to wait for the invited participant to pickup.
        /// The maximum value of this is 180 seconds
        /// </summary>
        public int? InvitationTimeoutInSeconds { get; set; }
        /// <summary> Used by customers when calling mid-call actions to correlate the request to the response event. </summary>
        public string OperationContext { get; set; }
        /// <summary> Used by customer to send custom calling context to targets. </summary>
        public CustomCallingContextInternal CustomCallingContext { get; set; }
        /// <summary>
        /// Set a callback URI that overrides the default callback URI set by CreateCall/AnswerCall for this operation.
        /// This setup is per-action. If this is not set, the default callback URI set by CreateCall/AnswerCall will be used.
        /// </summary>
        public string OperationCallbackUri { get; set; }
    }
}
