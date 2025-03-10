// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using azure_parameter_grouping.Models;

namespace azure_parameter_grouping
{
    internal partial class ParameterGroupingRestClient
    {
        private Uri endpoint;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of ParameterGroupingRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. </param>
        public ParameterGroupingRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint = null)
        {
            this.endpoint = endpoint ?? new Uri("http://localhost:3000");
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreatePostRequiredRequest(ParameterGroupingPostRequiredParameters parameterGroupingPostRequiredParameters)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/parameterGrouping/postRequired/", false);
            uri.AppendPath(parameterGroupingPostRequiredParameters.Path, true);
            if (parameterGroupingPostRequiredParameters?.Query != null)
            {
                uri.AppendQuery("query", parameterGroupingPostRequiredParameters.Query.Value, true);
            }
            request.Uri = uri;
            if (parameterGroupingPostRequiredParameters?.CustomHeader != null)
            {
                request.Headers.Add("customHeader", parameterGroupingPostRequiredParameters.CustomHeader);
            }
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteNumberValue(parameterGroupingPostRequiredParameters.Body);
            request.Content = content;
            return message;
        }

        /// <summary> Post a bunch of required parameters grouped. </summary>
        /// <param name="parameterGroupingPostRequiredParameters"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameterGroupingPostRequiredParameters"/> is null. </exception>
        public async Task<Response> PostRequiredAsync(ParameterGroupingPostRequiredParameters parameterGroupingPostRequiredParameters, CancellationToken cancellationToken = default)
        {
            if (parameterGroupingPostRequiredParameters == null)
            {
                throw new ArgumentNullException(nameof(parameterGroupingPostRequiredParameters));
            }

            using var message = CreatePostRequiredRequest(parameterGroupingPostRequiredParameters);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Post a bunch of required parameters grouped. </summary>
        /// <param name="parameterGroupingPostRequiredParameters"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameterGroupingPostRequiredParameters"/> is null. </exception>
        public Response PostRequired(ParameterGroupingPostRequiredParameters parameterGroupingPostRequiredParameters, CancellationToken cancellationToken = default)
        {
            if (parameterGroupingPostRequiredParameters == null)
            {
                throw new ArgumentNullException(nameof(parameterGroupingPostRequiredParameters));
            }

            using var message = CreatePostRequiredRequest(parameterGroupingPostRequiredParameters);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreatePostOptionalRequest(ParameterGroupingPostOptionalParameters parameterGroupingPostOptionalParameters)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/parameterGrouping/postOptional", false);
            if (parameterGroupingPostOptionalParameters?.Query != null)
            {
                uri.AppendQuery("query", parameterGroupingPostOptionalParameters.Query.Value, true);
            }
            request.Uri = uri;
            if (parameterGroupingPostOptionalParameters?.CustomHeader != null)
            {
                request.Headers.Add("customHeader", parameterGroupingPostOptionalParameters.CustomHeader);
            }
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Post a bunch of optional parameters grouped. </summary>
        /// <param name="parameterGroupingPostOptionalParameters"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response> PostOptionalAsync(ParameterGroupingPostOptionalParameters parameterGroupingPostOptionalParameters = null, CancellationToken cancellationToken = default)
        {
            using var message = CreatePostOptionalRequest(parameterGroupingPostOptionalParameters);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Post a bunch of optional parameters grouped. </summary>
        /// <param name="parameterGroupingPostOptionalParameters"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response PostOptional(ParameterGroupingPostOptionalParameters parameterGroupingPostOptionalParameters = null, CancellationToken cancellationToken = default)
        {
            using var message = CreatePostOptionalRequest(parameterGroupingPostOptionalParameters);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreatePostReservedWordsRequest(ParameterGroupingPostReservedWordsParameters parameterGroupingPostReservedWordsParameters)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/parameterGrouping/postReservedWords", false);
            if (parameterGroupingPostReservedWordsParameters?.From != null)
            {
                uri.AppendQuery("from", parameterGroupingPostReservedWordsParameters.From, true);
            }
            if (parameterGroupingPostReservedWordsParameters?.Accept != null)
            {
                uri.AppendQuery("accept", parameterGroupingPostReservedWordsParameters.Accept, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Post a grouped parameters with reserved words. </summary>
        /// <param name="parameterGroupingPostReservedWordsParameters"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response> PostReservedWordsAsync(ParameterGroupingPostReservedWordsParameters parameterGroupingPostReservedWordsParameters = null, CancellationToken cancellationToken = default)
        {
            using var message = CreatePostReservedWordsRequest(parameterGroupingPostReservedWordsParameters);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Post a grouped parameters with reserved words. </summary>
        /// <param name="parameterGroupingPostReservedWordsParameters"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response PostReservedWords(ParameterGroupingPostReservedWordsParameters parameterGroupingPostReservedWordsParameters = null, CancellationToken cancellationToken = default)
        {
            using var message = CreatePostReservedWordsRequest(parameterGroupingPostReservedWordsParameters);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreatePostMultiParamGroupsRequest(FirstParameterGroup firstParameterGroup, ParameterGroupingPostMultiParamGroupsSecondParamGroup parameterGroupingPostMultiParamGroupsSecondParamGroup)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/parameterGrouping/postMultipleParameterGroups", false);
            if (firstParameterGroup?.QueryOne != null)
            {
                uri.AppendQuery("query-one", firstParameterGroup.QueryOne.Value, true);
            }
            if (parameterGroupingPostMultiParamGroupsSecondParamGroup?.QueryTwo != null)
            {
                uri.AppendQuery("query-two", parameterGroupingPostMultiParamGroupsSecondParamGroup.QueryTwo.Value, true);
            }
            request.Uri = uri;
            if (firstParameterGroup?.HeaderOne != null)
            {
                request.Headers.Add("header-one", firstParameterGroup.HeaderOne);
            }
            if (parameterGroupingPostMultiParamGroupsSecondParamGroup?.HeaderTwo != null)
            {
                request.Headers.Add("header-two", parameterGroupingPostMultiParamGroupsSecondParamGroup.HeaderTwo);
            }
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Post parameters from multiple different parameter groups. </summary>
        /// <param name="firstParameterGroup"> Parameter group. </param>
        /// <param name="parameterGroupingPostMultiParamGroupsSecondParamGroup"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response> PostMultiParamGroupsAsync(FirstParameterGroup firstParameterGroup = null, ParameterGroupingPostMultiParamGroupsSecondParamGroup parameterGroupingPostMultiParamGroupsSecondParamGroup = null, CancellationToken cancellationToken = default)
        {
            using var message = CreatePostMultiParamGroupsRequest(firstParameterGroup, parameterGroupingPostMultiParamGroupsSecondParamGroup);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Post parameters from multiple different parameter groups. </summary>
        /// <param name="firstParameterGroup"> Parameter group. </param>
        /// <param name="parameterGroupingPostMultiParamGroupsSecondParamGroup"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response PostMultiParamGroups(FirstParameterGroup firstParameterGroup = null, ParameterGroupingPostMultiParamGroupsSecondParamGroup parameterGroupingPostMultiParamGroupsSecondParamGroup = null, CancellationToken cancellationToken = default)
        {
            using var message = CreatePostMultiParamGroupsRequest(firstParameterGroup, parameterGroupingPostMultiParamGroupsSecondParamGroup);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreatePostSharedParameterGroupObjectRequest(FirstParameterGroup firstParameterGroup)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/parameterGrouping/sharedParameterGroupObject", false);
            if (firstParameterGroup?.QueryOne != null)
            {
                uri.AppendQuery("query-one", firstParameterGroup.QueryOne.Value, true);
            }
            request.Uri = uri;
            if (firstParameterGroup?.HeaderOne != null)
            {
                request.Headers.Add("header-one", firstParameterGroup.HeaderOne);
            }
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Post parameters with a shared parameter group object. </summary>
        /// <param name="firstParameterGroup"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response> PostSharedParameterGroupObjectAsync(FirstParameterGroup firstParameterGroup = null, CancellationToken cancellationToken = default)
        {
            using var message = CreatePostSharedParameterGroupObjectRequest(firstParameterGroup);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Post parameters with a shared parameter group object. </summary>
        /// <param name="firstParameterGroup"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response PostSharedParameterGroupObject(FirstParameterGroup firstParameterGroup = null, CancellationToken cancellationToken = default)
        {
            using var message = CreatePostSharedParameterGroupObjectRequest(firstParameterGroup);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
