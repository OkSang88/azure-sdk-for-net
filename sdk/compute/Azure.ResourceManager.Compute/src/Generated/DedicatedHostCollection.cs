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
using Azure.ResourceManager.Compute.Models;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Compute
{
    /// <summary> A class representing collection of DedicatedHost and their operations over its parent. </summary>
    public partial class DedicatedHostCollection : ArmCollection, IEnumerable<DedicatedHost>, IAsyncEnumerable<DedicatedHost>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly DedicatedHostsRestOperations _dedicatedHostsRestClient;

        /// <summary> Initializes a new instance of the <see cref="DedicatedHostCollection"/> class for mocking. </summary>
        protected DedicatedHostCollection()
        {
        }

        /// <summary> Initializes a new instance of DedicatedHostCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal DedicatedHostCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _dedicatedHostsRestClient = new DedicatedHostsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != DedicatedHostGroup.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, DedicatedHostGroup.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// <summary> Create or update a dedicated host . </summary>
        /// <param name="hostName"> The name of the dedicated host . </param>
        /// <param name="parameters"> Parameters supplied to the Create Dedicated Host. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="hostName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual DedicatedHostCreateOrUpdateOperation CreateOrUpdate(string hostName, DedicatedHostData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (hostName == null)
            {
                throw new ArgumentNullException(nameof(hostName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("DedicatedHostCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _dedicatedHostsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, hostName, parameters, cancellationToken);
                var operation = new DedicatedHostCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _dedicatedHostsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, hostName, parameters).Request, response);
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

        /// <summary> Create or update a dedicated host . </summary>
        /// <param name="hostName"> The name of the dedicated host . </param>
        /// <param name="parameters"> Parameters supplied to the Create Dedicated Host. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="hostName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<DedicatedHostCreateOrUpdateOperation> CreateOrUpdateAsync(string hostName, DedicatedHostData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (hostName == null)
            {
                throw new ArgumentNullException(nameof(hostName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("DedicatedHostCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _dedicatedHostsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, hostName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new DedicatedHostCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _dedicatedHostsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, hostName, parameters).Request, response);
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

        /// <summary> Retrieves information about a dedicated host. </summary>
        /// <param name="hostName"> The name of the dedicated host. </param>
        /// <param name="expand"> The expand expression to apply on the operation. &apos;InstanceView&apos; will retrieve the list of instance views of the dedicated host. &apos;UserData&apos; is not supported for dedicated host. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="hostName"/> is null. </exception>
        public virtual Response<DedicatedHost> Get(string hostName, InstanceViewTypes? expand = null, CancellationToken cancellationToken = default)
        {
            if (hostName == null)
            {
                throw new ArgumentNullException(nameof(hostName));
            }

            using var scope = _clientDiagnostics.CreateScope("DedicatedHostCollection.Get");
            scope.Start();
            try
            {
                var response = _dedicatedHostsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, hostName, expand, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DedicatedHost(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieves information about a dedicated host. </summary>
        /// <param name="hostName"> The name of the dedicated host. </param>
        /// <param name="expand"> The expand expression to apply on the operation. &apos;InstanceView&apos; will retrieve the list of instance views of the dedicated host. &apos;UserData&apos; is not supported for dedicated host. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="hostName"/> is null. </exception>
        public async virtual Task<Response<DedicatedHost>> GetAsync(string hostName, InstanceViewTypes? expand = null, CancellationToken cancellationToken = default)
        {
            if (hostName == null)
            {
                throw new ArgumentNullException(nameof(hostName));
            }

            using var scope = _clientDiagnostics.CreateScope("DedicatedHostCollection.Get");
            scope.Start();
            try
            {
                var response = await _dedicatedHostsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, hostName, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new DedicatedHost(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="hostName"> The name of the dedicated host. </param>
        /// <param name="expand"> The expand expression to apply on the operation. &apos;InstanceView&apos; will retrieve the list of instance views of the dedicated host. &apos;UserData&apos; is not supported for dedicated host. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="hostName"/> is null. </exception>
        public virtual Response<DedicatedHost> GetIfExists(string hostName, InstanceViewTypes? expand = null, CancellationToken cancellationToken = default)
        {
            if (hostName == null)
            {
                throw new ArgumentNullException(nameof(hostName));
            }

            using var scope = _clientDiagnostics.CreateScope("DedicatedHostCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _dedicatedHostsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, hostName, expand, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<DedicatedHost>(null, response.GetRawResponse())
                    : Response.FromValue(new DedicatedHost(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="hostName"> The name of the dedicated host. </param>
        /// <param name="expand"> The expand expression to apply on the operation. &apos;InstanceView&apos; will retrieve the list of instance views of the dedicated host. &apos;UserData&apos; is not supported for dedicated host. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="hostName"/> is null. </exception>
        public async virtual Task<Response<DedicatedHost>> GetIfExistsAsync(string hostName, InstanceViewTypes? expand = null, CancellationToken cancellationToken = default)
        {
            if (hostName == null)
            {
                throw new ArgumentNullException(nameof(hostName));
            }

            using var scope = _clientDiagnostics.CreateScope("DedicatedHostCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _dedicatedHostsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, hostName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<DedicatedHost>(null, response.GetRawResponse())
                    : Response.FromValue(new DedicatedHost(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="hostName"> The name of the dedicated host. </param>
        /// <param name="expand"> The expand expression to apply on the operation. &apos;InstanceView&apos; will retrieve the list of instance views of the dedicated host. &apos;UserData&apos; is not supported for dedicated host. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="hostName"/> is null. </exception>
        public virtual Response<bool> Exists(string hostName, InstanceViewTypes? expand = null, CancellationToken cancellationToken = default)
        {
            if (hostName == null)
            {
                throw new ArgumentNullException(nameof(hostName));
            }

            using var scope = _clientDiagnostics.CreateScope("DedicatedHostCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(hostName, expand, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="hostName"> The name of the dedicated host. </param>
        /// <param name="expand"> The expand expression to apply on the operation. &apos;InstanceView&apos; will retrieve the list of instance views of the dedicated host. &apos;UserData&apos; is not supported for dedicated host. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="hostName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string hostName, InstanceViewTypes? expand = null, CancellationToken cancellationToken = default)
        {
            if (hostName == null)
            {
                throw new ArgumentNullException(nameof(hostName));
            }

            using var scope = _clientDiagnostics.CreateScope("DedicatedHostCollection.ExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(hostName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all of the dedicated hosts in the specified dedicated host group. Use the nextLink property in the response to get the next page of dedicated hosts. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DedicatedHost" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DedicatedHost> GetAll(CancellationToken cancellationToken = default)
        {
            Page<DedicatedHost> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DedicatedHostCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _dedicatedHostsRestClient.ListByHostGroup(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DedicatedHost(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<DedicatedHost> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DedicatedHostCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _dedicatedHostsRestClient.ListByHostGroupNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DedicatedHost(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists all of the dedicated hosts in the specified dedicated host group. Use the nextLink property in the response to get the next page of dedicated hosts. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DedicatedHost" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DedicatedHost> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<DedicatedHost>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DedicatedHostCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _dedicatedHostsRestClient.ListByHostGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DedicatedHost(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<DedicatedHost>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DedicatedHostCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _dedicatedHostsRestClient.ListByHostGroupNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DedicatedHost(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<DedicatedHost> IEnumerable<DedicatedHost>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DedicatedHost> IAsyncEnumerable<DedicatedHost>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, DedicatedHost, DedicatedHostData> Construct() { }
    }
}
