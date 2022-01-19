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
    /// <summary> A class representing collection of SqlJob and their operations over its parent. </summary>
    public partial class SqlJobCollection : ArmCollection, IEnumerable<SqlJob>, IAsyncEnumerable<SqlJob>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly JobsRestOperations _jobsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SqlJobCollection"/> class for mocking. </summary>
        protected SqlJobCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SqlJobCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal SqlJobCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            ClientOptions.TryGetApiVersion(SqlJob.ResourceType, out string apiVersion);
            _jobsRestClient = new JobsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != JobAgent.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, JobAgent.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}
        /// OperationId: Jobs_CreateOrUpdate
        /// <summary> Creates or updates a job. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="jobName"> The name of the job to get. </param>
        /// <param name="parameters"> The requested job state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="jobName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual SqlJobCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string jobName, SqlJobData parameters, CancellationToken cancellationToken = default)
        {
            if (jobName == null)
            {
                throw new ArgumentNullException(nameof(jobName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("SqlJobCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _jobsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, jobName, parameters, cancellationToken);
                var operation = new SqlJobCreateOrUpdateOperation(this, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}
        /// OperationId: Jobs_CreateOrUpdate
        /// <summary> Creates or updates a job. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="jobName"> The name of the job to get. </param>
        /// <param name="parameters"> The requested job state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="jobName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<SqlJobCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string jobName, SqlJobData parameters, CancellationToken cancellationToken = default)
        {
            if (jobName == null)
            {
                throw new ArgumentNullException(nameof(jobName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("SqlJobCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _jobsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, jobName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new SqlJobCreateOrUpdateOperation(this, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}
        /// OperationId: Jobs_Get
        /// <summary> Gets a job. </summary>
        /// <param name="jobName"> The name of the job to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="jobName"/> is null. </exception>
        public virtual Response<SqlJob> Get(string jobName, CancellationToken cancellationToken = default)
        {
            if (jobName == null)
            {
                throw new ArgumentNullException(nameof(jobName));
            }

            using var scope = _clientDiagnostics.CreateScope("SqlJobCollection.Get");
            scope.Start();
            try
            {
                var response = _jobsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, jobName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SqlJob(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}
        /// OperationId: Jobs_Get
        /// <summary> Gets a job. </summary>
        /// <param name="jobName"> The name of the job to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="jobName"/> is null. </exception>
        public async virtual Task<Response<SqlJob>> GetAsync(string jobName, CancellationToken cancellationToken = default)
        {
            if (jobName == null)
            {
                throw new ArgumentNullException(nameof(jobName));
            }

            using var scope = _clientDiagnostics.CreateScope("SqlJobCollection.Get");
            scope.Start();
            try
            {
                var response = await _jobsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, jobName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new SqlJob(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="jobName"> The name of the job to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="jobName"/> is null. </exception>
        public virtual Response<SqlJob> GetIfExists(string jobName, CancellationToken cancellationToken = default)
        {
            if (jobName == null)
            {
                throw new ArgumentNullException(nameof(jobName));
            }

            using var scope = _clientDiagnostics.CreateScope("SqlJobCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _jobsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, jobName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<SqlJob>(null, response.GetRawResponse());
                return Response.FromValue(new SqlJob(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="jobName"> The name of the job to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="jobName"/> is null. </exception>
        public async virtual Task<Response<SqlJob>> GetIfExistsAsync(string jobName, CancellationToken cancellationToken = default)
        {
            if (jobName == null)
            {
                throw new ArgumentNullException(nameof(jobName));
            }

            using var scope = _clientDiagnostics.CreateScope("SqlJobCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _jobsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, jobName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<SqlJob>(null, response.GetRawResponse());
                return Response.FromValue(new SqlJob(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="jobName"> The name of the job to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="jobName"/> is null. </exception>
        public virtual Response<bool> Exists(string jobName, CancellationToken cancellationToken = default)
        {
            if (jobName == null)
            {
                throw new ArgumentNullException(nameof(jobName));
            }

            using var scope = _clientDiagnostics.CreateScope("SqlJobCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(jobName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="jobName"> The name of the job to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="jobName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string jobName, CancellationToken cancellationToken = default)
        {
            if (jobName == null)
            {
                throw new ArgumentNullException(nameof(jobName));
            }

            using var scope = _clientDiagnostics.CreateScope("SqlJobCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(jobName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}
        /// OperationId: Jobs_ListByAgent
        /// <summary> Gets a list of jobs. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SqlJob" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SqlJob> GetAll(CancellationToken cancellationToken = default)
        {
            Page<SqlJob> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SqlJobCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _jobsRestClient.ListByAgent(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SqlJob(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SqlJob> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SqlJobCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _jobsRestClient.ListByAgentNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SqlJob(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}
        /// OperationId: Jobs_ListByAgent
        /// <summary> Gets a list of jobs. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SqlJob" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SqlJob> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SqlJob>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SqlJobCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _jobsRestClient.ListByAgentAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SqlJob(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SqlJob>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SqlJobCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _jobsRestClient.ListByAgentNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SqlJob(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<SqlJob> IEnumerable<SqlJob>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SqlJob> IAsyncEnumerable<SqlJob>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, SqlJob, SqlJobData> Construct() { }
    }
}
