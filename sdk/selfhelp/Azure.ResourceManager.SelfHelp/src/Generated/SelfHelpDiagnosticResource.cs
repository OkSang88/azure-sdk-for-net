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

namespace Azure.ResourceManager.SelfHelp
{
    /// <summary>
    /// A Class representing a SelfHelpDiagnostic along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="SelfHelpDiagnosticResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetSelfHelpDiagnosticResource method.
    /// Otherwise you can get one from its parent resource <see cref="ArmResource"/> using the GetSelfHelpDiagnostic method.
    /// </summary>
    public partial class SelfHelpDiagnosticResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SelfHelpDiagnosticResource"/> instance. </summary>
        /// <param name="scope"> The scope. </param>
        /// <param name="diagnosticsResourceName"> The diagnosticsResourceName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string scope, string diagnosticsResourceName)
        {
            var resourceId = $"{scope}/providers/Microsoft.Help/diagnostics/{diagnosticsResourceName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _selfHelpDiagnosticDiagnosticsClientDiagnostics;
        private readonly DiagnosticsRestOperations _selfHelpDiagnosticDiagnosticsRestClient;
        private readonly SelfHelpDiagnosticData _data;

        /// <summary> Initializes a new instance of the <see cref="SelfHelpDiagnosticResource"/> class for mocking. </summary>
        protected SelfHelpDiagnosticResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SelfHelpDiagnosticResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SelfHelpDiagnosticResource(ArmClient client, SelfHelpDiagnosticData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SelfHelpDiagnosticResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SelfHelpDiagnosticResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _selfHelpDiagnosticDiagnosticsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SelfHelp", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string selfHelpDiagnosticDiagnosticsApiVersion);
            _selfHelpDiagnosticDiagnosticsRestClient = new DiagnosticsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, selfHelpDiagnosticDiagnosticsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Help/diagnostics";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual SelfHelpDiagnosticData Data
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
        /// Get the diagnostics using the 'diagnosticsResourceName' you chose while creating the diagnostic.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Help/diagnostics/{diagnosticsResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Diagnostics_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SelfHelpDiagnosticResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _selfHelpDiagnosticDiagnosticsClientDiagnostics.CreateScope("SelfHelpDiagnosticResource.Get");
            scope.Start();
            try
            {
                var response = await _selfHelpDiagnosticDiagnosticsRestClient.GetAsync(Id.Parent, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SelfHelpDiagnosticResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the diagnostics using the 'diagnosticsResourceName' you chose while creating the diagnostic.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Help/diagnostics/{diagnosticsResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Diagnostics_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SelfHelpDiagnosticResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _selfHelpDiagnosticDiagnosticsClientDiagnostics.CreateScope("SelfHelpDiagnosticResource.Get");
            scope.Start();
            try
            {
                var response = _selfHelpDiagnosticDiagnosticsRestClient.Get(Id.Parent, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SelfHelpDiagnosticResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates a diagnostic for the specific resource using solutionId and requiredInputs* from discovery solutions. &lt;br/&gt;Diagnostics tells you precisely the root cause of the issue and the steps to address it. You can get diagnostics once you discover the relevant solution for your Azure issue. &lt;br/&gt;&lt;br/&gt; &lt;b&gt;Note: &lt;/b&gt; requiredInputs’ from Discovery solutions response must be passed via ‘additionalParameters’ as an input to Diagnostics API.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Help/diagnostics/{diagnosticsResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Diagnostics_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The required request body for this insightResource invocation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SelfHelpDiagnosticResource>> UpdateAsync(WaitUntil waitUntil, SelfHelpDiagnosticData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _selfHelpDiagnosticDiagnosticsClientDiagnostics.CreateScope("SelfHelpDiagnosticResource.Update");
            scope.Start();
            try
            {
                var response = await _selfHelpDiagnosticDiagnosticsRestClient.CreateAsync(Id.Parent, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new SelfHelpArmOperation<SelfHelpDiagnosticResource>(new SelfHelpDiagnosticOperationSource(Client), _selfHelpDiagnosticDiagnosticsClientDiagnostics, Pipeline, _selfHelpDiagnosticDiagnosticsRestClient.CreateCreateRequest(Id.Parent, Id.Name, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates a diagnostic for the specific resource using solutionId and requiredInputs* from discovery solutions. &lt;br/&gt;Diagnostics tells you precisely the root cause of the issue and the steps to address it. You can get diagnostics once you discover the relevant solution for your Azure issue. &lt;br/&gt;&lt;br/&gt; &lt;b&gt;Note: &lt;/b&gt; requiredInputs’ from Discovery solutions response must be passed via ‘additionalParameters’ as an input to Diagnostics API.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Help/diagnostics/{diagnosticsResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Diagnostics_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The required request body for this insightResource invocation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SelfHelpDiagnosticResource> Update(WaitUntil waitUntil, SelfHelpDiagnosticData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _selfHelpDiagnosticDiagnosticsClientDiagnostics.CreateScope("SelfHelpDiagnosticResource.Update");
            scope.Start();
            try
            {
                var response = _selfHelpDiagnosticDiagnosticsRestClient.Create(Id.Parent, Id.Name, data, cancellationToken);
                var operation = new SelfHelpArmOperation<SelfHelpDiagnosticResource>(new SelfHelpDiagnosticOperationSource(Client), _selfHelpDiagnosticDiagnosticsClientDiagnostics, Pipeline, _selfHelpDiagnosticDiagnosticsRestClient.CreateCreateRequest(Id.Parent, Id.Name, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
    }
}
