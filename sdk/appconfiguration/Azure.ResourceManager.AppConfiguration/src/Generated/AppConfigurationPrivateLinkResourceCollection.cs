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

namespace Azure.ResourceManager.AppConfiguration
{
    /// <summary>
    /// A class representing a collection of <see cref="AppConfigurationPrivateLinkResource"/> and their operations.
    /// Each <see cref="AppConfigurationPrivateLinkResource"/> in the collection will belong to the same instance of <see cref="AppConfigurationStoreResource"/>.
    /// To get an <see cref="AppConfigurationPrivateLinkResourceCollection"/> instance call the GetAppConfigurationPrivateLinkResources method from an instance of <see cref="AppConfigurationStoreResource"/>.
    /// </summary>
    public partial class AppConfigurationPrivateLinkResourceCollection : ArmCollection, IEnumerable<AppConfigurationPrivateLinkResource>, IAsyncEnumerable<AppConfigurationPrivateLinkResource>
    {
        private readonly ClientDiagnostics _appConfigurationPrivateLinkResourcePrivateLinkResourcesClientDiagnostics;
        private readonly PrivateLinkResourcesRestOperations _appConfigurationPrivateLinkResourcePrivateLinkResourcesRestClient;

        /// <summary> Initializes a new instance of the <see cref="AppConfigurationPrivateLinkResourceCollection"/> class for mocking. </summary>
        protected AppConfigurationPrivateLinkResourceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AppConfigurationPrivateLinkResourceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal AppConfigurationPrivateLinkResourceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _appConfigurationPrivateLinkResourcePrivateLinkResourcesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppConfiguration", AppConfigurationPrivateLinkResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(AppConfigurationPrivateLinkResource.ResourceType, out string appConfigurationPrivateLinkResourcePrivateLinkResourcesApiVersion);
            _appConfigurationPrivateLinkResourcePrivateLinkResourcesRestClient = new PrivateLinkResourcesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, appConfigurationPrivateLinkResourcePrivateLinkResourcesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != AppConfigurationStoreResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, AppConfigurationStoreResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets a private link resource that need to be created for a configuration store.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppConfiguration/configurationStores/{configStoreName}/privateLinkResources/{groupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkResources_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppConfigurationPrivateLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="groupName"> The name of the private link resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="groupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="groupName"/> is null. </exception>
        public virtual async Task<Response<AppConfigurationPrivateLinkResource>> GetAsync(string groupName, CancellationToken cancellationToken = default)
        {
            if (groupName == null)
            {
                throw new ArgumentNullException(nameof(groupName));
            }
            if (groupName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(groupName));
            }

            using var scope = _appConfigurationPrivateLinkResourcePrivateLinkResourcesClientDiagnostics.CreateScope("AppConfigurationPrivateLinkResourceCollection.Get");
            scope.Start();
            try
            {
                var response = await _appConfigurationPrivateLinkResourcePrivateLinkResourcesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, groupName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AppConfigurationPrivateLinkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a private link resource that need to be created for a configuration store.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppConfiguration/configurationStores/{configStoreName}/privateLinkResources/{groupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkResources_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppConfigurationPrivateLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="groupName"> The name of the private link resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="groupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="groupName"/> is null. </exception>
        public virtual Response<AppConfigurationPrivateLinkResource> Get(string groupName, CancellationToken cancellationToken = default)
        {
            if (groupName == null)
            {
                throw new ArgumentNullException(nameof(groupName));
            }
            if (groupName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(groupName));
            }

            using var scope = _appConfigurationPrivateLinkResourcePrivateLinkResourcesClientDiagnostics.CreateScope("AppConfigurationPrivateLinkResourceCollection.Get");
            scope.Start();
            try
            {
                var response = _appConfigurationPrivateLinkResourcePrivateLinkResourcesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, groupName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AppConfigurationPrivateLinkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the private link resources that need to be created for a configuration store.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppConfiguration/configurationStores/{configStoreName}/privateLinkResources</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkResources_ListByConfigurationStore</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppConfigurationPrivateLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AppConfigurationPrivateLinkResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AppConfigurationPrivateLinkResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _appConfigurationPrivateLinkResourcePrivateLinkResourcesRestClient.CreateListByConfigurationStoreRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _appConfigurationPrivateLinkResourcePrivateLinkResourcesRestClient.CreateListByConfigurationStoreNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new AppConfigurationPrivateLinkResource(Client, AppConfigurationPrivateLinkResourceData.DeserializeAppConfigurationPrivateLinkResourceData(e)), _appConfigurationPrivateLinkResourcePrivateLinkResourcesClientDiagnostics, Pipeline, "AppConfigurationPrivateLinkResourceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets the private link resources that need to be created for a configuration store.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppConfiguration/configurationStores/{configStoreName}/privateLinkResources</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkResources_ListByConfigurationStore</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppConfigurationPrivateLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AppConfigurationPrivateLinkResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AppConfigurationPrivateLinkResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _appConfigurationPrivateLinkResourcePrivateLinkResourcesRestClient.CreateListByConfigurationStoreRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _appConfigurationPrivateLinkResourcePrivateLinkResourcesRestClient.CreateListByConfigurationStoreNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new AppConfigurationPrivateLinkResource(Client, AppConfigurationPrivateLinkResourceData.DeserializeAppConfigurationPrivateLinkResourceData(e)), _appConfigurationPrivateLinkResourcePrivateLinkResourcesClientDiagnostics, Pipeline, "AppConfigurationPrivateLinkResourceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppConfiguration/configurationStores/{configStoreName}/privateLinkResources/{groupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkResources_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppConfigurationPrivateLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="groupName"> The name of the private link resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="groupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="groupName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string groupName, CancellationToken cancellationToken = default)
        {
            if (groupName == null)
            {
                throw new ArgumentNullException(nameof(groupName));
            }
            if (groupName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(groupName));
            }

            using var scope = _appConfigurationPrivateLinkResourcePrivateLinkResourcesClientDiagnostics.CreateScope("AppConfigurationPrivateLinkResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _appConfigurationPrivateLinkResourcePrivateLinkResourcesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, groupName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppConfiguration/configurationStores/{configStoreName}/privateLinkResources/{groupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkResources_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppConfigurationPrivateLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="groupName"> The name of the private link resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="groupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="groupName"/> is null. </exception>
        public virtual Response<bool> Exists(string groupName, CancellationToken cancellationToken = default)
        {
            if (groupName == null)
            {
                throw new ArgumentNullException(nameof(groupName));
            }
            if (groupName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(groupName));
            }

            using var scope = _appConfigurationPrivateLinkResourcePrivateLinkResourcesClientDiagnostics.CreateScope("AppConfigurationPrivateLinkResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = _appConfigurationPrivateLinkResourcePrivateLinkResourcesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, groupName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppConfiguration/configurationStores/{configStoreName}/privateLinkResources/{groupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkResources_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppConfigurationPrivateLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="groupName"> The name of the private link resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="groupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="groupName"/> is null. </exception>
        public virtual async Task<NullableResponse<AppConfigurationPrivateLinkResource>> GetIfExistsAsync(string groupName, CancellationToken cancellationToken = default)
        {
            if (groupName == null)
            {
                throw new ArgumentNullException(nameof(groupName));
            }
            if (groupName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(groupName));
            }

            using var scope = _appConfigurationPrivateLinkResourcePrivateLinkResourcesClientDiagnostics.CreateScope("AppConfigurationPrivateLinkResourceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _appConfigurationPrivateLinkResourcePrivateLinkResourcesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, groupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<AppConfigurationPrivateLinkResource>(response.GetRawResponse());
                return Response.FromValue(new AppConfigurationPrivateLinkResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppConfiguration/configurationStores/{configStoreName}/privateLinkResources/{groupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkResources_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppConfigurationPrivateLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="groupName"> The name of the private link resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="groupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="groupName"/> is null. </exception>
        public virtual NullableResponse<AppConfigurationPrivateLinkResource> GetIfExists(string groupName, CancellationToken cancellationToken = default)
        {
            if (groupName == null)
            {
                throw new ArgumentNullException(nameof(groupName));
            }
            if (groupName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(groupName));
            }

            using var scope = _appConfigurationPrivateLinkResourcePrivateLinkResourcesClientDiagnostics.CreateScope("AppConfigurationPrivateLinkResourceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _appConfigurationPrivateLinkResourcePrivateLinkResourcesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, groupName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<AppConfigurationPrivateLinkResource>(response.GetRawResponse());
                return Response.FromValue(new AppConfigurationPrivateLinkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<AppConfigurationPrivateLinkResource> IEnumerable<AppConfigurationPrivateLinkResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<AppConfigurationPrivateLinkResource> IAsyncEnumerable<AppConfigurationPrivateLinkResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
