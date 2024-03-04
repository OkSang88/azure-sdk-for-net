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
using Azure.ResourceManager.Compute.Models;

namespace Azure.ResourceManager.Compute
{
    /// <summary>
    /// A class representing a collection of <see cref="CloudServiceRoleInstanceResource"/> and their operations.
    /// Each <see cref="CloudServiceRoleInstanceResource"/> in the collection will belong to the same instance of <see cref="CloudServiceResource"/>.
    /// To get a <see cref="CloudServiceRoleInstanceCollection"/> instance call the GetCloudServiceRoleInstances method from an instance of <see cref="CloudServiceResource"/>.
    /// </summary>
    public partial class CloudServiceRoleInstanceCollection : ArmCollection, IEnumerable<CloudServiceRoleInstanceResource>, IAsyncEnumerable<CloudServiceRoleInstanceResource>
    {
        private readonly ClientDiagnostics _cloudServiceRoleInstanceClientDiagnostics;
        private readonly CloudServiceRoleInstancesRestOperations _cloudServiceRoleInstanceRestClient;

        /// <summary> Initializes a new instance of the <see cref="CloudServiceRoleInstanceCollection"/> class for mocking. </summary>
        protected CloudServiceRoleInstanceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="CloudServiceRoleInstanceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal CloudServiceRoleInstanceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _cloudServiceRoleInstanceClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Compute", CloudServiceRoleInstanceResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(CloudServiceRoleInstanceResource.ResourceType, out string cloudServiceRoleInstanceApiVersion);
            _cloudServiceRoleInstanceRestClient = new CloudServiceRoleInstancesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, cloudServiceRoleInstanceApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != CloudServiceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, CloudServiceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets a role instance from a cloud service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/cloudServices/{cloudServiceName}/roleInstances/{roleInstanceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CloudServiceRoleInstances_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-09-04</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CloudServiceRoleInstanceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="roleInstanceName"> Name of the role instance. </param>
        /// <param name="expand"> The expand expression to apply to the operation. 'UserData' is not supported for cloud services. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="roleInstanceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="roleInstanceName"/> is null. </exception>
        public virtual async Task<Response<CloudServiceRoleInstanceResource>> GetAsync(string roleInstanceName, InstanceViewType? expand = null, CancellationToken cancellationToken = default)
        {
            if (roleInstanceName == null)
            {
                throw new ArgumentNullException(nameof(roleInstanceName));
            }
            if (roleInstanceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(roleInstanceName));
            }

            using var scope = _cloudServiceRoleInstanceClientDiagnostics.CreateScope("CloudServiceRoleInstanceCollection.Get");
            scope.Start();
            try
            {
                var response = await _cloudServiceRoleInstanceRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, roleInstanceName, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CloudServiceRoleInstanceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a role instance from a cloud service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/cloudServices/{cloudServiceName}/roleInstances/{roleInstanceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CloudServiceRoleInstances_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-09-04</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CloudServiceRoleInstanceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="roleInstanceName"> Name of the role instance. </param>
        /// <param name="expand"> The expand expression to apply to the operation. 'UserData' is not supported for cloud services. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="roleInstanceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="roleInstanceName"/> is null. </exception>
        public virtual Response<CloudServiceRoleInstanceResource> Get(string roleInstanceName, InstanceViewType? expand = null, CancellationToken cancellationToken = default)
        {
            if (roleInstanceName == null)
            {
                throw new ArgumentNullException(nameof(roleInstanceName));
            }
            if (roleInstanceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(roleInstanceName));
            }

            using var scope = _cloudServiceRoleInstanceClientDiagnostics.CreateScope("CloudServiceRoleInstanceCollection.Get");
            scope.Start();
            try
            {
                var response = _cloudServiceRoleInstanceRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, roleInstanceName, expand, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CloudServiceRoleInstanceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the list of all role instances in a cloud service. Use nextLink property in the response to get the next page of role instances. Do this till nextLink is null to fetch all the role instances.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/cloudServices/{cloudServiceName}/roleInstances</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CloudServiceRoleInstances_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-09-04</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CloudServiceRoleInstanceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="expand"> The expand expression to apply to the operation. 'UserData' is not supported for cloud services. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="CloudServiceRoleInstanceResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<CloudServiceRoleInstanceResource> GetAllAsync(InstanceViewType? expand = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _cloudServiceRoleInstanceRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, expand);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _cloudServiceRoleInstanceRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, expand);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new CloudServiceRoleInstanceResource(Client, CloudServiceRoleInstanceData.DeserializeCloudServiceRoleInstanceData(e)), _cloudServiceRoleInstanceClientDiagnostics, Pipeline, "CloudServiceRoleInstanceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets the list of all role instances in a cloud service. Use nextLink property in the response to get the next page of role instances. Do this till nextLink is null to fetch all the role instances.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/cloudServices/{cloudServiceName}/roleInstances</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CloudServiceRoleInstances_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-09-04</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CloudServiceRoleInstanceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="expand"> The expand expression to apply to the operation. 'UserData' is not supported for cloud services. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="CloudServiceRoleInstanceResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<CloudServiceRoleInstanceResource> GetAll(InstanceViewType? expand = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _cloudServiceRoleInstanceRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, expand);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _cloudServiceRoleInstanceRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, expand);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new CloudServiceRoleInstanceResource(Client, CloudServiceRoleInstanceData.DeserializeCloudServiceRoleInstanceData(e)), _cloudServiceRoleInstanceClientDiagnostics, Pipeline, "CloudServiceRoleInstanceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/cloudServices/{cloudServiceName}/roleInstances/{roleInstanceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CloudServiceRoleInstances_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-09-04</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CloudServiceRoleInstanceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="roleInstanceName"> Name of the role instance. </param>
        /// <param name="expand"> The expand expression to apply to the operation. 'UserData' is not supported for cloud services. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="roleInstanceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="roleInstanceName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string roleInstanceName, InstanceViewType? expand = null, CancellationToken cancellationToken = default)
        {
            if (roleInstanceName == null)
            {
                throw new ArgumentNullException(nameof(roleInstanceName));
            }
            if (roleInstanceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(roleInstanceName));
            }

            using var scope = _cloudServiceRoleInstanceClientDiagnostics.CreateScope("CloudServiceRoleInstanceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _cloudServiceRoleInstanceRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, roleInstanceName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/cloudServices/{cloudServiceName}/roleInstances/{roleInstanceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CloudServiceRoleInstances_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-09-04</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CloudServiceRoleInstanceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="roleInstanceName"> Name of the role instance. </param>
        /// <param name="expand"> The expand expression to apply to the operation. 'UserData' is not supported for cloud services. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="roleInstanceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="roleInstanceName"/> is null. </exception>
        public virtual Response<bool> Exists(string roleInstanceName, InstanceViewType? expand = null, CancellationToken cancellationToken = default)
        {
            if (roleInstanceName == null)
            {
                throw new ArgumentNullException(nameof(roleInstanceName));
            }
            if (roleInstanceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(roleInstanceName));
            }

            using var scope = _cloudServiceRoleInstanceClientDiagnostics.CreateScope("CloudServiceRoleInstanceCollection.Exists");
            scope.Start();
            try
            {
                var response = _cloudServiceRoleInstanceRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, roleInstanceName, expand, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/cloudServices/{cloudServiceName}/roleInstances/{roleInstanceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CloudServiceRoleInstances_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-09-04</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CloudServiceRoleInstanceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="roleInstanceName"> Name of the role instance. </param>
        /// <param name="expand"> The expand expression to apply to the operation. 'UserData' is not supported for cloud services. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="roleInstanceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="roleInstanceName"/> is null. </exception>
        public virtual async Task<NullableResponse<CloudServiceRoleInstanceResource>> GetIfExistsAsync(string roleInstanceName, InstanceViewType? expand = null, CancellationToken cancellationToken = default)
        {
            if (roleInstanceName == null)
            {
                throw new ArgumentNullException(nameof(roleInstanceName));
            }
            if (roleInstanceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(roleInstanceName));
            }

            using var scope = _cloudServiceRoleInstanceClientDiagnostics.CreateScope("CloudServiceRoleInstanceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _cloudServiceRoleInstanceRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, roleInstanceName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<CloudServiceRoleInstanceResource>(response.GetRawResponse());
                return Response.FromValue(new CloudServiceRoleInstanceResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/cloudServices/{cloudServiceName}/roleInstances/{roleInstanceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CloudServiceRoleInstances_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-09-04</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CloudServiceRoleInstanceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="roleInstanceName"> Name of the role instance. </param>
        /// <param name="expand"> The expand expression to apply to the operation. 'UserData' is not supported for cloud services. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="roleInstanceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="roleInstanceName"/> is null. </exception>
        public virtual NullableResponse<CloudServiceRoleInstanceResource> GetIfExists(string roleInstanceName, InstanceViewType? expand = null, CancellationToken cancellationToken = default)
        {
            if (roleInstanceName == null)
            {
                throw new ArgumentNullException(nameof(roleInstanceName));
            }
            if (roleInstanceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(roleInstanceName));
            }

            using var scope = _cloudServiceRoleInstanceClientDiagnostics.CreateScope("CloudServiceRoleInstanceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _cloudServiceRoleInstanceRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, roleInstanceName, expand, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<CloudServiceRoleInstanceResource>(response.GetRawResponse());
                return Response.FromValue(new CloudServiceRoleInstanceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<CloudServiceRoleInstanceResource> IEnumerable<CloudServiceRoleInstanceResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<CloudServiceRoleInstanceResource> IAsyncEnumerable<CloudServiceRoleInstanceResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
