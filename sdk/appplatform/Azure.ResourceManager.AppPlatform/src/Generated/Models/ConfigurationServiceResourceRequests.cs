// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> Resource request payload of Application Configuration Service. </summary>
    public partial class ConfigurationServiceResourceRequests
    {
        /// <summary> Initializes a new instance of ConfigurationServiceResourceRequests. </summary>
        internal ConfigurationServiceResourceRequests()
        {
        }

        /// <summary> Initializes a new instance of ConfigurationServiceResourceRequests. </summary>
        /// <param name="cpu"> Cpu allocated to each Application Configuration Service instance. </param>
        /// <param name="memory"> Memory allocated to each Application Configuration Service instance. </param>
        /// <param name="instanceCount"> Instance count of the Application Configuration Service. </param>
        internal ConfigurationServiceResourceRequests(string cpu, string memory, int? instanceCount)
        {
            Cpu = cpu;
            Memory = memory;
            InstanceCount = instanceCount;
        }

        /// <summary> Cpu allocated to each Application Configuration Service instance. </summary>
        public string Cpu { get; }
        /// <summary> Memory allocated to each Application Configuration Service instance. </summary>
        public string Memory { get; }
        /// <summary> Instance count of the Application Configuration Service. </summary>
        public int? InstanceCount { get; }
    }
}
