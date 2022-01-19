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
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    internal partial class ApplicationGatewayPrivateEndpointConnectionsRestOperations
    {
        private Uri endpoint;
        private string apiVersion;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;
        private readonly string _userAgent;

        /// <summary> Initializes a new instance of ApplicationGatewayPrivateEndpointConnectionsRestOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="options"> The client options used to construct the current client. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="apiVersion"/> is null. </exception>
        public ApplicationGatewayPrivateEndpointConnectionsRestOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, ArmClientOptions options, Uri endpoint = null, string apiVersion = default)
        {
            this.endpoint = endpoint ?? new Uri("https://management.azure.com");
            this.apiVersion = apiVersion ?? "2021-02-01";
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
            _userAgent = HttpMessageUtilities.GetUserAgentName(this, options);
        }

        internal HttpMessage CreateDeleteRequest(string subscriptionId, string resourceGroupName, string applicationGatewayName, string connectionName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Network/applicationGateways/", false);
            uri.AppendPath(applicationGatewayName, true);
            uri.AppendPath("/privateEndpointConnections/", false);
            uri.AppendPath(connectionName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Deletes the specified private endpoint connection on application gateway. </summary>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="applicationGatewayName"> The name of the application gateway. </param>
        /// <param name="connectionName"> The name of the application gateway private endpoint connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="applicationGatewayName"/>, or <paramref name="connectionName"/> is null. </exception>
        public async Task<Response> DeleteAsync(string subscriptionId, string resourceGroupName, string applicationGatewayName, string connectionName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (applicationGatewayName == null)
            {
                throw new ArgumentNullException(nameof(applicationGatewayName));
            }
            if (connectionName == null)
            {
                throw new ArgumentNullException(nameof(connectionName));
            }

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, applicationGatewayName, connectionName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Deletes the specified private endpoint connection on application gateway. </summary>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="applicationGatewayName"> The name of the application gateway. </param>
        /// <param name="connectionName"> The name of the application gateway private endpoint connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="applicationGatewayName"/>, or <paramref name="connectionName"/> is null. </exception>
        public Response Delete(string subscriptionId, string resourceGroupName, string applicationGatewayName, string connectionName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (applicationGatewayName == null)
            {
                throw new ArgumentNullException(nameof(applicationGatewayName));
            }
            if (connectionName == null)
            {
                throw new ArgumentNullException(nameof(connectionName));
            }

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, applicationGatewayName, connectionName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateUpdateRequest(string subscriptionId, string resourceGroupName, string applicationGatewayName, string connectionName, ApplicationGatewayPrivateEndpointConnectionData parameters)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Network/applicationGateways/", false);
            uri.AppendPath(applicationGatewayName, true);
            uri.AppendPath("/privateEndpointConnections/", false);
            uri.AppendPath(connectionName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(parameters);
            request.Content = content;
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Updates the specified private endpoint connection on application gateway. </summary>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="applicationGatewayName"> The name of the application gateway. </param>
        /// <param name="connectionName"> The name of the application gateway private endpoint connection. </param>
        /// <param name="parameters"> Parameters supplied to update application gateway private endpoint connection operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="applicationGatewayName"/>, <paramref name="connectionName"/>, or <paramref name="parameters"/> is null. </exception>
        public async Task<Response> UpdateAsync(string subscriptionId, string resourceGroupName, string applicationGatewayName, string connectionName, ApplicationGatewayPrivateEndpointConnectionData parameters, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (applicationGatewayName == null)
            {
                throw new ArgumentNullException(nameof(applicationGatewayName));
            }
            if (connectionName == null)
            {
                throw new ArgumentNullException(nameof(connectionName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var message = CreateUpdateRequest(subscriptionId, resourceGroupName, applicationGatewayName, connectionName, parameters);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Updates the specified private endpoint connection on application gateway. </summary>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="applicationGatewayName"> The name of the application gateway. </param>
        /// <param name="connectionName"> The name of the application gateway private endpoint connection. </param>
        /// <param name="parameters"> Parameters supplied to update application gateway private endpoint connection operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="applicationGatewayName"/>, <paramref name="connectionName"/>, or <paramref name="parameters"/> is null. </exception>
        public Response Update(string subscriptionId, string resourceGroupName, string applicationGatewayName, string connectionName, ApplicationGatewayPrivateEndpointConnectionData parameters, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (applicationGatewayName == null)
            {
                throw new ArgumentNullException(nameof(applicationGatewayName));
            }
            if (connectionName == null)
            {
                throw new ArgumentNullException(nameof(connectionName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var message = CreateUpdateRequest(subscriptionId, resourceGroupName, applicationGatewayName, connectionName, parameters);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string applicationGatewayName, string connectionName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Network/applicationGateways/", false);
            uri.AppendPath(applicationGatewayName, true);
            uri.AppendPath("/privateEndpointConnections/", false);
            uri.AppendPath(connectionName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Gets the specified private endpoint connection on application gateway. </summary>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="applicationGatewayName"> The name of the application gateway. </param>
        /// <param name="connectionName"> The name of the application gateway private endpoint connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="applicationGatewayName"/>, or <paramref name="connectionName"/> is null. </exception>
        public async Task<Response<ApplicationGatewayPrivateEndpointConnectionData>> GetAsync(string subscriptionId, string resourceGroupName, string applicationGatewayName, string connectionName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (applicationGatewayName == null)
            {
                throw new ArgumentNullException(nameof(applicationGatewayName));
            }
            if (connectionName == null)
            {
                throw new ArgumentNullException(nameof(connectionName));
            }

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, applicationGatewayName, connectionName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ApplicationGatewayPrivateEndpointConnectionData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ApplicationGatewayPrivateEndpointConnectionData.DeserializeApplicationGatewayPrivateEndpointConnectionData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((ApplicationGatewayPrivateEndpointConnectionData)null, message.Response);
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets the specified private endpoint connection on application gateway. </summary>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="applicationGatewayName"> The name of the application gateway. </param>
        /// <param name="connectionName"> The name of the application gateway private endpoint connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="applicationGatewayName"/>, or <paramref name="connectionName"/> is null. </exception>
        public Response<ApplicationGatewayPrivateEndpointConnectionData> Get(string subscriptionId, string resourceGroupName, string applicationGatewayName, string connectionName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (applicationGatewayName == null)
            {
                throw new ArgumentNullException(nameof(applicationGatewayName));
            }
            if (connectionName == null)
            {
                throw new ArgumentNullException(nameof(connectionName));
            }

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, applicationGatewayName, connectionName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ApplicationGatewayPrivateEndpointConnectionData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ApplicationGatewayPrivateEndpointConnectionData.DeserializeApplicationGatewayPrivateEndpointConnectionData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((ApplicationGatewayPrivateEndpointConnectionData)null, message.Response);
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListRequest(string subscriptionId, string resourceGroupName, string applicationGatewayName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Network/applicationGateways/", false);
            uri.AppendPath(applicationGatewayName, true);
            uri.AppendPath("/privateEndpointConnections", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Lists all private endpoint connections on an application gateway. </summary>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="applicationGatewayName"> The name of the application gateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, or <paramref name="applicationGatewayName"/> is null. </exception>
        public async Task<Response<ApplicationGatewayPrivateEndpointConnectionListResult>> ListAsync(string subscriptionId, string resourceGroupName, string applicationGatewayName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (applicationGatewayName == null)
            {
                throw new ArgumentNullException(nameof(applicationGatewayName));
            }

            using var message = CreateListRequest(subscriptionId, resourceGroupName, applicationGatewayName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ApplicationGatewayPrivateEndpointConnectionListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ApplicationGatewayPrivateEndpointConnectionListResult.DeserializeApplicationGatewayPrivateEndpointConnectionListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Lists all private endpoint connections on an application gateway. </summary>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="applicationGatewayName"> The name of the application gateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, or <paramref name="applicationGatewayName"/> is null. </exception>
        public Response<ApplicationGatewayPrivateEndpointConnectionListResult> List(string subscriptionId, string resourceGroupName, string applicationGatewayName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (applicationGatewayName == null)
            {
                throw new ArgumentNullException(nameof(applicationGatewayName));
            }

            using var message = CreateListRequest(subscriptionId, resourceGroupName, applicationGatewayName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ApplicationGatewayPrivateEndpointConnectionListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ApplicationGatewayPrivateEndpointConnectionListResult.DeserializeApplicationGatewayPrivateEndpointConnectionListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListNextPageRequest(string nextLink, string subscriptionId, string resourceGroupName, string applicationGatewayName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Lists all private endpoint connections on an application gateway. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="applicationGatewayName"> The name of the application gateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, or <paramref name="applicationGatewayName"/> is null. </exception>
        public async Task<Response<ApplicationGatewayPrivateEndpointConnectionListResult>> ListNextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, string applicationGatewayName, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (applicationGatewayName == null)
            {
                throw new ArgumentNullException(nameof(applicationGatewayName));
            }

            using var message = CreateListNextPageRequest(nextLink, subscriptionId, resourceGroupName, applicationGatewayName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ApplicationGatewayPrivateEndpointConnectionListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ApplicationGatewayPrivateEndpointConnectionListResult.DeserializeApplicationGatewayPrivateEndpointConnectionListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Lists all private endpoint connections on an application gateway. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="applicationGatewayName"> The name of the application gateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, or <paramref name="applicationGatewayName"/> is null. </exception>
        public Response<ApplicationGatewayPrivateEndpointConnectionListResult> ListNextPage(string nextLink, string subscriptionId, string resourceGroupName, string applicationGatewayName, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (applicationGatewayName == null)
            {
                throw new ArgumentNullException(nameof(applicationGatewayName));
            }

            using var message = CreateListNextPageRequest(nextLink, subscriptionId, resourceGroupName, applicationGatewayName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ApplicationGatewayPrivateEndpointConnectionListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ApplicationGatewayPrivateEndpointConnectionListResult.DeserializeApplicationGatewayPrivateEndpointConnectionListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
