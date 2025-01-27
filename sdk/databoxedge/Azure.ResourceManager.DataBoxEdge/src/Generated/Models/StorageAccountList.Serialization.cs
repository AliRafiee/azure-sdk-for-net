// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DataBoxEdge;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    internal partial class StorageAccountList
    {
        internal static StorageAccountList DeserializeStorageAccountList(JsonElement element)
        {
            Optional<IReadOnlyList<DataBoxEdgeStorageAccountData>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<DataBoxEdgeStorageAccountData> array = new List<DataBoxEdgeStorageAccountData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataBoxEdgeStorageAccountData.DeserializeDataBoxEdgeStorageAccountData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new StorageAccountList(Optional.ToList(value), nextLink.Value);
        }
    }
}
