// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Defines an Aml Instance container. </summary>
    public partial class ComputeInstanceContainer
    {
        /// <summary> Initializes a new instance of ComputeInstanceContainer. </summary>
        internal ComputeInstanceContainer()
        {
            Services = new ChangeTrackingList<BinaryData>();
        }

        /// <summary> Initializes a new instance of ComputeInstanceContainer. </summary>
        /// <param name="name"> Name of the ComputeInstance container. </param>
        /// <param name="autosave"> Auto save settings. </param>
        /// <param name="gpu"> Information of GPU. </param>
        /// <param name="network"> network of this container. </param>
        /// <param name="environment"> Environment information of this container. </param>
        /// <param name="services"> services of this containers. </param>
        internal ComputeInstanceContainer(string name, Autosave? autosave, string gpu, Network? network, ComputeInstanceEnvironmentInfo environment, IReadOnlyList<BinaryData> services)
        {
            Name = name;
            Autosave = autosave;
            Gpu = gpu;
            Network = network;
            Environment = environment;
            Services = services;
        }

        /// <summary> Name of the ComputeInstance container. </summary>
        public string Name { get; }
        /// <summary> Auto save settings. </summary>
        public Autosave? Autosave { get; }
        /// <summary> Information of GPU. </summary>
        public string Gpu { get; }
        /// <summary> network of this container. </summary>
        public Network? Network { get; }
        /// <summary> Environment information of this container. </summary>
        public ComputeInstanceEnvironmentInfo Environment { get; }
        /// <summary> services of this containers. </summary>
        public IReadOnlyList<BinaryData> Services { get; }
    }
}
