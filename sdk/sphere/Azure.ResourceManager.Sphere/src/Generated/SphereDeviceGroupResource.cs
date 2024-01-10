// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Sphere.Models;

namespace Azure.ResourceManager.Sphere
{
    /// <summary>
    /// A Class representing a SphereDeviceGroup along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="SphereDeviceGroupResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetSphereDeviceGroupResource method.
    /// Otherwise you can get one from its parent resource <see cref="SphereProductResource"/> using the GetSphereDeviceGroup method.
    /// </summary>
    public partial class SphereDeviceGroupResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SphereDeviceGroupResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="catalogName"> The catalogName. </param>
        /// <param name="productName"> The productName. </param>
        /// <param name="deviceGroupName"> The deviceGroupName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string catalogName, string productName, string deviceGroupName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureSphere/catalogs/{catalogName}/products/{productName}/deviceGroups/{deviceGroupName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _sphereDeviceGroupDeviceGroupsClientDiagnostics;
        private readonly DeviceGroupsRestOperations _sphereDeviceGroupDeviceGroupsRestClient;
        private readonly SphereDeviceGroupData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.AzureSphere/catalogs/products/deviceGroups";

        /// <summary> Initializes a new instance of the <see cref="SphereDeviceGroupResource"/> class for mocking. </summary>
        protected SphereDeviceGroupResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SphereDeviceGroupResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SphereDeviceGroupResource(ArmClient client, SphereDeviceGroupData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SphereDeviceGroupResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SphereDeviceGroupResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _sphereDeviceGroupDeviceGroupsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sphere", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string sphereDeviceGroupDeviceGroupsApiVersion);
            _sphereDeviceGroupDeviceGroupsRestClient = new DeviceGroupsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, sphereDeviceGroupDeviceGroupsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual SphereDeviceGroupData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary> Gets a collection of SphereDeploymentResources in the SphereDeviceGroup. </summary>
        /// <returns> An object representing collection of SphereDeploymentResources and their operations over a SphereDeploymentResource. </returns>
        public virtual SphereDeploymentCollection GetSphereDeployments()
        {
            return GetCachedClient(client => new SphereDeploymentCollection(client, Id));
        }

        /// <summary>
        /// Get a Deployment. '.default' and '.unassigned' are system defined values and cannot be used for product or device group name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureSphere/catalogs/{catalogName}/products/{productName}/deviceGroups/{deviceGroupName}/deployments/{deploymentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Deployments_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SphereDeploymentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="deploymentName"> Deployment name. Use .default for deployment creation and to get the current deployment for the associated device group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="deploymentName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="deploymentName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<SphereDeploymentResource>> GetSphereDeploymentAsync(string deploymentName, CancellationToken cancellationToken = default)
        {
            return await GetSphereDeployments().GetAsync(deploymentName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a Deployment. '.default' and '.unassigned' are system defined values and cannot be used for product or device group name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureSphere/catalogs/{catalogName}/products/{productName}/deviceGroups/{deviceGroupName}/deployments/{deploymentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Deployments_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SphereDeploymentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="deploymentName"> Deployment name. Use .default for deployment creation and to get the current deployment for the associated device group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="deploymentName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="deploymentName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<SphereDeploymentResource> GetSphereDeployment(string deploymentName, CancellationToken cancellationToken = default)
        {
            return GetSphereDeployments().Get(deploymentName, cancellationToken);
        }

        /// <summary> Gets a collection of SphereDeviceResources in the SphereDeviceGroup. </summary>
        /// <returns> An object representing collection of SphereDeviceResources and their operations over a SphereDeviceResource. </returns>
        public virtual SphereDeviceCollection GetSphereDevices()
        {
            return GetCachedClient(client => new SphereDeviceCollection(client, Id));
        }

        /// <summary>
        /// Get a Device. Use '.unassigned' or '.default' for the device group and product names when a device does not belong to a device group and product.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureSphere/catalogs/{catalogName}/products/{productName}/deviceGroups/{deviceGroupName}/devices/{deviceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Devices_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SphereDeviceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="deviceName"> Device name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="deviceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="deviceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<SphereDeviceResource>> GetSphereDeviceAsync(string deviceName, CancellationToken cancellationToken = default)
        {
            return await GetSphereDevices().GetAsync(deviceName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a Device. Use '.unassigned' or '.default' for the device group and product names when a device does not belong to a device group and product.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureSphere/catalogs/{catalogName}/products/{productName}/deviceGroups/{deviceGroupName}/devices/{deviceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Devices_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SphereDeviceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="deviceName"> Device name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="deviceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="deviceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<SphereDeviceResource> GetSphereDevice(string deviceName, CancellationToken cancellationToken = default)
        {
            return GetSphereDevices().Get(deviceName, cancellationToken);
        }

        /// <summary>
        /// Get a DeviceGroup. '.default' and '.unassigned' are system defined values and cannot be used for product or device group name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureSphere/catalogs/{catalogName}/products/{productName}/deviceGroups/{deviceGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeviceGroups_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SphereDeviceGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SphereDeviceGroupResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _sphereDeviceGroupDeviceGroupsClientDiagnostics.CreateScope("SphereDeviceGroupResource.Get");
            scope.Start();
            try
            {
                var response = await _sphereDeviceGroupDeviceGroupsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SphereDeviceGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a DeviceGroup. '.default' and '.unassigned' are system defined values and cannot be used for product or device group name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureSphere/catalogs/{catalogName}/products/{productName}/deviceGroups/{deviceGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeviceGroups_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SphereDeviceGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SphereDeviceGroupResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _sphereDeviceGroupDeviceGroupsClientDiagnostics.CreateScope("SphereDeviceGroupResource.Get");
            scope.Start();
            try
            {
                var response = _sphereDeviceGroupDeviceGroupsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SphereDeviceGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete a DeviceGroup. '.default' and '.unassigned' are system defined values and cannot be used for product or device group name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureSphere/catalogs/{catalogName}/products/{productName}/deviceGroups/{deviceGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeviceGroups_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SphereDeviceGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _sphereDeviceGroupDeviceGroupsClientDiagnostics.CreateScope("SphereDeviceGroupResource.Delete");
            scope.Start();
            try
            {
                var response = await _sphereDeviceGroupDeviceGroupsRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new SphereArmOperation(_sphereDeviceGroupDeviceGroupsClientDiagnostics, Pipeline, _sphereDeviceGroupDeviceGroupsRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete a DeviceGroup. '.default' and '.unassigned' are system defined values and cannot be used for product or device group name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureSphere/catalogs/{catalogName}/products/{productName}/deviceGroups/{deviceGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeviceGroups_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SphereDeviceGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _sphereDeviceGroupDeviceGroupsClientDiagnostics.CreateScope("SphereDeviceGroupResource.Delete");
            scope.Start();
            try
            {
                var response = _sphereDeviceGroupDeviceGroupsRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new SphereArmOperation(_sphereDeviceGroupDeviceGroupsClientDiagnostics, Pipeline, _sphereDeviceGroupDeviceGroupsRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Update a DeviceGroup. '.default' and '.unassigned' are system defined values and cannot be used for product or device group name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureSphere/catalogs/{catalogName}/products/{productName}/deviceGroups/{deviceGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeviceGroups_Update</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SphereDeviceGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="patch"> The resource properties to be updated. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patch"/> is null. </exception>
        public virtual async Task<ArmOperation<SphereDeviceGroupResource>> UpdateAsync(WaitUntil waitUntil, SphereDeviceGroupPatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(patch, nameof(patch));

            using var scope = _sphereDeviceGroupDeviceGroupsClientDiagnostics.CreateScope("SphereDeviceGroupResource.Update");
            scope.Start();
            try
            {
                var response = await _sphereDeviceGroupDeviceGroupsRestClient.UpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, patch, cancellationToken).ConfigureAwait(false);
                var operation = new SphereArmOperation<SphereDeviceGroupResource>(new SphereDeviceGroupOperationSource(Client), _sphereDeviceGroupDeviceGroupsClientDiagnostics, Pipeline, _sphereDeviceGroupDeviceGroupsRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, patch).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Update a DeviceGroup. '.default' and '.unassigned' are system defined values and cannot be used for product or device group name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureSphere/catalogs/{catalogName}/products/{productName}/deviceGroups/{deviceGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeviceGroups_Update</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SphereDeviceGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="patch"> The resource properties to be updated. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patch"/> is null. </exception>
        public virtual ArmOperation<SphereDeviceGroupResource> Update(WaitUntil waitUntil, SphereDeviceGroupPatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(patch, nameof(patch));

            using var scope = _sphereDeviceGroupDeviceGroupsClientDiagnostics.CreateScope("SphereDeviceGroupResource.Update");
            scope.Start();
            try
            {
                var response = _sphereDeviceGroupDeviceGroupsRestClient.Update(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, patch, cancellationToken);
                var operation = new SphereArmOperation<SphereDeviceGroupResource>(new SphereDeviceGroupOperationSource(Client), _sphereDeviceGroupDeviceGroupsClientDiagnostics, Pipeline, _sphereDeviceGroupDeviceGroupsRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, patch).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Bulk claims the devices. Use '.unassigned' or '.default' for the device group and product names when bulk claiming devices to a catalog only.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureSphere/catalogs/{catalogName}/products/{productName}/deviceGroups/{deviceGroupName}/claimDevices</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeviceGroups_ClaimDevices</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SphereDeviceGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="content"> Bulk claim devices request body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation> ClaimDevicesAsync(WaitUntil waitUntil, ClaimSphereDevicesContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _sphereDeviceGroupDeviceGroupsClientDiagnostics.CreateScope("SphereDeviceGroupResource.ClaimDevices");
            scope.Start();
            try
            {
                var response = await _sphereDeviceGroupDeviceGroupsRestClient.ClaimDevicesAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, content, cancellationToken).ConfigureAwait(false);
                var operation = new SphereArmOperation(_sphereDeviceGroupDeviceGroupsClientDiagnostics, Pipeline, _sphereDeviceGroupDeviceGroupsRestClient.CreateClaimDevicesRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, content).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Bulk claims the devices. Use '.unassigned' or '.default' for the device group and product names when bulk claiming devices to a catalog only.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureSphere/catalogs/{catalogName}/products/{productName}/deviceGroups/{deviceGroupName}/claimDevices</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeviceGroups_ClaimDevices</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SphereDeviceGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="content"> Bulk claim devices request body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual ArmOperation ClaimDevices(WaitUntil waitUntil, ClaimSphereDevicesContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _sphereDeviceGroupDeviceGroupsClientDiagnostics.CreateScope("SphereDeviceGroupResource.ClaimDevices");
            scope.Start();
            try
            {
                var response = _sphereDeviceGroupDeviceGroupsRestClient.ClaimDevices(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, content, cancellationToken);
                var operation = new SphereArmOperation(_sphereDeviceGroupDeviceGroupsClientDiagnostics, Pipeline, _sphereDeviceGroupDeviceGroupsRestClient.CreateClaimDevicesRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, content).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Counts devices in device group. '.default' and '.unassigned' are system defined values and cannot be used for product or device group name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureSphere/catalogs/{catalogName}/products/{productName}/deviceGroups/{deviceGroupName}/countDevices</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeviceGroups_CountDevices</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SphereDeviceGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<CountDeviceResult>> CountDevicesAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _sphereDeviceGroupDeviceGroupsClientDiagnostics.CreateScope("SphereDeviceGroupResource.CountDevices");
            scope.Start();
            try
            {
                var response = await _sphereDeviceGroupDeviceGroupsRestClient.CountDevicesAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Counts devices in device group. '.default' and '.unassigned' are system defined values and cannot be used for product or device group name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureSphere/catalogs/{catalogName}/products/{productName}/deviceGroups/{deviceGroupName}/countDevices</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeviceGroups_CountDevices</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SphereDeviceGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<CountDeviceResult> CountDevices(CancellationToken cancellationToken = default)
        {
            using var scope = _sphereDeviceGroupDeviceGroupsClientDiagnostics.CreateScope("SphereDeviceGroupResource.CountDevices");
            scope.Start();
            try
            {
                var response = _sphereDeviceGroupDeviceGroupsRestClient.CountDevices(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
