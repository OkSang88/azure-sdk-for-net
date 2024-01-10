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
using Azure.ResourceManager.Batch;
using Azure.ResourceManager.Batch.Models;

namespace Azure.ResourceManager.Batch.Mocking
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    public partial class MockableBatchSubscriptionResource : ArmResource
    {
        private ClientDiagnostics _batchAccountClientDiagnostics;
        private BatchAccountRestOperations _batchAccountRestClient;
        private ClientDiagnostics _locationClientDiagnostics;
        private LocationRestOperations _locationRestClient;

        /// <summary> Initializes a new instance of the <see cref="MockableBatchSubscriptionResource"/> class for mocking. </summary>
        protected MockableBatchSubscriptionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableBatchSubscriptionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableBatchSubscriptionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics BatchAccountClientDiagnostics => _batchAccountClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Batch", BatchAccountResource.ResourceType.Namespace, Diagnostics);
        private BatchAccountRestOperations BatchAccountRestClient => _batchAccountRestClient ??= new BatchAccountRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(BatchAccountResource.ResourceType));
        private ClientDiagnostics LocationClientDiagnostics => _locationClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Batch", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private LocationRestOperations LocationRestClient => _locationRestClient ??= new LocationRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Gets information about the Batch accounts associated with the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Batch/batchAccounts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BatchAccount_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BatchAccountResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="BatchAccountResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<BatchAccountResource> GetBatchAccountsAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => BatchAccountRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => BatchAccountRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new BatchAccountResource(Client, BatchAccountData.DeserializeBatchAccountData(e)), BatchAccountClientDiagnostics, Pipeline, "MockableBatchSubscriptionResource.GetBatchAccounts", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets information about the Batch accounts associated with the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Batch/batchAccounts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BatchAccount_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BatchAccountResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="BatchAccountResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<BatchAccountResource> GetBatchAccounts(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => BatchAccountRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => BatchAccountRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new BatchAccountResource(Client, BatchAccountData.DeserializeBatchAccountData(e)), BatchAccountClientDiagnostics, Pipeline, "MockableBatchSubscriptionResource.GetBatchAccounts", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets the Batch service quotas for the specified subscription at the given location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Batch/locations/{locationName}/quotas</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Location_GetQuotas</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="locationName"> The region for which to retrieve Batch service quotas. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<BatchLocationQuota>> GetBatchQuotasAsync(AzureLocation locationName, CancellationToken cancellationToken = default)
        {
            using var scope = LocationClientDiagnostics.CreateScope("MockableBatchSubscriptionResource.GetBatchQuotas");
            scope.Start();
            try
            {
                var response = await LocationRestClient.GetQuotasAsync(Id.SubscriptionId, locationName, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the Batch service quotas for the specified subscription at the given location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Batch/locations/{locationName}/quotas</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Location_GetQuotas</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="locationName"> The region for which to retrieve Batch service quotas. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<BatchLocationQuota> GetBatchQuotas(AzureLocation locationName, CancellationToken cancellationToken = default)
        {
            using var scope = LocationClientDiagnostics.CreateScope("MockableBatchSubscriptionResource.GetBatchQuotas");
            scope.Start();
            try
            {
                var response = LocationRestClient.GetQuotas(Id.SubscriptionId, locationName, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the list of Batch supported Virtual Machine VM sizes available at the given location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Batch/locations/{locationName}/virtualMachineSkus</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Location_ListSupportedVirtualMachineSkus</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="locationName"> The region for which to retrieve Batch service supported SKUs. </param>
        /// <param name="maxresults"> The maximum number of items to return in the response. </param>
        /// <param name="filter"> OData filter expression. Valid properties for filtering are "familyName". </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="BatchSupportedSku"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<BatchSupportedSku> GetBatchSupportedVirtualMachineSkusAsync(AzureLocation locationName, int? maxresults = null, string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => LocationRestClient.CreateListSupportedVirtualMachineSkusRequest(Id.SubscriptionId, locationName, maxresults, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => LocationRestClient.CreateListSupportedVirtualMachineSkusNextPageRequest(nextLink, Id.SubscriptionId, locationName, maxresults, filter);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, BatchSupportedSku.DeserializeBatchSupportedSku, LocationClientDiagnostics, Pipeline, "MockableBatchSubscriptionResource.GetBatchSupportedVirtualMachineSkus", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets the list of Batch supported Virtual Machine VM sizes available at the given location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Batch/locations/{locationName}/virtualMachineSkus</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Location_ListSupportedVirtualMachineSkus</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="locationName"> The region for which to retrieve Batch service supported SKUs. </param>
        /// <param name="maxresults"> The maximum number of items to return in the response. </param>
        /// <param name="filter"> OData filter expression. Valid properties for filtering are "familyName". </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="BatchSupportedSku"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<BatchSupportedSku> GetBatchSupportedVirtualMachineSkus(AzureLocation locationName, int? maxresults = null, string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => LocationRestClient.CreateListSupportedVirtualMachineSkusRequest(Id.SubscriptionId, locationName, maxresults, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => LocationRestClient.CreateListSupportedVirtualMachineSkusNextPageRequest(nextLink, Id.SubscriptionId, locationName, maxresults, filter);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, BatchSupportedSku.DeserializeBatchSupportedSku, LocationClientDiagnostics, Pipeline, "MockableBatchSubscriptionResource.GetBatchSupportedVirtualMachineSkus", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets the list of Batch supported Cloud Service VM sizes available at the given location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Batch/locations/{locationName}/cloudServiceSkus</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Location_ListSupportedCloudServiceSkus</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="locationName"> The region for which to retrieve Batch service supported SKUs. </param>
        /// <param name="maxresults"> The maximum number of items to return in the response. </param>
        /// <param name="filter"> OData filter expression. Valid properties for filtering are "familyName". </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="BatchSupportedSku"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<BatchSupportedSku> GetBatchSupportedCloudServiceSkusAsync(AzureLocation locationName, int? maxresults = null, string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => LocationRestClient.CreateListSupportedCloudServiceSkusRequest(Id.SubscriptionId, locationName, maxresults, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => LocationRestClient.CreateListSupportedCloudServiceSkusNextPageRequest(nextLink, Id.SubscriptionId, locationName, maxresults, filter);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, BatchSupportedSku.DeserializeBatchSupportedSku, LocationClientDiagnostics, Pipeline, "MockableBatchSubscriptionResource.GetBatchSupportedCloudServiceSkus", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets the list of Batch supported Cloud Service VM sizes available at the given location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Batch/locations/{locationName}/cloudServiceSkus</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Location_ListSupportedCloudServiceSkus</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="locationName"> The region for which to retrieve Batch service supported SKUs. </param>
        /// <param name="maxresults"> The maximum number of items to return in the response. </param>
        /// <param name="filter"> OData filter expression. Valid properties for filtering are "familyName". </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="BatchSupportedSku"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<BatchSupportedSku> GetBatchSupportedCloudServiceSkus(AzureLocation locationName, int? maxresults = null, string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => LocationRestClient.CreateListSupportedCloudServiceSkusRequest(Id.SubscriptionId, locationName, maxresults, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => LocationRestClient.CreateListSupportedCloudServiceSkusNextPageRequest(nextLink, Id.SubscriptionId, locationName, maxresults, filter);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, BatchSupportedSku.DeserializeBatchSupportedSku, LocationClientDiagnostics, Pipeline, "MockableBatchSubscriptionResource.GetBatchSupportedCloudServiceSkus", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks whether the Batch account name is available in the specified region.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Batch/locations/{locationName}/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Location_CheckNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="locationName"> The desired region for the name check. </param>
        /// <param name="content"> Properties needed to check the availability of a name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual async Task<Response<BatchNameAvailabilityResult>> CheckBatchNameAvailabilityAsync(AzureLocation locationName, BatchNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = LocationClientDiagnostics.CreateScope("MockableBatchSubscriptionResource.CheckBatchNameAvailability");
            scope.Start();
            try
            {
                var response = await LocationRestClient.CheckNameAvailabilityAsync(Id.SubscriptionId, locationName, content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks whether the Batch account name is available in the specified region.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Batch/locations/{locationName}/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Location_CheckNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="locationName"> The desired region for the name check. </param>
        /// <param name="content"> Properties needed to check the availability of a name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual Response<BatchNameAvailabilityResult> CheckBatchNameAvailability(AzureLocation locationName, BatchNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = LocationClientDiagnostics.CreateScope("MockableBatchSubscriptionResource.CheckBatchNameAvailability");
            scope.Start();
            try
            {
                var response = LocationRestClient.CheckNameAvailability(Id.SubscriptionId, locationName, content, cancellationToken);
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
