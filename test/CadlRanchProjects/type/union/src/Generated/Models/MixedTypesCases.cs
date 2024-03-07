// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using _Type.Union;

namespace _Type.Union.Models
{
    /// <summary> The MixedTypesCases. </summary>
    public partial class MixedTypesCases
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

        /// <summary> Initializes a new instance of <see cref="MixedTypesCases"/>. </summary>
        /// <param name="model"> This should be receive/send the Cat variant. </param>
        /// <param name="literal"> This should be receive/send the "a" variant. </param>
        /// <param name="int"> This should be receive/send the int variant. </param>
        /// <param name="boolean"> This should be receive/send the boolean variant. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="model"/>, <paramref name="literal"/>, <paramref name="int"/> or <paramref name="boolean"/> is null. </exception>
        public MixedTypesCases(BinaryData model, BinaryData literal, BinaryData @int, BinaryData boolean)
        {
            Argument.AssertNotNull(model, nameof(model));
            Argument.AssertNotNull(literal, nameof(literal));
            Argument.AssertNotNull(@int, nameof(@int));
            Argument.AssertNotNull(boolean, nameof(boolean));

            Model = model;
            Literal = literal;
            Int = @int;
            Boolean = boolean;
        }

        /// <summary> Initializes a new instance of <see cref="MixedTypesCases"/>. </summary>
        /// <param name="model"> This should be receive/send the Cat variant. </param>
        /// <param name="literal"> This should be receive/send the "a" variant. </param>
        /// <param name="int"> This should be receive/send the int variant. </param>
        /// <param name="boolean"> This should be receive/send the boolean variant. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MixedTypesCases(BinaryData model, BinaryData literal, BinaryData @int, BinaryData boolean, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Model = model;
            Literal = literal;
            Int = @int;
            Boolean = boolean;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="MixedTypesCases"/> for deserialization. </summary>
        internal MixedTypesCases()
        {
        }

        /// <summary>
        /// This should be receive/send the Cat variant
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// <remarks>
        /// Supported types:
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="Cat"/></description>
        /// </item>
        /// <item>
        /// <description>"a"</description>
        /// </item>
        /// <item>
        /// <description><see cref="int"/></description>
        /// </item>
        /// <item>
        /// <description><see cref="bool"/></description>
        /// </item>
        /// </list>
        /// </remarks>
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
        public BinaryData Model { get; set; }
        /// <summary>
        /// This should be receive/send the "a" variant
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// <remarks>
        /// Supported types:
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="Cat"/></description>
        /// </item>
        /// <item>
        /// <description>"a"</description>
        /// </item>
        /// <item>
        /// <description><see cref="int"/></description>
        /// </item>
        /// <item>
        /// <description><see cref="bool"/></description>
        /// </item>
        /// </list>
        /// </remarks>
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
        public BinaryData Literal { get; set; }
        /// <summary>
        /// This should be receive/send the int variant
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// <remarks>
        /// Supported types:
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="Cat"/></description>
        /// </item>
        /// <item>
        /// <description>"a"</description>
        /// </item>
        /// <item>
        /// <description><see cref="int"/></description>
        /// </item>
        /// <item>
        /// <description><see cref="bool"/></description>
        /// </item>
        /// </list>
        /// </remarks>
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
        public BinaryData Int { get; set; }
        /// <summary>
        /// This should be receive/send the boolean variant
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// <remarks>
        /// Supported types:
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="Cat"/></description>
        /// </item>
        /// <item>
        /// <description>"a"</description>
        /// </item>
        /// <item>
        /// <description><see cref="int"/></description>
        /// </item>
        /// <item>
        /// <description><see cref="bool"/></description>
        /// </item>
        /// </list>
        /// </remarks>
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
        public BinaryData Boolean { get; set; }
    }
}
