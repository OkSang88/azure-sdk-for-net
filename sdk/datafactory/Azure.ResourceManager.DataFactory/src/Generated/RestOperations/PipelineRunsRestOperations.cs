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
using Azure.ResourceManager.DataFactory.Models;

namespace Azure.ResourceManager.DataFactory
{
    internal partial class PipelineRunsRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of PipelineRunsRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public PipelineRunsRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2018-06-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateQueryByFactoryRequest(string subscriptionId, string resourceGroupName, string factoryName, RunFilterContent content)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.DataFactory/factories/", false);
            uri.AppendPath(factoryName, true);
            uri.AppendPath("/queryPipelineRuns", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content0 = new Utf8JsonRequestContent();
            content0.JsonWriter.WriteObjectValue(content);
            request.Content = content0;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Query pipeline runs in the factory based on input filter conditions. </summary>
        /// <param name="subscriptionId"> The subscription identifier. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="factoryName"> The factory name. </param>
        /// <param name="content"> Parameters to filter the pipeline run. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="factoryName"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="factoryName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<DataFactoryPipelineRunsQueryResult>> QueryByFactoryAsync(string subscriptionId, string resourceGroupName, string factoryName, RunFilterContent content, CancellationToken cancellationToken = default)
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
            if (factoryName == null)
            {
                throw new ArgumentNullException(nameof(factoryName));
            }
            if (factoryName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(factoryName));
            }
            if (content == null)
            {
                throw new ArgumentNullException(nameof(content));
            }

            using var message = CreateQueryByFactoryRequest(subscriptionId, resourceGroupName, factoryName, content);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DataFactoryPipelineRunsQueryResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = DataFactoryPipelineRunsQueryResult.DeserializeDataFactoryPipelineRunsQueryResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Query pipeline runs in the factory based on input filter conditions. </summary>
        /// <param name="subscriptionId"> The subscription identifier. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="factoryName"> The factory name. </param>
        /// <param name="content"> Parameters to filter the pipeline run. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="factoryName"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="factoryName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<DataFactoryPipelineRunsQueryResult> QueryByFactory(string subscriptionId, string resourceGroupName, string factoryName, RunFilterContent content, CancellationToken cancellationToken = default)
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
            if (factoryName == null)
            {
                throw new ArgumentNullException(nameof(factoryName));
            }
            if (factoryName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(factoryName));
            }
            if (content == null)
            {
                throw new ArgumentNullException(nameof(content));
            }

            using var message = CreateQueryByFactoryRequest(subscriptionId, resourceGroupName, factoryName, content);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DataFactoryPipelineRunsQueryResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = DataFactoryPipelineRunsQueryResult.DeserializeDataFactoryPipelineRunsQueryResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string factoryName, string runId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.DataFactory/factories/", false);
            uri.AppendPath(factoryName, true);
            uri.AppendPath("/pipelineruns/", false);
            uri.AppendPath(runId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get a pipeline run by its run ID. </summary>
        /// <param name="subscriptionId"> The subscription identifier. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="factoryName"> The factory name. </param>
        /// <param name="runId"> The pipeline run identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="factoryName"/> or <paramref name="runId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="factoryName"/> or <paramref name="runId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<DataFactoryPipelineRunInfo>> GetAsync(string subscriptionId, string resourceGroupName, string factoryName, string runId, CancellationToken cancellationToken = default)
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
            if (factoryName == null)
            {
                throw new ArgumentNullException(nameof(factoryName));
            }
            if (factoryName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(factoryName));
            }
            if (runId == null)
            {
                throw new ArgumentNullException(nameof(runId));
            }
            if (runId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(runId));
            }

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, factoryName, runId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DataFactoryPipelineRunInfo value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = DataFactoryPipelineRunInfo.DeserializeDataFactoryPipelineRunInfo(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get a pipeline run by its run ID. </summary>
        /// <param name="subscriptionId"> The subscription identifier. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="factoryName"> The factory name. </param>
        /// <param name="runId"> The pipeline run identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="factoryName"/> or <paramref name="runId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="factoryName"/> or <paramref name="runId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<DataFactoryPipelineRunInfo> Get(string subscriptionId, string resourceGroupName, string factoryName, string runId, CancellationToken cancellationToken = default)
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
            if (factoryName == null)
            {
                throw new ArgumentNullException(nameof(factoryName));
            }
            if (factoryName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(factoryName));
            }
            if (runId == null)
            {
                throw new ArgumentNullException(nameof(runId));
            }
            if (runId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(runId));
            }

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, factoryName, runId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DataFactoryPipelineRunInfo value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = DataFactoryPipelineRunInfo.DeserializeDataFactoryPipelineRunInfo(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCancelRequest(string subscriptionId, string resourceGroupName, string factoryName, string runId, bool? isRecursive)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.DataFactory/factories/", false);
            uri.AppendPath(factoryName, true);
            uri.AppendPath("/pipelineruns/", false);
            uri.AppendPath(runId, true);
            uri.AppendPath("/cancel", false);
            if (isRecursive != null)
            {
                uri.AppendQuery("isRecursive", isRecursive.Value, true);
            }
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Cancel a pipeline run by its run ID. </summary>
        /// <param name="subscriptionId"> The subscription identifier. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="factoryName"> The factory name. </param>
        /// <param name="runId"> The pipeline run identifier. </param>
        /// <param name="isRecursive"> If true, cancel all the Child pipelines that are triggered by the current pipeline. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="factoryName"/> or <paramref name="runId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="factoryName"/> or <paramref name="runId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> CancelAsync(string subscriptionId, string resourceGroupName, string factoryName, string runId, bool? isRecursive = null, CancellationToken cancellationToken = default)
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
            if (factoryName == null)
            {
                throw new ArgumentNullException(nameof(factoryName));
            }
            if (factoryName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(factoryName));
            }
            if (runId == null)
            {
                throw new ArgumentNullException(nameof(runId));
            }
            if (runId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(runId));
            }

            using var message = CreateCancelRequest(subscriptionId, resourceGroupName, factoryName, runId, isRecursive);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Cancel a pipeline run by its run ID. </summary>
        /// <param name="subscriptionId"> The subscription identifier. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="factoryName"> The factory name. </param>
        /// <param name="runId"> The pipeline run identifier. </param>
        /// <param name="isRecursive"> If true, cancel all the Child pipelines that are triggered by the current pipeline. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="factoryName"/> or <paramref name="runId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="factoryName"/> or <paramref name="runId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Cancel(string subscriptionId, string resourceGroupName, string factoryName, string runId, bool? isRecursive = null, CancellationToken cancellationToken = default)
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
            if (factoryName == null)
            {
                throw new ArgumentNullException(nameof(factoryName));
            }
            if (factoryName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(factoryName));
            }
            if (runId == null)
            {
                throw new ArgumentNullException(nameof(runId));
            }
            if (runId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(runId));
            }

            using var message = CreateCancelRequest(subscriptionId, resourceGroupName, factoryName, runId, isRecursive);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
