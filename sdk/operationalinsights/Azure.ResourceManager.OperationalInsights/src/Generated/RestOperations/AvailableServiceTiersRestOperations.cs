// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.OperationalInsights.Models;

namespace Azure.ResourceManager.OperationalInsights
{
    internal partial class AvailableServiceTiersRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of AvailableServiceTiersRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public AvailableServiceTiersRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2020-08-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateListByWorkspaceRequest(string subscriptionId, string resourceGroupName, string workspaceName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourcegroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.OperationalInsights/workspaces/", false);
            uri.AppendPath(workspaceName, true);
            uri.AppendPath("/availableServiceTiers", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets the available service tiers for the workspace. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="workspaceName"> The name of the workspace. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="workspaceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="workspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<IReadOnlyList<OperationalInsightsAvailableServiceTier>>> ListByWorkspaceAsync(string subscriptionId, string resourceGroupName, string workspaceName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (subscriptionId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (resourceGroupName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceGroupName));
            }
            if (workspaceName == null)
            {
                throw new ArgumentNullException(nameof(workspaceName));
            }
            if (workspaceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(workspaceName));
            }

            using var message = CreateListByWorkspaceRequest(subscriptionId, resourceGroupName, workspaceName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        IReadOnlyList<OperationalInsightsAvailableServiceTier> value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        List<OperationalInsightsAvailableServiceTier> array = new List<OperationalInsightsAvailableServiceTier>();
                        foreach (var item in document.RootElement.EnumerateArray())
                        {
                            array.Add(OperationalInsightsAvailableServiceTier.DeserializeOperationalInsightsAvailableServiceTier(item));
                        }
                        value = array;
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets the available service tiers for the workspace. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="workspaceName"> The name of the workspace. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="workspaceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="workspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<IReadOnlyList<OperationalInsightsAvailableServiceTier>> ListByWorkspace(string subscriptionId, string resourceGroupName, string workspaceName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (subscriptionId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (resourceGroupName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceGroupName));
            }
            if (workspaceName == null)
            {
                throw new ArgumentNullException(nameof(workspaceName));
            }
            if (workspaceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(workspaceName));
            }

            using var message = CreateListByWorkspaceRequest(subscriptionId, resourceGroupName, workspaceName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        IReadOnlyList<OperationalInsightsAvailableServiceTier> value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        List<OperationalInsightsAvailableServiceTier> array = new List<OperationalInsightsAvailableServiceTier>();
                        foreach (var item in document.RootElement.EnumerateArray())
                        {
                            array.Add(OperationalInsightsAvailableServiceTier.DeserializeOperationalInsightsAvailableServiceTier(item));
                        }
                        value = array;
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
