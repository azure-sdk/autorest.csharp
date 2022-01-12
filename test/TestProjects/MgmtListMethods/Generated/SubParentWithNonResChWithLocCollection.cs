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
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources;
using MgmtListMethods.Models;

namespace MgmtListMethods
{
    /// <summary> A class representing collection of SubParentWithNonResChWithLoc and their operations over its parent. </summary>
    public partial class SubParentWithNonResChWithLocCollection : ArmCollection, IEnumerable<SubParentWithNonResChWithLoc>, IAsyncEnumerable<SubParentWithNonResChWithLoc>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly SubParentWithNonResChWithLocsRestOperations _subParentWithNonResChWithLocsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SubParentWithNonResChWithLocCollection"/> class for mocking. </summary>
        protected SubParentWithNonResChWithLocCollection()
        {
        }

        /// <summary> Initializes a new instance of SubParentWithNonResChWithLocCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal SubParentWithNonResChWithLocCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _subParentWithNonResChWithLocsRestClient = new SubParentWithNonResChWithLocsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != Subscription.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, Subscription.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.MgmtListMethods/subParentWithNonResChWithLocs/{subParentWithNonResChWithLocName}
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: SubParentWithNonResChWithLocs_CreateOrUpdate
        /// <summary> Create or update. </summary>
        /// <param name="subParentWithNonResChWithLocName"> Name. </param>
        /// <param name="parameters"> Parameters supplied to the Create. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subParentWithNonResChWithLocName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual SubParentWithNonResChWithLocCreateOrUpdateOperation CreateOrUpdate(string subParentWithNonResChWithLocName, SubParentWithNonResChWithLocData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (subParentWithNonResChWithLocName == null)
            {
                throw new ArgumentNullException(nameof(subParentWithNonResChWithLocName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("SubParentWithNonResChWithLocCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _subParentWithNonResChWithLocsRestClient.CreateOrUpdate(Id.SubscriptionId, subParentWithNonResChWithLocName, parameters, cancellationToken);
                var operation = new SubParentWithNonResChWithLocCreateOrUpdateOperation(Parent, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.MgmtListMethods/subParentWithNonResChWithLocs/{subParentWithNonResChWithLocName}
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: SubParentWithNonResChWithLocs_CreateOrUpdate
        /// <summary> Create or update. </summary>
        /// <param name="subParentWithNonResChWithLocName"> Name. </param>
        /// <param name="parameters"> Parameters supplied to the Create. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subParentWithNonResChWithLocName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<SubParentWithNonResChWithLocCreateOrUpdateOperation> CreateOrUpdateAsync(string subParentWithNonResChWithLocName, SubParentWithNonResChWithLocData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (subParentWithNonResChWithLocName == null)
            {
                throw new ArgumentNullException(nameof(subParentWithNonResChWithLocName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("SubParentWithNonResChWithLocCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _subParentWithNonResChWithLocsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, subParentWithNonResChWithLocName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new SubParentWithNonResChWithLocCreateOrUpdateOperation(Parent, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.MgmtListMethods/subParentWithNonResChWithLocs/{subParentWithNonResChWithLocName}
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: SubParentWithNonResChWithLocs_Get
        /// <summary> Retrieves information. </summary>
        /// <param name="subParentWithNonResChWithLocName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subParentWithNonResChWithLocName"/> is null. </exception>
        public virtual Response<SubParentWithNonResChWithLoc> Get(string subParentWithNonResChWithLocName, CancellationToken cancellationToken = default)
        {
            if (subParentWithNonResChWithLocName == null)
            {
                throw new ArgumentNullException(nameof(subParentWithNonResChWithLocName));
            }

            using var scope = _clientDiagnostics.CreateScope("SubParentWithNonResChWithLocCollection.Get");
            scope.Start();
            try
            {
                var response = _subParentWithNonResChWithLocsRestClient.Get(Id.SubscriptionId, subParentWithNonResChWithLocName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SubParentWithNonResChWithLoc(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.MgmtListMethods/subParentWithNonResChWithLocs/{subParentWithNonResChWithLocName}
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: SubParentWithNonResChWithLocs_Get
        /// <summary> Retrieves information. </summary>
        /// <param name="subParentWithNonResChWithLocName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subParentWithNonResChWithLocName"/> is null. </exception>
        public async virtual Task<Response<SubParentWithNonResChWithLoc>> GetAsync(string subParentWithNonResChWithLocName, CancellationToken cancellationToken = default)
        {
            if (subParentWithNonResChWithLocName == null)
            {
                throw new ArgumentNullException(nameof(subParentWithNonResChWithLocName));
            }

            using var scope = _clientDiagnostics.CreateScope("SubParentWithNonResChWithLocCollection.Get");
            scope.Start();
            try
            {
                var response = await _subParentWithNonResChWithLocsRestClient.GetAsync(Id.SubscriptionId, subParentWithNonResChWithLocName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new SubParentWithNonResChWithLoc(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="subParentWithNonResChWithLocName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subParentWithNonResChWithLocName"/> is null. </exception>
        public virtual Response<SubParentWithNonResChWithLoc> GetIfExists(string subParentWithNonResChWithLocName, CancellationToken cancellationToken = default)
        {
            if (subParentWithNonResChWithLocName == null)
            {
                throw new ArgumentNullException(nameof(subParentWithNonResChWithLocName));
            }

            using var scope = _clientDiagnostics.CreateScope("SubParentWithNonResChWithLocCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _subParentWithNonResChWithLocsRestClient.Get(Id.SubscriptionId, subParentWithNonResChWithLocName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<SubParentWithNonResChWithLoc>(null, response.GetRawResponse());
                return Response.FromValue(new SubParentWithNonResChWithLoc(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="subParentWithNonResChWithLocName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subParentWithNonResChWithLocName"/> is null. </exception>
        public async virtual Task<Response<SubParentWithNonResChWithLoc>> GetIfExistsAsync(string subParentWithNonResChWithLocName, CancellationToken cancellationToken = default)
        {
            if (subParentWithNonResChWithLocName == null)
            {
                throw new ArgumentNullException(nameof(subParentWithNonResChWithLocName));
            }

            using var scope = _clientDiagnostics.CreateScope("SubParentWithNonResChWithLocCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _subParentWithNonResChWithLocsRestClient.GetAsync(Id.SubscriptionId, subParentWithNonResChWithLocName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<SubParentWithNonResChWithLoc>(null, response.GetRawResponse());
                return Response.FromValue(new SubParentWithNonResChWithLoc(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="subParentWithNonResChWithLocName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subParentWithNonResChWithLocName"/> is null. </exception>
        public virtual Response<bool> Exists(string subParentWithNonResChWithLocName, CancellationToken cancellationToken = default)
        {
            if (subParentWithNonResChWithLocName == null)
            {
                throw new ArgumentNullException(nameof(subParentWithNonResChWithLocName));
            }

            using var scope = _clientDiagnostics.CreateScope("SubParentWithNonResChWithLocCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(subParentWithNonResChWithLocName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="subParentWithNonResChWithLocName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subParentWithNonResChWithLocName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string subParentWithNonResChWithLocName, CancellationToken cancellationToken = default)
        {
            if (subParentWithNonResChWithLocName == null)
            {
                throw new ArgumentNullException(nameof(subParentWithNonResChWithLocName));
            }

            using var scope = _clientDiagnostics.CreateScope("SubParentWithNonResChWithLocCollection.ExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(subParentWithNonResChWithLocName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.MgmtListMethods/subParentWithNonResChWithLocs
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: SubParentWithNonResChWithLocs_List
        /// <summary> Lists all in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SubParentWithNonResChWithLoc" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SubParentWithNonResChWithLoc> GetAll(CancellationToken cancellationToken = default)
        {
            Page<SubParentWithNonResChWithLoc> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SubParentWithNonResChWithLocCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _subParentWithNonResChWithLocsRestClient.List(Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SubParentWithNonResChWithLoc(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SubParentWithNonResChWithLoc> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SubParentWithNonResChWithLocCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _subParentWithNonResChWithLocsRestClient.ListNextPage(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SubParentWithNonResChWithLoc(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.MgmtListMethods/subParentWithNonResChWithLocs
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: SubParentWithNonResChWithLocs_List
        /// <summary> Lists all in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SubParentWithNonResChWithLoc" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SubParentWithNonResChWithLoc> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SubParentWithNonResChWithLoc>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SubParentWithNonResChWithLocCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _subParentWithNonResChWithLocsRestClient.ListAsync(Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SubParentWithNonResChWithLoc(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SubParentWithNonResChWithLoc>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SubParentWithNonResChWithLocCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _subParentWithNonResChWithLocsRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SubParentWithNonResChWithLoc(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="SubParentWithNonResChWithLoc" /> for this subscription represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SubParentWithNonResChWithLocCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(SubParentWithNonResChWithLoc.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as Subscription, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="SubParentWithNonResChWithLoc" /> for this subscription represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SubParentWithNonResChWithLocCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(SubParentWithNonResChWithLoc.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as Subscription, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SubParentWithNonResChWithLoc> IEnumerable<SubParentWithNonResChWithLoc>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SubParentWithNonResChWithLoc> IAsyncEnumerable<SubParentWithNonResChWithLoc>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, SubParentWithNonResChWithLoc, SubParentWithNonResChWithLocData> Construct() { }
    }
}
