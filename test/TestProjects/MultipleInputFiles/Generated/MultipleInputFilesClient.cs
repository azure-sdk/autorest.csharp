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
using MultipleInputFiles.Models;

namespace MultipleInputFiles
{
    /// <summary> The MultipleInputFiles service client. </summary>
    public partial class MultipleInputFilesClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal MultipleInputFilesRestClient RestClient { get; }

        /// <summary> Initializes a new instance of MultipleInputFilesClient for mocking. </summary>
        protected MultipleInputFilesClient()
        {
        }

        /// <summary> Initializes a new instance of MultipleInputFilesClient. </summary>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="source"> source - server parameter. </param>
        /// <param name="options"> The options for configuring the client. </param>
        public MultipleInputFilesClient(TokenCredential credential, Source? source = default, MultipleInputFilesClientOptions options = null)
        {
            if (credential == null)
            {
                throw new ArgumentNullException(nameof(credential));
            }
            source ??= new Source("value1");

            options ??= new MultipleInputFilesClientOptions();
            _clientDiagnostics = new ClientDiagnostics(options);
            string[] scopes = { "https://fakeendpoint.azure.com/.default" };
            _pipeline = HttpPipelineBuilder.Build(options, new BearerTokenAuthenticationPolicy(credential, scopes));
            RestClient = new MultipleInputFilesRestClient(_clientDiagnostics, _pipeline, source);
        }

        /// <summary> Initializes a new instance of MultipleInputFilesClient. </summary>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="source"> source - server parameter. </param>
        /// <param name="options"> The options for configuring the client. </param>
        public MultipleInputFilesClient(AzureKeyCredential credential, Source? source = default, MultipleInputFilesClientOptions options = null)
        {
            if (credential == null)
            {
                throw new ArgumentNullException(nameof(credential));
            }
            source ??= new Source("value1");

            options ??= new MultipleInputFilesClientOptions();
            _clientDiagnostics = new ClientDiagnostics(options);
            _pipeline = HttpPipelineBuilder.Build(options, new AzureKeyCredentialPolicy(credential, "subscription-key"));
            RestClient = new MultipleInputFilesRestClient(_clientDiagnostics, _pipeline, source);
        }

        /// <summary> Initializes a new instance of MultipleInputFilesClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="source"> source - server parameter. </param>
        internal MultipleInputFilesClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Source? source = default)
        {
            RestClient = new MultipleInputFilesRestClient(clientDiagnostics, pipeline, source);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <param name="value"> The TestModel to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> Operation1Async(TestModel value, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("MultipleInputFilesClient.Operation1");
            scope.Start();
            try
            {
                return await RestClient.Operation1Async(value, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <param name="value"> The TestModel to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Operation1(TestModel value, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("MultipleInputFilesClient.Operation1");
            scope.Start();
            try
            {
                return RestClient.Operation1(value, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <param name="value"> The TestModel to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> Operation2Async(TestModel value, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("MultipleInputFilesClient.Operation2");
            scope.Start();
            try
            {
                return await RestClient.Operation2Async(value, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <param name="value"> The TestModel to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Operation2(TestModel value, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("MultipleInputFilesClient.Operation2");
            scope.Start();
            try
            {
                return RestClient.Operation2(value, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
