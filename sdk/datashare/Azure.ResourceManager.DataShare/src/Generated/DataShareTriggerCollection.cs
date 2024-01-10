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

namespace Azure.ResourceManager.DataShare
{
    /// <summary>
    /// A class representing a collection of <see cref="DataShareTriggerResource"/> and their operations.
    /// Each <see cref="DataShareTriggerResource"/> in the collection will belong to the same instance of <see cref="ShareSubscriptionResource"/>.
    /// To get a <see cref="DataShareTriggerCollection"/> instance call the GetDataShareTriggers method from an instance of <see cref="ShareSubscriptionResource"/>.
    /// </summary>
    public partial class DataShareTriggerCollection : ArmCollection, IEnumerable<DataShareTriggerResource>, IAsyncEnumerable<DataShareTriggerResource>
    {
        private readonly ClientDiagnostics _dataShareTriggerTriggersClientDiagnostics;
        private readonly TriggersRestOperations _dataShareTriggerTriggersRestClient;

        /// <summary> Initializes a new instance of the <see cref="DataShareTriggerCollection"/> class for mocking. </summary>
        protected DataShareTriggerCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DataShareTriggerCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DataShareTriggerCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _dataShareTriggerTriggersClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DataShare", DataShareTriggerResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DataShareTriggerResource.ResourceType, out string dataShareTriggerTriggersApiVersion);
            _dataShareTriggerTriggersRestClient = new TriggersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, dataShareTriggerTriggersApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ShareSubscriptionResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ShareSubscriptionResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create a Trigger
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shareSubscriptions/{shareSubscriptionName}/triggers/{triggerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Triggers_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataShareTriggerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="triggerName"> The name of the trigger. </param>
        /// <param name="data"> Trigger details. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="triggerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="triggerName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<DataShareTriggerResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string triggerName, DataShareTriggerData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(triggerName, nameof(triggerName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _dataShareTriggerTriggersClientDiagnostics.CreateScope("DataShareTriggerCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _dataShareTriggerTriggersRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, triggerName, data, cancellationToken).ConfigureAwait(false);
                var operation = new DataShareArmOperation<DataShareTriggerResource>(new DataShareTriggerOperationSource(Client), _dataShareTriggerTriggersClientDiagnostics, Pipeline, _dataShareTriggerTriggersRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, triggerName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Create a Trigger
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shareSubscriptions/{shareSubscriptionName}/triggers/{triggerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Triggers_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataShareTriggerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="triggerName"> The name of the trigger. </param>
        /// <param name="data"> Trigger details. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="triggerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="triggerName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<DataShareTriggerResource> CreateOrUpdate(WaitUntil waitUntil, string triggerName, DataShareTriggerData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(triggerName, nameof(triggerName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _dataShareTriggerTriggersClientDiagnostics.CreateScope("DataShareTriggerCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _dataShareTriggerTriggersRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, triggerName, data, cancellationToken);
                var operation = new DataShareArmOperation<DataShareTriggerResource>(new DataShareTriggerOperationSource(Client), _dataShareTriggerTriggersClientDiagnostics, Pipeline, _dataShareTriggerTriggersRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, triggerName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Get a Trigger in a shareSubscription
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shareSubscriptions/{shareSubscriptionName}/triggers/{triggerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Triggers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataShareTriggerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="triggerName"> The name of the trigger. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="triggerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="triggerName"/> is null. </exception>
        public virtual async Task<Response<DataShareTriggerResource>> GetAsync(string triggerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(triggerName, nameof(triggerName));

            using var scope = _dataShareTriggerTriggersClientDiagnostics.CreateScope("DataShareTriggerCollection.Get");
            scope.Start();
            try
            {
                var response = await _dataShareTriggerTriggersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, triggerName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataShareTriggerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a Trigger in a shareSubscription
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shareSubscriptions/{shareSubscriptionName}/triggers/{triggerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Triggers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataShareTriggerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="triggerName"> The name of the trigger. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="triggerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="triggerName"/> is null. </exception>
        public virtual Response<DataShareTriggerResource> Get(string triggerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(triggerName, nameof(triggerName));

            using var scope = _dataShareTriggerTriggersClientDiagnostics.CreateScope("DataShareTriggerCollection.Get");
            scope.Start();
            try
            {
                var response = _dataShareTriggerTriggersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, triggerName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataShareTriggerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List Triggers in a share subscription
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shareSubscriptions/{shareSubscriptionName}/triggers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Triggers_ListByShareSubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataShareTriggerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="skipToken"> Continuation token. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DataShareTriggerResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DataShareTriggerResource> GetAllAsync(string skipToken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _dataShareTriggerTriggersRestClient.CreateListByShareSubscriptionRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, skipToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dataShareTriggerTriggersRestClient.CreateListByShareSubscriptionNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, skipToken);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new DataShareTriggerResource(Client, DataShareTriggerData.DeserializeDataShareTriggerData(e)), _dataShareTriggerTriggersClientDiagnostics, Pipeline, "DataShareTriggerCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List Triggers in a share subscription
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shareSubscriptions/{shareSubscriptionName}/triggers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Triggers_ListByShareSubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataShareTriggerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="skipToken"> Continuation token. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DataShareTriggerResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DataShareTriggerResource> GetAll(string skipToken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _dataShareTriggerTriggersRestClient.CreateListByShareSubscriptionRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, skipToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dataShareTriggerTriggersRestClient.CreateListByShareSubscriptionNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, skipToken);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new DataShareTriggerResource(Client, DataShareTriggerData.DeserializeDataShareTriggerData(e)), _dataShareTriggerTriggersClientDiagnostics, Pipeline, "DataShareTriggerCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shareSubscriptions/{shareSubscriptionName}/triggers/{triggerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Triggers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataShareTriggerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="triggerName"> The name of the trigger. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="triggerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="triggerName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string triggerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(triggerName, nameof(triggerName));

            using var scope = _dataShareTriggerTriggersClientDiagnostics.CreateScope("DataShareTriggerCollection.Exists");
            scope.Start();
            try
            {
                var response = await _dataShareTriggerTriggersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, triggerName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shareSubscriptions/{shareSubscriptionName}/triggers/{triggerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Triggers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataShareTriggerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="triggerName"> The name of the trigger. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="triggerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="triggerName"/> is null. </exception>
        public virtual Response<bool> Exists(string triggerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(triggerName, nameof(triggerName));

            using var scope = _dataShareTriggerTriggersClientDiagnostics.CreateScope("DataShareTriggerCollection.Exists");
            scope.Start();
            try
            {
                var response = _dataShareTriggerTriggersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, triggerName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shareSubscriptions/{shareSubscriptionName}/triggers/{triggerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Triggers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataShareTriggerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="triggerName"> The name of the trigger. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="triggerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="triggerName"/> is null. </exception>
        public virtual async Task<NullableResponse<DataShareTriggerResource>> GetIfExistsAsync(string triggerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(triggerName, nameof(triggerName));

            using var scope = _dataShareTriggerTriggersClientDiagnostics.CreateScope("DataShareTriggerCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _dataShareTriggerTriggersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, triggerName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<DataShareTriggerResource>(response.GetRawResponse());
                return Response.FromValue(new DataShareTriggerResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shareSubscriptions/{shareSubscriptionName}/triggers/{triggerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Triggers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataShareTriggerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="triggerName"> The name of the trigger. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="triggerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="triggerName"/> is null. </exception>
        public virtual NullableResponse<DataShareTriggerResource> GetIfExists(string triggerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(triggerName, nameof(triggerName));

            using var scope = _dataShareTriggerTriggersClientDiagnostics.CreateScope("DataShareTriggerCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _dataShareTriggerTriggersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, triggerName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<DataShareTriggerResource>(response.GetRawResponse());
                return Response.FromValue(new DataShareTriggerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DataShareTriggerResource> IEnumerable<DataShareTriggerResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DataShareTriggerResource> IAsyncEnumerable<DataShareTriggerResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
