// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Compute.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Compute
{
    public partial class CloudServiceData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags");
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location");
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(PackageUri))
            {
                writer.WritePropertyName("packageUrl");
                writer.WriteStringValue(PackageUri.AbsoluteUri);
            }
            if (Optional.IsDefined(Configuration))
            {
                writer.WritePropertyName("configuration");
                writer.WriteStringValue(Configuration);
            }
            if (Optional.IsDefined(ConfigurationUri))
            {
                writer.WritePropertyName("configurationUrl");
                writer.WriteStringValue(ConfigurationUri.AbsoluteUri);
            }
            if (Optional.IsDefined(StartCloudService))
            {
                writer.WritePropertyName("startCloudService");
                writer.WriteBooleanValue(StartCloudService.Value);
            }
            if (Optional.IsDefined(AllowModelOverride))
            {
                writer.WritePropertyName("allowModelOverride");
                writer.WriteBooleanValue(AllowModelOverride.Value);
            }
            if (Optional.IsDefined(UpgradeMode))
            {
                writer.WritePropertyName("upgradeMode");
                writer.WriteStringValue(UpgradeMode.Value.ToString());
            }
            if (Optional.IsDefined(RoleProfile))
            {
                writer.WritePropertyName("roleProfile");
                writer.WriteObjectValue(RoleProfile);
            }
            if (Optional.IsDefined(OSProfile))
            {
                writer.WritePropertyName("osProfile");
                writer.WriteObjectValue(OSProfile);
            }
            if (Optional.IsDefined(NetworkProfile))
            {
                writer.WritePropertyName("networkProfile");
                writer.WriteObjectValue(NetworkProfile);
            }
            if (Optional.IsDefined(ExtensionProfile))
            {
                writer.WritePropertyName("extensionProfile");
                writer.WriteObjectValue(ExtensionProfile);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static CloudServiceData DeserializeCloudServiceData(JsonElement element)
        {
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<Uri> packageUrl = default;
            Optional<string> configuration = default;
            Optional<Uri> configurationUrl = default;
            Optional<bool> startCloudService = default;
            Optional<bool> allowModelOverride = default;
            Optional<CloudServiceUpgradeMode> upgradeMode = default;
            Optional<CloudServiceRoleProfile> roleProfile = default;
            Optional<CloudServiceOSProfile> osProfile = default;
            Optional<CloudServiceNetworkProfile> networkProfile = default;
            Optional<CloudServiceExtensionProfile> extensionProfile = default;
            Optional<string> provisioningState = default;
            Optional<string> uniqueId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tags"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("packageUrl"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                packageUrl = null;
                                continue;
                            }
                            packageUrl = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("configuration"))
                        {
                            configuration = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("configurationUrl"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                configurationUrl = null;
                                continue;
                            }
                            configurationUrl = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("startCloudService"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            startCloudService = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("allowModelOverride"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            allowModelOverride = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("upgradeMode"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            upgradeMode = new CloudServiceUpgradeMode(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("roleProfile"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            roleProfile = CloudServiceRoleProfile.DeserializeCloudServiceRoleProfile(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("osProfile"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            osProfile = CloudServiceOSProfile.DeserializeCloudServiceOSProfile(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("networkProfile"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            networkProfile = CloudServiceNetworkProfile.DeserializeCloudServiceNetworkProfile(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("extensionProfile"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            extensionProfile = CloudServiceExtensionProfile.DeserializeCloudServiceExtensionProfile(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("uniqueId"))
                        {
                            uniqueId = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new CloudServiceData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, packageUrl.Value, configuration.Value, configurationUrl.Value, Optional.ToNullable(startCloudService), Optional.ToNullable(allowModelOverride), Optional.ToNullable(upgradeMode), roleProfile.Value, osProfile.Value, networkProfile.Value, extensionProfile.Value, provisioningState.Value, uniqueId.Value);
        }
    }
}
