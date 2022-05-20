// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Applications.Containers.Models
{
    public partial class HttpRequestData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Host))
            {
                writer.WritePropertyName("host");
                writer.WriteStringValue(Host);
            }
            if (Optional.IsCollectionDefined(HttpHeaders))
            {
                writer.WritePropertyName("httpHeaders");
                writer.WriteStartArray();
                foreach (var item in HttpHeaders)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Path))
            {
                writer.WritePropertyName("path");
                writer.WriteStringValue(Path);
            }
            writer.WritePropertyName("port");
            writer.WriteNumberValue(Port);
            if (Optional.IsDefined(Scheme))
            {
                writer.WritePropertyName("scheme");
                writer.WriteStringValue(Scheme.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static HttpRequestData DeserializeHttpRequestData(JsonElement element)
        {
            Optional<string> host = default;
            Optional<IList<HttpRequestDataHttpHeadersItem>> httpHeaders = default;
            Optional<string> path = default;
            int port = default;
            Optional<HttpScheme> scheme = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("host"))
                {
                    host = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("httpHeaders"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<HttpRequestDataHttpHeadersItem> array = new List<HttpRequestDataHttpHeadersItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(HttpRequestDataHttpHeadersItem.DeserializeHttpRequestDataHttpHeadersItem(item));
                    }
                    httpHeaders = array;
                    continue;
                }
                if (property.NameEquals("path"))
                {
                    path = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("port"))
                {
                    port = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("scheme"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    scheme = new HttpScheme(property.Value.GetString());
                    continue;
                }
            }
            return new HttpRequestData(host.Value, Optional.ToList(httpHeaders), path.Value, port, Optional.ToNullable(scheme));
        }
    }
}
