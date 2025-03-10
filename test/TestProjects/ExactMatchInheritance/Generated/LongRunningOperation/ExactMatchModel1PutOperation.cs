// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Core;
using ExactMatchInheritance;

namespace ExactMatchInheritance.Models
{
    public partial class ExactMatchModel1PutOperation : Operation<ExactMatchModel1>
    {
        private readonly OperationOrResponseInternals<ExactMatchModel1> _operation;

        /// <summary> Initializes a new instance of ExactMatchModel1PutOperation for mocking. </summary>
        protected ExactMatchModel1PutOperation()
        {
        }

        internal ExactMatchModel1PutOperation(ArmResource operationsBase, Response<ExactMatchModel1Data> response)
        {
            _operation = new OperationOrResponseInternals<ExactMatchModel1>(Response.FromValue(new ExactMatchModel1(operationsBase, response.Value), response.GetRawResponse()));
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override ExactMatchModel1 Value => _operation.Value;

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
        public override ValueTask<Response<ExactMatchModel1>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<ExactMatchModel1>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);
    }
}
