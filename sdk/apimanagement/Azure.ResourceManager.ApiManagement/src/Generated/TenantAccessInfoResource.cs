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
using Azure.ResourceManager.ApiManagement.Models;

namespace Azure.ResourceManager.ApiManagement
{
    /// <summary>
    /// A Class representing a TenantAccessInfo along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="TenantAccessInfoResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetTenantAccessInfoResource method.
    /// Otherwise you can get one from its parent resource <see cref="ApiManagementServiceResource"/> using the GetTenantAccessInfo method.
    /// </summary>
    public partial class TenantAccessInfoResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="TenantAccessInfoResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="serviceName"> The serviceName. </param>
        /// <param name="accessName"> The accessName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serviceName, AccessName accessName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/tenant/{accessName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _tenantAccessInfoTenantAccessClientDiagnostics;
        private readonly TenantAccessRestOperations _tenantAccessInfoTenantAccessRestClient;
        private readonly ClientDiagnostics _tenantAccessGitClientDiagnostics;
        private readonly TenantAccessGitRestOperations _tenantAccessGitRestClient;
        private readonly TenantAccessInfoData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.ApiManagement/service/tenant";

        /// <summary> Initializes a new instance of the <see cref="TenantAccessInfoResource"/> class for mocking. </summary>
        protected TenantAccessInfoResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="TenantAccessInfoResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal TenantAccessInfoResource(ArmClient client, TenantAccessInfoData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="TenantAccessInfoResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal TenantAccessInfoResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _tenantAccessInfoTenantAccessClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ApiManagement", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string tenantAccessInfoTenantAccessApiVersion);
            _tenantAccessInfoTenantAccessRestClient = new TenantAccessRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, tenantAccessInfoTenantAccessApiVersion);
            _tenantAccessGitClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ApiManagement", ProviderConstants.DefaultProviderNamespace, Diagnostics);
            _tenantAccessGitRestClient = new TenantAccessGitRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual TenantAccessInfoData Data
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
        /// Get tenant access information details without secrets.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/tenant/{accessName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TenantAccess_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TenantAccessInfoResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<TenantAccessInfoResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _tenantAccessInfoTenantAccessClientDiagnostics.CreateScope("TenantAccessInfoResource.Get");
            scope.Start();
            try
            {
                var response = await _tenantAccessInfoTenantAccessRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new TenantAccessInfoResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get tenant access information details without secrets.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/tenant/{accessName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TenantAccess_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TenantAccessInfoResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<TenantAccessInfoResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _tenantAccessInfoTenantAccessClientDiagnostics.CreateScope("TenantAccessInfoResource.Get");
            scope.Start();
            try
            {
                var response = _tenantAccessInfoTenantAccessRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new TenantAccessInfoResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Update tenant access information details.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/tenant/{accessName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TenantAccess_Update</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TenantAccessInfoResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ifMatch"> ETag of the Entity. ETag should match the current entity state from the header response of the GET request or it should be * for unconditional update. </param>
        /// <param name="patch"> Parameters supplied to retrieve the Tenant Access Information. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patch"/> is null. </exception>
        public virtual async Task<Response<TenantAccessInfoResource>> UpdateAsync(ETag ifMatch, TenantAccessInfoPatch patch, CancellationToken cancellationToken = default)
        {
            if (patch == null)
            {
                throw new ArgumentNullException(nameof(patch));
            }

            using var scope = _tenantAccessInfoTenantAccessClientDiagnostics.CreateScope("TenantAccessInfoResource.Update");
            scope.Start();
            try
            {
                var response = await _tenantAccessInfoTenantAccessRestClient.UpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, ifMatch, patch, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new TenantAccessInfoResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Update tenant access information details.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/tenant/{accessName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TenantAccess_Update</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TenantAccessInfoResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ifMatch"> ETag of the Entity. ETag should match the current entity state from the header response of the GET request or it should be * for unconditional update. </param>
        /// <param name="patch"> Parameters supplied to retrieve the Tenant Access Information. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patch"/> is null. </exception>
        public virtual Response<TenantAccessInfoResource> Update(ETag ifMatch, TenantAccessInfoPatch patch, CancellationToken cancellationToken = default)
        {
            if (patch == null)
            {
                throw new ArgumentNullException(nameof(patch));
            }

            using var scope = _tenantAccessInfoTenantAccessClientDiagnostics.CreateScope("TenantAccessInfoResource.Update");
            scope.Start();
            try
            {
                var response = _tenantAccessInfoTenantAccessRestClient.Update(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, ifMatch, patch, cancellationToken);
                return Response.FromValue(new TenantAccessInfoResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Regenerate primary access key
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/tenant/{accessName}/regeneratePrimaryKey</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TenantAccess_RegeneratePrimaryKey</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TenantAccessInfoResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> RegeneratePrimaryKeyAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _tenantAccessInfoTenantAccessClientDiagnostics.CreateScope("TenantAccessInfoResource.RegeneratePrimaryKey");
            scope.Start();
            try
            {
                var response = await _tenantAccessInfoTenantAccessRestClient.RegeneratePrimaryKeyAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Regenerate primary access key
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/tenant/{accessName}/regeneratePrimaryKey</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TenantAccess_RegeneratePrimaryKey</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TenantAccessInfoResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response RegeneratePrimaryKey(CancellationToken cancellationToken = default)
        {
            using var scope = _tenantAccessInfoTenantAccessClientDiagnostics.CreateScope("TenantAccessInfoResource.RegeneratePrimaryKey");
            scope.Start();
            try
            {
                var response = _tenantAccessInfoTenantAccessRestClient.RegeneratePrimaryKey(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Regenerate secondary access key
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/tenant/{accessName}/regenerateSecondaryKey</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TenantAccess_RegenerateSecondaryKey</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TenantAccessInfoResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> RegenerateSecondaryKeyAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _tenantAccessInfoTenantAccessClientDiagnostics.CreateScope("TenantAccessInfoResource.RegenerateSecondaryKey");
            scope.Start();
            try
            {
                var response = await _tenantAccessInfoTenantAccessRestClient.RegenerateSecondaryKeyAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Regenerate secondary access key
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/tenant/{accessName}/regenerateSecondaryKey</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TenantAccess_RegenerateSecondaryKey</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TenantAccessInfoResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response RegenerateSecondaryKey(CancellationToken cancellationToken = default)
        {
            using var scope = _tenantAccessInfoTenantAccessClientDiagnostics.CreateScope("TenantAccessInfoResource.RegenerateSecondaryKey");
            scope.Start();
            try
            {
                var response = _tenantAccessInfoTenantAccessRestClient.RegenerateSecondaryKey(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get tenant access information details.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/tenant/{accessName}/listSecrets</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TenantAccess_ListSecrets</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TenantAccessInfoResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<TenantAccessInfoSecretsDetails>> GetSecretsAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _tenantAccessInfoTenantAccessClientDiagnostics.CreateScope("TenantAccessInfoResource.GetSecrets");
            scope.Start();
            try
            {
                var response = await _tenantAccessInfoTenantAccessRestClient.ListSecretsAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get tenant access information details.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/tenant/{accessName}/listSecrets</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TenantAccess_ListSecrets</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TenantAccessInfoResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<TenantAccessInfoSecretsDetails> GetSecrets(CancellationToken cancellationToken = default)
        {
            using var scope = _tenantAccessInfoTenantAccessClientDiagnostics.CreateScope("TenantAccessInfoResource.GetSecrets");
            scope.Start();
            try
            {
                var response = _tenantAccessInfoTenantAccessRestClient.ListSecrets(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Regenerate primary access key for GIT.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/tenant/{accessName}/git/regeneratePrimaryKey</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TenantAccessGit_RegeneratePrimaryKey</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-08-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> RegeneratePrimaryKeyForGitAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _tenantAccessGitClientDiagnostics.CreateScope("TenantAccessInfoResource.RegeneratePrimaryKeyForGit");
            scope.Start();
            try
            {
                var response = await _tenantAccessGitRestClient.RegeneratePrimaryKeyAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Regenerate primary access key for GIT.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/tenant/{accessName}/git/regeneratePrimaryKey</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TenantAccessGit_RegeneratePrimaryKey</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-08-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response RegeneratePrimaryKeyForGit(CancellationToken cancellationToken = default)
        {
            using var scope = _tenantAccessGitClientDiagnostics.CreateScope("TenantAccessInfoResource.RegeneratePrimaryKeyForGit");
            scope.Start();
            try
            {
                var response = _tenantAccessGitRestClient.RegeneratePrimaryKey(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Regenerate secondary access key for GIT.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/tenant/{accessName}/git/regenerateSecondaryKey</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TenantAccessGit_RegenerateSecondaryKey</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-08-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> RegenerateSecondaryKeyForGitAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _tenantAccessGitClientDiagnostics.CreateScope("TenantAccessInfoResource.RegenerateSecondaryKeyForGit");
            scope.Start();
            try
            {
                var response = await _tenantAccessGitRestClient.RegenerateSecondaryKeyAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Regenerate secondary access key for GIT.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/tenant/{accessName}/git/regenerateSecondaryKey</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TenantAccessGit_RegenerateSecondaryKey</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-08-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response RegenerateSecondaryKeyForGit(CancellationToken cancellationToken = default)
        {
            using var scope = _tenantAccessGitClientDiagnostics.CreateScope("TenantAccessInfoResource.RegenerateSecondaryKeyForGit");
            scope.Start();
            try
            {
                var response = _tenantAccessGitRestClient.RegenerateSecondaryKey(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tenant access metadata
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/tenant/{accessName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TenantAccess_GetEntityTag</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TenantAccessInfoResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<bool>> GetEntityTagAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _tenantAccessInfoTenantAccessClientDiagnostics.CreateScope("TenantAccessInfoResource.GetEntityTag");
            scope.Start();
            try
            {
                var response = await _tenantAccessInfoTenantAccessRestClient.GetEntityTagAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tenant access metadata
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/tenant/{accessName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TenantAccess_GetEntityTag</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TenantAccessInfoResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> GetEntityTag(CancellationToken cancellationToken = default)
        {
            using var scope = _tenantAccessInfoTenantAccessClientDiagnostics.CreateScope("TenantAccessInfoResource.GetEntityTag");
            scope.Start();
            try
            {
                var response = _tenantAccessInfoTenantAccessRestClient.GetEntityTag(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
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
