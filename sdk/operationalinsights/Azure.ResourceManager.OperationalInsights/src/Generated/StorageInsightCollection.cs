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

namespace Azure.ResourceManager.OperationalInsights
{
    /// <summary>
    /// A class representing a collection of <see cref="StorageInsightResource"/> and their operations.
    /// Each <see cref="StorageInsightResource"/> in the collection will belong to the same instance of <see cref="OperationalInsightsWorkspaceResource"/>.
    /// To get a <see cref="StorageInsightCollection"/> instance call the GetStorageInsights method from an instance of <see cref="OperationalInsightsWorkspaceResource"/>.
    /// </summary>
    public partial class StorageInsightCollection : ArmCollection, IEnumerable<StorageInsightResource>, IAsyncEnumerable<StorageInsightResource>
    {
        private readonly ClientDiagnostics _storageInsightStorageInsightConfigsClientDiagnostics;
        private readonly StorageInsightConfigsRestOperations _storageInsightStorageInsightConfigsRestClient;

        /// <summary> Initializes a new instance of the <see cref="StorageInsightCollection"/> class for mocking. </summary>
        protected StorageInsightCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="StorageInsightCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal StorageInsightCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _storageInsightStorageInsightConfigsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.OperationalInsights", StorageInsightResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(StorageInsightResource.ResourceType, out string storageInsightStorageInsightConfigsApiVersion);
            _storageInsightStorageInsightConfigsRestClient = new StorageInsightConfigsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, storageInsightStorageInsightConfigsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != OperationalInsightsWorkspaceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, OperationalInsightsWorkspaceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update a storage insight.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/storageInsightConfigs/{storageInsightName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageInsightConfigs_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="storageInsightName"> Name of the storageInsightsConfigs resource. </param>
        /// <param name="data"> The parameters required to create or update a storage insight. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageInsightName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageInsightName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<StorageInsightResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string storageInsightName, StorageInsightData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storageInsightName, nameof(storageInsightName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _storageInsightStorageInsightConfigsClientDiagnostics.CreateScope("StorageInsightCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _storageInsightStorageInsightConfigsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, storageInsightName, data, cancellationToken).ConfigureAwait(false);
                var operation = new OperationalInsightsArmOperation<StorageInsightResource>(Response.FromValue(new StorageInsightResource(Client, response), response.GetRawResponse()));
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
        /// Create or update a storage insight.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/storageInsightConfigs/{storageInsightName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageInsightConfigs_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="storageInsightName"> Name of the storageInsightsConfigs resource. </param>
        /// <param name="data"> The parameters required to create or update a storage insight. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageInsightName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageInsightName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<StorageInsightResource> CreateOrUpdate(WaitUntil waitUntil, string storageInsightName, StorageInsightData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storageInsightName, nameof(storageInsightName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _storageInsightStorageInsightConfigsClientDiagnostics.CreateScope("StorageInsightCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _storageInsightStorageInsightConfigsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, storageInsightName, data, cancellationToken);
                var operation = new OperationalInsightsArmOperation<StorageInsightResource>(Response.FromValue(new StorageInsightResource(Client, response), response.GetRawResponse()));
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
        /// Gets a storage insight instance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/storageInsightConfigs/{storageInsightName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageInsightConfigs_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="storageInsightName"> Name of the storageInsightsConfigs resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageInsightName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageInsightName"/> is null. </exception>
        public virtual async Task<Response<StorageInsightResource>> GetAsync(string storageInsightName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storageInsightName, nameof(storageInsightName));

            using var scope = _storageInsightStorageInsightConfigsClientDiagnostics.CreateScope("StorageInsightCollection.Get");
            scope.Start();
            try
            {
                var response = await _storageInsightStorageInsightConfigsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, storageInsightName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StorageInsightResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a storage insight instance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/storageInsightConfigs/{storageInsightName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageInsightConfigs_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="storageInsightName"> Name of the storageInsightsConfigs resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageInsightName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageInsightName"/> is null. </exception>
        public virtual Response<StorageInsightResource> Get(string storageInsightName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storageInsightName, nameof(storageInsightName));

            using var scope = _storageInsightStorageInsightConfigsClientDiagnostics.CreateScope("StorageInsightCollection.Get");
            scope.Start();
            try
            {
                var response = _storageInsightStorageInsightConfigsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, storageInsightName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StorageInsightResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the storage insight instances within a workspace
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/storageInsightConfigs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageInsightConfigs_ListByWorkspace</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="StorageInsightResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<StorageInsightResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _storageInsightStorageInsightConfigsRestClient.CreateListByWorkspaceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _storageInsightStorageInsightConfigsRestClient.CreateListByWorkspaceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new StorageInsightResource(Client, StorageInsightData.DeserializeStorageInsightData(e)), _storageInsightStorageInsightConfigsClientDiagnostics, Pipeline, "StorageInsightCollection.GetAll", "value", "@odata.nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists the storage insight instances within a workspace
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/storageInsightConfigs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageInsightConfigs_ListByWorkspace</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="StorageInsightResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<StorageInsightResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _storageInsightStorageInsightConfigsRestClient.CreateListByWorkspaceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _storageInsightStorageInsightConfigsRestClient.CreateListByWorkspaceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new StorageInsightResource(Client, StorageInsightData.DeserializeStorageInsightData(e)), _storageInsightStorageInsightConfigsClientDiagnostics, Pipeline, "StorageInsightCollection.GetAll", "value", "@odata.nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/storageInsightConfigs/{storageInsightName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageInsightConfigs_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="storageInsightName"> Name of the storageInsightsConfigs resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageInsightName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageInsightName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string storageInsightName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storageInsightName, nameof(storageInsightName));

            using var scope = _storageInsightStorageInsightConfigsClientDiagnostics.CreateScope("StorageInsightCollection.Exists");
            scope.Start();
            try
            {
                var response = await _storageInsightStorageInsightConfigsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, storageInsightName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/storageInsightConfigs/{storageInsightName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageInsightConfigs_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="storageInsightName"> Name of the storageInsightsConfigs resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageInsightName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageInsightName"/> is null. </exception>
        public virtual Response<bool> Exists(string storageInsightName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storageInsightName, nameof(storageInsightName));

            using var scope = _storageInsightStorageInsightConfigsClientDiagnostics.CreateScope("StorageInsightCollection.Exists");
            scope.Start();
            try
            {
                var response = _storageInsightStorageInsightConfigsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, storageInsightName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/storageInsightConfigs/{storageInsightName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageInsightConfigs_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="storageInsightName"> Name of the storageInsightsConfigs resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageInsightName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageInsightName"/> is null. </exception>
        public virtual async Task<NullableResponse<StorageInsightResource>> GetIfExistsAsync(string storageInsightName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storageInsightName, nameof(storageInsightName));

            using var scope = _storageInsightStorageInsightConfigsClientDiagnostics.CreateScope("StorageInsightCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _storageInsightStorageInsightConfigsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, storageInsightName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<StorageInsightResource>(response.GetRawResponse());
                return Response.FromValue(new StorageInsightResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/storageInsightConfigs/{storageInsightName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageInsightConfigs_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="storageInsightName"> Name of the storageInsightsConfigs resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageInsightName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageInsightName"/> is null. </exception>
        public virtual NullableResponse<StorageInsightResource> GetIfExists(string storageInsightName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storageInsightName, nameof(storageInsightName));

            using var scope = _storageInsightStorageInsightConfigsClientDiagnostics.CreateScope("StorageInsightCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _storageInsightStorageInsightConfigsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, storageInsightName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<StorageInsightResource>(response.GetRawResponse());
                return Response.FromValue(new StorageInsightResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<StorageInsightResource> IEnumerable<StorageInsightResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<StorageInsightResource> IAsyncEnumerable<StorageInsightResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
