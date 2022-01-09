// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Management.Models;

namespace Azure.ResourceManager.Management
{
    /// <summary> A Class representing a ManagementGroup along with the instance operations that can be performed on it. </summary>
    public partial class ManagementGroup : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ManagementGroup"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string groupId)
        {
            var resourceId = $"/providers/Microsoft.Management/managementGroups/{groupId}";
            return new ResourceIdentifier(resourceId);
        }
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly ManagementGroupsRestOperations _managementGroupsRestClient;
        private readonly ManagementGroupData _data;

        /// <summary> Initializes a new instance of the <see cref="ManagementGroup"/> class for mocking. </summary>
        protected ManagementGroup()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "ManagementGroup"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="resource"> The resource that is the target of operations. </param>
        internal ManagementGroup(ArmResource options, ManagementGroupData resource) : base(options, resource.Id)
        {
            HasData = true;
            _data = resource;
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _managementGroupsRestClient = new ManagementGroupsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Initializes a new instance of the <see cref="ManagementGroup"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ManagementGroup(ArmResource options, ResourceIdentifier id) : base(options, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _managementGroupsRestClient = new ManagementGroupsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Initializes a new instance of the <see cref="ManagementGroup"/> class. </summary>
        /// <param name="clientOptions"> The client options to build client context. </param>
        /// <param name="credential"> The credential to build client context. </param>
        /// <param name="uri"> The uri to build client context. </param>
        /// <param name="pipeline"> The pipeline to build client context. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ManagementGroup(ArmClientOptions clientOptions, TokenCredential credential, Uri uri, HttpPipeline pipeline, ResourceIdentifier id) : base(clientOptions, credential, uri, pipeline, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _managementGroupsRestClient = new ManagementGroupsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Management/managementGroups";

        /// <summary> Gets the valid resource type for the operations. </summary>
        protected override ResourceType ValidResourceType => ResourceType;

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ManagementGroupData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        /// RequestPath: /providers/Microsoft.Management/managementGroups/{groupId}
        /// ContextualPath: /providers/Microsoft.Management/managementGroups/{groupId}
        /// OperationId: ManagementGroups_Get
        /// <summary>
        /// Get the details of the management group.
        /// 
        /// </summary>
        /// <param name="expand"> The $expand=children query string parameter allows clients to request inclusion of children in the response payload.  $expand=path includes the path from the root group to the current group.  $expand=ancestors includes the ancestor Ids of the current group. </param>
        /// <param name="recurse"> The $recurse=true query string parameter allows clients to request inclusion of entire hierarchy in the response payload. Note that  $expand=children must be passed up if $recurse is set to true. </param>
        /// <param name="filter"> A filter which allows the exclusion of subscriptions from results (i.e. &apos;$filter=children.childType ne Subscription&apos;). </param>
        /// <param name="cacheControl"> Indicates whether the request should utilize any caches. Populate the header with &apos;no-cache&apos; value to bypass existing caches. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<ManagementGroup>> GetAsync(ManagementGroupExpandType? expand = null, bool? recurse = null, string filter = null, string cacheControl = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ManagementGroup.Get");
            scope.Start();
            try
            {
                var response = await _managementGroupsRestClient.GetAsync(Id.Name, expand, recurse, filter, cacheControl, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new ManagementGroup(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /providers/Microsoft.Management/managementGroups/{groupId}
        /// ContextualPath: /providers/Microsoft.Management/managementGroups/{groupId}
        /// OperationId: ManagementGroups_Get
        /// <summary>
        /// Get the details of the management group.
        /// 
        /// </summary>
        /// <param name="expand"> The $expand=children query string parameter allows clients to request inclusion of children in the response payload.  $expand=path includes the path from the root group to the current group.  $expand=ancestors includes the ancestor Ids of the current group. </param>
        /// <param name="recurse"> The $recurse=true query string parameter allows clients to request inclusion of entire hierarchy in the response payload. Note that  $expand=children must be passed up if $recurse is set to true. </param>
        /// <param name="filter"> A filter which allows the exclusion of subscriptions from results (i.e. &apos;$filter=children.childType ne Subscription&apos;). </param>
        /// <param name="cacheControl"> Indicates whether the request should utilize any caches. Populate the header with &apos;no-cache&apos; value to bypass existing caches. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ManagementGroup> Get(ManagementGroupExpandType? expand = null, bool? recurse = null, string filter = null, string cacheControl = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ManagementGroup.Get");
            scope.Start();
            try
            {
                var response = _managementGroupsRestClient.Get(Id.Name, expand, recurse, filter, cacheControl, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagementGroup(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public async virtual Task<IEnumerable<AzureLocation>> GetAvailableLocationsAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ManagementGroup.GetAvailableLocations");
            scope.Start();
            try
            {
                return await ListAvailableLocationsAsync(ResourceType, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public virtual IEnumerable<AzureLocation> GetAvailableLocations(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ManagementGroup.GetAvailableLocations");
            scope.Start();
            try
            {
                return ListAvailableLocations(ResourceType, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /providers/Microsoft.Management/managementGroups/{groupId}
        /// ContextualPath: /providers/Microsoft.Management/managementGroups/{groupId}
        /// OperationId: ManagementGroups_Delete
        /// <summary>
        /// Delete management group.
        /// If a management group contains child resources, the request will fail.
        /// 
        /// </summary>
        /// <param name="cacheControl"> Indicates whether the request should utilize any caches. Populate the header with &apos;no-cache&apos; value to bypass existing caches. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<ManagementGroupDeleteOperation> DeleteAsync(string cacheControl = null, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ManagementGroup.Delete");
            scope.Start();
            try
            {
                var response = await _managementGroupsRestClient.DeleteAsync(Id.Name, cacheControl, cancellationToken).ConfigureAwait(false);
                var operation = new ManagementGroupDeleteOperation(_clientDiagnostics, Pipeline, _managementGroupsRestClient.CreateDeleteRequest(Id.Name, cacheControl).Request, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /providers/Microsoft.Management/managementGroups/{groupId}
        /// ContextualPath: /providers/Microsoft.Management/managementGroups/{groupId}
        /// OperationId: ManagementGroups_Delete
        /// <summary>
        /// Delete management group.
        /// If a management group contains child resources, the request will fail.
        /// 
        /// </summary>
        /// <param name="cacheControl"> Indicates whether the request should utilize any caches. Populate the header with &apos;no-cache&apos; value to bypass existing caches. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ManagementGroupDeleteOperation Delete(string cacheControl = null, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ManagementGroup.Delete");
            scope.Start();
            try
            {
                var response = _managementGroupsRestClient.Delete(Id.Name, cacheControl, cancellationToken);
                var operation = new ManagementGroupDeleteOperation(_clientDiagnostics, Pipeline, _managementGroupsRestClient.CreateDeleteRequest(Id.Name, cacheControl).Request, response);
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

        /// RequestPath: /providers/Microsoft.Management/managementGroups/{groupId}
        /// ContextualPath: /providers/Microsoft.Management/managementGroups/{groupId}
        /// OperationId: ManagementGroups_Update
        /// <summary>
        /// Update a management group.
        /// 
        /// </summary>
        /// <param name="patchGroupRequest"> Management group patch parameters. </param>
        /// <param name="cacheControl"> Indicates whether the request should utilize any caches. Populate the header with &apos;no-cache&apos; value to bypass existing caches. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patchGroupRequest"/> is null. </exception>
        public async virtual Task<Response<ManagementGroup>> UpdateAsync(PatchManagementGroupOptions patchGroupRequest, string cacheControl = null, CancellationToken cancellationToken = default)
        {
            if (patchGroupRequest == null)
            {
                throw new ArgumentNullException(nameof(patchGroupRequest));
            }

            using var scope = _clientDiagnostics.CreateScope("ManagementGroup.Update");
            scope.Start();
            try
            {
                var response = await _managementGroupsRestClient.UpdateAsync(Id.Name, patchGroupRequest, cacheControl, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new ManagementGroup(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /providers/Microsoft.Management/managementGroups/{groupId}
        /// ContextualPath: /providers/Microsoft.Management/managementGroups/{groupId}
        /// OperationId: ManagementGroups_Update
        /// <summary>
        /// Update a management group.
        /// 
        /// </summary>
        /// <param name="patchGroupRequest"> Management group patch parameters. </param>
        /// <param name="cacheControl"> Indicates whether the request should utilize any caches. Populate the header with &apos;no-cache&apos; value to bypass existing caches. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patchGroupRequest"/> is null. </exception>
        public virtual Response<ManagementGroup> Update(PatchManagementGroupOptions patchGroupRequest, string cacheControl = null, CancellationToken cancellationToken = default)
        {
            if (patchGroupRequest == null)
            {
                throw new ArgumentNullException(nameof(patchGroupRequest));
            }

            using var scope = _clientDiagnostics.CreateScope("ManagementGroup.Update");
            scope.Start();
            try
            {
                var response = _managementGroupsRestClient.Update(Id.Name, patchGroupRequest, cacheControl, cancellationToken);
                return Response.FromValue(new ManagementGroup(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /providers/Microsoft.Management/managementGroups/{groupId}/descendants
        /// ContextualPath: /providers/Microsoft.Management/managementGroups/{groupId}
        /// OperationId: ManagementGroups_GetDescendants
        /// <summary>
        /// List all entities that descend from a management group.
        /// 
        /// </summary>
        /// <param name="skiptoken">
        /// Page continuation token is only used if a previous operation returned a partial result. 
        /// If a previous response contains a nextLink element, the value of the nextLink element will include a token parameter that specifies a starting point to use for subsequent calls.
        /// 
        /// </param>
        /// <param name="top"> Number of elements to return when retrieving results. Passing this in will override $skipToken. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DescendantInfo" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DescendantInfo> GetDescendantsAsync(string skiptoken = null, int? top = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<DescendantInfo>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ManagementGroup.GetDescendants");
                scope.Start();
                try
                {
                    var response = await _managementGroupsRestClient.GetDescendantsAsync(Id.Name, skiptoken, top, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<DescendantInfo>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ManagementGroup.GetDescendants");
                scope.Start();
                try
                {
                    var response = await _managementGroupsRestClient.GetDescendantsNextPageAsync(nextLink, Id.Name, skiptoken, top, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /providers/Microsoft.Management/managementGroups/{groupId}/descendants
        /// ContextualPath: /providers/Microsoft.Management/managementGroups/{groupId}
        /// OperationId: ManagementGroups_GetDescendants
        /// <summary>
        /// List all entities that descend from a management group.
        /// 
        /// </summary>
        /// <param name="skiptoken">
        /// Page continuation token is only used if a previous operation returned a partial result. 
        /// If a previous response contains a nextLink element, the value of the nextLink element will include a token parameter that specifies a starting point to use for subsequent calls.
        /// 
        /// </param>
        /// <param name="top"> Number of elements to return when retrieving results. Passing this in will override $skipToken. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DescendantInfo" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DescendantInfo> GetDescendants(string skiptoken = null, int? top = null, CancellationToken cancellationToken = default)
        {
            Page<DescendantInfo> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ManagementGroup.GetDescendants");
                scope.Start();
                try
                {
                    var response = _managementGroupsRestClient.GetDescendants(Id.Name, skiptoken, top, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<DescendantInfo> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ManagementGroup.GetDescendants");
                scope.Start();
                try
                {
                    var response = _managementGroupsRestClient.GetDescendantsNextPage(nextLink, Id.Name, skiptoken, top, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }
    }
}
