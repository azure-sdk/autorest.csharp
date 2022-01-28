// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using SupersetInheritance;

namespace SupersetInheritance.Models
{
    public partial class SupersetModel6CreateOrUpdateOperation : Operation<SupersetModel6>
    {
        private readonly OperationOrResponseInternals<SupersetModel6> _operation;

        /// <summary> Initializes a new instance of SupersetModel6CreateOrUpdateOperation for mocking. </summary>
        protected SupersetModel6CreateOrUpdateOperation()
        {
        }

        internal SupersetModel6CreateOrUpdateOperation(ArmClient armClient, Response<SupersetModel6Data> response)
        {
            _operation = new OperationOrResponseInternals<SupersetModel6>(Response.FromValue(new SupersetModel6(armClient, response.Value), response.GetRawResponse()));
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override SupersetModel6 Value => _operation.Value;

        /// <inheritdoc />
        public override bool HasCompleted => _operation.HasCompleted;

        /// <inheritdoc />
        public override bool HasValue => _operation.HasValue;

        /// <inheritdoc />
        public override Response GetRawResponse() => _operation.GetRawResponse();

        /// <inheritdoc />
        public override Response UpdateStatus(CancellationToken cancellationToken = default) => _operation.UpdateStatus(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response> UpdateStatusAsync(CancellationToken cancellationToken = default) => _operation.UpdateStatusAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<SupersetModel6>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<SupersetModel6>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);
    }
}
