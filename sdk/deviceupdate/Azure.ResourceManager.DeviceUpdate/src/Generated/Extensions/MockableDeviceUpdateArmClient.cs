// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.DeviceUpdate;

namespace Azure.ResourceManager.DeviceUpdate.Mocking
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public partial class MockableDeviceUpdateArmClient : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableDeviceUpdateArmClient"/> class for mocking. </summary>
        protected MockableDeviceUpdateArmClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableDeviceUpdateArmClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableDeviceUpdateArmClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        internal MockableDeviceUpdateArmClient(ArmClient client) : this(client, ResourceIdentifier.Root)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Gets an object representing a <see cref="DeviceUpdateAccountResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DeviceUpdateAccountResource.CreateResourceIdentifier" /> to create a <see cref="DeviceUpdateAccountResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DeviceUpdateAccountResource"/> object. </returns>
        public virtual DeviceUpdateAccountResource GetDeviceUpdateAccountResource(ResourceIdentifier id)
        {
            DeviceUpdateAccountResource.ValidateResourceId(id);
            return new DeviceUpdateAccountResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="DeviceUpdateInstanceResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DeviceUpdateInstanceResource.CreateResourceIdentifier" /> to create a <see cref="DeviceUpdateInstanceResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DeviceUpdateInstanceResource"/> object. </returns>
        public virtual DeviceUpdateInstanceResource GetDeviceUpdateInstanceResource(ResourceIdentifier id)
        {
            DeviceUpdateInstanceResource.ValidateResourceId(id);
            return new DeviceUpdateInstanceResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="DeviceUpdatePrivateEndpointConnectionResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DeviceUpdatePrivateEndpointConnectionResource.CreateResourceIdentifier" /> to create a <see cref="DeviceUpdatePrivateEndpointConnectionResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DeviceUpdatePrivateEndpointConnectionResource"/> object. </returns>
        public virtual DeviceUpdatePrivateEndpointConnectionResource GetDeviceUpdatePrivateEndpointConnectionResource(ResourceIdentifier id)
        {
            DeviceUpdatePrivateEndpointConnectionResource.ValidateResourceId(id);
            return new DeviceUpdatePrivateEndpointConnectionResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="PrivateLinkResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="PrivateLinkResource.CreateResourceIdentifier" /> to create a <see cref="PrivateLinkResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PrivateLinkResource"/> object. </returns>
        public virtual PrivateLinkResource GetPrivateLinkResource(ResourceIdentifier id)
        {
            PrivateLinkResource.ValidateResourceId(id);
            return new PrivateLinkResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="PrivateEndpointConnectionProxyResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="PrivateEndpointConnectionProxyResource.CreateResourceIdentifier" /> to create a <see cref="PrivateEndpointConnectionProxyResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PrivateEndpointConnectionProxyResource"/> object. </returns>
        public virtual PrivateEndpointConnectionProxyResource GetPrivateEndpointConnectionProxyResource(ResourceIdentifier id)
        {
            PrivateEndpointConnectionProxyResource.ValidateResourceId(id);
            return new PrivateEndpointConnectionProxyResource(Client, id);
        }
    }
}
