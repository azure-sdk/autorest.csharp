// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace body_complex_LowLevel
{
    /// <summary> The Array service client. </summary>
    public partial class ArrayClient
    {
        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline { get; }
        private const string AuthorizationHeader = "Fake-Subscription-Key";
        private readonly AzureKeyCredential _keyCredential;
        private Uri endpoint;
        private readonly string apiVersion;
        private readonly ClientDiagnostics _clientDiagnostics;

        /// <summary> Initializes a new instance of ArrayClient for mocking. </summary>
        protected ArrayClient()
        {
        }

        /// <summary> Initializes a new instance of ArrayClient. </summary>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="options"> The options for configuring the client. </param>
        public ArrayClient(AzureKeyCredential credential, Uri endpoint = null, AutoRestComplexTestServiceClientOptions options = null)
        {
            if (credential == null)
            {
                throw new ArgumentNullException(nameof(credential));
            }
            endpoint ??= new Uri("http://localhost:3000");

            options ??= new AutoRestComplexTestServiceClientOptions();
            _clientDiagnostics = new ClientDiagnostics(options);
            _keyCredential = credential;
            var authPolicy = new AzureKeyCredentialPolicy(_keyCredential, AuthorizationHeader);
            Pipeline = HttpPipelineBuilder.Build(options, new HttpPipelinePolicy[] { new LowLevelCallbackPolicy() }, new HttpPipelinePolicy[] { authPolicy }, new ResponseClassifier());
            this.endpoint = endpoint;
            apiVersion = options.Version;
        }

        /// <summary> Get complex types with array property. </summary>
        /// <param name="options"> The request options. </param>
#pragma warning disable AZC0002
        public virtual async Task<Response> GetValidAsync(RequestOptions options = null)
#pragma warning restore AZC0002
        {
            options ??= new RequestOptions();
            using HttpMessage message = CreateGetValidRequest(options);
            if (options.PerCallPolicy != null)
            {
                message.SetProperty("RequestOptionsPerCallPolicyCallback", options.PerCallPolicy);
            }
            using var scope = _clientDiagnostics.CreateScope("ArrayClient.GetValid");
            scope.Start();
            try
            {
                await Pipeline.SendAsync(message, options.CancellationToken).ConfigureAwait(false);
                if (options.StatusOption == ResponseStatusOption.Default)
                {
                    switch (message.Response.Status)
                    {
                        case 200:
                            return message.Response;
                        default:
                            throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                    }
                }
                else
                {
                    return message.Response;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get complex types with array property. </summary>
        /// <param name="options"> The request options. </param>
#pragma warning disable AZC0002
        public virtual Response GetValid(RequestOptions options = null)
#pragma warning restore AZC0002
        {
            options ??= new RequestOptions();
            using HttpMessage message = CreateGetValidRequest(options);
            if (options.PerCallPolicy != null)
            {
                message.SetProperty("RequestOptionsPerCallPolicyCallback", options.PerCallPolicy);
            }
            using var scope = _clientDiagnostics.CreateScope("ArrayClient.GetValid");
            scope.Start();
            try
            {
                Pipeline.Send(message, options.CancellationToken);
                if (options.StatusOption == ResponseStatusOption.Default)
                {
                    switch (message.Response.Status)
                    {
                        case 200:
                            return message.Response;
                        default:
                            throw _clientDiagnostics.CreateRequestFailedException(message.Response);
                    }
                }
                else
                {
                    return message.Response;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create Request for <see cref="GetValid"/> and <see cref="GetValidAsync"/> operations. </summary>
        /// <param name="options"> The request options. </param>
        private HttpMessage CreateGetValidRequest(RequestOptions options = null)
        {
            var message = Pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/complex/array/valid", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Put complex types with array property. </summary>
        /// <remarks>
        /// Schema for <c>Request Body</c>:
        /// <list type="table">
        ///   <listheader>
        ///     <term>Name</term>
        ///     <term>Type</term>
        ///     <term>Required</term>
        ///     <term>Description</term>
        ///   </listheader>
        ///   <item>
        ///     <term>array</term>
        ///     <term>string[]</term>
        ///     <term></term>
        ///     <term></term>
        ///   </item>
        /// </list>
        /// </remarks>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options. </param>
#pragma warning disable AZC0002
        public virtual async Task<Response> PutValidAsync(RequestContent content, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            options ??= new RequestOptions();
            using HttpMessage message = CreatePutValidRequest(content, options);
            if (options.PerCallPolicy != null)
            {
                message.SetProperty("RequestOptionsPerCallPolicyCallback", options.PerCallPolicy);
            }
            using var scope = _clientDiagnostics.CreateScope("ArrayClient.PutValid");
            scope.Start();
            try
            {
                await Pipeline.SendAsync(message, options.CancellationToken).ConfigureAwait(false);
                if (options.StatusOption == ResponseStatusOption.Default)
                {
                    switch (message.Response.Status)
                    {
                        case 200:
                            return message.Response;
                        default:
                            throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                    }
                }
                else
                {
                    return message.Response;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Put complex types with array property. </summary>
        /// <remarks>
        /// Schema for <c>Request Body</c>:
        /// <list type="table">
        ///   <listheader>
        ///     <term>Name</term>
        ///     <term>Type</term>
        ///     <term>Required</term>
        ///     <term>Description</term>
        ///   </listheader>
        ///   <item>
        ///     <term>array</term>
        ///     <term>string[]</term>
        ///     <term></term>
        ///     <term></term>
        ///   </item>
        /// </list>
        /// </remarks>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options. </param>
#pragma warning disable AZC0002
        public virtual Response PutValid(RequestContent content, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            options ??= new RequestOptions();
            using HttpMessage message = CreatePutValidRequest(content, options);
            if (options.PerCallPolicy != null)
            {
                message.SetProperty("RequestOptionsPerCallPolicyCallback", options.PerCallPolicy);
            }
            using var scope = _clientDiagnostics.CreateScope("ArrayClient.PutValid");
            scope.Start();
            try
            {
                Pipeline.Send(message, options.CancellationToken);
                if (options.StatusOption == ResponseStatusOption.Default)
                {
                    switch (message.Response.Status)
                    {
                        case 200:
                            return message.Response;
                        default:
                            throw _clientDiagnostics.CreateRequestFailedException(message.Response);
                    }
                }
                else
                {
                    return message.Response;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create Request for <see cref="PutValid"/> and <see cref="PutValidAsync"/> operations. </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options. </param>
        private HttpMessage CreatePutValidRequest(RequestContent content, RequestOptions options = null)
        {
            var message = Pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/complex/array/valid", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            request.Content = content;
            return message;
        }

        /// <summary> Get complex types with array property which is empty. </summary>
        /// <param name="options"> The request options. </param>
#pragma warning disable AZC0002
        public virtual async Task<Response> GetEmptyAsync(RequestOptions options = null)
#pragma warning restore AZC0002
        {
            options ??= new RequestOptions();
            using HttpMessage message = CreateGetEmptyRequest(options);
            if (options.PerCallPolicy != null)
            {
                message.SetProperty("RequestOptionsPerCallPolicyCallback", options.PerCallPolicy);
            }
            using var scope = _clientDiagnostics.CreateScope("ArrayClient.GetEmpty");
            scope.Start();
            try
            {
                await Pipeline.SendAsync(message, options.CancellationToken).ConfigureAwait(false);
                if (options.StatusOption == ResponseStatusOption.Default)
                {
                    switch (message.Response.Status)
                    {
                        case 200:
                            return message.Response;
                        default:
                            throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                    }
                }
                else
                {
                    return message.Response;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get complex types with array property which is empty. </summary>
        /// <param name="options"> The request options. </param>
#pragma warning disable AZC0002
        public virtual Response GetEmpty(RequestOptions options = null)
#pragma warning restore AZC0002
        {
            options ??= new RequestOptions();
            using HttpMessage message = CreateGetEmptyRequest(options);
            if (options.PerCallPolicy != null)
            {
                message.SetProperty("RequestOptionsPerCallPolicyCallback", options.PerCallPolicy);
            }
            using var scope = _clientDiagnostics.CreateScope("ArrayClient.GetEmpty");
            scope.Start();
            try
            {
                Pipeline.Send(message, options.CancellationToken);
                if (options.StatusOption == ResponseStatusOption.Default)
                {
                    switch (message.Response.Status)
                    {
                        case 200:
                            return message.Response;
                        default:
                            throw _clientDiagnostics.CreateRequestFailedException(message.Response);
                    }
                }
                else
                {
                    return message.Response;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create Request for <see cref="GetEmpty"/> and <see cref="GetEmptyAsync"/> operations. </summary>
        /// <param name="options"> The request options. </param>
        private HttpMessage CreateGetEmptyRequest(RequestOptions options = null)
        {
            var message = Pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/complex/array/empty", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Put complex types with array property which is empty. </summary>
        /// <remarks>
        /// Schema for <c>Request Body</c>:
        /// <list type="table">
        ///   <listheader>
        ///     <term>Name</term>
        ///     <term>Type</term>
        ///     <term>Required</term>
        ///     <term>Description</term>
        ///   </listheader>
        ///   <item>
        ///     <term>array</term>
        ///     <term>string[]</term>
        ///     <term></term>
        ///     <term></term>
        ///   </item>
        /// </list>
        /// </remarks>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options. </param>
#pragma warning disable AZC0002
        public virtual async Task<Response> PutEmptyAsync(RequestContent content, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            options ??= new RequestOptions();
            using HttpMessage message = CreatePutEmptyRequest(content, options);
            if (options.PerCallPolicy != null)
            {
                message.SetProperty("RequestOptionsPerCallPolicyCallback", options.PerCallPolicy);
            }
            using var scope = _clientDiagnostics.CreateScope("ArrayClient.PutEmpty");
            scope.Start();
            try
            {
                await Pipeline.SendAsync(message, options.CancellationToken).ConfigureAwait(false);
                if (options.StatusOption == ResponseStatusOption.Default)
                {
                    switch (message.Response.Status)
                    {
                        case 200:
                            return message.Response;
                        default:
                            throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                    }
                }
                else
                {
                    return message.Response;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Put complex types with array property which is empty. </summary>
        /// <remarks>
        /// Schema for <c>Request Body</c>:
        /// <list type="table">
        ///   <listheader>
        ///     <term>Name</term>
        ///     <term>Type</term>
        ///     <term>Required</term>
        ///     <term>Description</term>
        ///   </listheader>
        ///   <item>
        ///     <term>array</term>
        ///     <term>string[]</term>
        ///     <term></term>
        ///     <term></term>
        ///   </item>
        /// </list>
        /// </remarks>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options. </param>
#pragma warning disable AZC0002
        public virtual Response PutEmpty(RequestContent content, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            options ??= new RequestOptions();
            using HttpMessage message = CreatePutEmptyRequest(content, options);
            if (options.PerCallPolicy != null)
            {
                message.SetProperty("RequestOptionsPerCallPolicyCallback", options.PerCallPolicy);
            }
            using var scope = _clientDiagnostics.CreateScope("ArrayClient.PutEmpty");
            scope.Start();
            try
            {
                Pipeline.Send(message, options.CancellationToken);
                if (options.StatusOption == ResponseStatusOption.Default)
                {
                    switch (message.Response.Status)
                    {
                        case 200:
                            return message.Response;
                        default:
                            throw _clientDiagnostics.CreateRequestFailedException(message.Response);
                    }
                }
                else
                {
                    return message.Response;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create Request for <see cref="PutEmpty"/> and <see cref="PutEmptyAsync"/> operations. </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options. </param>
        private HttpMessage CreatePutEmptyRequest(RequestContent content, RequestOptions options = null)
        {
            var message = Pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/complex/array/empty", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            request.Content = content;
            return message;
        }

        /// <summary> Get complex types with array property while server doesn&apos;t provide a response payload. </summary>
        /// <param name="options"> The request options. </param>
#pragma warning disable AZC0002
        public virtual async Task<Response> GetNotProvidedAsync(RequestOptions options = null)
#pragma warning restore AZC0002
        {
            options ??= new RequestOptions();
            using HttpMessage message = CreateGetNotProvidedRequest(options);
            if (options.PerCallPolicy != null)
            {
                message.SetProperty("RequestOptionsPerCallPolicyCallback", options.PerCallPolicy);
            }
            using var scope = _clientDiagnostics.CreateScope("ArrayClient.GetNotProvided");
            scope.Start();
            try
            {
                await Pipeline.SendAsync(message, options.CancellationToken).ConfigureAwait(false);
                if (options.StatusOption == ResponseStatusOption.Default)
                {
                    switch (message.Response.Status)
                    {
                        case 200:
                            return message.Response;
                        default:
                            throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                    }
                }
                else
                {
                    return message.Response;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get complex types with array property while server doesn&apos;t provide a response payload. </summary>
        /// <param name="options"> The request options. </param>
#pragma warning disable AZC0002
        public virtual Response GetNotProvided(RequestOptions options = null)
#pragma warning restore AZC0002
        {
            options ??= new RequestOptions();
            using HttpMessage message = CreateGetNotProvidedRequest(options);
            if (options.PerCallPolicy != null)
            {
                message.SetProperty("RequestOptionsPerCallPolicyCallback", options.PerCallPolicy);
            }
            using var scope = _clientDiagnostics.CreateScope("ArrayClient.GetNotProvided");
            scope.Start();
            try
            {
                Pipeline.Send(message, options.CancellationToken);
                if (options.StatusOption == ResponseStatusOption.Default)
                {
                    switch (message.Response.Status)
                    {
                        case 200:
                            return message.Response;
                        default:
                            throw _clientDiagnostics.CreateRequestFailedException(message.Response);
                    }
                }
                else
                {
                    return message.Response;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create Request for <see cref="GetNotProvided"/> and <see cref="GetNotProvidedAsync"/> operations. </summary>
        /// <param name="options"> The request options. </param>
        private HttpMessage CreateGetNotProvidedRequest(RequestOptions options = null)
        {
            var message = Pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/complex/array/notprovided", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }
    }
}
