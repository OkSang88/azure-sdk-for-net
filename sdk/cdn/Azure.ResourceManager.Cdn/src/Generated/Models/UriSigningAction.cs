// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Defines the url signing action for the delivery rule. </summary>
    public partial class UriSigningAction : DeliveryRuleAction
    {
        /// <summary> Initializes a new instance of <see cref="UriSigningAction"/>. </summary>
        /// <param name="properties"> Defines the parameters for the action. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public UriSigningAction(UriSigningActionProperties properties)
        {
            if (properties == null)
            {
                throw new ArgumentNullException(nameof(properties));
            }

            Properties = properties;
            Name = DeliveryRuleActionType.UriSigning;
        }

        /// <summary> Initializes a new instance of <see cref="UriSigningAction"/>. </summary>
        /// <param name="name"> The name of the action for the delivery rule. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="properties"> Defines the parameters for the action. </param>
        internal UriSigningAction(DeliveryRuleActionType name, IDictionary<string, BinaryData> serializedAdditionalRawData, UriSigningActionProperties properties) : base(name, serializedAdditionalRawData)
        {
            Properties = properties;
            Name = name;
        }

        /// <summary> Initializes a new instance of <see cref="UriSigningAction"/> for deserialization. </summary>
        internal UriSigningAction()
        {
        }

        /// <summary> Defines the parameters for the action. </summary>
        public UriSigningActionProperties Properties { get; set; }
    }
}
