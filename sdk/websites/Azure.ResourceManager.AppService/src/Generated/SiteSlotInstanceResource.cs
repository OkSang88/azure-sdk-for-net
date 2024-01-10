// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A Class representing a SiteSlotInstance along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="SiteSlotInstanceResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetSiteSlotInstanceResource method.
    /// Otherwise you can get one from its parent resource <see cref="WebSiteSlotResource"/> using the GetSiteSlotInstance method.
    /// </summary>
    public partial class SiteSlotInstanceResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SiteSlotInstanceResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="name"> The name. </param>
        /// <param name="slot"> The slot. </param>
        /// <param name="instanceId"> The instanceId. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string slot, string instanceId)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/instances/{instanceId}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _siteSlotInstanceWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _siteSlotInstanceWebAppsRestClient;
        private readonly WebSiteInstanceStatusData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Web/sites/slots/instances";

        /// <summary> Initializes a new instance of the <see cref="SiteSlotInstanceResource"/> class for mocking. </summary>
        protected SiteSlotInstanceResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SiteSlotInstanceResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SiteSlotInstanceResource(ArmClient client, WebSiteInstanceStatusData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SiteSlotInstanceResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SiteSlotInstanceResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _siteSlotInstanceWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string siteSlotInstanceWebAppsApiVersion);
            _siteSlotInstanceWebAppsRestClient = new WebAppsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, siteSlotInstanceWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual WebSiteInstanceStatusData Data
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

        /// <summary> Gets an object representing a SiteSlotInstanceExtensionResource along with the instance operations that can be performed on it in the SiteSlotInstance. </summary>
        /// <returns> Returns a <see cref="SiteSlotInstanceExtensionResource"/> object. </returns>
        public virtual SiteSlotInstanceExtensionResource GetSiteSlotInstanceExtension()
        {
            return new SiteSlotInstanceExtensionResource(Client, Id.AppendChildResource("extensions", "MSDeploy"));
        }

        /// <summary> Gets a collection of SiteSlotInstanceProcessResources in the SiteSlotInstance. </summary>
        /// <returns> An object representing collection of SiteSlotInstanceProcessResources and their operations over a SiteSlotInstanceProcessResource. </returns>
        public virtual SiteSlotInstanceProcessCollection GetSiteSlotInstanceProcesses()
        {
            return GetCachedClient(client => new SiteSlotInstanceProcessCollection(client, Id));
        }

        /// <summary>
        /// Description for Get process information by its ID for a specific scaled-out instance in a web site.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/instances/{instanceId}/processes/{processId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetInstanceProcessSlot</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteSlotInstanceProcessResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="processId"> PID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="processId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="processId"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<SiteSlotInstanceProcessResource>> GetSiteSlotInstanceProcessAsync(string processId, CancellationToken cancellationToken = default)
        {
            return await GetSiteSlotInstanceProcesses().GetAsync(processId, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Description for Get process information by its ID for a specific scaled-out instance in a web site.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/instances/{instanceId}/processes/{processId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetInstanceProcessSlot</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteSlotInstanceProcessResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="processId"> PID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="processId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="processId"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<SiteSlotInstanceProcessResource> GetSiteSlotInstanceProcess(string processId, CancellationToken cancellationToken = default)
        {
            return GetSiteSlotInstanceProcesses().Get(processId, cancellationToken);
        }

        /// <summary>
        /// Description for Gets all scale-out instances of an app.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/instances/{instanceId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetInstanceInfoSlot</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteSlotInstanceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SiteSlotInstanceResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _siteSlotInstanceWebAppsClientDiagnostics.CreateScope("SiteSlotInstanceResource.Get");
            scope.Start();
            try
            {
                var response = await _siteSlotInstanceWebAppsRestClient.GetInstanceInfoSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteSlotInstanceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Gets all scale-out instances of an app.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/instances/{instanceId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetInstanceInfoSlot</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteSlotInstanceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SiteSlotInstanceResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _siteSlotInstanceWebAppsClientDiagnostics.CreateScope("SiteSlotInstanceResource.Get");
            scope.Start();
            try
            {
                var response = _siteSlotInstanceWebAppsRestClient.GetInstanceInfoSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteSlotInstanceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
