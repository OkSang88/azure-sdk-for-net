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

namespace Azure.ResourceManager.AppContainers
{
    /// <summary>
    /// A Class representing a ContainerAppSourceControl along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="ContainerAppSourceControlResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetContainerAppSourceControlResource method.
    /// Otherwise you can get one from its parent resource <see cref="ContainerAppResource"/> using the GetContainerAppSourceControl method.
    /// </summary>
    public partial class ContainerAppSourceControlResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ContainerAppSourceControlResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="containerAppName"> The containerAppName. </param>
        /// <param name="sourceControlName"> The sourceControlName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string containerAppName, string sourceControlName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/containerApps/{containerAppName}/sourcecontrols/{sourceControlName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _containerAppSourceControlContainerAppsSourceControlsClientDiagnostics;
        private readonly ContainerAppsSourceControlsRestOperations _containerAppSourceControlContainerAppsSourceControlsRestClient;
        private readonly ContainerAppSourceControlData _data;

        /// <summary> Initializes a new instance of the <see cref="ContainerAppSourceControlResource"/> class for mocking. </summary>
        protected ContainerAppSourceControlResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ContainerAppSourceControlResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ContainerAppSourceControlResource(ArmClient client, ContainerAppSourceControlData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ContainerAppSourceControlResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ContainerAppSourceControlResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _containerAppSourceControlContainerAppsSourceControlsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppContainers", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string containerAppSourceControlContainerAppsSourceControlsApiVersion);
            _containerAppSourceControlContainerAppsSourceControlsRestClient = new ContainerAppsSourceControlsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, containerAppSourceControlContainerAppsSourceControlsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.App/containerApps/sourcecontrols";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ContainerAppSourceControlData Data
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

        /// <summary>
        /// Get a SourceControl of a Container App.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/containerApps/{containerAppName}/sourcecontrols/{sourceControlName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ContainerAppsSourceControls_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ContainerAppSourceControlResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _containerAppSourceControlContainerAppsSourceControlsClientDiagnostics.CreateScope("ContainerAppSourceControlResource.Get");
            scope.Start();
            try
            {
                var response = await _containerAppSourceControlContainerAppsSourceControlsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ContainerAppSourceControlResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a SourceControl of a Container App.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/containerApps/{containerAppName}/sourcecontrols/{sourceControlName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ContainerAppsSourceControls_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ContainerAppSourceControlResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _containerAppSourceControlContainerAppsSourceControlsClientDiagnostics.CreateScope("ContainerAppSourceControlResource.Get");
            scope.Start();
            try
            {
                var response = _containerAppSourceControlContainerAppsSourceControlsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ContainerAppSourceControlResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete a Container App SourceControl.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/containerApps/{containerAppName}/sourcecontrols/{sourceControlName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ContainerAppsSourceControls_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _containerAppSourceControlContainerAppsSourceControlsClientDiagnostics.CreateScope("ContainerAppSourceControlResource.Delete");
            scope.Start();
            try
            {
                var response = await _containerAppSourceControlContainerAppsSourceControlsRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new AppContainersArmOperation(_containerAppSourceControlContainerAppsSourceControlsClientDiagnostics, Pipeline, _containerAppSourceControlContainerAppsSourceControlsRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Delete a Container App SourceControl.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/containerApps/{containerAppName}/sourcecontrols/{sourceControlName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ContainerAppsSourceControls_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _containerAppSourceControlContainerAppsSourceControlsClientDiagnostics.CreateScope("ContainerAppSourceControlResource.Delete");
            scope.Start();
            try
            {
                var response = _containerAppSourceControlContainerAppsSourceControlsRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new AppContainersArmOperation(_containerAppSourceControlContainerAppsSourceControlsClientDiagnostics, Pipeline, _containerAppSourceControlContainerAppsSourceControlsRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Create or update the SourceControl for a Container App.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/containerApps/{containerAppName}/sourcecontrols/{sourceControlName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ContainerAppsSourceControls_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Properties used to create a Container App SourceControl. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ContainerAppSourceControlResource>> UpdateAsync(WaitUntil waitUntil, ContainerAppSourceControlData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _containerAppSourceControlContainerAppsSourceControlsClientDiagnostics.CreateScope("ContainerAppSourceControlResource.Update");
            scope.Start();
            try
            {
                var response = await _containerAppSourceControlContainerAppsSourceControlsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new AppContainersArmOperation<ContainerAppSourceControlResource>(new ContainerAppSourceControlOperationSource(Client), _containerAppSourceControlContainerAppsSourceControlsClientDiagnostics, Pipeline, _containerAppSourceControlContainerAppsSourceControlsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.Location);
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
        /// Create or update the SourceControl for a Container App.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/containerApps/{containerAppName}/sourcecontrols/{sourceControlName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ContainerAppsSourceControls_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Properties used to create a Container App SourceControl. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ContainerAppSourceControlResource> Update(WaitUntil waitUntil, ContainerAppSourceControlData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _containerAppSourceControlContainerAppsSourceControlsClientDiagnostics.CreateScope("ContainerAppSourceControlResource.Update");
            scope.Start();
            try
            {
                var response = _containerAppSourceControlContainerAppsSourceControlsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new AppContainersArmOperation<ContainerAppSourceControlResource>(new ContainerAppSourceControlOperationSource(Client), _containerAppSourceControlContainerAppsSourceControlsClientDiagnostics, Pipeline, _containerAppSourceControlContainerAppsSourceControlsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.Location);
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
    }
}
