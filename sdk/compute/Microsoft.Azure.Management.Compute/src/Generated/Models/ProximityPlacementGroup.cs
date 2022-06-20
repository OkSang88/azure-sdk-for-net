// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Specifies information about the proximity placement group.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ProximityPlacementGroup : Resource
    {
        /// <summary>
        /// Initializes a new instance of the ProximityPlacementGroup class.
        /// </summary>
        public ProximityPlacementGroup()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ProximityPlacementGroup class.
        /// </summary>
        /// <param name="location">Resource location</param>
        /// <param name="id">Resource Id</param>
        /// <param name="name">Resource name</param>
        /// <param name="type">Resource type</param>
        /// <param name="tags">Resource tags</param>
        /// <param name="proximityPlacementGroupType">Specifies the type of the
        /// proximity placement group. &lt;br&gt;&lt;br&gt; Possible values
        /// are: &lt;br&gt;&lt;br&gt; **Standard** : Co-locate resources within
        /// an Azure region or Availability Zone. &lt;br&gt;&lt;br&gt;
        /// **Ultra** : For future use. Possible values include: 'Standard',
        /// 'Ultra'</param>
        /// <param name="virtualMachines">A list of references to all virtual
        /// machines in the proximity placement group.</param>
        /// <param name="virtualMachineScaleSets">A list of references to all
        /// virtual machine scale sets in the proximity placement
        /// group.</param>
        /// <param name="availabilitySets">A list of references to all
        /// availability sets in the proximity placement group.</param>
        /// <param name="colocationStatus">Describes colocation status of the
        /// Proximity Placement Group.</param>
        /// <param name="intent">Specifies the user intent of the proximity
        /// placement group.</param>
        /// <param name="zones">Specifies the Availability Zone where virtual
        /// machine, virtual machine scale set or availability set associated
        /// with the  proximity placement group can be created.</param>
        public ProximityPlacementGroup(string location, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string proximityPlacementGroupType = default(string), IList<SubResourceWithColocationStatus> virtualMachines = default(IList<SubResourceWithColocationStatus>), IList<SubResourceWithColocationStatus> virtualMachineScaleSets = default(IList<SubResourceWithColocationStatus>), IList<SubResourceWithColocationStatus> availabilitySets = default(IList<SubResourceWithColocationStatus>), InstanceViewStatus colocationStatus = default(InstanceViewStatus), ProximityPlacementGroupPropertiesIntent intent = default(ProximityPlacementGroupPropertiesIntent), IList<string> zones = default(IList<string>))
            : base(location, id, name, type, tags)
        {
            ProximityPlacementGroupType = proximityPlacementGroupType;
            VirtualMachines = virtualMachines;
            VirtualMachineScaleSets = virtualMachineScaleSets;
            AvailabilitySets = availabilitySets;
            ColocationStatus = colocationStatus;
            Intent = intent;
            Zones = zones;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets specifies the type of the proximity placement group.
        /// &amp;lt;br&amp;gt;&amp;lt;br&amp;gt; Possible values are:
        /// &amp;lt;br&amp;gt;&amp;lt;br&amp;gt; **Standard** : Co-locate
        /// resources within an Azure region or Availability Zone.
        /// &amp;lt;br&amp;gt;&amp;lt;br&amp;gt; **Ultra** : For future use.
        /// Possible values include: 'Standard', 'Ultra'
        /// </summary>
        [JsonProperty(PropertyName = "properties.proximityPlacementGroupType")]
        public string ProximityPlacementGroupType { get; set; }

        /// <summary>
        /// Gets a list of references to all virtual machines in the proximity
        /// placement group.
        /// </summary>
        [JsonProperty(PropertyName = "properties.virtualMachines")]
        public IList<SubResourceWithColocationStatus> VirtualMachines { get; private set; }

        /// <summary>
        /// Gets a list of references to all virtual machine scale sets in the
        /// proximity placement group.
        /// </summary>
        [JsonProperty(PropertyName = "properties.virtualMachineScaleSets")]
        public IList<SubResourceWithColocationStatus> VirtualMachineScaleSets { get; private set; }

        /// <summary>
        /// Gets a list of references to all availability sets in the proximity
        /// placement group.
        /// </summary>
        [JsonProperty(PropertyName = "properties.availabilitySets")]
        public IList<SubResourceWithColocationStatus> AvailabilitySets { get; private set; }

        /// <summary>
        /// Gets or sets describes colocation status of the Proximity Placement
        /// Group.
        /// </summary>
        [JsonProperty(PropertyName = "properties.colocationStatus")]
        public InstanceViewStatus ColocationStatus { get; set; }

        /// <summary>
        /// Gets or sets specifies the user intent of the proximity placement
        /// group.
        /// </summary>
        [JsonProperty(PropertyName = "properties.intent")]
        public ProximityPlacementGroupPropertiesIntent Intent { get; set; }

        /// <summary>
        /// Gets or sets specifies the Availability Zone where virtual machine,
        /// virtual machine scale set or availability set associated with the
        /// proximity placement group can be created.
        /// </summary>
        [JsonProperty(PropertyName = "zones")]
        public IList<string> Zones { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
