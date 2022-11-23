// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Pagination.Models;

namespace Pagination
{
    // Data plane generated client. The Pagination service client.
    /// <summary> The Pagination service client. </summary>
    public partial class PaginationClient
    {
        private static readonly string[] AuthorizationScopes = new string[] { "https://pagination.azure.com/.default" };
        private readonly TokenCredential _tokenCredential;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of PaginationClient for mocking. </summary>
        protected PaginationClient()
        {
        }

        /// <summary> Initializes a new instance of PaginationClient. </summary>
        /// <param name="endpoint"> The Uri to use. </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> or <paramref name="credential"/> is null. </exception>
        public PaginationClient(Uri endpoint, TokenCredential credential) : this(endpoint, credential, new PaginationClientOptions())
        {
        }

        /// <summary> Initializes a new instance of PaginationClient. </summary>
        /// <param name="endpoint"> The Uri to use. </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="options"> The options for configuring the client. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> or <paramref name="credential"/> is null. </exception>
        public PaginationClient(Uri endpoint, TokenCredential credential, PaginationClientOptions options)
        {
            Argument.AssertNotNull(endpoint, nameof(endpoint));
            Argument.AssertNotNull(credential, nameof(credential));
            options ??= new PaginationClientOptions();

            ClientDiagnostics = new ClientDiagnostics(options, true);
            _tokenCredential = credential;
            _pipeline = HttpPipelineBuilder.Build(options, Array.Empty<HttpPipelinePolicy>(), new HttpPipelinePolicy[] { new BearerTokenAuthenticationPolicy(_tokenCredential, AuthorizationScopes) }, new ResponseClassifier());
            _endpoint = endpoint;
            _apiVersion = options.Version;
        }

        /// <summary> Gets ledger entries from a collection corresponding to a range. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks> A collection id may optionally be specified. Only entries in the specified (or default) collection will be returned. </remarks>
        public virtual AsyncPageable<LedgerEntry> GetLedgerEntryValuesAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<LedgerEntry>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = ClientDiagnostics.CreateScope("PaginationClient.GetLedgerEntryValues");
                scope.Start();
                try
                {
                    var response = await GetLedgerEntriesFirstPageAsync(cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<LedgerEntry>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = ClientDiagnostics.CreateScope("PaginationClient.GetLedgerEntryValues");
                scope.Start();
                try
                {
                    var response = await GetLedgerEntriesNextPageAsync(nextLink, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets ledger entries from a collection corresponding to a range. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks> A collection id may optionally be specified. Only entries in the specified (or default) collection will be returned. </remarks>
        public virtual Pageable<LedgerEntry> GetLedgerEntryValues(CancellationToken cancellationToken = default)
        {
            Page<LedgerEntry> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = ClientDiagnostics.CreateScope("PaginationClient.GetLedgerEntryValues");
                scope.Start();
                try
                {
                    var response = GetLedgerEntriesFirstPage(cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<LedgerEntry> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = ClientDiagnostics.CreateScope("PaginationClient.GetLedgerEntryValues");
                scope.Start();
                try
                {
                    var response = GetLedgerEntriesNextPage(nextLink, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets ledger entries from a collection corresponding to a range. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks> A collection id may optionally be specified. Only entries in the specified (or default) collection will be returned. </remarks>
        private async Task<Response<CustomPage>> GetLedgerEntriesFirstPageAsync(CancellationToken cancellationToken = default)
        {
            RequestContext context = FromCancellationToken(cancellationToken);
            using var message = CreateGetLedgerEntriesRequest(context);
            Response response = await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            return Response.FromValue(CustomPage.FromResponse(response), response);
        }

        /// <summary> Gets ledger entries from a collection corresponding to a range. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks> A collection id may optionally be specified. Only entries in the specified (or default) collection will be returned. </remarks>
        private Response<CustomPage> GetLedgerEntriesFirstPage(CancellationToken cancellationToken = default)
        {
            RequestContext context = FromCancellationToken(cancellationToken);
            using var message = CreateGetLedgerEntriesRequest(context);
            Response response = _pipeline.ProcessMessage(message, context);
            return Response.FromValue(CustomPage.FromResponse(response), response);
        }

        /// <summary> Gets ledger entries from a collection corresponding to a range. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> is null. </exception>
        /// <remarks> A collection id may optionally be specified. Only entries in the specified (or default) collection will be returned. </remarks>
        private async Task<Response<CustomPage>> GetLedgerEntriesNextPageAsync(string nextLink, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            RequestContext context = FromCancellationToken(cancellationToken);
            using var message = CreateGetLedgerEntriesNextPageRequest(nextLink, context);
            Response response = await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            return Response.FromValue(CustomPage.FromResponse(response), response);
        }

        /// <summary> Gets ledger entries from a collection corresponding to a range. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> is null. </exception>
        /// <remarks> A collection id may optionally be specified. Only entries in the specified (or default) collection will be returned. </remarks>
        private Response<CustomPage> GetLedgerEntriesNextPage(string nextLink, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            RequestContext context = FromCancellationToken(cancellationToken);
            using var message = CreateGetLedgerEntriesNextPageRequest(nextLink, context);
            Response response = _pipeline.ProcessMessage(message, context);
            return Response.FromValue(CustomPage.FromResponse(response), response);
        }

        /// <summary> List upload detail for the discovery resource. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<LedgerEntry> GetPaginationClientValuesAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<LedgerEntry>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = ClientDiagnostics.CreateScope("PaginationClient.GetPaginationClientValues");
                scope.Start();
                try
                {
                    var response = await GetPaginationClientsFirstPageAsync(cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<LedgerEntry>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = ClientDiagnostics.CreateScope("PaginationClient.GetPaginationClientValues");
                scope.Start();
                try
                {
                    var response = await GetPaginationClientsNextPageAsync(nextLink, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> List upload detail for the discovery resource. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<LedgerEntry> GetPaginationClientValues(CancellationToken cancellationToken = default)
        {
            Page<LedgerEntry> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = ClientDiagnostics.CreateScope("PaginationClient.GetPaginationClientValues");
                scope.Start();
                try
                {
                    var response = GetPaginationClientsFirstPage(cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<LedgerEntry> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = ClientDiagnostics.CreateScope("PaginationClient.GetPaginationClientValues");
                scope.Start();
                try
                {
                    var response = GetPaginationClientsNextPage(nextLink, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> List upload detail for the discovery resource. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        private async Task<Response<PagedLedgerEntry>> GetPaginationClientsFirstPageAsync(CancellationToken cancellationToken = default)
        {
            RequestContext context = FromCancellationToken(cancellationToken);
            using var message = CreateGetPaginationClientsRequest(context);
            Response response = await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            return Response.FromValue(PagedLedgerEntry.FromResponse(response), response);
        }

        /// <summary> List upload detail for the discovery resource. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        private Response<PagedLedgerEntry> GetPaginationClientsFirstPage(CancellationToken cancellationToken = default)
        {
            RequestContext context = FromCancellationToken(cancellationToken);
            using var message = CreateGetPaginationClientsRequest(context);
            Response response = _pipeline.ProcessMessage(message, context);
            return Response.FromValue(PagedLedgerEntry.FromResponse(response), response);
        }

        /// <summary> List upload detail for the discovery resource. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> is null. </exception>
        private async Task<Response<PagedLedgerEntry>> GetPaginationClientsNextPageAsync(string nextLink, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            RequestContext context = FromCancellationToken(cancellationToken);
            using var message = CreateGetPaginationClientsNextPageRequest(nextLink, context);
            Response response = await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            return Response.FromValue(PagedLedgerEntry.FromResponse(response), response);
        }

        /// <summary> List upload detail for the discovery resource. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> is null. </exception>
        private Response<PagedLedgerEntry> GetPaginationClientsNextPage(string nextLink, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            RequestContext context = FromCancellationToken(cancellationToken);
            using var message = CreateGetPaginationClientsNextPageRequest(nextLink, context);
            Response response = _pipeline.ProcessMessage(message, context);
            return Response.FromValue(PagedLedgerEntry.FromResponse(response), response);
        }

        /// <summary> Gets ledger entries from a collection corresponding to a range. </summary>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The <see cref="AsyncPageable{T}"/> from the service containing a list of <see cref="BinaryData"/> objects. Details of the body schema for each item in the collection are in the Remarks section below. </returns>
        /// <include file="Docs/PaginationClient.xml" path="doc/members/member[@name='GetLedgerEntriesAsync(RequestContext)']/*" />
        public virtual AsyncPageable<BinaryData> GetLedgerEntriesAsync(RequestContext context = null)
        {
            return GetLedgerEntriesImplementationAsync("PaginationClient.GetLedgerEntries", context);
        }

        private AsyncPageable<BinaryData> GetLedgerEntriesImplementationAsync(string diagnosticsScopeName, RequestContext context)
        {
            return PageableHelpers.CreateAsyncPageable(CreateEnumerableAsync, ClientDiagnostics, diagnosticsScopeName);
            async IAsyncEnumerable<Page<BinaryData>> CreateEnumerableAsync(string nextLink, int? pageSizeHint, [EnumeratorCancellation] CancellationToken cancellationToken = default)
            {
                do
                {
                    var message = string.IsNullOrEmpty(nextLink)
                        ? CreateGetLedgerEntriesRequest(context)
                        : CreateGetLedgerEntriesNextPageRequest(nextLink, context);
                    var page = await LowLevelPageableHelpers.ProcessMessageAsync(_pipeline, message, context, "value", "nextLink", cancellationToken).ConfigureAwait(false);
                    nextLink = page.ContinuationToken;
                    yield return page;
                } while (!string.IsNullOrEmpty(nextLink));
            }
        }

        /// <summary> Gets ledger entries from a collection corresponding to a range. </summary>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The <see cref="Pageable{T}"/> from the service containing a list of <see cref="BinaryData"/> objects. Details of the body schema for each item in the collection are in the Remarks section below. </returns>
        /// <include file="Docs/PaginationClient.xml" path="doc/members/member[@name='GetLedgerEntries(RequestContext)']/*" />
        public virtual Pageable<BinaryData> GetLedgerEntries(RequestContext context = null)
        {
            return GetLedgerEntriesImplementation("PaginationClient.GetLedgerEntries", context);
        }

        private Pageable<BinaryData> GetLedgerEntriesImplementation(string diagnosticsScopeName, RequestContext context)
        {
            return PageableHelpers.CreatePageable(CreateEnumerable, ClientDiagnostics, diagnosticsScopeName);
            IEnumerable<Page<BinaryData>> CreateEnumerable(string nextLink, int? pageSizeHint)
            {
                do
                {
                    var message = string.IsNullOrEmpty(nextLink)
                        ? CreateGetLedgerEntriesRequest(context)
                        : CreateGetLedgerEntriesNextPageRequest(nextLink, context);
                    var page = LowLevelPageableHelpers.ProcessMessage(_pipeline, message, context, "value", "nextLink");
                    nextLink = page.ContinuationToken;
                    yield return page;
                } while (!string.IsNullOrEmpty(nextLink));
            }
        }

        /// <summary> List upload detail for the discovery resource. </summary>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The <see cref="AsyncPageable{T}"/> from the service containing a list of <see cref="BinaryData"/> objects. Details of the body schema for each item in the collection are in the Remarks section below. </returns>
        /// <include file="Docs/PaginationClient.xml" path="doc/members/member[@name='GetPaginationClientsAsync(RequestContext)']/*" />
        public virtual AsyncPageable<BinaryData> GetPaginationClientsAsync(RequestContext context = null)
        {
            return GetPaginationClientsImplementationAsync("PaginationClient.GetPaginationClients", context);
        }

        private AsyncPageable<BinaryData> GetPaginationClientsImplementationAsync(string diagnosticsScopeName, RequestContext context)
        {
            return PageableHelpers.CreateAsyncPageable(CreateEnumerableAsync, ClientDiagnostics, diagnosticsScopeName);
            async IAsyncEnumerable<Page<BinaryData>> CreateEnumerableAsync(string nextLink, int? pageSizeHint, [EnumeratorCancellation] CancellationToken cancellationToken = default)
            {
                do
                {
                    var message = string.IsNullOrEmpty(nextLink)
                        ? CreateGetPaginationClientsRequest(context)
                        : CreateGetPaginationClientsNextPageRequest(nextLink, context);
                    var page = await LowLevelPageableHelpers.ProcessMessageAsync(_pipeline, message, context, "value", "nextLink", cancellationToken).ConfigureAwait(false);
                    nextLink = page.ContinuationToken;
                    yield return page;
                } while (!string.IsNullOrEmpty(nextLink));
            }
        }

        /// <summary> List upload detail for the discovery resource. </summary>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The <see cref="Pageable{T}"/> from the service containing a list of <see cref="BinaryData"/> objects. Details of the body schema for each item in the collection are in the Remarks section below. </returns>
        /// <include file="Docs/PaginationClient.xml" path="doc/members/member[@name='GetPaginationClients(RequestContext)']/*" />
        public virtual Pageable<BinaryData> GetPaginationClients(RequestContext context = null)
        {
            return GetPaginationClientsImplementation("PaginationClient.GetPaginationClients", context);
        }

        private Pageable<BinaryData> GetPaginationClientsImplementation(string diagnosticsScopeName, RequestContext context)
        {
            return PageableHelpers.CreatePageable(CreateEnumerable, ClientDiagnostics, diagnosticsScopeName);
            IEnumerable<Page<BinaryData>> CreateEnumerable(string nextLink, int? pageSizeHint)
            {
                do
                {
                    var message = string.IsNullOrEmpty(nextLink)
                        ? CreateGetPaginationClientsRequest(context)
                        : CreateGetPaginationClientsNextPageRequest(nextLink, context);
                    var page = LowLevelPageableHelpers.ProcessMessage(_pipeline, message, context, "value", "nextLink");
                    nextLink = page.ContinuationToken;
                    yield return page;
                } while (!string.IsNullOrEmpty(nextLink));
            }
        }

        internal HttpMessage CreateGetLedgerEntriesRequest(RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/app/transactions", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreateGetPaginationClientsRequest(RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/app/adp/transactions", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreateGetLedgerEntriesNextPageRequest(string nextLink, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreateGetPaginationClientsNextPageRequest(string nextLink, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        private static RequestContext DefaultRequestContext = new RequestContext();
        internal static RequestContext FromCancellationToken(CancellationToken cancellationToken = default)
        {
            if (!cancellationToken.CanBeCanceled)
            {
                return DefaultRequestContext;
            }

            return new RequestContext() { CancellationToken = cancellationToken };
        }

        private static ResponseClassifier _responseClassifier200;
        private static ResponseClassifier ResponseClassifier200 => _responseClassifier200 ??= new StatusCodeClassifier(stackalloc ushort[] { 200 });
    }
}
