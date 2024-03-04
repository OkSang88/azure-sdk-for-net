// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.CustomerInsights.Models;

namespace Azure.ResourceManager.CustomerInsights
{
    /// <summary>
    /// A Class representing a ProfileResourceFormat along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="ProfileResourceFormatResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetProfileResourceFormatResource method.
    /// Otherwise you can get one from its parent resource <see cref="HubResource"/> using the GetProfileResourceFormat method.
    /// </summary>
    public partial class ProfileResourceFormatResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ProfileResourceFormatResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="hubName"> The hubName. </param>
        /// <param name="profileName"> The profileName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string hubName, string profileName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/profiles/{profileName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _profileResourceFormatProfilesClientDiagnostics;
        private readonly ProfilesRestOperations _profileResourceFormatProfilesRestClient;
        private readonly ProfileResourceFormatData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.CustomerInsights/hubs/profiles";

        /// <summary> Initializes a new instance of the <see cref="ProfileResourceFormatResource"/> class for mocking. </summary>
        protected ProfileResourceFormatResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ProfileResourceFormatResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ProfileResourceFormatResource(ArmClient client, ProfileResourceFormatData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ProfileResourceFormatResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ProfileResourceFormatResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _profileResourceFormatProfilesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.CustomerInsights", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string profileResourceFormatProfilesApiVersion);
            _profileResourceFormatProfilesRestClient = new ProfilesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, profileResourceFormatProfilesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ProfileResourceFormatData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets information about the specified profile.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/profiles/{profileName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Profiles_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2017-04-26</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ProfileResourceFormatResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="localeCode"> Locale of profile to retrieve, default is en-us. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ProfileResourceFormatResource>> GetAsync(string localeCode = null, CancellationToken cancellationToken = default)
        {
            using var scope = _profileResourceFormatProfilesClientDiagnostics.CreateScope("ProfileResourceFormatResource.Get");
            scope.Start();
            try
            {
                var response = await _profileResourceFormatProfilesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, localeCode, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ProfileResourceFormatResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets information about the specified profile.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/profiles/{profileName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Profiles_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2017-04-26</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ProfileResourceFormatResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="localeCode"> Locale of profile to retrieve, default is en-us. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ProfileResourceFormatResource> Get(string localeCode = null, CancellationToken cancellationToken = default)
        {
            using var scope = _profileResourceFormatProfilesClientDiagnostics.CreateScope("ProfileResourceFormatResource.Get");
            scope.Start();
            try
            {
                var response = _profileResourceFormatProfilesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, localeCode, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ProfileResourceFormatResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes a profile within a hub
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/profiles/{profileName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Profiles_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2017-04-26</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ProfileResourceFormatResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="localeCode"> Locale of profile to retrieve, default is en-us. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, string localeCode = null, CancellationToken cancellationToken = default)
        {
            using var scope = _profileResourceFormatProfilesClientDiagnostics.CreateScope("ProfileResourceFormatResource.Delete");
            scope.Start();
            try
            {
                var response = await _profileResourceFormatProfilesRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, localeCode, cancellationToken).ConfigureAwait(false);
                var operation = new CustomerInsightsArmOperation(_profileResourceFormatProfilesClientDiagnostics, Pipeline, _profileResourceFormatProfilesRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, localeCode).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes a profile within a hub
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/profiles/{profileName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Profiles_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2017-04-26</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ProfileResourceFormatResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="localeCode"> Locale of profile to retrieve, default is en-us. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, string localeCode = null, CancellationToken cancellationToken = default)
        {
            using var scope = _profileResourceFormatProfilesClientDiagnostics.CreateScope("ProfileResourceFormatResource.Delete");
            scope.Start();
            try
            {
                var response = _profileResourceFormatProfilesRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, localeCode, cancellationToken);
                var operation = new CustomerInsightsArmOperation(_profileResourceFormatProfilesClientDiagnostics, Pipeline, _profileResourceFormatProfilesRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, localeCode).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates a profile within a Hub, or updates an existing profile.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/profiles/{profileName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Profiles_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2017-04-26</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ProfileResourceFormatResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Parameters supplied to the create/delete Profile type operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ProfileResourceFormatResource>> UpdateAsync(WaitUntil waitUntil, ProfileResourceFormatData data, CancellationToken cancellationToken = default)
        {
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _profileResourceFormatProfilesClientDiagnostics.CreateScope("ProfileResourceFormatResource.Update");
            scope.Start();
            try
            {
                var response = await _profileResourceFormatProfilesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new CustomerInsightsArmOperation<ProfileResourceFormatResource>(new ProfileResourceFormatOperationSource(Client), _profileResourceFormatProfilesClientDiagnostics, Pipeline, _profileResourceFormatProfilesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.Location);
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
        /// Creates a profile within a Hub, or updates an existing profile.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/profiles/{profileName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Profiles_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2017-04-26</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ProfileResourceFormatResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Parameters supplied to the create/delete Profile type operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ProfileResourceFormatResource> Update(WaitUntil waitUntil, ProfileResourceFormatData data, CancellationToken cancellationToken = default)
        {
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _profileResourceFormatProfilesClientDiagnostics.CreateScope("ProfileResourceFormatResource.Update");
            scope.Start();
            try
            {
                var response = _profileResourceFormatProfilesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new CustomerInsightsArmOperation<ProfileResourceFormatResource>(new ProfileResourceFormatOperationSource(Client), _profileResourceFormatProfilesClientDiagnostics, Pipeline, _profileResourceFormatProfilesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.Location);
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
        /// Gets the KPIs that enrich the profile Type identified by the supplied name. Enrichment happens through participants of the Interaction on an Interaction KPI and through Relationships for Profile KPIs.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/profiles/{profileName}/getEnrichingKpis</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Profiles_GetEnrichingKpis</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2017-04-26</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ProfileResourceFormatResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="KpiDefinition"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<KpiDefinition> GetEnrichingKpisAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _profileResourceFormatProfilesRestClient.CreateGetEnrichingKpisRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => KpiDefinition.DeserializeKpiDefinition(e), _profileResourceFormatProfilesClientDiagnostics, Pipeline, "ProfileResourceFormatResource.GetEnrichingKpis", "", null, cancellationToken);
        }

        /// <summary>
        /// Gets the KPIs that enrich the profile Type identified by the supplied name. Enrichment happens through participants of the Interaction on an Interaction KPI and through Relationships for Profile KPIs.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/profiles/{profileName}/getEnrichingKpis</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Profiles_GetEnrichingKpis</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2017-04-26</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ProfileResourceFormatResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="KpiDefinition"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<KpiDefinition> GetEnrichingKpis(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _profileResourceFormatProfilesRestClient.CreateGetEnrichingKpisRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, e => KpiDefinition.DeserializeKpiDefinition(e), _profileResourceFormatProfilesClientDiagnostics, Pipeline, "ProfileResourceFormatResource.GetEnrichingKpis", "", null, cancellationToken);
        }
    }
}
