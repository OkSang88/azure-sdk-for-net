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
using Azure.ResourceManager.CosmosDB.Models;

namespace Azure.ResourceManager.CosmosDB
{
    /// <summary> A class representing collection of CassandraTable and their operations over its parent. </summary>
    public partial class CassandraTableCollection : ArmCollection, IEnumerable<CassandraTable>, IAsyncEnumerable<CassandraTable>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly CassandraResourcesRestOperations _cassandraResourcesRestClient;

        /// <summary> Initializes a new instance of the <see cref="CassandraTableCollection"/> class for mocking. </summary>
        protected CassandraTableCollection()
        {
        }

        /// <summary> Initializes a new instance of CassandraTableCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal CassandraTableCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _cassandraResourcesRestClient = new CassandraResourcesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != CassandraKeyspace.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, CassandraKeyspace.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// <summary> Create or update an Azure Cosmos DB Cassandra Table. </summary>
        /// <param name="tableName"> Cosmos DB table name. </param>
        /// <param name="createUpdateCassandraTableParameters"> The parameters to provide for the current Cassandra Table. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tableName"/> or <paramref name="createUpdateCassandraTableParameters"/> is null. </exception>
        public virtual CassandraResourceCreateUpdateCassandraTableOperation CreateOrUpdate(string tableName, CassandraTableCreateUpdateOptions createUpdateCassandraTableParameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (tableName == null)
            {
                throw new ArgumentNullException(nameof(tableName));
            }
            if (createUpdateCassandraTableParameters == null)
            {
                throw new ArgumentNullException(nameof(createUpdateCassandraTableParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("CassandraTableCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _cassandraResourcesRestClient.CreateUpdateCassandraTable(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, tableName, createUpdateCassandraTableParameters, cancellationToken);
                var operation = new CassandraResourceCreateUpdateCassandraTableOperation(Parent, _clientDiagnostics, Pipeline, _cassandraResourcesRestClient.CreateCreateUpdateCassandraTableRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, tableName, createUpdateCassandraTableParameters).Request, response);
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

        /// <summary> Create or update an Azure Cosmos DB Cassandra Table. </summary>
        /// <param name="tableName"> Cosmos DB table name. </param>
        /// <param name="createUpdateCassandraTableParameters"> The parameters to provide for the current Cassandra Table. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tableName"/> or <paramref name="createUpdateCassandraTableParameters"/> is null. </exception>
        public async virtual Task<CassandraResourceCreateUpdateCassandraTableOperation> CreateOrUpdateAsync(string tableName, CassandraTableCreateUpdateOptions createUpdateCassandraTableParameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (tableName == null)
            {
                throw new ArgumentNullException(nameof(tableName));
            }
            if (createUpdateCassandraTableParameters == null)
            {
                throw new ArgumentNullException(nameof(createUpdateCassandraTableParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("CassandraTableCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _cassandraResourcesRestClient.CreateUpdateCassandraTableAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, tableName, createUpdateCassandraTableParameters, cancellationToken).ConfigureAwait(false);
                var operation = new CassandraResourceCreateUpdateCassandraTableOperation(Parent, _clientDiagnostics, Pipeline, _cassandraResourcesRestClient.CreateCreateUpdateCassandraTableRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, tableName, createUpdateCassandraTableParameters).Request, response);
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

        /// <summary> Gets the Cassandra table under an existing Azure Cosmos DB database account. </summary>
        /// <param name="tableName"> Cosmos DB table name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tableName"/> is null. </exception>
        public virtual Response<CassandraTable> Get(string tableName, CancellationToken cancellationToken = default)
        {
            if (tableName == null)
            {
                throw new ArgumentNullException(nameof(tableName));
            }

            using var scope = _clientDiagnostics.CreateScope("CassandraTableCollection.Get");
            scope.Start();
            try
            {
                var response = _cassandraResourcesRestClient.GetCassandraTable(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, tableName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CassandraTable(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the Cassandra table under an existing Azure Cosmos DB database account. </summary>
        /// <param name="tableName"> Cosmos DB table name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tableName"/> is null. </exception>
        public async virtual Task<Response<CassandraTable>> GetAsync(string tableName, CancellationToken cancellationToken = default)
        {
            if (tableName == null)
            {
                throw new ArgumentNullException(nameof(tableName));
            }

            using var scope = _clientDiagnostics.CreateScope("CassandraTableCollection.Get");
            scope.Start();
            try
            {
                var response = await _cassandraResourcesRestClient.GetCassandraTableAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, tableName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new CassandraTable(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="tableName"> Cosmos DB table name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tableName"/> is null. </exception>
        public virtual Response<CassandraTable> GetIfExists(string tableName, CancellationToken cancellationToken = default)
        {
            if (tableName == null)
            {
                throw new ArgumentNullException(nameof(tableName));
            }

            using var scope = _clientDiagnostics.CreateScope("CassandraTableCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _cassandraResourcesRestClient.GetCassandraTable(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, tableName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<CassandraTable>(null, response.GetRawResponse())
                    : Response.FromValue(new CassandraTable(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="tableName"> Cosmos DB table name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tableName"/> is null. </exception>
        public async virtual Task<Response<CassandraTable>> GetIfExistsAsync(string tableName, CancellationToken cancellationToken = default)
        {
            if (tableName == null)
            {
                throw new ArgumentNullException(nameof(tableName));
            }

            using var scope = _clientDiagnostics.CreateScope("CassandraTableCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _cassandraResourcesRestClient.GetCassandraTableAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, tableName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<CassandraTable>(null, response.GetRawResponse())
                    : Response.FromValue(new CassandraTable(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="tableName"> Cosmos DB table name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tableName"/> is null. </exception>
        public virtual Response<bool> Exists(string tableName, CancellationToken cancellationToken = default)
        {
            if (tableName == null)
            {
                throw new ArgumentNullException(nameof(tableName));
            }

            using var scope = _clientDiagnostics.CreateScope("CassandraTableCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(tableName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="tableName"> Cosmos DB table name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tableName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string tableName, CancellationToken cancellationToken = default)
        {
            if (tableName == null)
            {
                throw new ArgumentNullException(nameof(tableName));
            }

            using var scope = _clientDiagnostics.CreateScope("CassandraTableCollection.ExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(tableName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists the Cassandra table under an existing Azure Cosmos DB database account. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="CassandraTable" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<CassandraTable> GetAll(CancellationToken cancellationToken = default)
        {
            Page<CassandraTable> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("CassandraTableCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _cassandraResourcesRestClient.ListCassandraTables(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new CassandraTable(Parent, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary> Lists the Cassandra table under an existing Azure Cosmos DB database account. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="CassandraTable" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<CassandraTable> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<CassandraTable>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("CassandraTableCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _cassandraResourcesRestClient.ListCassandraTablesAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new CassandraTable(Parent, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        IEnumerator<CassandraTable> IEnumerable<CassandraTable>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<CassandraTable> IAsyncEnumerable<CassandraTable>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, CassandraTable, CassandraTableData> Construct() { }
    }
}
