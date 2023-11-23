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
using Azure.ResourceManager.DataLakeAnalytics.Models;

namespace Azure.ResourceManager.DataLakeAnalytics
{
    /// <summary>
    /// A class representing a collection of <see cref="DataLakeStoreAccountInformationResource"/> and their operations.
    /// Each <see cref="DataLakeStoreAccountInformationResource"/> in the collection will belong to the same instance of <see cref="DataLakeAnalyticsAccountResource"/>.
    /// To get a <see cref="DataLakeStoreAccountInformationCollection"/> instance call the GetDataLakeStoreAccountInformation method from an instance of <see cref="DataLakeAnalyticsAccountResource"/>.
    /// </summary>
    public partial class DataLakeStoreAccountInformationCollection : ArmCollection, IEnumerable<DataLakeStoreAccountInformationResource>, IAsyncEnumerable<DataLakeStoreAccountInformationResource>
    {
        private readonly ClientDiagnostics _dataLakeStoreAccountInformationDataLakeStoreAccountsClientDiagnostics;
        private readonly DataLakeStoreAccountsRestOperations _dataLakeStoreAccountInformationDataLakeStoreAccountsRestClient;

        /// <summary> Initializes a new instance of the <see cref="DataLakeStoreAccountInformationCollection"/> class for mocking. </summary>
        protected DataLakeStoreAccountInformationCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DataLakeStoreAccountInformationCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DataLakeStoreAccountInformationCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _dataLakeStoreAccountInformationDataLakeStoreAccountsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DataLakeAnalytics", DataLakeStoreAccountInformationResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DataLakeStoreAccountInformationResource.ResourceType, out string dataLakeStoreAccountInformationDataLakeStoreAccountsApiVersion);
            _dataLakeStoreAccountInformationDataLakeStoreAccountsRestClient = new DataLakeStoreAccountsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, dataLakeStoreAccountInformationDataLakeStoreAccountsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != DataLakeAnalyticsAccountResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, DataLakeAnalyticsAccountResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Updates the specified Data Lake Analytics account to include the additional Data Lake Store account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeAnalytics/accounts/{accountName}/dataLakeStoreAccounts/{dataLakeStoreAccountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataLakeStoreAccounts_Add</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="dataLakeStoreAccountName"> The name of the Data Lake Store account to add. </param>
        /// <param name="content"> The details of the Data Lake Store account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataLakeStoreAccountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataLakeStoreAccountName"/> or <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation> CreateOrUpdateAsync(WaitUntil waitUntil, string dataLakeStoreAccountName, DataLakeStoreAccountInformationCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataLakeStoreAccountName, nameof(dataLakeStoreAccountName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _dataLakeStoreAccountInformationDataLakeStoreAccountsClientDiagnostics.CreateScope("DataLakeStoreAccountInformationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _dataLakeStoreAccountInformationDataLakeStoreAccountsRestClient.AddAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dataLakeStoreAccountName, content, cancellationToken).ConfigureAwait(false);
                var operation = new DataLakeAnalyticsArmOperation(response);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Updates the specified Data Lake Analytics account to include the additional Data Lake Store account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeAnalytics/accounts/{accountName}/dataLakeStoreAccounts/{dataLakeStoreAccountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataLakeStoreAccounts_Add</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="dataLakeStoreAccountName"> The name of the Data Lake Store account to add. </param>
        /// <param name="content"> The details of the Data Lake Store account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataLakeStoreAccountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataLakeStoreAccountName"/> or <paramref name="content"/> is null. </exception>
        public virtual ArmOperation CreateOrUpdate(WaitUntil waitUntil, string dataLakeStoreAccountName, DataLakeStoreAccountInformationCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataLakeStoreAccountName, nameof(dataLakeStoreAccountName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _dataLakeStoreAccountInformationDataLakeStoreAccountsClientDiagnostics.CreateScope("DataLakeStoreAccountInformationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _dataLakeStoreAccountInformationDataLakeStoreAccountsRestClient.Add(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dataLakeStoreAccountName, content, cancellationToken);
                var operation = new DataLakeAnalyticsArmOperation(response);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified Data Lake Store account details in the specified Data Lake Analytics account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeAnalytics/accounts/{accountName}/dataLakeStoreAccounts/{dataLakeStoreAccountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataLakeStoreAccounts_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dataLakeStoreAccountName"> The name of the Data Lake Store account to retrieve. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataLakeStoreAccountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataLakeStoreAccountName"/> is null. </exception>
        public virtual async Task<Response<DataLakeStoreAccountInformationResource>> GetAsync(string dataLakeStoreAccountName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataLakeStoreAccountName, nameof(dataLakeStoreAccountName));

            using var scope = _dataLakeStoreAccountInformationDataLakeStoreAccountsClientDiagnostics.CreateScope("DataLakeStoreAccountInformationCollection.Get");
            scope.Start();
            try
            {
                var response = await _dataLakeStoreAccountInformationDataLakeStoreAccountsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dataLakeStoreAccountName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataLakeStoreAccountInformationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified Data Lake Store account details in the specified Data Lake Analytics account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeAnalytics/accounts/{accountName}/dataLakeStoreAccounts/{dataLakeStoreAccountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataLakeStoreAccounts_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dataLakeStoreAccountName"> The name of the Data Lake Store account to retrieve. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataLakeStoreAccountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataLakeStoreAccountName"/> is null. </exception>
        public virtual Response<DataLakeStoreAccountInformationResource> Get(string dataLakeStoreAccountName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataLakeStoreAccountName, nameof(dataLakeStoreAccountName));

            using var scope = _dataLakeStoreAccountInformationDataLakeStoreAccountsClientDiagnostics.CreateScope("DataLakeStoreAccountInformationCollection.Get");
            scope.Start();
            try
            {
                var response = _dataLakeStoreAccountInformationDataLakeStoreAccountsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dataLakeStoreAccountName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataLakeStoreAccountInformationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the first page of Data Lake Store accounts linked to the specified Data Lake Analytics account. The response includes a link to the next page, if any.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeAnalytics/accounts/{accountName}/dataLakeStoreAccounts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataLakeStoreAccounts_ListByAccount</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="options"> A property bag which contains all the parameters of this method except the LRO qualifier and request context parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DataLakeStoreAccountInformationResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DataLakeStoreAccountInformationResource> GetAllAsync(DataLakeStoreAccountInformationCollectionGetAllOptions options, CancellationToken cancellationToken = default)
        {
            options ??= new DataLakeStoreAccountInformationCollectionGetAllOptions();

            HttpMessage FirstPageRequest(int? pageSizeHint) => _dataLakeStoreAccountInformationDataLakeStoreAccountsRestClient.CreateListByAccountRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, options.Filter, options.Top, options.Skip, options.Select, options.Orderby, options.Count);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dataLakeStoreAccountInformationDataLakeStoreAccountsRestClient.CreateListByAccountNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, options.Filter, options.Top, options.Skip, options.Select, options.Orderby, options.Count);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new DataLakeStoreAccountInformationResource(Client, DataLakeStoreAccountInformationData.DeserializeDataLakeStoreAccountInformationData(e)), _dataLakeStoreAccountInformationDataLakeStoreAccountsClientDiagnostics, Pipeline, "DataLakeStoreAccountInformationCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets the first page of Data Lake Store accounts linked to the specified Data Lake Analytics account. The response includes a link to the next page, if any.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeAnalytics/accounts/{accountName}/dataLakeStoreAccounts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataLakeStoreAccounts_ListByAccount</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="options"> A property bag which contains all the parameters of this method except the LRO qualifier and request context parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DataLakeStoreAccountInformationResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DataLakeStoreAccountInformationResource> GetAll(DataLakeStoreAccountInformationCollectionGetAllOptions options, CancellationToken cancellationToken = default)
        {
            options ??= new DataLakeStoreAccountInformationCollectionGetAllOptions();

            HttpMessage FirstPageRequest(int? pageSizeHint) => _dataLakeStoreAccountInformationDataLakeStoreAccountsRestClient.CreateListByAccountRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, options.Filter, options.Top, options.Skip, options.Select, options.Orderby, options.Count);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dataLakeStoreAccountInformationDataLakeStoreAccountsRestClient.CreateListByAccountNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, options.Filter, options.Top, options.Skip, options.Select, options.Orderby, options.Count);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new DataLakeStoreAccountInformationResource(Client, DataLakeStoreAccountInformationData.DeserializeDataLakeStoreAccountInformationData(e)), _dataLakeStoreAccountInformationDataLakeStoreAccountsClientDiagnostics, Pipeline, "DataLakeStoreAccountInformationCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeAnalytics/accounts/{accountName}/dataLakeStoreAccounts/{dataLakeStoreAccountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataLakeStoreAccounts_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dataLakeStoreAccountName"> The name of the Data Lake Store account to retrieve. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataLakeStoreAccountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataLakeStoreAccountName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string dataLakeStoreAccountName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataLakeStoreAccountName, nameof(dataLakeStoreAccountName));

            using var scope = _dataLakeStoreAccountInformationDataLakeStoreAccountsClientDiagnostics.CreateScope("DataLakeStoreAccountInformationCollection.Exists");
            scope.Start();
            try
            {
                var response = await _dataLakeStoreAccountInformationDataLakeStoreAccountsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dataLakeStoreAccountName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeAnalytics/accounts/{accountName}/dataLakeStoreAccounts/{dataLakeStoreAccountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataLakeStoreAccounts_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dataLakeStoreAccountName"> The name of the Data Lake Store account to retrieve. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataLakeStoreAccountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataLakeStoreAccountName"/> is null. </exception>
        public virtual Response<bool> Exists(string dataLakeStoreAccountName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataLakeStoreAccountName, nameof(dataLakeStoreAccountName));

            using var scope = _dataLakeStoreAccountInformationDataLakeStoreAccountsClientDiagnostics.CreateScope("DataLakeStoreAccountInformationCollection.Exists");
            scope.Start();
            try
            {
                var response = _dataLakeStoreAccountInformationDataLakeStoreAccountsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dataLakeStoreAccountName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeAnalytics/accounts/{accountName}/dataLakeStoreAccounts/{dataLakeStoreAccountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataLakeStoreAccounts_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dataLakeStoreAccountName"> The name of the Data Lake Store account to retrieve. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataLakeStoreAccountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataLakeStoreAccountName"/> is null. </exception>
        public virtual async Task<NullableResponse<DataLakeStoreAccountInformationResource>> GetIfExistsAsync(string dataLakeStoreAccountName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataLakeStoreAccountName, nameof(dataLakeStoreAccountName));

            using var scope = _dataLakeStoreAccountInformationDataLakeStoreAccountsClientDiagnostics.CreateScope("DataLakeStoreAccountInformationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _dataLakeStoreAccountInformationDataLakeStoreAccountsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dataLakeStoreAccountName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<DataLakeStoreAccountInformationResource>(response.GetRawResponse());
                return Response.FromValue(new DataLakeStoreAccountInformationResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeAnalytics/accounts/{accountName}/dataLakeStoreAccounts/{dataLakeStoreAccountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataLakeStoreAccounts_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dataLakeStoreAccountName"> The name of the Data Lake Store account to retrieve. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataLakeStoreAccountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataLakeStoreAccountName"/> is null. </exception>
        public virtual NullableResponse<DataLakeStoreAccountInformationResource> GetIfExists(string dataLakeStoreAccountName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataLakeStoreAccountName, nameof(dataLakeStoreAccountName));

            using var scope = _dataLakeStoreAccountInformationDataLakeStoreAccountsClientDiagnostics.CreateScope("DataLakeStoreAccountInformationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _dataLakeStoreAccountInformationDataLakeStoreAccountsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dataLakeStoreAccountName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<DataLakeStoreAccountInformationResource>(response.GetRawResponse());
                return Response.FromValue(new DataLakeStoreAccountInformationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DataLakeStoreAccountInformationResource> IEnumerable<DataLakeStoreAccountInformationResource>.GetEnumerator()
        {
            return GetAll(options: null).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll(options: null).GetEnumerator();
        }

        IAsyncEnumerator<DataLakeStoreAccountInformationResource> IAsyncEnumerable<DataLakeStoreAccountInformationResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(options: null, cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
