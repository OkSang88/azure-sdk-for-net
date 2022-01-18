// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Compute;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The List VMSS VM Extension operation response. </summary>
    public partial class VirtualMachineScaleSetVMExtensionsListResult
    {
        /// <summary> Initializes a new instance of VirtualMachineScaleSetVMExtensionsListResult. </summary>
        internal VirtualMachineScaleSetVMExtensionsListResult()
        {
            Value = new ChangeTrackingList<VirtualMachineScaleSetVmExtensionData>();
        }

        /// <summary> Initializes a new instance of VirtualMachineScaleSetVMExtensionsListResult. </summary>
        /// <param name="value"> The list of VMSS VM extensions. </param>
        internal VirtualMachineScaleSetVMExtensionsListResult(IReadOnlyList<VirtualMachineScaleSetVmExtensionData> value)
        {
            Value = value;
        }

        /// <summary> The list of VMSS VM extensions. </summary>
        public IReadOnlyList<VirtualMachineScaleSetVmExtensionData> Value { get; }
    }
}
