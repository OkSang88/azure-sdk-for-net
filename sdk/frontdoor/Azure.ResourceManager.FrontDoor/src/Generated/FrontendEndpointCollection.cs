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

namespace Azure.ResourceManager.FrontDoor
{
    /// <summary>
    /// A class representing a collection of <see cref="FrontendEndpointResource" /> and their operations.
    /// Each <see cref="FrontendEndpointResource" /> in the collection will belong to the same instance of <see cref="FrontDoorResource" />.
    /// To get a <see cref="FrontendEndpointCollection" /> instance call the GetFrontendEndpoints method from an instance of <see cref="FrontDoorResource" />.
    /// </summary>
    public partial class FrontendEndpointCollection : ArmCollection, IEnumerable<FrontendEndpointResource>, IAsyncEnumerable<FrontendEndpointResource>
    {
        private readonly ClientDiagnostics _frontendEndpointClientDiagnostics;
        private readonly FrontendEndpointsRestOperations _frontendEndpointRestClient;

        /// <summary> Initializes a new instance of the <see cref="FrontendEndpointCollection"/> class for mocking. </summary>
        protected FrontendEndpointCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="FrontendEndpointCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal FrontendEndpointCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _frontendEndpointClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.FrontDoor", FrontendEndpointResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(FrontendEndpointResource.ResourceType, out string frontendEndpointApiVersion);
            _frontendEndpointRestClient = new FrontendEndpointsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, frontendEndpointApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != FrontDoorResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, FrontDoorResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets a Frontend endpoint with the specified name within the specified Front Door.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/frontDoors/{frontDoorName}/frontendEndpoints/{frontendEndpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FrontendEndpoints_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="frontendEndpointName"> Name of the Frontend endpoint which is unique within the Front Door. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="frontendEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="frontendEndpointName"/> is null. </exception>
        public virtual async Task<Response<FrontendEndpointResource>> GetAsync(string frontendEndpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(frontendEndpointName, nameof(frontendEndpointName));

            using var scope = _frontendEndpointClientDiagnostics.CreateScope("FrontendEndpointCollection.Get");
            scope.Start();
            try
            {
                var response = await _frontendEndpointRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, frontendEndpointName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new FrontendEndpointResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a Frontend endpoint with the specified name within the specified Front Door.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/frontDoors/{frontDoorName}/frontendEndpoints/{frontendEndpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FrontendEndpoints_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="frontendEndpointName"> Name of the Frontend endpoint which is unique within the Front Door. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="frontendEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="frontendEndpointName"/> is null. </exception>
        public virtual Response<FrontendEndpointResource> Get(string frontendEndpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(frontendEndpointName, nameof(frontendEndpointName));

            using var scope = _frontendEndpointClientDiagnostics.CreateScope("FrontendEndpointCollection.Get");
            scope.Start();
            try
            {
                var response = _frontendEndpointRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, frontendEndpointName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new FrontendEndpointResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all of the frontend endpoints within a Front Door.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/frontDoors/{frontDoorName}/frontendEndpoints</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FrontendEndpoints_ListByFrontDoor</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="FrontendEndpointResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<FrontendEndpointResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _frontendEndpointRestClient.CreateListByFrontDoorRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _frontendEndpointRestClient.CreateListByFrontDoorNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new FrontendEndpointResource(Client, FrontendEndpointData.DeserializeFrontendEndpointData(e)), _frontendEndpointClientDiagnostics, Pipeline, "FrontendEndpointCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all of the frontend endpoints within a Front Door.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/frontDoors/{frontDoorName}/frontendEndpoints</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FrontendEndpoints_ListByFrontDoor</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="FrontendEndpointResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<FrontendEndpointResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _frontendEndpointRestClient.CreateListByFrontDoorRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _frontendEndpointRestClient.CreateListByFrontDoorNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new FrontendEndpointResource(Client, FrontendEndpointData.DeserializeFrontendEndpointData(e)), _frontendEndpointClientDiagnostics, Pipeline, "FrontendEndpointCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/frontDoors/{frontDoorName}/frontendEndpoints/{frontendEndpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FrontendEndpoints_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="frontendEndpointName"> Name of the Frontend endpoint which is unique within the Front Door. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="frontendEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="frontendEndpointName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string frontendEndpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(frontendEndpointName, nameof(frontendEndpointName));

            using var scope = _frontendEndpointClientDiagnostics.CreateScope("FrontendEndpointCollection.Exists");
            scope.Start();
            try
            {
                var response = await _frontendEndpointRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, frontendEndpointName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/frontDoors/{frontDoorName}/frontendEndpoints/{frontendEndpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FrontendEndpoints_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="frontendEndpointName"> Name of the Frontend endpoint which is unique within the Front Door. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="frontendEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="frontendEndpointName"/> is null. </exception>
        public virtual Response<bool> Exists(string frontendEndpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(frontendEndpointName, nameof(frontendEndpointName));

            using var scope = _frontendEndpointClientDiagnostics.CreateScope("FrontendEndpointCollection.Exists");
            scope.Start();
            try
            {
                var response = _frontendEndpointRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, frontendEndpointName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/frontDoors/{frontDoorName}/frontendEndpoints/{frontendEndpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FrontendEndpoints_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="frontendEndpointName"> Name of the Frontend endpoint which is unique within the Front Door. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="frontendEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="frontendEndpointName"/> is null. </exception>
        public virtual async Task<NullableResponse<FrontendEndpointResource>> GetIfExistsAsync(string frontendEndpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(frontendEndpointName, nameof(frontendEndpointName));

            using var scope = _frontendEndpointClientDiagnostics.CreateScope("FrontendEndpointCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _frontendEndpointRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, frontendEndpointName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<FrontendEndpointResource>(response.GetRawResponse());
                return Response.FromValue(new FrontendEndpointResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/frontDoors/{frontDoorName}/frontendEndpoints/{frontendEndpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FrontendEndpoints_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="frontendEndpointName"> Name of the Frontend endpoint which is unique within the Front Door. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="frontendEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="frontendEndpointName"/> is null. </exception>
        public virtual NullableResponse<FrontendEndpointResource> GetIfExists(string frontendEndpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(frontendEndpointName, nameof(frontendEndpointName));

            using var scope = _frontendEndpointClientDiagnostics.CreateScope("FrontendEndpointCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _frontendEndpointRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, frontendEndpointName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<FrontendEndpointResource>(response.GetRawResponse());
                return Response.FromValue(new FrontendEndpointResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<FrontendEndpointResource> IEnumerable<FrontendEndpointResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<FrontendEndpointResource> IAsyncEnumerable<FrontendEndpointResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
