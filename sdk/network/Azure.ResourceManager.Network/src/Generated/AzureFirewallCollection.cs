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
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing collection of AzureFirewall and their operations over its parent. </summary>
    public partial class AzureFirewallCollection : ArmCollection, IEnumerable<AzureFirewall>, IAsyncEnumerable<AzureFirewall>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly AzureFirewallsRestOperations _azureFirewallsRestClient;

        /// <summary> Initializes a new instance of the <see cref="AzureFirewallCollection"/> class for mocking. </summary>
        protected AzureFirewallCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AzureFirewallCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal AzureFirewallCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _azureFirewallsRestClient = new AzureFirewallsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroup.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroup.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// <summary> Creates or updates the specified Azure Firewall. </summary>
        /// <param name="azureFirewallName"> The name of the Azure Firewall. </param>
        /// <param name="parameters"> Parameters supplied to the create or update Azure Firewall operation. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="azureFirewallName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual AzureFirewallCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string azureFirewallName, AzureFirewallData parameters, CancellationToken cancellationToken = default)
        {
            if (azureFirewallName == null)
            {
                throw new ArgumentNullException(nameof(azureFirewallName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("AzureFirewallCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _azureFirewallsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, azureFirewallName, parameters, cancellationToken);
                var operation = new AzureFirewallCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _azureFirewallsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, azureFirewallName, parameters).Request, response);
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

        /// <summary> Creates or updates the specified Azure Firewall. </summary>
        /// <param name="azureFirewallName"> The name of the Azure Firewall. </param>
        /// <param name="parameters"> Parameters supplied to the create or update Azure Firewall operation. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="azureFirewallName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<AzureFirewallCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string azureFirewallName, AzureFirewallData parameters, CancellationToken cancellationToken = default)
        {
            if (azureFirewallName == null)
            {
                throw new ArgumentNullException(nameof(azureFirewallName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("AzureFirewallCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _azureFirewallsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, azureFirewallName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new AzureFirewallCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _azureFirewallsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, azureFirewallName, parameters).Request, response);
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

        /// <summary> Gets the specified Azure Firewall. </summary>
        /// <param name="azureFirewallName"> The name of the Azure Firewall. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="azureFirewallName"/> is null. </exception>
        public virtual Response<AzureFirewall> Get(string azureFirewallName, CancellationToken cancellationToken = default)
        {
            if (azureFirewallName == null)
            {
                throw new ArgumentNullException(nameof(azureFirewallName));
            }

            using var scope = _clientDiagnostics.CreateScope("AzureFirewallCollection.Get");
            scope.Start();
            try
            {
                var response = _azureFirewallsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, azureFirewallName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AzureFirewall(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the specified Azure Firewall. </summary>
        /// <param name="azureFirewallName"> The name of the Azure Firewall. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="azureFirewallName"/> is null. </exception>
        public async virtual Task<Response<AzureFirewall>> GetAsync(string azureFirewallName, CancellationToken cancellationToken = default)
        {
            if (azureFirewallName == null)
            {
                throw new ArgumentNullException(nameof(azureFirewallName));
            }

            using var scope = _clientDiagnostics.CreateScope("AzureFirewallCollection.Get");
            scope.Start();
            try
            {
                var response = await _azureFirewallsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, azureFirewallName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new AzureFirewall(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="azureFirewallName"> The name of the Azure Firewall. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="azureFirewallName"/> is null. </exception>
        public virtual Response<AzureFirewall> GetIfExists(string azureFirewallName, CancellationToken cancellationToken = default)
        {
            if (azureFirewallName == null)
            {
                throw new ArgumentNullException(nameof(azureFirewallName));
            }

            using var scope = _clientDiagnostics.CreateScope("AzureFirewallCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _azureFirewallsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, azureFirewallName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<AzureFirewall>(null, response.GetRawResponse());
                return Response.FromValue(new AzureFirewall(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="azureFirewallName"> The name of the Azure Firewall. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="azureFirewallName"/> is null. </exception>
        public async virtual Task<Response<AzureFirewall>> GetIfExistsAsync(string azureFirewallName, CancellationToken cancellationToken = default)
        {
            if (azureFirewallName == null)
            {
                throw new ArgumentNullException(nameof(azureFirewallName));
            }

            using var scope = _clientDiagnostics.CreateScope("AzureFirewallCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _azureFirewallsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, azureFirewallName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<AzureFirewall>(null, response.GetRawResponse());
                return Response.FromValue(new AzureFirewall(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="azureFirewallName"> The name of the Azure Firewall. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="azureFirewallName"/> is null. </exception>
        public virtual Response<bool> Exists(string azureFirewallName, CancellationToken cancellationToken = default)
        {
            if (azureFirewallName == null)
            {
                throw new ArgumentNullException(nameof(azureFirewallName));
            }

            using var scope = _clientDiagnostics.CreateScope("AzureFirewallCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(azureFirewallName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="azureFirewallName"> The name of the Azure Firewall. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="azureFirewallName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string azureFirewallName, CancellationToken cancellationToken = default)
        {
            if (azureFirewallName == null)
            {
                throw new ArgumentNullException(nameof(azureFirewallName));
            }

            using var scope = _clientDiagnostics.CreateScope("AzureFirewallCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(azureFirewallName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all Azure Firewalls in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AzureFirewall" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AzureFirewall> GetAll(CancellationToken cancellationToken = default)
        {
            Page<AzureFirewall> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("AzureFirewallCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _azureFirewallsRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new AzureFirewall(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<AzureFirewall> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("AzureFirewallCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _azureFirewallsRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new AzureFirewall(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists all Azure Firewalls in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AzureFirewall" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AzureFirewall> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<AzureFirewall>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("AzureFirewallCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _azureFirewallsRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new AzureFirewall(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<AzureFirewall>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("AzureFirewallCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _azureFirewallsRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new AzureFirewall(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="AzureFirewall" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AzureFirewallCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(AzureFirewall.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="AzureFirewall" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AzureFirewallCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(AzureFirewall.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<AzureFirewall> IEnumerable<AzureFirewall>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<AzureFirewall> IAsyncEnumerable<AzureFirewall>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, AzureFirewall, AzureFirewallData> Construct() { }
    }
}
