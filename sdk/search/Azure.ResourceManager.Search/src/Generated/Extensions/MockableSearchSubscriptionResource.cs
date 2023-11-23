// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Search;
using Azure.ResourceManager.Search.Models;

namespace Azure.ResourceManager.Search.Mocking
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    public partial class MockableSearchSubscriptionResource : ArmResource
    {
        private ClientDiagnostics _searchServiceServicesClientDiagnostics;
        private ServicesRestOperations _searchServiceServicesRestClient;
        private ClientDiagnostics _usagesClientDiagnostics;
        private UsagesRestOperations _usagesRestClient;
        private ClientDiagnostics _defaultClientDiagnostics;
        private SearchManagementRestOperations _defaultRestClient;

        /// <summary> Initializes a new instance of the <see cref="MockableSearchSubscriptionResource"/> class for mocking. </summary>
        protected MockableSearchSubscriptionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableSearchSubscriptionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableSearchSubscriptionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics SearchServiceServicesClientDiagnostics => _searchServiceServicesClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Search", SearchServiceResource.ResourceType.Namespace, Diagnostics);
        private ServicesRestOperations SearchServiceServicesRestClient => _searchServiceServicesRestClient ??= new ServicesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(SearchServiceResource.ResourceType));
        private ClientDiagnostics UsagesClientDiagnostics => _usagesClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Search", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private UsagesRestOperations UsagesRestClient => _usagesRestClient ??= new UsagesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
        private ClientDiagnostics DefaultClientDiagnostics => _defaultClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Search", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private SearchManagementRestOperations DefaultRestClient => _defaultRestClient ??= new SearchManagementRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Gets a list of all Search services in the given subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Search/searchServices</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Services_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="searchManagementRequestOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SearchServiceResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SearchServiceResource> GetSearchServicesAsync(SearchManagementRequestOptions searchManagementRequestOptions = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => SearchServiceServicesRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId, searchManagementRequestOptions);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => SearchServiceServicesRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId, searchManagementRequestOptions);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new SearchServiceResource(Client, SearchServiceData.DeserializeSearchServiceData(e)), SearchServiceServicesClientDiagnostics, Pipeline, "MockableSearchSubscriptionResource.GetSearchServices", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets a list of all Search services in the given subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Search/searchServices</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Services_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="searchManagementRequestOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SearchServiceResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SearchServiceResource> GetSearchServices(SearchManagementRequestOptions searchManagementRequestOptions = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => SearchServiceServicesRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId, searchManagementRequestOptions);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => SearchServiceServicesRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId, searchManagementRequestOptions);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new SearchServiceResource(Client, SearchServiceData.DeserializeSearchServiceData(e)), SearchServiceServicesClientDiagnostics, Pipeline, "MockableSearchSubscriptionResource.GetSearchServices", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks whether or not the given search service name is available for use. Search service names must be globally unique since they are part of the service URI (https://&lt;name&gt;.search.windows.net).
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Search/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Services_CheckNameAvailability</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The resource name and type to check. </param>
        /// <param name="searchManagementRequestOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual async Task<Response<SearchServiceNameAvailabilityResult>> CheckSearchServiceNameAvailabilityAsync(SearchServiceNameAvailabilityContent content, SearchManagementRequestOptions searchManagementRequestOptions = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = SearchServiceServicesClientDiagnostics.CreateScope("MockableSearchSubscriptionResource.CheckSearchServiceNameAvailability");
            scope.Start();
            try
            {
                var response = await SearchServiceServicesRestClient.CheckNameAvailabilityAsync(Id.SubscriptionId, content, searchManagementRequestOptions, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks whether or not the given search service name is available for use. Search service names must be globally unique since they are part of the service URI (https://&lt;name&gt;.search.windows.net).
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Search/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Services_CheckNameAvailability</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The resource name and type to check. </param>
        /// <param name="searchManagementRequestOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual Response<SearchServiceNameAvailabilityResult> CheckSearchServiceNameAvailability(SearchServiceNameAvailabilityContent content, SearchManagementRequestOptions searchManagementRequestOptions = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = SearchServiceServicesClientDiagnostics.CreateScope("MockableSearchSubscriptionResource.CheckSearchServiceNameAvailability");
            scope.Start();
            try
            {
                var response = SearchServiceServicesRestClient.CheckNameAvailability(Id.SubscriptionId, content, searchManagementRequestOptions, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a list of all Search quota usages in the given subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Search/locations/{location}/usages</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Usages_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The unique location name for a Microsoft Azure geographic region. </param>
        /// <param name="searchManagementRequestOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="QuotaUsageResult"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<QuotaUsageResult> GetUsagesBySubscriptionAsync(AzureLocation location, SearchManagementRequestOptions searchManagementRequestOptions = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => UsagesRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId, location, searchManagementRequestOptions);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => UsagesRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId, location, searchManagementRequestOptions);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, QuotaUsageResult.DeserializeQuotaUsageResult, UsagesClientDiagnostics, Pipeline, "MockableSearchSubscriptionResource.GetUsagesBySubscription", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets a list of all Search quota usages in the given subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Search/locations/{location}/usages</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Usages_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The unique location name for a Microsoft Azure geographic region. </param>
        /// <param name="searchManagementRequestOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="QuotaUsageResult"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<QuotaUsageResult> GetUsagesBySubscription(AzureLocation location, SearchManagementRequestOptions searchManagementRequestOptions = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => UsagesRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId, location, searchManagementRequestOptions);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => UsagesRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId, location, searchManagementRequestOptions);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, QuotaUsageResult.DeserializeQuotaUsageResult, UsagesClientDiagnostics, Pipeline, "MockableSearchSubscriptionResource.GetUsagesBySubscription", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets the quota usage for a search sku in the given subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Search/locations/{location}/usages/{skuName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>UsageBySubscriptionSku</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The unique location name for a Microsoft Azure geographic region. </param>
        /// <param name="skuName"> The unique search service sku name supported by Azure Cognitive Search. </param>
        /// <param name="searchManagementRequestOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="skuName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="skuName"/> is null. </exception>
        public virtual async Task<Response<QuotaUsageResult>> UsageBySubscriptionSkuAsync(AzureLocation location, string skuName, SearchManagementRequestOptions searchManagementRequestOptions = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(skuName, nameof(skuName));

            using var scope = DefaultClientDiagnostics.CreateScope("MockableSearchSubscriptionResource.UsageBySubscriptionSku");
            scope.Start();
            try
            {
                var response = await DefaultRestClient.UsageBySubscriptionSkuAsync(Id.SubscriptionId, location, skuName, searchManagementRequestOptions, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the quota usage for a search sku in the given subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Search/locations/{location}/usages/{skuName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>UsageBySubscriptionSku</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The unique location name for a Microsoft Azure geographic region. </param>
        /// <param name="skuName"> The unique search service sku name supported by Azure Cognitive Search. </param>
        /// <param name="searchManagementRequestOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="skuName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="skuName"/> is null. </exception>
        public virtual Response<QuotaUsageResult> UsageBySubscriptionSku(AzureLocation location, string skuName, SearchManagementRequestOptions searchManagementRequestOptions = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(skuName, nameof(skuName));

            using var scope = DefaultClientDiagnostics.CreateScope("MockableSearchSubscriptionResource.UsageBySubscriptionSku");
            scope.Start();
            try
            {
                var response = DefaultRestClient.UsageBySubscriptionSku(Id.SubscriptionId, location, skuName, searchManagementRequestOptions, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
