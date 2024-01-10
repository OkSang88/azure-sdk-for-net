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

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing a collection of <see cref="ServiceEndpointPolicyDefinitionResource"/> and their operations.
    /// Each <see cref="ServiceEndpointPolicyDefinitionResource"/> in the collection will belong to the same instance of <see cref="ServiceEndpointPolicyResource"/>.
    /// To get a <see cref="ServiceEndpointPolicyDefinitionCollection"/> instance call the GetServiceEndpointPolicyDefinitions method from an instance of <see cref="ServiceEndpointPolicyResource"/>.
    /// </summary>
    public partial class ServiceEndpointPolicyDefinitionCollection : ArmCollection, IEnumerable<ServiceEndpointPolicyDefinitionResource>, IAsyncEnumerable<ServiceEndpointPolicyDefinitionResource>
    {
        private readonly ClientDiagnostics _serviceEndpointPolicyDefinitionClientDiagnostics;
        private readonly ServiceEndpointPolicyDefinitionsRestOperations _serviceEndpointPolicyDefinitionRestClient;

        /// <summary> Initializes a new instance of the <see cref="ServiceEndpointPolicyDefinitionCollection"/> class for mocking. </summary>
        protected ServiceEndpointPolicyDefinitionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ServiceEndpointPolicyDefinitionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ServiceEndpointPolicyDefinitionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _serviceEndpointPolicyDefinitionClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", ServiceEndpointPolicyDefinitionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ServiceEndpointPolicyDefinitionResource.ResourceType, out string serviceEndpointPolicyDefinitionApiVersion);
            _serviceEndpointPolicyDefinitionRestClient = new ServiceEndpointPolicyDefinitionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, serviceEndpointPolicyDefinitionApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ServiceEndpointPolicyResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ServiceEndpointPolicyResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a service endpoint policy definition in the specified service endpoint policy.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/serviceEndpointPolicies/{serviceEndpointPolicyName}/serviceEndpointPolicyDefinitions/{serviceEndpointPolicyDefinitionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServiceEndpointPolicyDefinitions_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceEndpointPolicyDefinitionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="serviceEndpointPolicyDefinitionName"> The name of the service endpoint policy definition name. </param>
        /// <param name="data"> Parameters supplied to the create or update service endpoint policy operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serviceEndpointPolicyDefinitionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceEndpointPolicyDefinitionName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ServiceEndpointPolicyDefinitionResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string serviceEndpointPolicyDefinitionName, ServiceEndpointPolicyDefinitionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serviceEndpointPolicyDefinitionName, nameof(serviceEndpointPolicyDefinitionName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _serviceEndpointPolicyDefinitionClientDiagnostics.CreateScope("ServiceEndpointPolicyDefinitionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _serviceEndpointPolicyDefinitionRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, serviceEndpointPolicyDefinitionName, data, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation<ServiceEndpointPolicyDefinitionResource>(new ServiceEndpointPolicyDefinitionOperationSource(Client), _serviceEndpointPolicyDefinitionClientDiagnostics, Pipeline, _serviceEndpointPolicyDefinitionRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, serviceEndpointPolicyDefinitionName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates or updates a service endpoint policy definition in the specified service endpoint policy.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/serviceEndpointPolicies/{serviceEndpointPolicyName}/serviceEndpointPolicyDefinitions/{serviceEndpointPolicyDefinitionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServiceEndpointPolicyDefinitions_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceEndpointPolicyDefinitionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="serviceEndpointPolicyDefinitionName"> The name of the service endpoint policy definition name. </param>
        /// <param name="data"> Parameters supplied to the create or update service endpoint policy operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serviceEndpointPolicyDefinitionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceEndpointPolicyDefinitionName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ServiceEndpointPolicyDefinitionResource> CreateOrUpdate(WaitUntil waitUntil, string serviceEndpointPolicyDefinitionName, ServiceEndpointPolicyDefinitionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serviceEndpointPolicyDefinitionName, nameof(serviceEndpointPolicyDefinitionName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _serviceEndpointPolicyDefinitionClientDiagnostics.CreateScope("ServiceEndpointPolicyDefinitionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _serviceEndpointPolicyDefinitionRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, serviceEndpointPolicyDefinitionName, data, cancellationToken);
                var operation = new NetworkArmOperation<ServiceEndpointPolicyDefinitionResource>(new ServiceEndpointPolicyDefinitionOperationSource(Client), _serviceEndpointPolicyDefinitionClientDiagnostics, Pipeline, _serviceEndpointPolicyDefinitionRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, serviceEndpointPolicyDefinitionName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Get the specified service endpoint policy definitions from service endpoint policy.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/serviceEndpointPolicies/{serviceEndpointPolicyName}/serviceEndpointPolicyDefinitions/{serviceEndpointPolicyDefinitionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServiceEndpointPolicyDefinitions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceEndpointPolicyDefinitionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="serviceEndpointPolicyDefinitionName"> The name of the service endpoint policy definition name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serviceEndpointPolicyDefinitionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceEndpointPolicyDefinitionName"/> is null. </exception>
        public virtual async Task<Response<ServiceEndpointPolicyDefinitionResource>> GetAsync(string serviceEndpointPolicyDefinitionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serviceEndpointPolicyDefinitionName, nameof(serviceEndpointPolicyDefinitionName));

            using var scope = _serviceEndpointPolicyDefinitionClientDiagnostics.CreateScope("ServiceEndpointPolicyDefinitionCollection.Get");
            scope.Start();
            try
            {
                var response = await _serviceEndpointPolicyDefinitionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, serviceEndpointPolicyDefinitionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServiceEndpointPolicyDefinitionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the specified service endpoint policy definitions from service endpoint policy.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/serviceEndpointPolicies/{serviceEndpointPolicyName}/serviceEndpointPolicyDefinitions/{serviceEndpointPolicyDefinitionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServiceEndpointPolicyDefinitions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceEndpointPolicyDefinitionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="serviceEndpointPolicyDefinitionName"> The name of the service endpoint policy definition name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serviceEndpointPolicyDefinitionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceEndpointPolicyDefinitionName"/> is null. </exception>
        public virtual Response<ServiceEndpointPolicyDefinitionResource> Get(string serviceEndpointPolicyDefinitionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serviceEndpointPolicyDefinitionName, nameof(serviceEndpointPolicyDefinitionName));

            using var scope = _serviceEndpointPolicyDefinitionClientDiagnostics.CreateScope("ServiceEndpointPolicyDefinitionCollection.Get");
            scope.Start();
            try
            {
                var response = _serviceEndpointPolicyDefinitionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, serviceEndpointPolicyDefinitionName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServiceEndpointPolicyDefinitionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all service endpoint policy definitions in a service end point policy.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/serviceEndpointPolicies/{serviceEndpointPolicyName}/serviceEndpointPolicyDefinitions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServiceEndpointPolicyDefinitions_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceEndpointPolicyDefinitionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ServiceEndpointPolicyDefinitionResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ServiceEndpointPolicyDefinitionResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _serviceEndpointPolicyDefinitionRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _serviceEndpointPolicyDefinitionRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ServiceEndpointPolicyDefinitionResource(Client, ServiceEndpointPolicyDefinitionData.DeserializeServiceEndpointPolicyDefinitionData(e)), _serviceEndpointPolicyDefinitionClientDiagnostics, Pipeline, "ServiceEndpointPolicyDefinitionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets all service endpoint policy definitions in a service end point policy.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/serviceEndpointPolicies/{serviceEndpointPolicyName}/serviceEndpointPolicyDefinitions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServiceEndpointPolicyDefinitions_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceEndpointPolicyDefinitionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ServiceEndpointPolicyDefinitionResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ServiceEndpointPolicyDefinitionResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _serviceEndpointPolicyDefinitionRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _serviceEndpointPolicyDefinitionRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ServiceEndpointPolicyDefinitionResource(Client, ServiceEndpointPolicyDefinitionData.DeserializeServiceEndpointPolicyDefinitionData(e)), _serviceEndpointPolicyDefinitionClientDiagnostics, Pipeline, "ServiceEndpointPolicyDefinitionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/serviceEndpointPolicies/{serviceEndpointPolicyName}/serviceEndpointPolicyDefinitions/{serviceEndpointPolicyDefinitionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServiceEndpointPolicyDefinitions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceEndpointPolicyDefinitionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="serviceEndpointPolicyDefinitionName"> The name of the service endpoint policy definition name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serviceEndpointPolicyDefinitionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceEndpointPolicyDefinitionName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string serviceEndpointPolicyDefinitionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serviceEndpointPolicyDefinitionName, nameof(serviceEndpointPolicyDefinitionName));

            using var scope = _serviceEndpointPolicyDefinitionClientDiagnostics.CreateScope("ServiceEndpointPolicyDefinitionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _serviceEndpointPolicyDefinitionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, serviceEndpointPolicyDefinitionName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/serviceEndpointPolicies/{serviceEndpointPolicyName}/serviceEndpointPolicyDefinitions/{serviceEndpointPolicyDefinitionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServiceEndpointPolicyDefinitions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceEndpointPolicyDefinitionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="serviceEndpointPolicyDefinitionName"> The name of the service endpoint policy definition name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serviceEndpointPolicyDefinitionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceEndpointPolicyDefinitionName"/> is null. </exception>
        public virtual Response<bool> Exists(string serviceEndpointPolicyDefinitionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serviceEndpointPolicyDefinitionName, nameof(serviceEndpointPolicyDefinitionName));

            using var scope = _serviceEndpointPolicyDefinitionClientDiagnostics.CreateScope("ServiceEndpointPolicyDefinitionCollection.Exists");
            scope.Start();
            try
            {
                var response = _serviceEndpointPolicyDefinitionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, serviceEndpointPolicyDefinitionName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/serviceEndpointPolicies/{serviceEndpointPolicyName}/serviceEndpointPolicyDefinitions/{serviceEndpointPolicyDefinitionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServiceEndpointPolicyDefinitions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceEndpointPolicyDefinitionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="serviceEndpointPolicyDefinitionName"> The name of the service endpoint policy definition name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serviceEndpointPolicyDefinitionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceEndpointPolicyDefinitionName"/> is null. </exception>
        public virtual async Task<NullableResponse<ServiceEndpointPolicyDefinitionResource>> GetIfExistsAsync(string serviceEndpointPolicyDefinitionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serviceEndpointPolicyDefinitionName, nameof(serviceEndpointPolicyDefinitionName));

            using var scope = _serviceEndpointPolicyDefinitionClientDiagnostics.CreateScope("ServiceEndpointPolicyDefinitionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _serviceEndpointPolicyDefinitionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, serviceEndpointPolicyDefinitionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ServiceEndpointPolicyDefinitionResource>(response.GetRawResponse());
                return Response.FromValue(new ServiceEndpointPolicyDefinitionResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/serviceEndpointPolicies/{serviceEndpointPolicyName}/serviceEndpointPolicyDefinitions/{serviceEndpointPolicyDefinitionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServiceEndpointPolicyDefinitions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceEndpointPolicyDefinitionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="serviceEndpointPolicyDefinitionName"> The name of the service endpoint policy definition name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serviceEndpointPolicyDefinitionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceEndpointPolicyDefinitionName"/> is null. </exception>
        public virtual NullableResponse<ServiceEndpointPolicyDefinitionResource> GetIfExists(string serviceEndpointPolicyDefinitionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serviceEndpointPolicyDefinitionName, nameof(serviceEndpointPolicyDefinitionName));

            using var scope = _serviceEndpointPolicyDefinitionClientDiagnostics.CreateScope("ServiceEndpointPolicyDefinitionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _serviceEndpointPolicyDefinitionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, serviceEndpointPolicyDefinitionName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ServiceEndpointPolicyDefinitionResource>(response.GetRawResponse());
                return Response.FromValue(new ServiceEndpointPolicyDefinitionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ServiceEndpointPolicyDefinitionResource> IEnumerable<ServiceEndpointPolicyDefinitionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ServiceEndpointPolicyDefinitionResource> IAsyncEnumerable<ServiceEndpointPolicyDefinitionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
