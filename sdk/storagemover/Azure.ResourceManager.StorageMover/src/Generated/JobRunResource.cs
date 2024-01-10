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

namespace Azure.ResourceManager.StorageMover
{
    /// <summary>
    /// A Class representing a JobRun along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="JobRunResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetJobRunResource method.
    /// Otherwise you can get one from its parent resource <see cref="JobDefinitionResource"/> using the GetJobRun method.
    /// </summary>
    public partial class JobRunResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="JobRunResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="storageMoverName"> The storageMoverName. </param>
        /// <param name="projectName"> The projectName. </param>
        /// <param name="jobDefinitionName"> The jobDefinitionName. </param>
        /// <param name="jobRunName"> The jobRunName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string storageMoverName, string projectName, string jobDefinitionName, string jobRunName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageMover/storageMovers/{storageMoverName}/projects/{projectName}/jobDefinitions/{jobDefinitionName}/jobRuns/{jobRunName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _jobRunClientDiagnostics;
        private readonly JobRunsRestOperations _jobRunRestClient;
        private readonly JobRunData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.StorageMover/storageMovers/projects/jobDefinitions/jobRuns";

        /// <summary> Initializes a new instance of the <see cref="JobRunResource"/> class for mocking. </summary>
        protected JobRunResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="JobRunResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal JobRunResource(ArmClient client, JobRunData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="JobRunResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal JobRunResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _jobRunClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.StorageMover", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string jobRunApiVersion);
            _jobRunRestClient = new JobRunsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, jobRunApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual JobRunData Data
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
        /// Gets a Job Run resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageMover/storageMovers/{storageMoverName}/projects/{projectName}/jobDefinitions/{jobDefinitionName}/jobRuns/{jobRunName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobRuns_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="JobRunResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<JobRunResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _jobRunClientDiagnostics.CreateScope("JobRunResource.Get");
            scope.Start();
            try
            {
                var response = await _jobRunRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new JobRunResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a Job Run resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageMover/storageMovers/{storageMoverName}/projects/{projectName}/jobDefinitions/{jobDefinitionName}/jobRuns/{jobRunName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobRuns_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="JobRunResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<JobRunResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _jobRunClientDiagnostics.CreateScope("JobRunResource.Get");
            scope.Start();
            try
            {
                var response = _jobRunRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new JobRunResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
