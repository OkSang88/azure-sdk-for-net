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

namespace Azure.ResourceManager.TrafficManager
{
    /// <summary>
    /// A class representing a collection of <see cref="TrafficManagerProfileResource"/> and their operations.
    /// Each <see cref="TrafficManagerProfileResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get a <see cref="TrafficManagerProfileCollection"/> instance call the GetTrafficManagerProfiles method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class TrafficManagerProfileCollection : ArmCollection, IEnumerable<TrafficManagerProfileResource>, IAsyncEnumerable<TrafficManagerProfileResource>
    {
        private readonly ClientDiagnostics _trafficManagerProfileProfilesClientDiagnostics;
        private readonly ProfilesRestOperations _trafficManagerProfileProfilesRestClient;

        /// <summary> Initializes a new instance of the <see cref="TrafficManagerProfileCollection"/> class for mocking. </summary>
        protected TrafficManagerProfileCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="TrafficManagerProfileCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal TrafficManagerProfileCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _trafficManagerProfileProfilesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.TrafficManager", TrafficManagerProfileResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(TrafficManagerProfileResource.ResourceType, out string trafficManagerProfileProfilesApiVersion);
            _trafficManagerProfileProfilesRestClient = new ProfilesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, trafficManagerProfileProfilesApiVersion);
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
        /// Create or update a Traffic Manager profile.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/trafficmanagerprofiles/{profileName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Profiles_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TrafficManagerProfileResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="profileName"> The name of the Traffic Manager profile. </param>
        /// <param name="data"> The Traffic Manager profile parameters supplied to the CreateOrUpdate operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="profileName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="profileName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<TrafficManagerProfileResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string profileName, TrafficManagerProfileData data, CancellationToken cancellationToken = default)
        {
            if (profileName == null)
            {
                throw new ArgumentNullException(nameof(profileName));
            }
            if (profileName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(profileName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _trafficManagerProfileProfilesClientDiagnostics.CreateScope("TrafficManagerProfileCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _trafficManagerProfileProfilesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, profileName, data, cancellationToken).ConfigureAwait(false);
                var operation = new TrafficManagerArmOperation<TrafficManagerProfileResource>(Response.FromValue(new TrafficManagerProfileResource(Client, response), response.GetRawResponse()));
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
        /// Create or update a Traffic Manager profile.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/trafficmanagerprofiles/{profileName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Profiles_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TrafficManagerProfileResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="profileName"> The name of the Traffic Manager profile. </param>
        /// <param name="data"> The Traffic Manager profile parameters supplied to the CreateOrUpdate operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="profileName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="profileName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<TrafficManagerProfileResource> CreateOrUpdate(WaitUntil waitUntil, string profileName, TrafficManagerProfileData data, CancellationToken cancellationToken = default)
        {
            if (profileName == null)
            {
                throw new ArgumentNullException(nameof(profileName));
            }
            if (profileName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(profileName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _trafficManagerProfileProfilesClientDiagnostics.CreateScope("TrafficManagerProfileCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _trafficManagerProfileProfilesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, profileName, data, cancellationToken);
                var operation = new TrafficManagerArmOperation<TrafficManagerProfileResource>(Response.FromValue(new TrafficManagerProfileResource(Client, response), response.GetRawResponse()));
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
        /// Gets a Traffic Manager profile.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/trafficmanagerprofiles/{profileName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Profiles_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TrafficManagerProfileResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="profileName"> The name of the Traffic Manager profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="profileName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="profileName"/> is null. </exception>
        public virtual async Task<Response<TrafficManagerProfileResource>> GetAsync(string profileName, CancellationToken cancellationToken = default)
        {
            if (profileName == null)
            {
                throw new ArgumentNullException(nameof(profileName));
            }
            if (profileName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(profileName));
            }

            using var scope = _trafficManagerProfileProfilesClientDiagnostics.CreateScope("TrafficManagerProfileCollection.Get");
            scope.Start();
            try
            {
                var response = await _trafficManagerProfileProfilesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, profileName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new TrafficManagerProfileResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a Traffic Manager profile.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/trafficmanagerprofiles/{profileName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Profiles_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TrafficManagerProfileResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="profileName"> The name of the Traffic Manager profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="profileName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="profileName"/> is null. </exception>
        public virtual Response<TrafficManagerProfileResource> Get(string profileName, CancellationToken cancellationToken = default)
        {
            if (profileName == null)
            {
                throw new ArgumentNullException(nameof(profileName));
            }
            if (profileName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(profileName));
            }

            using var scope = _trafficManagerProfileProfilesClientDiagnostics.CreateScope("TrafficManagerProfileCollection.Get");
            scope.Start();
            try
            {
                var response = _trafficManagerProfileProfilesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, profileName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new TrafficManagerProfileResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all Traffic Manager profiles within a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/trafficmanagerprofiles</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Profiles_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TrafficManagerProfileResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="TrafficManagerProfileResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<TrafficManagerProfileResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _trafficManagerProfileProfilesRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new TrafficManagerProfileResource(Client, TrafficManagerProfileData.DeserializeTrafficManagerProfileData(e)), _trafficManagerProfileProfilesClientDiagnostics, Pipeline, "TrafficManagerProfileCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Lists all Traffic Manager profiles within a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/trafficmanagerprofiles</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Profiles_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TrafficManagerProfileResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="TrafficManagerProfileResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<TrafficManagerProfileResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _trafficManagerProfileProfilesRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, e => new TrafficManagerProfileResource(Client, TrafficManagerProfileData.DeserializeTrafficManagerProfileData(e)), _trafficManagerProfileProfilesClientDiagnostics, Pipeline, "TrafficManagerProfileCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/trafficmanagerprofiles/{profileName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Profiles_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TrafficManagerProfileResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="profileName"> The name of the Traffic Manager profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="profileName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="profileName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string profileName, CancellationToken cancellationToken = default)
        {
            if (profileName == null)
            {
                throw new ArgumentNullException(nameof(profileName));
            }
            if (profileName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(profileName));
            }

            using var scope = _trafficManagerProfileProfilesClientDiagnostics.CreateScope("TrafficManagerProfileCollection.Exists");
            scope.Start();
            try
            {
                var response = await _trafficManagerProfileProfilesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, profileName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/trafficmanagerprofiles/{profileName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Profiles_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TrafficManagerProfileResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="profileName"> The name of the Traffic Manager profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="profileName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="profileName"/> is null. </exception>
        public virtual Response<bool> Exists(string profileName, CancellationToken cancellationToken = default)
        {
            if (profileName == null)
            {
                throw new ArgumentNullException(nameof(profileName));
            }
            if (profileName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(profileName));
            }

            using var scope = _trafficManagerProfileProfilesClientDiagnostics.CreateScope("TrafficManagerProfileCollection.Exists");
            scope.Start();
            try
            {
                var response = _trafficManagerProfileProfilesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, profileName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/trafficmanagerprofiles/{profileName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Profiles_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TrafficManagerProfileResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="profileName"> The name of the Traffic Manager profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="profileName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="profileName"/> is null. </exception>
        public virtual async Task<NullableResponse<TrafficManagerProfileResource>> GetIfExistsAsync(string profileName, CancellationToken cancellationToken = default)
        {
            if (profileName == null)
            {
                throw new ArgumentNullException(nameof(profileName));
            }
            if (profileName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(profileName));
            }

            using var scope = _trafficManagerProfileProfilesClientDiagnostics.CreateScope("TrafficManagerProfileCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _trafficManagerProfileProfilesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, profileName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<TrafficManagerProfileResource>(response.GetRawResponse());
                return Response.FromValue(new TrafficManagerProfileResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/trafficmanagerprofiles/{profileName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Profiles_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TrafficManagerProfileResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="profileName"> The name of the Traffic Manager profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="profileName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="profileName"/> is null. </exception>
        public virtual NullableResponse<TrafficManagerProfileResource> GetIfExists(string profileName, CancellationToken cancellationToken = default)
        {
            if (profileName == null)
            {
                throw new ArgumentNullException(nameof(profileName));
            }
            if (profileName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(profileName));
            }

            using var scope = _trafficManagerProfileProfilesClientDiagnostics.CreateScope("TrafficManagerProfileCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _trafficManagerProfileProfilesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, profileName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<TrafficManagerProfileResource>(response.GetRawResponse());
                return Response.FromValue(new TrafficManagerProfileResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<TrafficManagerProfileResource> IEnumerable<TrafficManagerProfileResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<TrafficManagerProfileResource> IAsyncEnumerable<TrafficManagerProfileResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
