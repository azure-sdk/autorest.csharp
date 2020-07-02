// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Text.Json;
using AutoRest.TestServer.Tests.Infrastructure;
using Azure.Core;
using ModelShapes.Models;
using NUnit.Framework;

namespace AutoRest.TestServer.Tests
{
    public class ModelShapeTests
    {
        [Test]
        public void UnusedModelAreInternal()
        {
            Assert.False(typeof(UnusedModel).IsPublic);
        }

        [Test]
        public void RequiredPropertiesAreSetableInMixedModels()
        {
            var requiredInt = TypeAsserts.HasProperty(typeof(MixedModel), "RequiredInt", BindingFlags.Public | BindingFlags.Instance);
            var requiredString = TypeAsserts.HasProperty(typeof(MixedModel), "RequiredString", BindingFlags.Public | BindingFlags.Instance);

            Assert.NotNull(requiredInt.SetMethod);
            Assert.NotNull(requiredString.SetMethod);
        }

        [Test]
        public void RequiredPropertiesAreNotSetableInInputModels()
        {
            var requiredInt = TypeAsserts.HasProperty(typeof(InputModel), "RequiredInt", BindingFlags.Public | BindingFlags.Instance);
            var requiredString = TypeAsserts.HasProperty(typeof(InputModel), "RequiredString", BindingFlags.Public | BindingFlags.Instance);

            Assert.Null(requiredInt.SetMethod);
            Assert.Null(requiredString.SetMethod);
        }

        [Test]
        public void RequiredListsAreReadOnly()
        {
            var requiredIntList = TypeAsserts.HasProperty(typeof(InputModel), "RequiredIntList", BindingFlags.Public | BindingFlags.Instance);
            var requiredStringList = TypeAsserts.HasProperty(typeof(InputModel), "RequiredStringList", BindingFlags.Public | BindingFlags.Instance);

            Assert.Null(requiredIntList.SetMethod);
            Assert.Null(requiredStringList.SetMethod);
        }

        [Test]
        public void RequiredNullableListsOnInputsAreWriteable()
        {
            var requiredIntList = TypeAsserts.HasProperty(typeof(InputModel), "RequiredNullableIntList", BindingFlags.Public | BindingFlags.Instance);
            var requiredStringList = TypeAsserts.HasProperty(typeof(InputModel), "RequiredNullableStringList", BindingFlags.Public | BindingFlags.Instance);

            Assert.NotNull(requiredIntList.SetMethod);
            Assert.NotNull(requiredStringList.SetMethod);
        }

        [Test]
        public void RequiredNullableListsAreNotNullByDefault()
        {
            var input = CreateInputModel();
            Assert.NotNull(input.RequiredNullableIntList);
            Assert.NotNull(input.RequiredNullableStringList);
        }

        [Test]
        public void RequiredNullableListsOnMixedAreWriteableAndNullByDefault()
        {
            var requiredIntList = TypeAsserts.HasProperty(typeof(MixedModel), "RequiredNullableIntList", BindingFlags.Public | BindingFlags.Instance);
            var requiredStringList = TypeAsserts.HasProperty(typeof(MixedModel), "RequiredNullableStringList", BindingFlags.Public | BindingFlags.Instance);

            Assert.NotNull(requiredIntList.SetMethod);
            Assert.NotNull(requiredStringList.SetMethod);
        }

        [Test]
        public void NullablePropertiesCanBeInitializedWithNull()
        {
            var inputModel = new InputModel(
                "string",
                1,
                Array.Empty<string>(),
                Array.Empty<int>(),
                null,
                null,
                null,
                null
            );

            Assert.IsNull(inputModel.RequiredNullableInt);
            Assert.IsNull(inputModel.RequiredNullableString);
            Assert.IsNull(inputModel.RequiredNullableIntList);
            Assert.IsNull(inputModel.RequiredNullableStringList);
        }

        [Test]
        public void NullablePropertiesSerializedAsNulls()
        {
            var inputModel = new InputModel(
                "string",
                1,
                Array.Empty<string>(),
                Array.Empty<int>(),
                null,
                null,
                null,
                null
            );

            var element = JsonAsserts.AssertSerializes(inputModel);
            Assert.AreEqual(JsonValueKind.Null, element.GetProperty("RequiredNullableString").ValueKind);
            Assert.AreEqual(JsonValueKind.Null, element.GetProperty("RequiredNullableInt").ValueKind);
            Assert.AreEqual(JsonValueKind.Null, element.GetProperty("RequiredNullableStringList").ValueKind);
            Assert.AreEqual(JsonValueKind.Null, element.GetProperty("RequiredNullableIntList").ValueKind);
        }

        [Test]
        public void NullablePropertiesSerializedAsEmptyLists()
        {
            var inputModel = new InputModel(
                "string",
                1,
                Array.Empty<string>(),
                Array.Empty<int>(),
                "string",
                1,
                Array.Empty<string>(),
                Array.Empty<int>()
            );

            var element = JsonAsserts.AssertSerializes(inputModel);
            Assert.AreEqual(JsonValueKind.Array, element.GetProperty("RequiredNullableStringList").ValueKind);
            Assert.AreEqual(0, element.GetProperty("RequiredNullableStringList").GetArrayLength());
            Assert.AreEqual(JsonValueKind.Array, element.GetProperty("RequiredNullableIntList").ValueKind);
            Assert.AreEqual(0, element.GetProperty("RequiredNullableIntList").GetArrayLength());
        }

        [Test]
        public void NullablePropertiesDeserializedAsNullsWithUndefined()
        {
            var model = MixedModel.DeserializeMixedModel(JsonDocument.Parse("{}").RootElement);
            Assert.Null(model.RequiredNullableIntList);
            Assert.Null(model.RequiredNullableStringList);
        }

        [Test]
        public void NullablePropertiesDeserializedAsNullsWithNulls()
        {
            var model = MixedModel.DeserializeMixedModel(JsonDocument.Parse("{\"RequiredNullableIntList\":null, \"RequiredNullableStringList\": null}").RootElement);
            Assert.Null(model.RequiredNullableIntList);
            Assert.Null(model.RequiredNullableStringList);
        }

        [Test]
        public void NullablePropertiesDeserializedAsValues()
        {
            var model = MixedModel.DeserializeMixedModel(JsonDocument.Parse("{\"RequiredNullableIntList\":[1,2,3], \"RequiredNullableStringList\": [\"a\", \"b\"]}").RootElement);
            Assert.AreEqual(new[] {1, 2, 3}, model.RequiredNullableIntList);
            Assert.AreEqual(new[] {"a", "b"}, model.RequiredNullableStringList);
        }

        [Test]
        public void InputModelDoesntSerializeOptionalCollections()
        {
            var inputModel = CreateInputModel();

            // Perform non mutating operations
            _ = inputModel.NonRequiredIntList.Count;
            _ = inputModel.NonRequiredStringList.Count;
            _ = inputModel.NonRequiredIntList.Count();
            _ = inputModel.NonRequiredStringList.Count();
            _ = inputModel.NonRequiredIntList.IsReadOnly;
            _ = inputModel.NonRequiredStringList.IsReadOnly;
            _ = inputModel.NonRequiredIntList.Remove(1);
            _ = inputModel.NonRequiredStringList.Remove("s");

            var element = JsonAsserts.AssertSerializes(inputModel);

            Assert.False(element.TryGetProperty("NonRequiredStringList", out _));
            Assert.False(element.TryGetProperty("NonRequiredIntList", out _));
        }

        [Test]
        public void InputModelSerializeOptionalCollectionAfterMutation()
        {
            var inputModel = CreateInputModel();

            inputModel.NonRequiredIntList.Add(1);
            inputModel.NonRequiredStringList.Add("1");

            var element = JsonAsserts.AssertSerializes(inputModel);

            Assert.AreEqual("[1]", element.GetProperty("NonRequiredIntList").ToString());
            Assert.AreEqual("[\"1\"]", element.GetProperty("NonRequiredStringList").ToString());
        }

        [Test]
        public void InputModelSerializeOptionalEmptyCollectionAfterMutation()
        {
            var inputModel = CreateInputModel();

            inputModel.NonRequiredIntList.Add(1);
            inputModel.NonRequiredIntList.Clear();
            inputModel.NonRequiredStringList.Add("1");
            inputModel.NonRequiredStringList.Clear();

            var element = JsonAsserts.AssertSerializes(inputModel);

            Assert.AreEqual("[]", element.GetProperty("NonRequiredIntList").ToString());
            Assert.AreEqual("[]", element.GetProperty("NonRequiredStringList").ToString());
        }

        [Test]
        public void InputModelDoesntSerializeOptionalCollectionAfterReset()
        {
            var inputModel = CreateInputModel();

            inputModel.NonRequiredIntList.Add(1);
            (inputModel.NonRequiredIntList as ChangeTrackingList<int>).Reset();
            inputModel.NonRequiredStringList.Add("1");
            (inputModel.NonRequiredStringList as ChangeTrackingList<string>).Reset();

            var element = JsonAsserts.AssertSerializes(inputModel);

            Assert.False(element.TryGetProperty("NonRequiredStringList", out _));
            Assert.False(element.TryGetProperty("NonRequiredIntList", out _));
        }

        [Test]
        public void RequiredNullableCollectionsSerializeAsNull()
        {
            var inputModel = CreateInputModel();

            Assert.NotNull(inputModel.RequiredNullableIntList);
            Assert.NotNull(inputModel.RequiredNullableStringList);

            inputModel.RequiredNullableIntList = null;
            inputModel.RequiredNullableStringList = null;

            var element = JsonAsserts.AssertSerializes(inputModel);

            Assert.AreEqual(JsonValueKind.Null, element.GetProperty("RequiredNullableIntList").ValueKind);
            Assert.AreEqual(JsonValueKind.Null, element.GetProperty("RequiredNullableStringList").ValueKind);
        }

        private static InputModel CreateInputModel()
        {
            return new InputModel(
                "string",
                1,
                Array.Empty<string>(),
                Array.Empty<int>(),
                null,
                null,
                Array.Empty<string>(),
                Array.Empty<int>()
            );
        }

        [Test]
        public void InputCollectionPropertiesCanBeMutatedAfterConstruction()
        {
            var inputModel = new InputModel(
                "string",
                1,
                Array.Empty<string>(),
                Array.Empty<int>(),
                "string",
                1,
                Array.Empty<string>(),
                Array.Empty<int>()
            );

            inputModel.RequiredIntList.Add(1);

            Assert.AreEqual(1, inputModel.RequiredIntList.Count);
        }
    }
}