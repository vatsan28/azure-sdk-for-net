// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DevSpaces.Models
{
    public partial class ControllerConnectionDetails
    {
        internal static ControllerConnectionDetails DeserializeControllerConnectionDetails(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<OrchestratorSpecificConnectionDetails> orchestratorSpecificConnectionDetails = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("orchestratorSpecificConnectionDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    orchestratorSpecificConnectionDetails = OrchestratorSpecificConnectionDetails.DeserializeOrchestratorSpecificConnectionDetails(property.Value);
                    continue;
                }
            }
            return new ControllerConnectionDetails(orchestratorSpecificConnectionDetails.Value);
        }
    }
}
