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
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A class representing collection of ManagedInstanceKey and their operations over its parent. </summary>
    public partial class ManagedInstanceKeyCollection : ArmCollection, IEnumerable<ManagedInstanceKey>, IAsyncEnumerable<ManagedInstanceKey>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly ManagedInstanceKeysRestOperations _managedInstanceKeysRestClient;

        /// <summary> Initializes a new instance of the <see cref="ManagedInstanceKeyCollection"/> class for mocking. </summary>
        protected ManagedInstanceKeyCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ManagedInstanceKeyCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal ManagedInstanceKeyCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            ClientOptions.TryGetApiVersion(ManagedInstanceKey.ResourceType, out string apiVersion);
            _managedInstanceKeysRestClient = new ManagedInstanceKeysRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ManagedInstance.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ManagedInstance.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/keys/{keyName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}
        /// OperationId: ManagedInstanceKeys_CreateOrUpdate
        /// <summary> Creates or updates a managed instance key. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="keyName"> The name of the managed instance key to be operated on (updated or created). </param>
        /// <param name="parameters"> The requested managed instance key resource state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="keyName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual ManagedInstanceKeyCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string keyName, ManagedInstanceKeyData parameters, CancellationToken cancellationToken = default)
        {
            if (keyName == null)
            {
                throw new ArgumentNullException(nameof(keyName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ManagedInstanceKeyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _managedInstanceKeysRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, keyName, parameters, cancellationToken);
                var operation = new ManagedInstanceKeyCreateOrUpdateOperation(this, _clientDiagnostics, Pipeline, _managedInstanceKeysRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, keyName, parameters).Request, response);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/keys/{keyName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}
        /// OperationId: ManagedInstanceKeys_CreateOrUpdate
        /// <summary> Creates or updates a managed instance key. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="keyName"> The name of the managed instance key to be operated on (updated or created). </param>
        /// <param name="parameters"> The requested managed instance key resource state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="keyName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<ManagedInstanceKeyCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string keyName, ManagedInstanceKeyData parameters, CancellationToken cancellationToken = default)
        {
            if (keyName == null)
            {
                throw new ArgumentNullException(nameof(keyName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ManagedInstanceKeyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _managedInstanceKeysRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, keyName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new ManagedInstanceKeyCreateOrUpdateOperation(this, _clientDiagnostics, Pipeline, _managedInstanceKeysRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, keyName, parameters).Request, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/keys/{keyName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}
        /// OperationId: ManagedInstanceKeys_Get
        /// <summary> Gets a managed instance key. </summary>
        /// <param name="keyName"> The name of the managed instance key to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="keyName"/> is null. </exception>
        public virtual Response<ManagedInstanceKey> Get(string keyName, CancellationToken cancellationToken = default)
        {
            if (keyName == null)
            {
                throw new ArgumentNullException(nameof(keyName));
            }

            using var scope = _clientDiagnostics.CreateScope("ManagedInstanceKeyCollection.Get");
            scope.Start();
            try
            {
                var response = _managedInstanceKeysRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, keyName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagedInstanceKey(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/keys/{keyName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}
        /// OperationId: ManagedInstanceKeys_Get
        /// <summary> Gets a managed instance key. </summary>
        /// <param name="keyName"> The name of the managed instance key to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="keyName"/> is null. </exception>
        public async virtual Task<Response<ManagedInstanceKey>> GetAsync(string keyName, CancellationToken cancellationToken = default)
        {
            if (keyName == null)
            {
                throw new ArgumentNullException(nameof(keyName));
            }

            using var scope = _clientDiagnostics.CreateScope("ManagedInstanceKeyCollection.Get");
            scope.Start();
            try
            {
                var response = await _managedInstanceKeysRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, keyName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new ManagedInstanceKey(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="keyName"> The name of the managed instance key to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="keyName"/> is null. </exception>
        public virtual Response<ManagedInstanceKey> GetIfExists(string keyName, CancellationToken cancellationToken = default)
        {
            if (keyName == null)
            {
                throw new ArgumentNullException(nameof(keyName));
            }

            using var scope = _clientDiagnostics.CreateScope("ManagedInstanceKeyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _managedInstanceKeysRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, keyName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<ManagedInstanceKey>(null, response.GetRawResponse());
                return Response.FromValue(new ManagedInstanceKey(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="keyName"> The name of the managed instance key to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="keyName"/> is null. </exception>
        public async virtual Task<Response<ManagedInstanceKey>> GetIfExistsAsync(string keyName, CancellationToken cancellationToken = default)
        {
            if (keyName == null)
            {
                throw new ArgumentNullException(nameof(keyName));
            }

            using var scope = _clientDiagnostics.CreateScope("ManagedInstanceKeyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _managedInstanceKeysRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, keyName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<ManagedInstanceKey>(null, response.GetRawResponse());
                return Response.FromValue(new ManagedInstanceKey(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="keyName"> The name of the managed instance key to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="keyName"/> is null. </exception>
        public virtual Response<bool> Exists(string keyName, CancellationToken cancellationToken = default)
        {
            if (keyName == null)
            {
                throw new ArgumentNullException(nameof(keyName));
            }

            using var scope = _clientDiagnostics.CreateScope("ManagedInstanceKeyCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(keyName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="keyName"> The name of the managed instance key to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="keyName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string keyName, CancellationToken cancellationToken = default)
        {
            if (keyName == null)
            {
                throw new ArgumentNullException(nameof(keyName));
            }

            using var scope = _clientDiagnostics.CreateScope("ManagedInstanceKeyCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(keyName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/keys
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}
        /// OperationId: ManagedInstanceKeys_ListByInstance
        /// <summary> Gets a list of managed instance keys. </summary>
        /// <param name="filter"> An OData filter expression that filters elements in the collection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ManagedInstanceKey" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ManagedInstanceKey> GetAll(string filter = null, CancellationToken cancellationToken = default)
        {
            Page<ManagedInstanceKey> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ManagedInstanceKeyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _managedInstanceKeysRestClient.ListByInstance(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ManagedInstanceKey(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ManagedInstanceKey> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ManagedInstanceKeyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _managedInstanceKeysRestClient.ListByInstanceNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ManagedInstanceKey(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/keys
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}
        /// OperationId: ManagedInstanceKeys_ListByInstance
        /// <summary> Gets a list of managed instance keys. </summary>
        /// <param name="filter"> An OData filter expression that filters elements in the collection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ManagedInstanceKey" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ManagedInstanceKey> GetAllAsync(string filter = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<ManagedInstanceKey>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ManagedInstanceKeyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _managedInstanceKeysRestClient.ListByInstanceAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ManagedInstanceKey(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ManagedInstanceKey>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ManagedInstanceKeyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _managedInstanceKeysRestClient.ListByInstanceNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ManagedInstanceKey(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<ManagedInstanceKey> IEnumerable<ManagedInstanceKey>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ManagedInstanceKey> IAsyncEnumerable<ManagedInstanceKey>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, ManagedInstanceKey, ManagedInstanceKeyData> Construct() { }
    }
}
