// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using lrotsp;

namespace lrotsp.Models
{
    /// <summary> The inference results for the Radiology Insights request. </summary>
    public partial class RadiologyInsightsInferenceResult
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="RadiologyInsightsInferenceResult"/>. </summary>
        /// <param name="id"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        internal RadiologyInsightsInferenceResult(string id)
        {
            Argument.AssertNotNull(id, nameof(id));

            Id = id;
        }

        /// <summary> Initializes a new instance of <see cref="RadiologyInsightsInferenceResult"/>. </summary>
        /// <param name="id"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RadiologyInsightsInferenceResult(string id, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="RadiologyInsightsInferenceResult"/> for deserialization. </summary>
        internal RadiologyInsightsInferenceResult()
        {
        }

        /// <summary> Gets the id. </summary>
        public string Id { get; }
    }
}
