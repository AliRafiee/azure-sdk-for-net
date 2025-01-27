// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class GalleryApplicationCustomAction : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            writer.WritePropertyName("script");
            writer.WriteStringValue(Script);
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            if (Optional.IsCollectionDefined(Parameters))
            {
                writer.WritePropertyName("parameters");
                writer.WriteStartArray();
                foreach (var item in Parameters)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static GalleryApplicationCustomAction DeserializeGalleryApplicationCustomAction(JsonElement element)
        {
            string name = default;
            string script = default;
            Optional<string> description = default;
            Optional<IList<GalleryApplicationCustomActionParameter>> parameters = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("script"))
                {
                    script = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("parameters"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<GalleryApplicationCustomActionParameter> array = new List<GalleryApplicationCustomActionParameter>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(GalleryApplicationCustomActionParameter.DeserializeGalleryApplicationCustomActionParameter(item));
                    }
                    parameters = array;
                    continue;
                }
            }
            return new GalleryApplicationCustomAction(name, script, description.Value, Optional.ToList(parameters));
        }
    }
}
