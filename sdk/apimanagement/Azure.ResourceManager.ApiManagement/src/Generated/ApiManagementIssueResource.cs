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

namespace Azure.ResourceManager.ApiManagement
{
    /// <summary>
    /// A Class representing an ApiManagementIssue along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct an <see cref="ApiManagementIssueResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetApiManagementIssueResource method.
    /// Otherwise you can get one from its parent resource <see cref="ApiManagementServiceResource"/> using the GetApiManagementIssue method.
    /// </summary>
    public partial class ApiManagementIssueResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ApiManagementIssueResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="serviceName"> The serviceName. </param>
        /// <param name="issueId"> The issueId. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serviceName, string issueId)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/issues/{issueId}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _apiManagementIssueIssueClientDiagnostics;
        private readonly IssueRestOperations _apiManagementIssueIssueRestClient;
        private readonly IssueContractData _data;

        /// <summary> Initializes a new instance of the <see cref="ApiManagementIssueResource"/> class for mocking. </summary>
        protected ApiManagementIssueResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ApiManagementIssueResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ApiManagementIssueResource(ArmClient client, IssueContractData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ApiManagementIssueResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ApiManagementIssueResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _apiManagementIssueIssueClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ApiManagement", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string apiManagementIssueIssueApiVersion);
            _apiManagementIssueIssueRestClient = new IssueRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, apiManagementIssueIssueApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.ApiManagement/service/issues";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual IssueContractData Data
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
        /// Gets API Management issue details
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/issues/{issueId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Issue_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ApiManagementIssueResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _apiManagementIssueIssueClientDiagnostics.CreateScope("ApiManagementIssueResource.Get");
            scope.Start();
            try
            {
                var response = await _apiManagementIssueIssueRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ApiManagementIssueResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets API Management issue details
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/issues/{issueId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Issue_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ApiManagementIssueResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _apiManagementIssueIssueClientDiagnostics.CreateScope("ApiManagementIssueResource.Get");
            scope.Start();
            try
            {
                var response = _apiManagementIssueIssueRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ApiManagementIssueResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
