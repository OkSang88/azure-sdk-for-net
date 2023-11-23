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

namespace Azure.ResourceManager.ApiManagement
{
    /// <summary>
    /// A class representing a collection of <see cref="ApiManagementPortalRevisionResource"/> and their operations.
    /// Each <see cref="ApiManagementPortalRevisionResource"/> in the collection will belong to the same instance of <see cref="ApiManagementServiceResource"/>.
    /// To get an <see cref="ApiManagementPortalRevisionCollection"/> instance call the GetApiManagementPortalRevisions method from an instance of <see cref="ApiManagementServiceResource"/>.
    /// </summary>
    public partial class ApiManagementPortalRevisionCollection : ArmCollection, IEnumerable<ApiManagementPortalRevisionResource>, IAsyncEnumerable<ApiManagementPortalRevisionResource>
    {
        private readonly ClientDiagnostics _apiManagementPortalRevisionPortalRevisionClientDiagnostics;
        private readonly PortalRevisionRestOperations _apiManagementPortalRevisionPortalRevisionRestClient;

        /// <summary> Initializes a new instance of the <see cref="ApiManagementPortalRevisionCollection"/> class for mocking. </summary>
        protected ApiManagementPortalRevisionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ApiManagementPortalRevisionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ApiManagementPortalRevisionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _apiManagementPortalRevisionPortalRevisionClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ApiManagement", ApiManagementPortalRevisionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ApiManagementPortalRevisionResource.ResourceType, out string apiManagementPortalRevisionPortalRevisionApiVersion);
            _apiManagementPortalRevisionPortalRevisionRestClient = new PortalRevisionRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, apiManagementPortalRevisionPortalRevisionApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ApiManagementServiceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ApiManagementServiceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a new developer portal's revision by running the portal's publishing. The `isCurrent` property indicates if the revision is publicly accessible.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/portalRevisions/{portalRevisionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PortalRevision_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="portalRevisionId"> Portal revision identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="data"> The ApiManagementPortalRevision to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="portalRevisionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="portalRevisionId"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ApiManagementPortalRevisionResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string portalRevisionId, ApiManagementPortalRevisionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(portalRevisionId, nameof(portalRevisionId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _apiManagementPortalRevisionPortalRevisionClientDiagnostics.CreateScope("ApiManagementPortalRevisionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _apiManagementPortalRevisionPortalRevisionRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, portalRevisionId, data, cancellationToken).ConfigureAwait(false);
                var operation = new ApiManagementArmOperation<ApiManagementPortalRevisionResource>(new ApiManagementPortalRevisionOperationSource(Client), _apiManagementPortalRevisionPortalRevisionClientDiagnostics, Pipeline, _apiManagementPortalRevisionPortalRevisionRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, portalRevisionId, data).Request, response, OperationFinalStateVia.Location);
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
        /// Creates a new developer portal's revision by running the portal's publishing. The `isCurrent` property indicates if the revision is publicly accessible.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/portalRevisions/{portalRevisionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PortalRevision_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="portalRevisionId"> Portal revision identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="data"> The ApiManagementPortalRevision to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="portalRevisionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="portalRevisionId"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ApiManagementPortalRevisionResource> CreateOrUpdate(WaitUntil waitUntil, string portalRevisionId, ApiManagementPortalRevisionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(portalRevisionId, nameof(portalRevisionId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _apiManagementPortalRevisionPortalRevisionClientDiagnostics.CreateScope("ApiManagementPortalRevisionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _apiManagementPortalRevisionPortalRevisionRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, portalRevisionId, data, cancellationToken);
                var operation = new ApiManagementArmOperation<ApiManagementPortalRevisionResource>(new ApiManagementPortalRevisionOperationSource(Client), _apiManagementPortalRevisionPortalRevisionClientDiagnostics, Pipeline, _apiManagementPortalRevisionPortalRevisionRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, portalRevisionId, data).Request, response, OperationFinalStateVia.Location);
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
        /// Gets the developer portal's revision specified by its identifier.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/portalRevisions/{portalRevisionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PortalRevision_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="portalRevisionId"> Portal revision identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="portalRevisionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="portalRevisionId"/> is null. </exception>
        public virtual async Task<Response<ApiManagementPortalRevisionResource>> GetAsync(string portalRevisionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(portalRevisionId, nameof(portalRevisionId));

            using var scope = _apiManagementPortalRevisionPortalRevisionClientDiagnostics.CreateScope("ApiManagementPortalRevisionCollection.Get");
            scope.Start();
            try
            {
                var response = await _apiManagementPortalRevisionPortalRevisionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, portalRevisionId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ApiManagementPortalRevisionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the developer portal's revision specified by its identifier.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/portalRevisions/{portalRevisionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PortalRevision_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="portalRevisionId"> Portal revision identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="portalRevisionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="portalRevisionId"/> is null. </exception>
        public virtual Response<ApiManagementPortalRevisionResource> Get(string portalRevisionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(portalRevisionId, nameof(portalRevisionId));

            using var scope = _apiManagementPortalRevisionPortalRevisionClientDiagnostics.CreateScope("ApiManagementPortalRevisionCollection.Get");
            scope.Start();
            try
            {
                var response = _apiManagementPortalRevisionPortalRevisionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, portalRevisionId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ApiManagementPortalRevisionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists developer portal's revisions.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/portalRevisions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PortalRevision_ListByService</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter">
        /// | Field       | Supported operators    | Supported functions               |
        /// |-------------|------------------------|-----------------------------------|
        ///
        /// |name | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith|
        /// |description | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith|
        /// |isCurrent | eq, ne |    |
        ///
        /// </param>
        /// <param name="top"> Number of records to return. </param>
        /// <param name="skip"> Number of records to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ApiManagementPortalRevisionResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ApiManagementPortalRevisionResource> GetAllAsync(string filter = null, int? top = null, int? skip = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _apiManagementPortalRevisionPortalRevisionRestClient.CreateListByServiceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, skip);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _apiManagementPortalRevisionPortalRevisionRestClient.CreateListByServiceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, skip);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ApiManagementPortalRevisionResource(Client, ApiManagementPortalRevisionData.DeserializeApiManagementPortalRevisionData(e)), _apiManagementPortalRevisionPortalRevisionClientDiagnostics, Pipeline, "ApiManagementPortalRevisionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists developer portal's revisions.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/portalRevisions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PortalRevision_ListByService</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter">
        /// | Field       | Supported operators    | Supported functions               |
        /// |-------------|------------------------|-----------------------------------|
        ///
        /// |name | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith|
        /// |description | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith|
        /// |isCurrent | eq, ne |    |
        ///
        /// </param>
        /// <param name="top"> Number of records to return. </param>
        /// <param name="skip"> Number of records to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ApiManagementPortalRevisionResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ApiManagementPortalRevisionResource> GetAll(string filter = null, int? top = null, int? skip = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _apiManagementPortalRevisionPortalRevisionRestClient.CreateListByServiceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, skip);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _apiManagementPortalRevisionPortalRevisionRestClient.CreateListByServiceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, skip);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ApiManagementPortalRevisionResource(Client, ApiManagementPortalRevisionData.DeserializeApiManagementPortalRevisionData(e)), _apiManagementPortalRevisionPortalRevisionClientDiagnostics, Pipeline, "ApiManagementPortalRevisionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/portalRevisions/{portalRevisionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PortalRevision_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="portalRevisionId"> Portal revision identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="portalRevisionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="portalRevisionId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string portalRevisionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(portalRevisionId, nameof(portalRevisionId));

            using var scope = _apiManagementPortalRevisionPortalRevisionClientDiagnostics.CreateScope("ApiManagementPortalRevisionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _apiManagementPortalRevisionPortalRevisionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, portalRevisionId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/portalRevisions/{portalRevisionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PortalRevision_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="portalRevisionId"> Portal revision identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="portalRevisionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="portalRevisionId"/> is null. </exception>
        public virtual Response<bool> Exists(string portalRevisionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(portalRevisionId, nameof(portalRevisionId));

            using var scope = _apiManagementPortalRevisionPortalRevisionClientDiagnostics.CreateScope("ApiManagementPortalRevisionCollection.Exists");
            scope.Start();
            try
            {
                var response = _apiManagementPortalRevisionPortalRevisionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, portalRevisionId, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/portalRevisions/{portalRevisionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PortalRevision_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="portalRevisionId"> Portal revision identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="portalRevisionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="portalRevisionId"/> is null. </exception>
        public virtual async Task<NullableResponse<ApiManagementPortalRevisionResource>> GetIfExistsAsync(string portalRevisionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(portalRevisionId, nameof(portalRevisionId));

            using var scope = _apiManagementPortalRevisionPortalRevisionClientDiagnostics.CreateScope("ApiManagementPortalRevisionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _apiManagementPortalRevisionPortalRevisionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, portalRevisionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ApiManagementPortalRevisionResource>(response.GetRawResponse());
                return Response.FromValue(new ApiManagementPortalRevisionResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/portalRevisions/{portalRevisionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PortalRevision_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="portalRevisionId"> Portal revision identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="portalRevisionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="portalRevisionId"/> is null. </exception>
        public virtual NullableResponse<ApiManagementPortalRevisionResource> GetIfExists(string portalRevisionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(portalRevisionId, nameof(portalRevisionId));

            using var scope = _apiManagementPortalRevisionPortalRevisionClientDiagnostics.CreateScope("ApiManagementPortalRevisionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _apiManagementPortalRevisionPortalRevisionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, portalRevisionId, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ApiManagementPortalRevisionResource>(response.GetRawResponse());
                return Response.FromValue(new ApiManagementPortalRevisionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ApiManagementPortalRevisionResource> IEnumerable<ApiManagementPortalRevisionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ApiManagementPortalRevisionResource> IAsyncEnumerable<ApiManagementPortalRevisionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
