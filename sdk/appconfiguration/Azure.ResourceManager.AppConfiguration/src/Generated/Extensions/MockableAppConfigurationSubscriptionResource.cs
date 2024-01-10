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
using Azure.ResourceManager.AppConfiguration;
using Azure.ResourceManager.AppConfiguration.Models;

namespace Azure.ResourceManager.AppConfiguration.Mocking
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    public partial class MockableAppConfigurationSubscriptionResource : ArmResource
    {
        private ClientDiagnostics _appConfigurationStoreConfigurationStoresClientDiagnostics;
        private ConfigurationStoresRestOperations _appConfigurationStoreConfigurationStoresRestClient;
        private ClientDiagnostics _defaultClientDiagnostics;
        private AppConfigurationManagementRestOperations _defaultRestClient;

        /// <summary> Initializes a new instance of the <see cref="MockableAppConfigurationSubscriptionResource"/> class for mocking. </summary>
        protected MockableAppConfigurationSubscriptionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableAppConfigurationSubscriptionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableAppConfigurationSubscriptionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics AppConfigurationStoreConfigurationStoresClientDiagnostics => _appConfigurationStoreConfigurationStoresClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.AppConfiguration", AppConfigurationStoreResource.ResourceType.Namespace, Diagnostics);
        private ConfigurationStoresRestOperations AppConfigurationStoreConfigurationStoresRestClient => _appConfigurationStoreConfigurationStoresRestClient ??= new ConfigurationStoresRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(AppConfigurationStoreResource.ResourceType));
        private ClientDiagnostics DefaultClientDiagnostics => _defaultClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.AppConfiguration", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private AppConfigurationManagementRestOperations DefaultRestClient => _defaultRestClient ??= new AppConfigurationManagementRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of DeletedAppConfigurationStoreResources in the SubscriptionResource. </summary>
        /// <returns> An object representing collection of DeletedAppConfigurationStoreResources and their operations over a DeletedAppConfigurationStoreResource. </returns>
        public virtual DeletedAppConfigurationStoreCollection GetDeletedAppConfigurationStores()
        {
            return GetCachedClient(client => new DeletedAppConfigurationStoreCollection(client, Id));
        }

        /// <summary>
        /// Gets a deleted Azure app configuration store.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AppConfiguration/locations/{location}/deletedConfigurationStores/{configStoreName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConfigurationStores_GetDeleted</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DeletedAppConfigurationStoreResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The location in which uniqueness will be verified. </param>
        /// <param name="configStoreName"> The name of the configuration store. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="configStoreName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="configStoreName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<DeletedAppConfigurationStoreResource>> GetDeletedAppConfigurationStoreAsync(AzureLocation location, string configStoreName, CancellationToken cancellationToken = default)
        {
            return await GetDeletedAppConfigurationStores().GetAsync(location, configStoreName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets a deleted Azure app configuration store.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AppConfiguration/locations/{location}/deletedConfigurationStores/{configStoreName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConfigurationStores_GetDeleted</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DeletedAppConfigurationStoreResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The location in which uniqueness will be verified. </param>
        /// <param name="configStoreName"> The name of the configuration store. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="configStoreName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="configStoreName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<DeletedAppConfigurationStoreResource> GetDeletedAppConfigurationStore(AzureLocation location, string configStoreName, CancellationToken cancellationToken = default)
        {
            return GetDeletedAppConfigurationStores().Get(location, configStoreName, cancellationToken);
        }

        /// <summary>
        /// Lists the configuration stores for a given subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AppConfiguration/configurationStores</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConfigurationStores_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppConfigurationStoreResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="skipToken"> A skip token is used to continue retrieving items after an operation returns a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skipToken parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AppConfigurationStoreResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AppConfigurationStoreResource> GetAppConfigurationStoresAsync(string skipToken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => AppConfigurationStoreConfigurationStoresRestClient.CreateListRequest(Id.SubscriptionId, skipToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => AppConfigurationStoreConfigurationStoresRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, skipToken);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new AppConfigurationStoreResource(Client, AppConfigurationStoreData.DeserializeAppConfigurationStoreData(e)), AppConfigurationStoreConfigurationStoresClientDiagnostics, Pipeline, "MockableAppConfigurationSubscriptionResource.GetAppConfigurationStores", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists the configuration stores for a given subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AppConfiguration/configurationStores</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConfigurationStores_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppConfigurationStoreResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="skipToken"> A skip token is used to continue retrieving items after an operation returns a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skipToken parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AppConfigurationStoreResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AppConfigurationStoreResource> GetAppConfigurationStores(string skipToken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => AppConfigurationStoreConfigurationStoresRestClient.CreateListRequest(Id.SubscriptionId, skipToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => AppConfigurationStoreConfigurationStoresRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, skipToken);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new AppConfigurationStoreResource(Client, AppConfigurationStoreData.DeserializeAppConfigurationStoreData(e)), AppConfigurationStoreConfigurationStoresClientDiagnostics, Pipeline, "MockableAppConfigurationSubscriptionResource.GetAppConfigurationStores", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks whether the configuration store name is available for use.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AppConfiguration/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CheckAppConfigurationNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-05-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The object containing information for the availability request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual async Task<Response<AppConfigurationNameAvailabilityResult>> CheckAppConfigurationNameAvailabilityAsync(AppConfigurationNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = DefaultClientDiagnostics.CreateScope("MockableAppConfigurationSubscriptionResource.CheckAppConfigurationNameAvailability");
            scope.Start();
            try
            {
                var response = await DefaultRestClient.CheckAppConfigurationNameAvailabilityAsync(Id.SubscriptionId, content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks whether the configuration store name is available for use.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AppConfiguration/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CheckAppConfigurationNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-05-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The object containing information for the availability request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual Response<AppConfigurationNameAvailabilityResult> CheckAppConfigurationNameAvailability(AppConfigurationNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = DefaultClientDiagnostics.CreateScope("MockableAppConfigurationSubscriptionResource.CheckAppConfigurationNameAvailability");
            scope.Start();
            try
            {
                var response = DefaultRestClient.CheckAppConfigurationNameAvailability(Id.SubscriptionId, content, cancellationToken);
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
