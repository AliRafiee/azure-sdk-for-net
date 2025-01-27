// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.PhoneNumbers
{
    public partial class PhoneNumberOffering
    {
        internal static PhoneNumberOffering DeserializePhoneNumberOffering(JsonElement element)
        {
            Optional<PhoneNumberType> phoneNumberType = default;
            Optional<PhoneNumberAssignmentType> assignmentType = default;
            Optional<PhoneNumberCapabilities> availableCapabilities = default;
            PhoneNumberCost cost = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("phoneNumberType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    phoneNumberType = new PhoneNumberType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("assignmentType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    assignmentType = new PhoneNumberAssignmentType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("availableCapabilities"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    availableCapabilities = PhoneNumberCapabilities.DeserializePhoneNumberCapabilities(property.Value);
                    continue;
                }
                if (property.NameEquals("cost"))
                {
                    cost = PhoneNumberCost.DeserializePhoneNumberCost(property.Value);
                    continue;
                }
            }
            return new PhoneNumberOffering(Optional.ToNullable(phoneNumberType), Optional.ToNullable(assignmentType), availableCapabilities.Value, cost);
        }
    }
}
