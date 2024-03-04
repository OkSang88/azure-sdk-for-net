// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> VirtualMachinePlacementHint represents a single scheduling hint of the virtual machine. </summary>
    public partial class VirtualMachinePlacementHint
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="VirtualMachinePlacementHint"/>. </summary>
        /// <param name="hintType"> The specification of whether this hint supports affinity or anti-affinity with the referenced resources. </param>
        /// <param name="resourceId"> The resource ID of the target object that the placement hints will be checked against, e.g., the bare metal node to host the virtual machine. </param>
        /// <param name="schedulingExecution"> The indicator of whether the hint is a hard or soft requirement during scheduling. </param>
        /// <param name="scope"> The scope for the virtual machine affinity or anti-affinity placement hint. It should always be "Machine" in the case of node affinity. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceId"/> is null. </exception>
        public VirtualMachinePlacementHint(VirtualMachinePlacementHintType hintType, ResourceIdentifier resourceId, VirtualMachineSchedulingExecution schedulingExecution, VirtualMachinePlacementHintPodAffinityScope scope)
        {
            if (resourceId == null)
            {
                throw new ArgumentNullException(nameof(resourceId));
            }

            HintType = hintType;
            ResourceId = resourceId;
            SchedulingExecution = schedulingExecution;
            Scope = scope;
        }

        /// <summary> Initializes a new instance of <see cref="VirtualMachinePlacementHint"/>. </summary>
        /// <param name="hintType"> The specification of whether this hint supports affinity or anti-affinity with the referenced resources. </param>
        /// <param name="resourceId"> The resource ID of the target object that the placement hints will be checked against, e.g., the bare metal node to host the virtual machine. </param>
        /// <param name="schedulingExecution"> The indicator of whether the hint is a hard or soft requirement during scheduling. </param>
        /// <param name="scope"> The scope for the virtual machine affinity or anti-affinity placement hint. It should always be "Machine" in the case of node affinity. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal VirtualMachinePlacementHint(VirtualMachinePlacementHintType hintType, ResourceIdentifier resourceId, VirtualMachineSchedulingExecution schedulingExecution, VirtualMachinePlacementHintPodAffinityScope scope, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            HintType = hintType;
            ResourceId = resourceId;
            SchedulingExecution = schedulingExecution;
            Scope = scope;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="VirtualMachinePlacementHint"/> for deserialization. </summary>
        internal VirtualMachinePlacementHint()
        {
        }

        /// <summary> The specification of whether this hint supports affinity or anti-affinity with the referenced resources. </summary>
        public VirtualMachinePlacementHintType HintType { get; set; }
        /// <summary> The resource ID of the target object that the placement hints will be checked against, e.g., the bare metal node to host the virtual machine. </summary>
        public ResourceIdentifier ResourceId { get; set; }
        /// <summary> The indicator of whether the hint is a hard or soft requirement during scheduling. </summary>
        public VirtualMachineSchedulingExecution SchedulingExecution { get; set; }
        /// <summary> The scope for the virtual machine affinity or anti-affinity placement hint. It should always be "Machine" in the case of node affinity. </summary>
        public VirtualMachinePlacementHintPodAffinityScope Scope { get; set; }
    }
}
