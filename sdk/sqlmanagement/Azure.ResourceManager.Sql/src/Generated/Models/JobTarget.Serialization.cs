// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class JobTarget : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(MembershipType))
            {
                writer.WritePropertyName("membershipType"u8);
                writer.WriteStringValue(MembershipType.Value.ToSerialString());
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(TargetType.ToString());
            if (Optional.IsDefined(ServerName))
            {
                writer.WritePropertyName("serverName"u8);
                writer.WriteStringValue(ServerName);
            }
            if (Optional.IsDefined(DatabaseName))
            {
                writer.WritePropertyName("databaseName"u8);
                writer.WriteStringValue(DatabaseName);
            }
            if (Optional.IsDefined(ElasticPoolName))
            {
                writer.WritePropertyName("elasticPoolName"u8);
                writer.WriteStringValue(ElasticPoolName);
            }
            if (Optional.IsDefined(ShardMapName))
            {
                writer.WritePropertyName("shardMapName"u8);
                writer.WriteStringValue(ShardMapName);
            }
            if (Optional.IsDefined(RefreshCredential))
            {
                writer.WritePropertyName("refreshCredential"u8);
                writer.WriteStringValue(RefreshCredential);
            }
            writer.WriteEndObject();
        }

        internal static JobTarget DeserializeJobTarget(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<JobTargetGroupMembershipType> membershipType = default;
            JobTargetType type = default;
            Optional<string> serverName = default;
            Optional<string> databaseName = default;
            Optional<string> elasticPoolName = default;
            Optional<string> shardMapName = default;
            Optional<string> refreshCredential = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("membershipType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    membershipType = property.Value.GetString().ToJobTargetGroupMembershipType();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new JobTargetType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("serverName"u8))
                {
                    serverName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("databaseName"u8))
                {
                    databaseName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("elasticPoolName"u8))
                {
                    elasticPoolName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("shardMapName"u8))
                {
                    shardMapName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("refreshCredential"u8))
                {
                    refreshCredential = property.Value.GetString();
                    continue;
                }
            }
            return new JobTarget(Optional.ToNullable(membershipType), type, serverName.Value, databaseName.Value, elasticPoolName.Value, shardMapName.Value, refreshCredential.Value);
        }
    }
}
