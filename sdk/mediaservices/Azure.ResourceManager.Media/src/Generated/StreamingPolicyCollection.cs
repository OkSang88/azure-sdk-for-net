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

namespace Azure.ResourceManager.Media
{
    /// <summary>
    /// A class representing a collection of <see cref="StreamingPolicyResource"/> and their operations.
    /// Each <see cref="StreamingPolicyResource"/> in the collection will belong to the same instance of <see cref="MediaServicesAccountResource"/>.
    /// To get a <see cref="StreamingPolicyCollection"/> instance call the GetStreamingPolicies method from an instance of <see cref="MediaServicesAccountResource"/>.
    /// </summary>
    public partial class StreamingPolicyCollection : ArmCollection, IEnumerable<StreamingPolicyResource>, IAsyncEnumerable<StreamingPolicyResource>
    {
        private readonly ClientDiagnostics _streamingPolicyClientDiagnostics;
        private readonly StreamingPoliciesRestOperations _streamingPolicyRestClient;

        /// <summary> Initializes a new instance of the <see cref="StreamingPolicyCollection"/> class for mocking. </summary>
        protected StreamingPolicyCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="StreamingPolicyCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal StreamingPolicyCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _streamingPolicyClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Media", StreamingPolicyResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(StreamingPolicyResource.ResourceType, out string streamingPolicyApiVersion);
            _streamingPolicyRestClient = new StreamingPoliciesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, streamingPolicyApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != MediaServicesAccountResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, MediaServicesAccountResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create a Streaming Policy in the Media Services account
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaServices/{accountName}/streamingPolicies/{streamingPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StreamingPolicies_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="streamingPolicyName"> The Streaming Policy name. </param>
        /// <param name="data"> The request parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="streamingPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="streamingPolicyName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<StreamingPolicyResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string streamingPolicyName, StreamingPolicyData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(streamingPolicyName, nameof(streamingPolicyName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _streamingPolicyClientDiagnostics.CreateScope("StreamingPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _streamingPolicyRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, streamingPolicyName, data, cancellationToken).ConfigureAwait(false);
                var operation = new MediaArmOperation<StreamingPolicyResource>(Response.FromValue(new StreamingPolicyResource(Client, response), response.GetRawResponse()));
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
        /// Create a Streaming Policy in the Media Services account
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaServices/{accountName}/streamingPolicies/{streamingPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StreamingPolicies_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="streamingPolicyName"> The Streaming Policy name. </param>
        /// <param name="data"> The request parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="streamingPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="streamingPolicyName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<StreamingPolicyResource> CreateOrUpdate(WaitUntil waitUntil, string streamingPolicyName, StreamingPolicyData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(streamingPolicyName, nameof(streamingPolicyName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _streamingPolicyClientDiagnostics.CreateScope("StreamingPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _streamingPolicyRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, streamingPolicyName, data, cancellationToken);
                var operation = new MediaArmOperation<StreamingPolicyResource>(Response.FromValue(new StreamingPolicyResource(Client, response), response.GetRawResponse()));
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
        /// Get the details of a Streaming Policy in the Media Services account
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaServices/{accountName}/streamingPolicies/{streamingPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StreamingPolicies_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="streamingPolicyName"> The Streaming Policy name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="streamingPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="streamingPolicyName"/> is null. </exception>
        public virtual async Task<Response<StreamingPolicyResource>> GetAsync(string streamingPolicyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(streamingPolicyName, nameof(streamingPolicyName));

            using var scope = _streamingPolicyClientDiagnostics.CreateScope("StreamingPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = await _streamingPolicyRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, streamingPolicyName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StreamingPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the details of a Streaming Policy in the Media Services account
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaServices/{accountName}/streamingPolicies/{streamingPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StreamingPolicies_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="streamingPolicyName"> The Streaming Policy name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="streamingPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="streamingPolicyName"/> is null. </exception>
        public virtual Response<StreamingPolicyResource> Get(string streamingPolicyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(streamingPolicyName, nameof(streamingPolicyName));

            using var scope = _streamingPolicyClientDiagnostics.CreateScope("StreamingPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = _streamingPolicyRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, streamingPolicyName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StreamingPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the Streaming Policies in the account
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaServices/{accountName}/streamingPolicies</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StreamingPolicies_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> Restricts the set of items returned. </param>
        /// <param name="top"> Specifies a non-negative integer n that limits the number of items returned from a collection. The service returns the number of available items up to but not greater than the specified value n. </param>
        /// <param name="orderby"> Specifies the key by which the result collection should be ordered. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="StreamingPolicyResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<StreamingPolicyResource> GetAllAsync(string filter = null, int? top = null, string orderby = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _streamingPolicyRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, orderby);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _streamingPolicyRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, orderby);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new StreamingPolicyResource(Client, StreamingPolicyData.DeserializeStreamingPolicyData(e)), _streamingPolicyClientDiagnostics, Pipeline, "StreamingPolicyCollection.GetAll", "value", "@odata.nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists the Streaming Policies in the account
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaServices/{accountName}/streamingPolicies</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StreamingPolicies_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> Restricts the set of items returned. </param>
        /// <param name="top"> Specifies a non-negative integer n that limits the number of items returned from a collection. The service returns the number of available items up to but not greater than the specified value n. </param>
        /// <param name="orderby"> Specifies the key by which the result collection should be ordered. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="StreamingPolicyResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<StreamingPolicyResource> GetAll(string filter = null, int? top = null, string orderby = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _streamingPolicyRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, orderby);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _streamingPolicyRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, orderby);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new StreamingPolicyResource(Client, StreamingPolicyData.DeserializeStreamingPolicyData(e)), _streamingPolicyClientDiagnostics, Pipeline, "StreamingPolicyCollection.GetAll", "value", "@odata.nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaServices/{accountName}/streamingPolicies/{streamingPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StreamingPolicies_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="streamingPolicyName"> The Streaming Policy name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="streamingPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="streamingPolicyName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string streamingPolicyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(streamingPolicyName, nameof(streamingPolicyName));

            using var scope = _streamingPolicyClientDiagnostics.CreateScope("StreamingPolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = await _streamingPolicyRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, streamingPolicyName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaServices/{accountName}/streamingPolicies/{streamingPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StreamingPolicies_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="streamingPolicyName"> The Streaming Policy name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="streamingPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="streamingPolicyName"/> is null. </exception>
        public virtual Response<bool> Exists(string streamingPolicyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(streamingPolicyName, nameof(streamingPolicyName));

            using var scope = _streamingPolicyClientDiagnostics.CreateScope("StreamingPolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = _streamingPolicyRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, streamingPolicyName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaServices/{accountName}/streamingPolicies/{streamingPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StreamingPolicies_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="streamingPolicyName"> The Streaming Policy name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="streamingPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="streamingPolicyName"/> is null. </exception>
        public virtual async Task<NullableResponse<StreamingPolicyResource>> GetIfExistsAsync(string streamingPolicyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(streamingPolicyName, nameof(streamingPolicyName));

            using var scope = _streamingPolicyClientDiagnostics.CreateScope("StreamingPolicyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _streamingPolicyRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, streamingPolicyName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<StreamingPolicyResource>(response.GetRawResponse());
                return Response.FromValue(new StreamingPolicyResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaServices/{accountName}/streamingPolicies/{streamingPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StreamingPolicies_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="streamingPolicyName"> The Streaming Policy name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="streamingPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="streamingPolicyName"/> is null. </exception>
        public virtual NullableResponse<StreamingPolicyResource> GetIfExists(string streamingPolicyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(streamingPolicyName, nameof(streamingPolicyName));

            using var scope = _streamingPolicyClientDiagnostics.CreateScope("StreamingPolicyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _streamingPolicyRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, streamingPolicyName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<StreamingPolicyResource>(response.GetRawResponse());
                return Response.FromValue(new StreamingPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<StreamingPolicyResource> IEnumerable<StreamingPolicyResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<StreamingPolicyResource> IAsyncEnumerable<StreamingPolicyResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
