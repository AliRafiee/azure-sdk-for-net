// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class FailoverReplicationProtectedItemDetails
    {
        internal static FailoverReplicationProtectedItemDetails DeserializeFailoverReplicationProtectedItemDetails(JsonElement element)
        {
            Optional<string> name = default;
            Optional<string> friendlyName = default;
            Optional<string> testVmName = default;
            Optional<string> testVmFriendlyName = default;
            Optional<string> networkConnectionStatus = default;
            Optional<string> networkFriendlyName = default;
            Optional<string> subnet = default;
            Optional<string> recoveryPointId = default;
            Optional<DateTimeOffset> recoveryPointTime = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("friendlyName"))
                {
                    friendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("testVmName"))
                {
                    testVmName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("testVmFriendlyName"))
                {
                    testVmFriendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("networkConnectionStatus"))
                {
                    networkConnectionStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("networkFriendlyName"))
                {
                    networkFriendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("subnet"))
                {
                    subnet = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recoveryPointId"))
                {
                    recoveryPointId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recoveryPointTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    recoveryPointTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
            }
            return new FailoverReplicationProtectedItemDetails(name.Value, friendlyName.Value, testVmName.Value, testVmFriendlyName.Value, networkConnectionStatus.Value, networkFriendlyName.Value, subnet.Value, recoveryPointId.Value, Optional.ToNullable(recoveryPointTime));
        }
    }
}
