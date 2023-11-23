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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.SqlVirtualMachine
{
    /// <summary>
    /// A class representing a collection of <see cref="SqlVmGroupResource"/> and their operations.
    /// Each <see cref="SqlVmGroupResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get a <see cref="SqlVmGroupCollection"/> instance call the GetSqlVmGroups method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class SqlVmGroupCollection : ArmCollection, IEnumerable<SqlVmGroupResource>, IAsyncEnumerable<SqlVmGroupResource>
    {
        private readonly ClientDiagnostics _sqlVmGroupSqlVmGroupsClientDiagnostics;
        private readonly SqlVirtualMachineGroupsRestOperations _sqlVmGroupSqlVmGroupsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SqlVmGroupCollection"/> class for mocking. </summary>
        protected SqlVmGroupCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SqlVmGroupCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SqlVmGroupCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _sqlVmGroupSqlVmGroupsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SqlVirtualMachine", SqlVmGroupResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SqlVmGroupResource.ResourceType, out string sqlVmGroupSqlVmGroupsApiVersion);
            _sqlVmGroupSqlVmGroupsRestClient = new SqlVirtualMachineGroupsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, sqlVmGroupSqlVmGroupsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a SQL virtual machine group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SqlVirtualMachine/sqlVirtualMachineGroups/{sqlVirtualMachineGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlVirtualMachineGroups_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="sqlVmGroupName"> Name of the SQL virtual machine group. </param>
        /// <param name="data"> The SQL virtual machine group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sqlVmGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sqlVmGroupName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SqlVmGroupResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string sqlVmGroupName, SqlVmGroupData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sqlVmGroupName, nameof(sqlVmGroupName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _sqlVmGroupSqlVmGroupsClientDiagnostics.CreateScope("SqlVmGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _sqlVmGroupSqlVmGroupsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, sqlVmGroupName, data, cancellationToken).ConfigureAwait(false);
                var operation = new SqlVirtualMachineArmOperation<SqlVmGroupResource>(new SqlVmGroupOperationSource(Client), _sqlVmGroupSqlVmGroupsClientDiagnostics, Pipeline, _sqlVmGroupSqlVmGroupsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, sqlVmGroupName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Creates or updates a SQL virtual machine group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SqlVirtualMachine/sqlVirtualMachineGroups/{sqlVirtualMachineGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlVirtualMachineGroups_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="sqlVmGroupName"> Name of the SQL virtual machine group. </param>
        /// <param name="data"> The SQL virtual machine group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sqlVmGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sqlVmGroupName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SqlVmGroupResource> CreateOrUpdate(WaitUntil waitUntil, string sqlVmGroupName, SqlVmGroupData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sqlVmGroupName, nameof(sqlVmGroupName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _sqlVmGroupSqlVmGroupsClientDiagnostics.CreateScope("SqlVmGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _sqlVmGroupSqlVmGroupsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, sqlVmGroupName, data, cancellationToken);
                var operation = new SqlVirtualMachineArmOperation<SqlVmGroupResource>(new SqlVmGroupOperationSource(Client), _sqlVmGroupSqlVmGroupsClientDiagnostics, Pipeline, _sqlVmGroupSqlVmGroupsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, sqlVmGroupName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Gets a SQL virtual machine group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SqlVirtualMachine/sqlVirtualMachineGroups/{sqlVirtualMachineGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlVirtualMachineGroups_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sqlVmGroupName"> Name of the SQL virtual machine group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sqlVmGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sqlVmGroupName"/> is null. </exception>
        public virtual async Task<Response<SqlVmGroupResource>> GetAsync(string sqlVmGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sqlVmGroupName, nameof(sqlVmGroupName));

            using var scope = _sqlVmGroupSqlVmGroupsClientDiagnostics.CreateScope("SqlVmGroupCollection.Get");
            scope.Start();
            try
            {
                var response = await _sqlVmGroupSqlVmGroupsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, sqlVmGroupName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SqlVmGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a SQL virtual machine group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SqlVirtualMachine/sqlVirtualMachineGroups/{sqlVirtualMachineGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlVirtualMachineGroups_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sqlVmGroupName"> Name of the SQL virtual machine group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sqlVmGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sqlVmGroupName"/> is null. </exception>
        public virtual Response<SqlVmGroupResource> Get(string sqlVmGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sqlVmGroupName, nameof(sqlVmGroupName));

            using var scope = _sqlVmGroupSqlVmGroupsClientDiagnostics.CreateScope("SqlVmGroupCollection.Get");
            scope.Start();
            try
            {
                var response = _sqlVmGroupSqlVmGroupsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, sqlVmGroupName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SqlVmGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all SQL virtual machine groups in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SqlVirtualMachine/sqlVirtualMachineGroups</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlVirtualMachineGroups_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SqlVmGroupResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SqlVmGroupResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _sqlVmGroupSqlVmGroupsRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _sqlVmGroupSqlVmGroupsRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new SqlVmGroupResource(Client, SqlVmGroupData.DeserializeSqlVmGroupData(e)), _sqlVmGroupSqlVmGroupsClientDiagnostics, Pipeline, "SqlVmGroupCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets all SQL virtual machine groups in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SqlVirtualMachine/sqlVirtualMachineGroups</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlVirtualMachineGroups_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SqlVmGroupResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SqlVmGroupResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _sqlVmGroupSqlVmGroupsRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _sqlVmGroupSqlVmGroupsRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new SqlVmGroupResource(Client, SqlVmGroupData.DeserializeSqlVmGroupData(e)), _sqlVmGroupSqlVmGroupsClientDiagnostics, Pipeline, "SqlVmGroupCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SqlVirtualMachine/sqlVirtualMachineGroups/{sqlVirtualMachineGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlVirtualMachineGroups_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sqlVmGroupName"> Name of the SQL virtual machine group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sqlVmGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sqlVmGroupName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string sqlVmGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sqlVmGroupName, nameof(sqlVmGroupName));

            using var scope = _sqlVmGroupSqlVmGroupsClientDiagnostics.CreateScope("SqlVmGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = await _sqlVmGroupSqlVmGroupsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, sqlVmGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SqlVirtualMachine/sqlVirtualMachineGroups/{sqlVirtualMachineGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlVirtualMachineGroups_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sqlVmGroupName"> Name of the SQL virtual machine group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sqlVmGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sqlVmGroupName"/> is null. </exception>
        public virtual Response<bool> Exists(string sqlVmGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sqlVmGroupName, nameof(sqlVmGroupName));

            using var scope = _sqlVmGroupSqlVmGroupsClientDiagnostics.CreateScope("SqlVmGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = _sqlVmGroupSqlVmGroupsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, sqlVmGroupName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SqlVirtualMachine/sqlVirtualMachineGroups/{sqlVirtualMachineGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlVirtualMachineGroups_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sqlVmGroupName"> Name of the SQL virtual machine group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sqlVmGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sqlVmGroupName"/> is null. </exception>
        public virtual async Task<NullableResponse<SqlVmGroupResource>> GetIfExistsAsync(string sqlVmGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sqlVmGroupName, nameof(sqlVmGroupName));

            using var scope = _sqlVmGroupSqlVmGroupsClientDiagnostics.CreateScope("SqlVmGroupCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _sqlVmGroupSqlVmGroupsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, sqlVmGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<SqlVmGroupResource>(response.GetRawResponse());
                return Response.FromValue(new SqlVmGroupResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SqlVirtualMachine/sqlVirtualMachineGroups/{sqlVirtualMachineGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlVirtualMachineGroups_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sqlVmGroupName"> Name of the SQL virtual machine group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sqlVmGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sqlVmGroupName"/> is null. </exception>
        public virtual NullableResponse<SqlVmGroupResource> GetIfExists(string sqlVmGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sqlVmGroupName, nameof(sqlVmGroupName));

            using var scope = _sqlVmGroupSqlVmGroupsClientDiagnostics.CreateScope("SqlVmGroupCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _sqlVmGroupSqlVmGroupsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, sqlVmGroupName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<SqlVmGroupResource>(response.GetRawResponse());
                return Response.FromValue(new SqlVmGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SqlVmGroupResource> IEnumerable<SqlVmGroupResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SqlVmGroupResource> IAsyncEnumerable<SqlVmGroupResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
