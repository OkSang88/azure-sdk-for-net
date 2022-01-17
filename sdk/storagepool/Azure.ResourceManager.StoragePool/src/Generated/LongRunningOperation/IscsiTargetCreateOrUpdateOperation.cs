// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.StoragePool;

namespace Azure.ResourceManager.StoragePool.Models
{
    /// <summary> Create or Update an iSCSI Target. </summary>
    public partial class IscsiTargetCreateOrUpdateOperation : Operation<IscsiTarget>, IOperationSource<IscsiTarget>
    {
        private readonly OperationInternals<IscsiTarget> _operation;

        private readonly ArmResource _operationBase;

        /// <summary> Initializes a new instance of IscsiTargetCreateOrUpdateOperation for mocking. </summary>
        protected IscsiTargetCreateOrUpdateOperation()
        {
        }

        internal IscsiTargetCreateOrUpdateOperation(ArmResource operationsBase, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<IscsiTarget>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.AzureAsyncOperation, "IscsiTargetCreateOrUpdateOperation");
            _operationBase = operationsBase;
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override IscsiTarget Value => _operation.Value;

        /// <inheritdoc />
        public override bool HasCompleted => _operation.HasCompleted;

        /// <inheritdoc />
        public override bool HasValue => _operation.HasValue;

        /// <inheritdoc />
        public override Response GetRawResponse() => _operation.GetRawResponse();

        /// <inheritdoc />
        public override Response UpdateStatus(CancellationToken cancellationToken = default) => _operation.UpdateStatus(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response> UpdateStatusAsync(CancellationToken cancellationToken = default) => _operation.UpdateStatusAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<IscsiTarget>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<IscsiTarget>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        IscsiTarget IOperationSource<IscsiTarget>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = IscsiTargetData.DeserializeIscsiTargetData(document.RootElement);
            return new IscsiTarget(_operationBase, data);
        }

        async ValueTask<IscsiTarget> IOperationSource<IscsiTarget>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = IscsiTargetData.DeserializeIscsiTargetData(document.RootElement);
            return new IscsiTarget(_operationBase, data);
        }
    }
}
