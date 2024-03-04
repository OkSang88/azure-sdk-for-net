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

namespace Azure.ResourceManager.EventHubs
{
    /// <summary>
    /// A class representing a collection of <see cref="EventHubResource"/> and their operations.
    /// Each <see cref="EventHubResource"/> in the collection will belong to the same instance of <see cref="EventHubsNamespaceResource"/>.
    /// To get an <see cref="EventHubCollection"/> instance call the GetEventHubs method from an instance of <see cref="EventHubsNamespaceResource"/>.
    /// </summary>
    public partial class EventHubCollection : ArmCollection, IEnumerable<EventHubResource>, IAsyncEnumerable<EventHubResource>
    {
        private readonly ClientDiagnostics _eventHubClientDiagnostics;
        private readonly EventHubsRestOperations _eventHubRestClient;

        /// <summary> Initializes a new instance of the <see cref="EventHubCollection"/> class for mocking. </summary>
        protected EventHubCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="EventHubCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal EventHubCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _eventHubClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.EventHubs", EventHubResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(EventHubResource.ResourceType, out string eventHubApiVersion);
            _eventHubRestClient = new EventHubsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, eventHubApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != EventHubsNamespaceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, EventHubsNamespaceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a new Event Hub as a nested resource within a Namespace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/eventhubs/{eventHubName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EventHubs_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EventHubResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="eventHubName"> The Event Hub name. </param>
        /// <param name="data"> Parameters supplied to create an Event Hub resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="eventHubName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="eventHubName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<EventHubResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string eventHubName, EventHubData data, CancellationToken cancellationToken = default)
        {
            if (eventHubName == null)
            {
                throw new ArgumentNullException(nameof(eventHubName));
            }
            if (eventHubName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(eventHubName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _eventHubClientDiagnostics.CreateScope("EventHubCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _eventHubRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, eventHubName, data, cancellationToken).ConfigureAwait(false);
                var operation = new EventHubsArmOperation<EventHubResource>(Response.FromValue(new EventHubResource(Client, response), response.GetRawResponse()));
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
        /// Creates or updates a new Event Hub as a nested resource within a Namespace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/eventhubs/{eventHubName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EventHubs_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EventHubResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="eventHubName"> The Event Hub name. </param>
        /// <param name="data"> Parameters supplied to create an Event Hub resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="eventHubName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="eventHubName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<EventHubResource> CreateOrUpdate(WaitUntil waitUntil, string eventHubName, EventHubData data, CancellationToken cancellationToken = default)
        {
            if (eventHubName == null)
            {
                throw new ArgumentNullException(nameof(eventHubName));
            }
            if (eventHubName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(eventHubName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _eventHubClientDiagnostics.CreateScope("EventHubCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _eventHubRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, eventHubName, data, cancellationToken);
                var operation = new EventHubsArmOperation<EventHubResource>(Response.FromValue(new EventHubResource(Client, response), response.GetRawResponse()));
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
        /// Gets an Event Hubs description for the specified Event Hub.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/eventhubs/{eventHubName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EventHubs_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EventHubResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="eventHubName"> The Event Hub name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="eventHubName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="eventHubName"/> is null. </exception>
        public virtual async Task<Response<EventHubResource>> GetAsync(string eventHubName, CancellationToken cancellationToken = default)
        {
            if (eventHubName == null)
            {
                throw new ArgumentNullException(nameof(eventHubName));
            }
            if (eventHubName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(eventHubName));
            }

            using var scope = _eventHubClientDiagnostics.CreateScope("EventHubCollection.Get");
            scope.Start();
            try
            {
                var response = await _eventHubRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, eventHubName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new EventHubResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets an Event Hubs description for the specified Event Hub.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/eventhubs/{eventHubName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EventHubs_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EventHubResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="eventHubName"> The Event Hub name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="eventHubName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="eventHubName"/> is null. </exception>
        public virtual Response<EventHubResource> Get(string eventHubName, CancellationToken cancellationToken = default)
        {
            if (eventHubName == null)
            {
                throw new ArgumentNullException(nameof(eventHubName));
            }
            if (eventHubName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(eventHubName));
            }

            using var scope = _eventHubClientDiagnostics.CreateScope("EventHubCollection.Get");
            scope.Start();
            try
            {
                var response = _eventHubRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, eventHubName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new EventHubResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all the Event Hubs in a Namespace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/eventhubs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EventHubs_ListByNamespace</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EventHubResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="skip"> Skip is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skip parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="top"> May be used to limit the number of results to the most recent N usageDetails. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="EventHubResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<EventHubResource> GetAllAsync(int? skip = null, int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _eventHubRestClient.CreateListByNamespaceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skip, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _eventHubRestClient.CreateListByNamespaceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skip, top);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new EventHubResource(Client, EventHubData.DeserializeEventHubData(e)), _eventHubClientDiagnostics, Pipeline, "EventHubCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets all the Event Hubs in a Namespace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/eventhubs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EventHubs_ListByNamespace</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EventHubResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="skip"> Skip is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skip parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="top"> May be used to limit the number of results to the most recent N usageDetails. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="EventHubResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<EventHubResource> GetAll(int? skip = null, int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _eventHubRestClient.CreateListByNamespaceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skip, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _eventHubRestClient.CreateListByNamespaceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skip, top);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new EventHubResource(Client, EventHubData.DeserializeEventHubData(e)), _eventHubClientDiagnostics, Pipeline, "EventHubCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/eventhubs/{eventHubName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EventHubs_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EventHubResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="eventHubName"> The Event Hub name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="eventHubName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="eventHubName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string eventHubName, CancellationToken cancellationToken = default)
        {
            if (eventHubName == null)
            {
                throw new ArgumentNullException(nameof(eventHubName));
            }
            if (eventHubName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(eventHubName));
            }

            using var scope = _eventHubClientDiagnostics.CreateScope("EventHubCollection.Exists");
            scope.Start();
            try
            {
                var response = await _eventHubRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, eventHubName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/eventhubs/{eventHubName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EventHubs_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EventHubResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="eventHubName"> The Event Hub name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="eventHubName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="eventHubName"/> is null. </exception>
        public virtual Response<bool> Exists(string eventHubName, CancellationToken cancellationToken = default)
        {
            if (eventHubName == null)
            {
                throw new ArgumentNullException(nameof(eventHubName));
            }
            if (eventHubName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(eventHubName));
            }

            using var scope = _eventHubClientDiagnostics.CreateScope("EventHubCollection.Exists");
            scope.Start();
            try
            {
                var response = _eventHubRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, eventHubName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/eventhubs/{eventHubName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EventHubs_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EventHubResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="eventHubName"> The Event Hub name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="eventHubName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="eventHubName"/> is null. </exception>
        public virtual async Task<NullableResponse<EventHubResource>> GetIfExistsAsync(string eventHubName, CancellationToken cancellationToken = default)
        {
            if (eventHubName == null)
            {
                throw new ArgumentNullException(nameof(eventHubName));
            }
            if (eventHubName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(eventHubName));
            }

            using var scope = _eventHubClientDiagnostics.CreateScope("EventHubCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _eventHubRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, eventHubName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<EventHubResource>(response.GetRawResponse());
                return Response.FromValue(new EventHubResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/eventhubs/{eventHubName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EventHubs_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EventHubResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="eventHubName"> The Event Hub name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="eventHubName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="eventHubName"/> is null. </exception>
        public virtual NullableResponse<EventHubResource> GetIfExists(string eventHubName, CancellationToken cancellationToken = default)
        {
            if (eventHubName == null)
            {
                throw new ArgumentNullException(nameof(eventHubName));
            }
            if (eventHubName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(eventHubName));
            }

            using var scope = _eventHubClientDiagnostics.CreateScope("EventHubCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _eventHubRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, eventHubName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<EventHubResource>(response.GetRawResponse());
                return Response.FromValue(new EventHubResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<EventHubResource> IEnumerable<EventHubResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<EventHubResource> IAsyncEnumerable<EventHubResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
