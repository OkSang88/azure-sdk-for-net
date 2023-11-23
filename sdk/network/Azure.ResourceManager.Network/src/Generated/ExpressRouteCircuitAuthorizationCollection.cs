// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing a collection of <see cref="ExpressRouteCircuitAuthorizationResource"/> and their operations.
    /// Each <see cref="ExpressRouteCircuitAuthorizationResource"/> in the collection will belong to the same instance of <see cref="ExpressRouteCircuitResource"/>.
    /// To get an <see cref="ExpressRouteCircuitAuthorizationCollection"/> instance call the GetExpressRouteCircuitAuthorizations method from an instance of <see cref="ExpressRouteCircuitResource"/>.
    /// </summary>
    public partial class ExpressRouteCircuitAuthorizationCollection : ArmCollection, IEnumerable<ExpressRouteCircuitAuthorizationResource>, IAsyncEnumerable<ExpressRouteCircuitAuthorizationResource>
    {
        private readonly ClientDiagnostics _expressRouteCircuitAuthorizationClientDiagnostics;
        private readonly ExpressRouteCircuitAuthorizationsRestOperations _expressRouteCircuitAuthorizationRestClient;

        /// <summary> Initializes a new instance of the <see cref="ExpressRouteCircuitAuthorizationCollection"/> class for mocking. </summary>
        protected ExpressRouteCircuitAuthorizationCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ExpressRouteCircuitAuthorizationCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ExpressRouteCircuitAuthorizationCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _expressRouteCircuitAuthorizationClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", ExpressRouteCircuitAuthorizationResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ExpressRouteCircuitAuthorizationResource.ResourceType, out string expressRouteCircuitAuthorizationApiVersion);
            _expressRouteCircuitAuthorizationRestClient = new ExpressRouteCircuitAuthorizationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, expressRouteCircuitAuthorizationApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ExpressRouteCircuitResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ExpressRouteCircuitResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates an authorization in the specified express route circuit.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCircuits/{circuitName}/authorizations/{authorizationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExpressRouteCircuitAuthorizations_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="authorizationName"> The name of the authorization. </param>
        /// <param name="data"> Parameters supplied to the create or update express route circuit authorization operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ExpressRouteCircuitAuthorizationResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string authorizationName, ExpressRouteCircuitAuthorizationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationName, nameof(authorizationName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _expressRouteCircuitAuthorizationClientDiagnostics.CreateScope("ExpressRouteCircuitAuthorizationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _expressRouteCircuitAuthorizationRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, authorizationName, data, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation<ExpressRouteCircuitAuthorizationResource>(new ExpressRouteCircuitAuthorizationOperationSource(Client), _expressRouteCircuitAuthorizationClientDiagnostics, Pipeline, _expressRouteCircuitAuthorizationRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, authorizationName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates or updates an authorization in the specified express route circuit.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCircuits/{circuitName}/authorizations/{authorizationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExpressRouteCircuitAuthorizations_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="authorizationName"> The name of the authorization. </param>
        /// <param name="data"> Parameters supplied to the create or update express route circuit authorization operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ExpressRouteCircuitAuthorizationResource> CreateOrUpdate(WaitUntil waitUntil, string authorizationName, ExpressRouteCircuitAuthorizationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationName, nameof(authorizationName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _expressRouteCircuitAuthorizationClientDiagnostics.CreateScope("ExpressRouteCircuitAuthorizationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _expressRouteCircuitAuthorizationRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, authorizationName, data, cancellationToken);
                var operation = new NetworkArmOperation<ExpressRouteCircuitAuthorizationResource>(new ExpressRouteCircuitAuthorizationOperationSource(Client), _expressRouteCircuitAuthorizationClientDiagnostics, Pipeline, _expressRouteCircuitAuthorizationRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, authorizationName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Gets the specified authorization from the specified express route circuit.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCircuits/{circuitName}/authorizations/{authorizationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExpressRouteCircuitAuthorizations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="authorizationName"> The name of the authorization. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationName"/> is null. </exception>
        public virtual async Task<Response<ExpressRouteCircuitAuthorizationResource>> GetAsync(string authorizationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationName, nameof(authorizationName));

            using var scope = _expressRouteCircuitAuthorizationClientDiagnostics.CreateScope("ExpressRouteCircuitAuthorizationCollection.Get");
            scope.Start();
            try
            {
                var response = await _expressRouteCircuitAuthorizationRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, authorizationName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ExpressRouteCircuitAuthorizationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified authorization from the specified express route circuit.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCircuits/{circuitName}/authorizations/{authorizationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExpressRouteCircuitAuthorizations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="authorizationName"> The name of the authorization. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationName"/> is null. </exception>
        public virtual Response<ExpressRouteCircuitAuthorizationResource> Get(string authorizationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationName, nameof(authorizationName));

            using var scope = _expressRouteCircuitAuthorizationClientDiagnostics.CreateScope("ExpressRouteCircuitAuthorizationCollection.Get");
            scope.Start();
            try
            {
                var response = _expressRouteCircuitAuthorizationRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, authorizationName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ExpressRouteCircuitAuthorizationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all authorizations in an express route circuit.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCircuits/{circuitName}/authorizations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExpressRouteCircuitAuthorizations_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ExpressRouteCircuitAuthorizationResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ExpressRouteCircuitAuthorizationResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _expressRouteCircuitAuthorizationRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _expressRouteCircuitAuthorizationRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ExpressRouteCircuitAuthorizationResource(Client, ExpressRouteCircuitAuthorizationData.DeserializeExpressRouteCircuitAuthorizationData(e)), _expressRouteCircuitAuthorizationClientDiagnostics, Pipeline, "ExpressRouteCircuitAuthorizationCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets all authorizations in an express route circuit.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCircuits/{circuitName}/authorizations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExpressRouteCircuitAuthorizations_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ExpressRouteCircuitAuthorizationResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ExpressRouteCircuitAuthorizationResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _expressRouteCircuitAuthorizationRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _expressRouteCircuitAuthorizationRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ExpressRouteCircuitAuthorizationResource(Client, ExpressRouteCircuitAuthorizationData.DeserializeExpressRouteCircuitAuthorizationData(e)), _expressRouteCircuitAuthorizationClientDiagnostics, Pipeline, "ExpressRouteCircuitAuthorizationCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCircuits/{circuitName}/authorizations/{authorizationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExpressRouteCircuitAuthorizations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="authorizationName"> The name of the authorization. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string authorizationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationName, nameof(authorizationName));

            using var scope = _expressRouteCircuitAuthorizationClientDiagnostics.CreateScope("ExpressRouteCircuitAuthorizationCollection.Exists");
            scope.Start();
            try
            {
                var response = await _expressRouteCircuitAuthorizationRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, authorizationName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCircuits/{circuitName}/authorizations/{authorizationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExpressRouteCircuitAuthorizations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="authorizationName"> The name of the authorization. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationName"/> is null. </exception>
        public virtual Response<bool> Exists(string authorizationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationName, nameof(authorizationName));

            using var scope = _expressRouteCircuitAuthorizationClientDiagnostics.CreateScope("ExpressRouteCircuitAuthorizationCollection.Exists");
            scope.Start();
            try
            {
                var response = _expressRouteCircuitAuthorizationRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, authorizationName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCircuits/{circuitName}/authorizations/{authorizationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExpressRouteCircuitAuthorizations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="authorizationName"> The name of the authorization. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationName"/> is null. </exception>
        public virtual async Task<NullableResponse<ExpressRouteCircuitAuthorizationResource>> GetIfExistsAsync(string authorizationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationName, nameof(authorizationName));

            using var scope = _expressRouteCircuitAuthorizationClientDiagnostics.CreateScope("ExpressRouteCircuitAuthorizationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _expressRouteCircuitAuthorizationRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, authorizationName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ExpressRouteCircuitAuthorizationResource>(response.GetRawResponse());
                return Response.FromValue(new ExpressRouteCircuitAuthorizationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCircuits/{circuitName}/authorizations/{authorizationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExpressRouteCircuitAuthorizations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="authorizationName"> The name of the authorization. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationName"/> is null. </exception>
        public virtual NullableResponse<ExpressRouteCircuitAuthorizationResource> GetIfExists(string authorizationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationName, nameof(authorizationName));

            using var scope = _expressRouteCircuitAuthorizationClientDiagnostics.CreateScope("ExpressRouteCircuitAuthorizationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _expressRouteCircuitAuthorizationRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, authorizationName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ExpressRouteCircuitAuthorizationResource>(response.GetRawResponse());
                return Response.FromValue(new ExpressRouteCircuitAuthorizationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ExpressRouteCircuitAuthorizationResource> IEnumerable<ExpressRouteCircuitAuthorizationResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ExpressRouteCircuitAuthorizationResource> IAsyncEnumerable<ExpressRouteCircuitAuthorizationResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
