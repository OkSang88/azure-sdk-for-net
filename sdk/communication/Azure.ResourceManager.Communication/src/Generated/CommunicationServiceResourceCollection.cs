// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Communication
{
    /// <summary>
    /// A class representing a collection of <see cref="CommunicationServiceResource" /> and their operations.
    /// Each <see cref="CommunicationServiceResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="CommunicationServiceResourceCollection" /> instance call the GetCommunicationServiceResources method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class CommunicationServiceResourceCollection : ArmCollection, IEnumerable<CommunicationServiceResource>, IAsyncEnumerable<CommunicationServiceResource>
    {
        private readonly ClientDiagnostics _communicationServiceResourceCommunicationServicesClientDiagnostics;
        private readonly CommunicationServicesRestOperations _communicationServiceResourceCommunicationServicesRestClient;

        /// <summary> Initializes a new instance of the <see cref="CommunicationServiceResourceCollection"/> class for mocking. </summary>
        protected CommunicationServiceResourceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="CommunicationServiceResourceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal CommunicationServiceResourceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _communicationServiceResourceCommunicationServicesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Communication", CommunicationServiceResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(CommunicationServiceResource.ResourceType, out string communicationServiceResourceCommunicationServicesApiVersion);
            _communicationServiceResourceCommunicationServicesRestClient = new CommunicationServicesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, communicationServiceResourceCommunicationServicesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create a new CommunicationService or update an existing CommunicationService.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Communication/communicationServices/{communicationServiceName}
        /// Operation Id: CommunicationServices_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="communicationServiceName"> The name of the CommunicationService resource. </param>
        /// <param name="data"> Parameters for the create or update operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="communicationServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="communicationServiceName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<CommunicationServiceResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string communicationServiceName, CommunicationServiceResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(communicationServiceName, nameof(communicationServiceName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _communicationServiceResourceCommunicationServicesClientDiagnostics.CreateScope("CommunicationServiceResourceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _communicationServiceResourceCommunicationServicesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, communicationServiceName, data, cancellationToken).ConfigureAwait(false);
                var operation = new CommunicationArmOperation<CommunicationServiceResource>(new CommunicationServiceResourceOperationSource(Client), _communicationServiceResourceCommunicationServicesClientDiagnostics, Pipeline, _communicationServiceResourceCommunicationServicesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, communicationServiceName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create a new CommunicationService or update an existing CommunicationService.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Communication/communicationServices/{communicationServiceName}
        /// Operation Id: CommunicationServices_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="communicationServiceName"> The name of the CommunicationService resource. </param>
        /// <param name="data"> Parameters for the create or update operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="communicationServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="communicationServiceName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<CommunicationServiceResource> CreateOrUpdate(WaitUntil waitUntil, string communicationServiceName, CommunicationServiceResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(communicationServiceName, nameof(communicationServiceName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _communicationServiceResourceCommunicationServicesClientDiagnostics.CreateScope("CommunicationServiceResourceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _communicationServiceResourceCommunicationServicesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, communicationServiceName, data, cancellationToken);
                var operation = new CommunicationArmOperation<CommunicationServiceResource>(new CommunicationServiceResourceOperationSource(Client), _communicationServiceResourceCommunicationServicesClientDiagnostics, Pipeline, _communicationServiceResourceCommunicationServicesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, communicationServiceName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Get the CommunicationService and its properties.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Communication/communicationServices/{communicationServiceName}
        /// Operation Id: CommunicationServices_Get
        /// </summary>
        /// <param name="communicationServiceName"> The name of the CommunicationService resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="communicationServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="communicationServiceName"/> is null. </exception>
        public virtual async Task<Response<CommunicationServiceResource>> GetAsync(string communicationServiceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(communicationServiceName, nameof(communicationServiceName));

            using var scope = _communicationServiceResourceCommunicationServicesClientDiagnostics.CreateScope("CommunicationServiceResourceCollection.Get");
            scope.Start();
            try
            {
                var response = await _communicationServiceResourceCommunicationServicesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, communicationServiceName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CommunicationServiceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the CommunicationService and its properties.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Communication/communicationServices/{communicationServiceName}
        /// Operation Id: CommunicationServices_Get
        /// </summary>
        /// <param name="communicationServiceName"> The name of the CommunicationService resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="communicationServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="communicationServiceName"/> is null. </exception>
        public virtual Response<CommunicationServiceResource> Get(string communicationServiceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(communicationServiceName, nameof(communicationServiceName));

            using var scope = _communicationServiceResourceCommunicationServicesClientDiagnostics.CreateScope("CommunicationServiceResourceCollection.Get");
            scope.Start();
            try
            {
                var response = _communicationServiceResourceCommunicationServicesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, communicationServiceName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CommunicationServiceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Handles requests to list all resources in a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Communication/communicationServices
        /// Operation Id: CommunicationServices_ListByResourceGroup
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="CommunicationServiceResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<CommunicationServiceResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<CommunicationServiceResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _communicationServiceResourceCommunicationServicesClientDiagnostics.CreateScope("CommunicationServiceResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _communicationServiceResourceCommunicationServicesRestClient.ListByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new CommunicationServiceResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<CommunicationServiceResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _communicationServiceResourceCommunicationServicesClientDiagnostics.CreateScope("CommunicationServiceResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _communicationServiceResourceCommunicationServicesRestClient.ListByResourceGroupNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new CommunicationServiceResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Handles requests to list all resources in a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Communication/communicationServices
        /// Operation Id: CommunicationServices_ListByResourceGroup
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="CommunicationServiceResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<CommunicationServiceResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<CommunicationServiceResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _communicationServiceResourceCommunicationServicesClientDiagnostics.CreateScope("CommunicationServiceResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _communicationServiceResourceCommunicationServicesRestClient.ListByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new CommunicationServiceResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<CommunicationServiceResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _communicationServiceResourceCommunicationServicesClientDiagnostics.CreateScope("CommunicationServiceResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _communicationServiceResourceCommunicationServicesRestClient.ListByResourceGroupNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new CommunicationServiceResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Communication/communicationServices/{communicationServiceName}
        /// Operation Id: CommunicationServices_Get
        /// </summary>
        /// <param name="communicationServiceName"> The name of the CommunicationService resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="communicationServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="communicationServiceName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string communicationServiceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(communicationServiceName, nameof(communicationServiceName));

            using var scope = _communicationServiceResourceCommunicationServicesClientDiagnostics.CreateScope("CommunicationServiceResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _communicationServiceResourceCommunicationServicesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, communicationServiceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Communication/communicationServices/{communicationServiceName}
        /// Operation Id: CommunicationServices_Get
        /// </summary>
        /// <param name="communicationServiceName"> The name of the CommunicationService resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="communicationServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="communicationServiceName"/> is null. </exception>
        public virtual Response<bool> Exists(string communicationServiceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(communicationServiceName, nameof(communicationServiceName));

            using var scope = _communicationServiceResourceCommunicationServicesClientDiagnostics.CreateScope("CommunicationServiceResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = _communicationServiceResourceCommunicationServicesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, communicationServiceName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<CommunicationServiceResource> IEnumerable<CommunicationServiceResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<CommunicationServiceResource> IAsyncEnumerable<CommunicationServiceResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
