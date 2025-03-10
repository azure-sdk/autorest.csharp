// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using MgmtListMethods.Models;

namespace MgmtListMethods
{
    /// <summary> A class representing collection of FakeParentWithAncestorWithNonResChWithLoc and their operations over a Fake. </summary>
    public partial class FakeParentWithAncestorWithNonResChWithLocContainer : ArmContainer
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly FakeParentWithAncestorWithNonResChWithLocsRestOperations _restClient;

        /// <summary> Initializes a new instance of the <see cref="FakeParentWithAncestorWithNonResChWithLocContainer"/> class for mocking. </summary>
        protected FakeParentWithAncestorWithNonResChWithLocContainer()
        {
        }

        /// <summary> Initializes a new instance of FakeParentWithAncestorWithNonResChWithLocContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal FakeParentWithAncestorWithNonResChWithLocContainer(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _restClient = new FakeParentWithAncestorWithNonResChWithLocsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => Fake.ResourceType;

        // Container level operations.

        /// <summary> Create or update. </summary>
        /// <param name="fakeParentWithAncestorWithNonResChWithLocName"> Name. </param>
        /// <param name="parameters"> Parameters supplied to the Create. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fakeParentWithAncestorWithNonResChWithLocName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual FakeParentWithAncestorWithNonResChWithLocCreateOrUpdateOperation CreateOrUpdate(string fakeParentWithAncestorWithNonResChWithLocName, FakeParentWithAncestorWithNonResChWithLocData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (fakeParentWithAncestorWithNonResChWithLocName == null)
            {
                throw new ArgumentNullException(nameof(fakeParentWithAncestorWithNonResChWithLocName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("FakeParentWithAncestorWithNonResChWithLocContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _restClient.CreateOrUpdate(Id.Name, fakeParentWithAncestorWithNonResChWithLocName, parameters, cancellationToken);
                var operation = new FakeParentWithAncestorWithNonResChWithLocCreateOrUpdateOperation(Parent, response);
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

        /// <summary> Create or update. </summary>
        /// <param name="fakeParentWithAncestorWithNonResChWithLocName"> Name. </param>
        /// <param name="parameters"> Parameters supplied to the Create. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fakeParentWithAncestorWithNonResChWithLocName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<FakeParentWithAncestorWithNonResChWithLocCreateOrUpdateOperation> CreateOrUpdateAsync(string fakeParentWithAncestorWithNonResChWithLocName, FakeParentWithAncestorWithNonResChWithLocData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (fakeParentWithAncestorWithNonResChWithLocName == null)
            {
                throw new ArgumentNullException(nameof(fakeParentWithAncestorWithNonResChWithLocName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("FakeParentWithAncestorWithNonResChWithLocContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _restClient.CreateOrUpdateAsync(Id.Name, fakeParentWithAncestorWithNonResChWithLocName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new FakeParentWithAncestorWithNonResChWithLocCreateOrUpdateOperation(Parent, response);
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

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="fakeParentWithAncestorWithNonResChWithLocName"> Name. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<FakeParentWithAncestorWithNonResChWithLoc> Get(string fakeParentWithAncestorWithNonResChWithLocName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("FakeParentWithAncestorWithNonResChWithLocContainer.Get");
            scope.Start();
            try
            {
                if (fakeParentWithAncestorWithNonResChWithLocName == null)
                {
                    throw new ArgumentNullException(nameof(fakeParentWithAncestorWithNonResChWithLocName));
                }

                var response = _restClient.Get(Id.Name, fakeParentWithAncestorWithNonResChWithLocName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new FakeParentWithAncestorWithNonResChWithLoc(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="fakeParentWithAncestorWithNonResChWithLocName"> Name. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<FakeParentWithAncestorWithNonResChWithLoc>> GetAsync(string fakeParentWithAncestorWithNonResChWithLocName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("FakeParentWithAncestorWithNonResChWithLocContainer.Get");
            scope.Start();
            try
            {
                if (fakeParentWithAncestorWithNonResChWithLocName == null)
                {
                    throw new ArgumentNullException(nameof(fakeParentWithAncestorWithNonResChWithLocName));
                }

                var response = await _restClient.GetAsync(Id.Name, fakeParentWithAncestorWithNonResChWithLocName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new FakeParentWithAncestorWithNonResChWithLoc(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="fakeParentWithAncestorWithNonResChWithLocName"> Name. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<FakeParentWithAncestorWithNonResChWithLoc> GetIfExists(string fakeParentWithAncestorWithNonResChWithLocName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("FakeParentWithAncestorWithNonResChWithLocContainer.GetIfExists");
            scope.Start();
            try
            {
                if (fakeParentWithAncestorWithNonResChWithLocName == null)
                {
                    throw new ArgumentNullException(nameof(fakeParentWithAncestorWithNonResChWithLocName));
                }

                var response = _restClient.Get(Id.Name, fakeParentWithAncestorWithNonResChWithLocName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<FakeParentWithAncestorWithNonResChWithLoc>(null, response.GetRawResponse())
                    : Response.FromValue(new FakeParentWithAncestorWithNonResChWithLoc(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="fakeParentWithAncestorWithNonResChWithLocName"> Name. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<FakeParentWithAncestorWithNonResChWithLoc>> GetIfExistsAsync(string fakeParentWithAncestorWithNonResChWithLocName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("FakeParentWithAncestorWithNonResChWithLocContainer.GetIfExists");
            scope.Start();
            try
            {
                if (fakeParentWithAncestorWithNonResChWithLocName == null)
                {
                    throw new ArgumentNullException(nameof(fakeParentWithAncestorWithNonResChWithLocName));
                }

                var response = await _restClient.GetAsync(Id.Name, fakeParentWithAncestorWithNonResChWithLocName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<FakeParentWithAncestorWithNonResChWithLoc>(null, response.GetRawResponse())
                    : Response.FromValue(new FakeParentWithAncestorWithNonResChWithLoc(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="fakeParentWithAncestorWithNonResChWithLocName"> Name. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<bool> CheckIfExists(string fakeParentWithAncestorWithNonResChWithLocName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("FakeParentWithAncestorWithNonResChWithLocContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (fakeParentWithAncestorWithNonResChWithLocName == null)
                {
                    throw new ArgumentNullException(nameof(fakeParentWithAncestorWithNonResChWithLocName));
                }

                var response = GetIfExists(fakeParentWithAncestorWithNonResChWithLocName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="fakeParentWithAncestorWithNonResChWithLocName"> Name. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string fakeParentWithAncestorWithNonResChWithLocName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("FakeParentWithAncestorWithNonResChWithLocContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (fakeParentWithAncestorWithNonResChWithLocName == null)
                {
                    throw new ArgumentNullException(nameof(fakeParentWithAncestorWithNonResChWithLocName));
                }

                var response = await GetIfExistsAsync(fakeParentWithAncestorWithNonResChWithLocName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="FakeParentWithAncestorWithNonResChWithLoc" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<FakeParentWithAncestorWithNonResChWithLoc> GetAll(CancellationToken cancellationToken = default)
        {
            Page<FakeParentWithAncestorWithNonResChWithLoc> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("FakeParentWithAncestorWithNonResChWithLocContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.GetTest(Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new FakeParentWithAncestorWithNonResChWithLoc(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<FakeParentWithAncestorWithNonResChWithLoc> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("FakeParentWithAncestorWithNonResChWithLocContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.GetTestNextPage(nextLink, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new FakeParentWithAncestorWithNonResChWithLoc(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists all in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="FakeParentWithAncestorWithNonResChWithLoc" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<FakeParentWithAncestorWithNonResChWithLoc> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<FakeParentWithAncestorWithNonResChWithLoc>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("FakeParentWithAncestorWithNonResChWithLocContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.GetTestAsync(Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new FakeParentWithAncestorWithNonResChWithLoc(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<FakeParentWithAncestorWithNonResChWithLoc>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("FakeParentWithAncestorWithNonResChWithLocContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.GetTestNextPageAsync(nextLink, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new FakeParentWithAncestorWithNonResChWithLoc(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        // Builders.
        // public ArmBuilder<ResourceIdentifier, FakeParentWithAncestorWithNonResChWithLoc, FakeParentWithAncestorWithNonResChWithLocData> Construct() { }
    }
}
