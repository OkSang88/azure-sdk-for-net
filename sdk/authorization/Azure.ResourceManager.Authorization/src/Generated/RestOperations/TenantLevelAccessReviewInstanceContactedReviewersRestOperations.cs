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
using Azure.ResourceManager.Authorization.Models;

namespace Azure.ResourceManager.Authorization
{
    internal partial class TenantLevelAccessReviewInstanceContactedReviewersRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of TenantLevelAccessReviewInstanceContactedReviewersRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public TenantLevelAccessReviewInstanceContactedReviewersRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2021-11-16-preview";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateListRequest(string scheduleDefinitionId, string id)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.Authorization/accessReviewScheduleDefinitions/", false);
            uri.AppendPath(scheduleDefinitionId, true);
            uri.AppendPath("/instances/", false);
            uri.AppendPath(id, true);
            uri.AppendPath("/contactedReviewers", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get access review instance contacted reviewers. </summary>
        /// <param name="scheduleDefinitionId"> The id of the access review schedule definition. </param>
        /// <param name="id"> The id of the access review instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scheduleDefinitionId"/> or <paramref name="id"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="scheduleDefinitionId"/> or <paramref name="id"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<AccessReviewContactedReviewerListResult>> ListAsync(string scheduleDefinitionId, string id, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(scheduleDefinitionId, nameof(scheduleDefinitionId));
            Argument.AssertNotNullOrEmpty(id, nameof(id));

            using var message = CreateListRequest(scheduleDefinitionId, id);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AccessReviewContactedReviewerListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = AccessReviewContactedReviewerListResult.DeserializeAccessReviewContactedReviewerListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get access review instance contacted reviewers. </summary>
        /// <param name="scheduleDefinitionId"> The id of the access review schedule definition. </param>
        /// <param name="id"> The id of the access review instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scheduleDefinitionId"/> or <paramref name="id"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="scheduleDefinitionId"/> or <paramref name="id"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<AccessReviewContactedReviewerListResult> List(string scheduleDefinitionId, string id, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(scheduleDefinitionId, nameof(scheduleDefinitionId));
            Argument.AssertNotNullOrEmpty(id, nameof(id));

            using var message = CreateListRequest(scheduleDefinitionId, id);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AccessReviewContactedReviewerListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = AccessReviewContactedReviewerListResult.DeserializeAccessReviewContactedReviewerListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListNextPageRequest(string nextLink, string scheduleDefinitionId, string id)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get access review instance contacted reviewers. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="scheduleDefinitionId"> The id of the access review schedule definition. </param>
        /// <param name="id"> The id of the access review instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="scheduleDefinitionId"/> or <paramref name="id"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="scheduleDefinitionId"/> or <paramref name="id"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<AccessReviewContactedReviewerListResult>> ListNextPageAsync(string nextLink, string scheduleDefinitionId, string id, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(scheduleDefinitionId, nameof(scheduleDefinitionId));
            Argument.AssertNotNullOrEmpty(id, nameof(id));

            using var message = CreateListNextPageRequest(nextLink, scheduleDefinitionId, id);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AccessReviewContactedReviewerListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = AccessReviewContactedReviewerListResult.DeserializeAccessReviewContactedReviewerListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get access review instance contacted reviewers. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="scheduleDefinitionId"> The id of the access review schedule definition. </param>
        /// <param name="id"> The id of the access review instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="scheduleDefinitionId"/> or <paramref name="id"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="scheduleDefinitionId"/> or <paramref name="id"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<AccessReviewContactedReviewerListResult> ListNextPage(string nextLink, string scheduleDefinitionId, string id, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(scheduleDefinitionId, nameof(scheduleDefinitionId));
            Argument.AssertNotNullOrEmpty(id, nameof(id));

            using var message = CreateListNextPageRequest(nextLink, scheduleDefinitionId, id);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AccessReviewContactedReviewerListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = AccessReviewContactedReviewerListResult.DeserializeAccessReviewContactedReviewerListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
