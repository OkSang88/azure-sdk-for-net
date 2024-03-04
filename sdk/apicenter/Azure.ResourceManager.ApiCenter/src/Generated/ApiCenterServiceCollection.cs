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

namespace Azure.ResourceManager.ApiCenter
{
    /// <summary>
    /// A class representing a collection of <see cref="ApiCenterServiceResource"/> and their operations.
    /// Each <see cref="ApiCenterServiceResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get an <see cref="ApiCenterServiceCollection"/> instance call the GetApiCenterServices method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class ApiCenterServiceCollection : ArmCollection, IEnumerable<ApiCenterServiceResource>, IAsyncEnumerable<ApiCenterServiceResource>
    {
        private readonly ClientDiagnostics _apiCenterServiceServicesClientDiagnostics;
        private readonly ServicesRestOperations _apiCenterServiceServicesRestClient;

        /// <summary> Initializes a new instance of the <see cref="ApiCenterServiceCollection"/> class for mocking. </summary>
        protected ApiCenterServiceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ApiCenterServiceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ApiCenterServiceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _apiCenterServiceServicesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ApiCenter", ApiCenterServiceResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ApiCenterServiceResource.ResourceType, out string apiCenterServiceServicesApiVersion);
            _apiCenterServiceServicesRestClient = new ServicesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, apiCenterServiceServicesApiVersion);
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
        /// Create or update service
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiCenter/services/{serviceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Services_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-07-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiCenterServiceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="serviceName"> Service name. </param>
        /// <param name="data"> The service entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serviceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ApiCenterServiceResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string serviceName, ApiCenterServiceData data, CancellationToken cancellationToken = default)
        {
            if (serviceName == null)
            {
                throw new ArgumentNullException(nameof(serviceName));
            }
            if (serviceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(serviceName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _apiCenterServiceServicesClientDiagnostics.CreateScope("ApiCenterServiceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _apiCenterServiceServicesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, serviceName, data, cancellationToken).ConfigureAwait(false);
                var operation = new ApiCenterArmOperation<ApiCenterServiceResource>(Response.FromValue(new ApiCenterServiceResource(Client, response), response.GetRawResponse()));
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
        /// Create or update service
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiCenter/services/{serviceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Services_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-07-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiCenterServiceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="serviceName"> Service name. </param>
        /// <param name="data"> The service entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serviceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ApiCenterServiceResource> CreateOrUpdate(WaitUntil waitUntil, string serviceName, ApiCenterServiceData data, CancellationToken cancellationToken = default)
        {
            if (serviceName == null)
            {
                throw new ArgumentNullException(nameof(serviceName));
            }
            if (serviceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(serviceName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _apiCenterServiceServicesClientDiagnostics.CreateScope("ApiCenterServiceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _apiCenterServiceServicesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, serviceName, data, cancellationToken);
                var operation = new ApiCenterArmOperation<ApiCenterServiceResource>(Response.FromValue(new ApiCenterServiceResource(Client, response), response.GetRawResponse()));
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
        /// Get service
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiCenter/services/{serviceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Services_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-07-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiCenterServiceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="serviceName"> Service name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serviceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceName"/> is null. </exception>
        public virtual async Task<Response<ApiCenterServiceResource>> GetAsync(string serviceName, CancellationToken cancellationToken = default)
        {
            if (serviceName == null)
            {
                throw new ArgumentNullException(nameof(serviceName));
            }
            if (serviceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(serviceName));
            }

            using var scope = _apiCenterServiceServicesClientDiagnostics.CreateScope("ApiCenterServiceCollection.Get");
            scope.Start();
            try
            {
                var response = await _apiCenterServiceServicesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, serviceName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ApiCenterServiceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get service
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiCenter/services/{serviceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Services_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-07-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiCenterServiceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="serviceName"> Service name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serviceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceName"/> is null. </exception>
        public virtual Response<ApiCenterServiceResource> Get(string serviceName, CancellationToken cancellationToken = default)
        {
            if (serviceName == null)
            {
                throw new ArgumentNullException(nameof(serviceName));
            }
            if (serviceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(serviceName));
            }

            using var scope = _apiCenterServiceServicesClientDiagnostics.CreateScope("ApiCenterServiceCollection.Get");
            scope.Start();
            try
            {
                var response = _apiCenterServiceServicesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, serviceName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ApiCenterServiceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists services within a resource group
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiCenter/services</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Services_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-07-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiCenterServiceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ApiCenterServiceResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ApiCenterServiceResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _apiCenterServiceServicesRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _apiCenterServiceServicesRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ApiCenterServiceResource(Client, ApiCenterServiceData.DeserializeApiCenterServiceData(e)), _apiCenterServiceServicesClientDiagnostics, Pipeline, "ApiCenterServiceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists services within a resource group
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiCenter/services</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Services_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-07-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiCenterServiceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ApiCenterServiceResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ApiCenterServiceResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _apiCenterServiceServicesRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _apiCenterServiceServicesRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ApiCenterServiceResource(Client, ApiCenterServiceData.DeserializeApiCenterServiceData(e)), _apiCenterServiceServicesClientDiagnostics, Pipeline, "ApiCenterServiceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiCenter/services/{serviceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Services_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-07-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiCenterServiceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="serviceName"> Service name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serviceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string serviceName, CancellationToken cancellationToken = default)
        {
            if (serviceName == null)
            {
                throw new ArgumentNullException(nameof(serviceName));
            }
            if (serviceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(serviceName));
            }

            using var scope = _apiCenterServiceServicesClientDiagnostics.CreateScope("ApiCenterServiceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _apiCenterServiceServicesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, serviceName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiCenter/services/{serviceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Services_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-07-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiCenterServiceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="serviceName"> Service name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serviceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceName"/> is null. </exception>
        public virtual Response<bool> Exists(string serviceName, CancellationToken cancellationToken = default)
        {
            if (serviceName == null)
            {
                throw new ArgumentNullException(nameof(serviceName));
            }
            if (serviceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(serviceName));
            }

            using var scope = _apiCenterServiceServicesClientDiagnostics.CreateScope("ApiCenterServiceCollection.Exists");
            scope.Start();
            try
            {
                var response = _apiCenterServiceServicesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, serviceName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiCenter/services/{serviceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Services_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-07-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiCenterServiceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="serviceName"> Service name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serviceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceName"/> is null. </exception>
        public virtual async Task<NullableResponse<ApiCenterServiceResource>> GetIfExistsAsync(string serviceName, CancellationToken cancellationToken = default)
        {
            if (serviceName == null)
            {
                throw new ArgumentNullException(nameof(serviceName));
            }
            if (serviceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(serviceName));
            }

            using var scope = _apiCenterServiceServicesClientDiagnostics.CreateScope("ApiCenterServiceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _apiCenterServiceServicesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, serviceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ApiCenterServiceResource>(response.GetRawResponse());
                return Response.FromValue(new ApiCenterServiceResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiCenter/services/{serviceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Services_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-07-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiCenterServiceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="serviceName"> Service name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serviceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceName"/> is null. </exception>
        public virtual NullableResponse<ApiCenterServiceResource> GetIfExists(string serviceName, CancellationToken cancellationToken = default)
        {
            if (serviceName == null)
            {
                throw new ArgumentNullException(nameof(serviceName));
            }
            if (serviceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(serviceName));
            }

            using var scope = _apiCenterServiceServicesClientDiagnostics.CreateScope("ApiCenterServiceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _apiCenterServiceServicesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, serviceName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ApiCenterServiceResource>(response.GetRawResponse());
                return Response.FromValue(new ApiCenterServiceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ApiCenterServiceResource> IEnumerable<ApiCenterServiceResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ApiCenterServiceResource> IAsyncEnumerable<ApiCenterServiceResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
