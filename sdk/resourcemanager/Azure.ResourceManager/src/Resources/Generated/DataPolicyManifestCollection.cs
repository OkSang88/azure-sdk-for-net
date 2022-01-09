// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Resources
{
    /// <summary> A class representing collection of DataPolicyManifest and their operations over its parent. </summary>
    public partial class DataPolicyManifestCollection : ArmCollection, IEnumerable<DataPolicyManifest>, IAsyncEnumerable<DataPolicyManifest>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly DataPolicyManifestsRestOperations _dataPolicyManifestsRestClient;

        /// <summary> Initializes a new instance of the <see cref="DataPolicyManifestCollection"/> class for mocking. </summary>
        protected DataPolicyManifestCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DataPolicyManifestCollection"/> class class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal DataPolicyManifestCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _dataPolicyManifestsRestClient = new DataPolicyManifestsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => Tenant.ResourceType;

        // Collection level operations.

        /// RequestPath: /providers/Microsoft.Authorization/dataPolicyManifests/{policyMode}
        /// ContextualPath: /
        /// OperationId: DataPolicyManifests_GetByPolicyMode
        /// <summary> This operation retrieves the data policy manifest with the given policy mode. </summary>
        /// <param name="policyMode"> The policy mode of the data policy manifest to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="policyMode"/> is null. </exception>
        public virtual Response<DataPolicyManifest> Get(string policyMode, CancellationToken cancellationToken = default)
        {
            if (policyMode == null)
            {
                throw new ArgumentNullException(nameof(policyMode));
            }

            using var scope = _clientDiagnostics.CreateScope("DataPolicyManifestCollection.Get");
            scope.Start();
            try
            {
                var response = _dataPolicyManifestsRestClient.GetByPolicyMode(policyMode, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataPolicyManifest(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /providers/Microsoft.Authorization/dataPolicyManifests/{policyMode}
        /// ContextualPath: /
        /// OperationId: DataPolicyManifests_GetByPolicyMode
        /// <summary> This operation retrieves the data policy manifest with the given policy mode. </summary>
        /// <param name="policyMode"> The policy mode of the data policy manifest to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="policyMode"/> is null. </exception>
        public async virtual Task<Response<DataPolicyManifest>> GetAsync(string policyMode, CancellationToken cancellationToken = default)
        {
            if (policyMode == null)
            {
                throw new ArgumentNullException(nameof(policyMode));
            }

            using var scope = _clientDiagnostics.CreateScope("DataPolicyManifestCollection.Get");
            scope.Start();
            try
            {
                var response = await _dataPolicyManifestsRestClient.GetByPolicyModeAsync(policyMode, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new DataPolicyManifest(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="policyMode"> The policy mode of the data policy manifest to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="policyMode"/> is null. </exception>
        public virtual Response<DataPolicyManifest> GetIfExists(string policyMode, CancellationToken cancellationToken = default)
        {
            if (policyMode == null)
            {
                throw new ArgumentNullException(nameof(policyMode));
            }

            using var scope = _clientDiagnostics.CreateScope("DataPolicyManifestCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _dataPolicyManifestsRestClient.GetByPolicyMode(policyMode, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<DataPolicyManifest>(null, response.GetRawResponse())
                    : Response.FromValue(new DataPolicyManifest(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="policyMode"> The policy mode of the data policy manifest to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="policyMode"/> is null. </exception>
        public async virtual Task<Response<DataPolicyManifest>> GetIfExistsAsync(string policyMode, CancellationToken cancellationToken = default)
        {
            if (policyMode == null)
            {
                throw new ArgumentNullException(nameof(policyMode));
            }

            using var scope = _clientDiagnostics.CreateScope("DataPolicyManifestCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _dataPolicyManifestsRestClient.GetByPolicyModeAsync(policyMode, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<DataPolicyManifest>(null, response.GetRawResponse())
                    : Response.FromValue(new DataPolicyManifest(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="policyMode"> The policy mode of the data policy manifest to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="policyMode"/> is null. </exception>
        public virtual Response<bool> Exists(string policyMode, CancellationToken cancellationToken = default)
        {
            if (policyMode == null)
            {
                throw new ArgumentNullException(nameof(policyMode));
            }

            using var scope = _clientDiagnostics.CreateScope("DataPolicyManifestCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(policyMode, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="policyMode"> The policy mode of the data policy manifest to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="policyMode"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string policyMode, CancellationToken cancellationToken = default)
        {
            if (policyMode == null)
            {
                throw new ArgumentNullException(nameof(policyMode));
            }

            using var scope = _clientDiagnostics.CreateScope("DataPolicyManifestCollection.ExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(policyMode, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /providers/Microsoft.Authorization/dataPolicyManifests
        /// ContextualPath: /
        /// OperationId: DataPolicyManifests_List
        /// <summary> This operation retrieves a list of all the data policy manifests that match the optional given $filter. Valid values for $filter are: &quot;$filter=namespace eq &apos;{0}&apos;&quot;. If $filter is not provided, the unfiltered list includes all data policy manifests for data resource types. If $filter=namespace is provided, the returned list only includes all data policy manifests that have a namespace matching the provided value. </summary>
        /// <param name="filter"> The filter to apply on the operation. Valid values for $filter are: &quot;namespace eq &apos;{value}&apos;&quot;. If $filter is not provided, no filtering is performed. If $filter=namespace eq &apos;{value}&apos; is provided, the returned list only includes all data policy manifests that have a namespace matching the provided value. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DataPolicyManifest" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DataPolicyManifest> GetAll(string filter = null, CancellationToken cancellationToken = default)
        {
            Page<DataPolicyManifest> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DataPolicyManifestCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _dataPolicyManifestsRestClient.List(filter, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DataPolicyManifest(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<DataPolicyManifest> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DataPolicyManifestCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _dataPolicyManifestsRestClient.ListNextPage(nextLink, filter, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DataPolicyManifest(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /providers/Microsoft.Authorization/dataPolicyManifests
        /// ContextualPath: /
        /// OperationId: DataPolicyManifests_List
        /// <summary> This operation retrieves a list of all the data policy manifests that match the optional given $filter. Valid values for $filter are: &quot;$filter=namespace eq &apos;{0}&apos;&quot;. If $filter is not provided, the unfiltered list includes all data policy manifests for data resource types. If $filter=namespace is provided, the returned list only includes all data policy manifests that have a namespace matching the provided value. </summary>
        /// <param name="filter"> The filter to apply on the operation. Valid values for $filter are: &quot;namespace eq &apos;{value}&apos;&quot;. If $filter is not provided, no filtering is performed. If $filter=namespace eq &apos;{value}&apos; is provided, the returned list only includes all data policy manifests that have a namespace matching the provided value. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DataPolicyManifest" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DataPolicyManifest> GetAllAsync(string filter = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<DataPolicyManifest>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DataPolicyManifestCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _dataPolicyManifestsRestClient.ListAsync(filter, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DataPolicyManifest(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<DataPolicyManifest>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DataPolicyManifestCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _dataPolicyManifestsRestClient.ListNextPageAsync(nextLink, filter, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DataPolicyManifest(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<DataPolicyManifest> IEnumerable<DataPolicyManifest>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DataPolicyManifest> IAsyncEnumerable<DataPolicyManifest>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, DataPolicyManifest, DataPolicyManifestData> Construct() { }
    }
}
