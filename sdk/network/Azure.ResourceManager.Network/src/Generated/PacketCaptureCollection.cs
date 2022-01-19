// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing collection of PacketCapture and their operations over its parent. </summary>
    public partial class PacketCaptureCollection : ArmCollection, IEnumerable<PacketCapture>, IAsyncEnumerable<PacketCapture>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly PacketCapturesRestOperations _packetCapturesRestClient;

        /// <summary> Initializes a new instance of the <see cref="PacketCaptureCollection"/> class for mocking. </summary>
        protected PacketCaptureCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="PacketCaptureCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal PacketCaptureCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            ClientOptions.TryGetApiVersion(PacketCapture.ResourceType, out string apiVersion);
            _packetCapturesRestClient = new PacketCapturesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != NetworkWatcher.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, NetworkWatcher.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// <summary> Create and start a packet capture on the specified VM. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="packetCaptureName"> The name of the packet capture session. </param>
        /// <param name="parameters"> Parameters that define the create packet capture operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="packetCaptureName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual PacketCaptureCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string packetCaptureName, PacketCaptureInput parameters, CancellationToken cancellationToken = default)
        {
            if (packetCaptureName == null)
            {
                throw new ArgumentNullException(nameof(packetCaptureName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("PacketCaptureCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _packetCapturesRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, packetCaptureName, parameters, cancellationToken);
                var operation = new PacketCaptureCreateOrUpdateOperation(this, _clientDiagnostics, Pipeline, _packetCapturesRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, packetCaptureName, parameters).Request, response);
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

        /// <summary> Create and start a packet capture on the specified VM. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="packetCaptureName"> The name of the packet capture session. </param>
        /// <param name="parameters"> Parameters that define the create packet capture operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="packetCaptureName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<PacketCaptureCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string packetCaptureName, PacketCaptureInput parameters, CancellationToken cancellationToken = default)
        {
            if (packetCaptureName == null)
            {
                throw new ArgumentNullException(nameof(packetCaptureName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("PacketCaptureCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _packetCapturesRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, packetCaptureName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new PacketCaptureCreateOrUpdateOperation(this, _clientDiagnostics, Pipeline, _packetCapturesRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, packetCaptureName, parameters).Request, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a packet capture session by name. </summary>
        /// <param name="packetCaptureName"> The name of the packet capture session. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="packetCaptureName"/> is null. </exception>
        public virtual Response<PacketCapture> Get(string packetCaptureName, CancellationToken cancellationToken = default)
        {
            if (packetCaptureName == null)
            {
                throw new ArgumentNullException(nameof(packetCaptureName));
            }

            using var scope = _clientDiagnostics.CreateScope("PacketCaptureCollection.Get");
            scope.Start();
            try
            {
                var response = _packetCapturesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, packetCaptureName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PacketCapture(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a packet capture session by name. </summary>
        /// <param name="packetCaptureName"> The name of the packet capture session. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="packetCaptureName"/> is null. </exception>
        public async virtual Task<Response<PacketCapture>> GetAsync(string packetCaptureName, CancellationToken cancellationToken = default)
        {
            if (packetCaptureName == null)
            {
                throw new ArgumentNullException(nameof(packetCaptureName));
            }

            using var scope = _clientDiagnostics.CreateScope("PacketCaptureCollection.Get");
            scope.Start();
            try
            {
                var response = await _packetCapturesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, packetCaptureName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new PacketCapture(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="packetCaptureName"> The name of the packet capture session. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="packetCaptureName"/> is null. </exception>
        public virtual Response<PacketCapture> GetIfExists(string packetCaptureName, CancellationToken cancellationToken = default)
        {
            if (packetCaptureName == null)
            {
                throw new ArgumentNullException(nameof(packetCaptureName));
            }

            using var scope = _clientDiagnostics.CreateScope("PacketCaptureCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _packetCapturesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, packetCaptureName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<PacketCapture>(null, response.GetRawResponse());
                return Response.FromValue(new PacketCapture(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="packetCaptureName"> The name of the packet capture session. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="packetCaptureName"/> is null. </exception>
        public async virtual Task<Response<PacketCapture>> GetIfExistsAsync(string packetCaptureName, CancellationToken cancellationToken = default)
        {
            if (packetCaptureName == null)
            {
                throw new ArgumentNullException(nameof(packetCaptureName));
            }

            using var scope = _clientDiagnostics.CreateScope("PacketCaptureCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _packetCapturesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, packetCaptureName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<PacketCapture>(null, response.GetRawResponse());
                return Response.FromValue(new PacketCapture(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="packetCaptureName"> The name of the packet capture session. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="packetCaptureName"/> is null. </exception>
        public virtual Response<bool> Exists(string packetCaptureName, CancellationToken cancellationToken = default)
        {
            if (packetCaptureName == null)
            {
                throw new ArgumentNullException(nameof(packetCaptureName));
            }

            using var scope = _clientDiagnostics.CreateScope("PacketCaptureCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(packetCaptureName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="packetCaptureName"> The name of the packet capture session. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="packetCaptureName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string packetCaptureName, CancellationToken cancellationToken = default)
        {
            if (packetCaptureName == null)
            {
                throw new ArgumentNullException(nameof(packetCaptureName));
            }

            using var scope = _clientDiagnostics.CreateScope("PacketCaptureCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(packetCaptureName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all packet capture sessions within the specified resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PacketCapture" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<PacketCapture> GetAll(CancellationToken cancellationToken = default)
        {
            Page<PacketCapture> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("PacketCaptureCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _packetCapturesRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new PacketCapture(this, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary> Lists all packet capture sessions within the specified resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PacketCapture" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<PacketCapture> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<PacketCapture>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("PacketCaptureCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _packetCapturesRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new PacketCapture(this, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        IEnumerator<PacketCapture> IEnumerable<PacketCapture>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<PacketCapture> IAsyncEnumerable<PacketCapture>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, PacketCapture, PacketCaptureData> Construct() { }
    }
}
