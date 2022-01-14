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
    /// <summary> A class representing collection of FailoverGroup and their operations over its parent. </summary>
    public partial class FailoverGroupCollection : ArmCollection, IEnumerable<FailoverGroup>, IAsyncEnumerable<FailoverGroup>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly FailoverGroupsRestOperations _failoverGroupsRestClient;

        /// <summary> Initializes a new instance of the <see cref="FailoverGroupCollection"/> class for mocking. </summary>
        protected FailoverGroupCollection()
        {
        }

        /// <summary> Initializes a new instance of FailoverGroupCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal FailoverGroupCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _failoverGroupsRestClient = new FailoverGroupsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SqlServer.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SqlServer.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/failoverGroups/{failoverGroupName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// OperationId: FailoverGroups_CreateOrUpdate
        /// <summary> Creates or updates a failover group. </summary>
        /// <param name="failoverGroupName"> The name of the failover group. </param>
        /// <param name="parameters"> The failover group parameters. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="failoverGroupName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual FailoverGroupCreateOrUpdateOperation CreateOrUpdate(string failoverGroupName, FailoverGroupData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (failoverGroupName == null)
            {
                throw new ArgumentNullException(nameof(failoverGroupName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("FailoverGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _failoverGroupsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, failoverGroupName, parameters, cancellationToken);
                var operation = new FailoverGroupCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _failoverGroupsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, failoverGroupName, parameters).Request, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/failoverGroups/{failoverGroupName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// OperationId: FailoverGroups_CreateOrUpdate
        /// <summary> Creates or updates a failover group. </summary>
        /// <param name="failoverGroupName"> The name of the failover group. </param>
        /// <param name="parameters"> The failover group parameters. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="failoverGroupName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<FailoverGroupCreateOrUpdateOperation> CreateOrUpdateAsync(string failoverGroupName, FailoverGroupData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (failoverGroupName == null)
            {
                throw new ArgumentNullException(nameof(failoverGroupName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("FailoverGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _failoverGroupsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, failoverGroupName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new FailoverGroupCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _failoverGroupsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, failoverGroupName, parameters).Request, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/failoverGroups/{failoverGroupName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// OperationId: FailoverGroups_Get
        /// <summary> Gets a failover group. </summary>
        /// <param name="failoverGroupName"> The name of the failover group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="failoverGroupName"/> is null. </exception>
        public virtual Response<FailoverGroup> Get(string failoverGroupName, CancellationToken cancellationToken = default)
        {
            if (failoverGroupName == null)
            {
                throw new ArgumentNullException(nameof(failoverGroupName));
            }

            using var scope = _clientDiagnostics.CreateScope("FailoverGroupCollection.Get");
            scope.Start();
            try
            {
                var response = _failoverGroupsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, failoverGroupName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new FailoverGroup(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/failoverGroups/{failoverGroupName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// OperationId: FailoverGroups_Get
        /// <summary> Gets a failover group. </summary>
        /// <param name="failoverGroupName"> The name of the failover group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="failoverGroupName"/> is null. </exception>
        public async virtual Task<Response<FailoverGroup>> GetAsync(string failoverGroupName, CancellationToken cancellationToken = default)
        {
            if (failoverGroupName == null)
            {
                throw new ArgumentNullException(nameof(failoverGroupName));
            }

            using var scope = _clientDiagnostics.CreateScope("FailoverGroupCollection.Get");
            scope.Start();
            try
            {
                var response = await _failoverGroupsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, failoverGroupName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new FailoverGroup(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="failoverGroupName"> The name of the failover group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="failoverGroupName"/> is null. </exception>
        public virtual Response<FailoverGroup> GetIfExists(string failoverGroupName, CancellationToken cancellationToken = default)
        {
            if (failoverGroupName == null)
            {
                throw new ArgumentNullException(nameof(failoverGroupName));
            }

            using var scope = _clientDiagnostics.CreateScope("FailoverGroupCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _failoverGroupsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, failoverGroupName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<FailoverGroup>(null, response.GetRawResponse())
                    : Response.FromValue(new FailoverGroup(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="failoverGroupName"> The name of the failover group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="failoverGroupName"/> is null. </exception>
        public async virtual Task<Response<FailoverGroup>> GetIfExistsAsync(string failoverGroupName, CancellationToken cancellationToken = default)
        {
            if (failoverGroupName == null)
            {
                throw new ArgumentNullException(nameof(failoverGroupName));
            }

            using var scope = _clientDiagnostics.CreateScope("FailoverGroupCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _failoverGroupsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, failoverGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<FailoverGroup>(null, response.GetRawResponse())
                    : Response.FromValue(new FailoverGroup(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="failoverGroupName"> The name of the failover group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="failoverGroupName"/> is null. </exception>
        public virtual Response<bool> Exists(string failoverGroupName, CancellationToken cancellationToken = default)
        {
            if (failoverGroupName == null)
            {
                throw new ArgumentNullException(nameof(failoverGroupName));
            }

            using var scope = _clientDiagnostics.CreateScope("FailoverGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(failoverGroupName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="failoverGroupName"> The name of the failover group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="failoverGroupName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string failoverGroupName, CancellationToken cancellationToken = default)
        {
            if (failoverGroupName == null)
            {
                throw new ArgumentNullException(nameof(failoverGroupName));
            }

            using var scope = _clientDiagnostics.CreateScope("FailoverGroupCollection.ExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(failoverGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/failoverGroups
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// OperationId: FailoverGroups_ListByServer
        /// <summary> Lists the failover groups in a server. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="FailoverGroup" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<FailoverGroup> GetAll(CancellationToken cancellationToken = default)
        {
            Page<FailoverGroup> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("FailoverGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _failoverGroupsRestClient.ListByServer(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new FailoverGroup(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<FailoverGroup> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("FailoverGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _failoverGroupsRestClient.ListByServerNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new FailoverGroup(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/failoverGroups
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// OperationId: FailoverGroups_ListByServer
        /// <summary> Lists the failover groups in a server. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="FailoverGroup" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<FailoverGroup> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<FailoverGroup>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("FailoverGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _failoverGroupsRestClient.ListByServerAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new FailoverGroup(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<FailoverGroup>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("FailoverGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _failoverGroupsRestClient.ListByServerNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new FailoverGroup(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<FailoverGroup> IEnumerable<FailoverGroup>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<FailoverGroup> IAsyncEnumerable<FailoverGroup>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, FailoverGroup, FailoverGroupData> Construct() { }
    }
}
