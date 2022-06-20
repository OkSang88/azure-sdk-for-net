// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Applications.Containers;

namespace Azure.ResourceManager.Applications.Containers.Models
{
    internal partial class ManagedEnvironmentStoragesCollection
    {
        internal static ManagedEnvironmentStoragesCollection DeserializeManagedEnvironmentStoragesCollection(JsonElement element)
        {
            IReadOnlyList<ManagedEnvironmentStorageData> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<ManagedEnvironmentStorageData> array = new List<ManagedEnvironmentStorageData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ManagedEnvironmentStorageData.DeserializeManagedEnvironmentStorageData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new ManagedEnvironmentStoragesCollection(value);
        }
    }
}
