// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    public partial class ArmDeploymentOperationProperties
    {
        internal static ArmDeploymentOperationProperties DeserializeArmDeploymentOperationProperties(JsonElement element)
        {
            Optional<ProvisioningOperation> provisioningOperation = default;
            Optional<string> provisioningState = default;
            Optional<DateTimeOffset> timestamp = default;
            Optional<TimeSpan> duration = default;
            Optional<string> serviceRequestId = default;
            Optional<string> statusCode = default;
            Optional<StatusMessage> statusMessage = default;
            Optional<TargetResource> targetResource = default;
            Optional<HttpMessage> request = default;
            Optional<HttpMessage> response = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provisioningOperation"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    provisioningOperation = property.Value.GetString().ToProvisioningOperation();
                    continue;
                }
                if (property.NameEquals("provisioningState"))
                {
                    provisioningState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("timestamp"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    timestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("duration"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    duration = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("serviceRequestId"))
                {
                    serviceRequestId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("statusCode"))
                {
                    statusCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("statusMessage"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        statusMessage = null;
                        continue;
                    }
                    statusMessage = StatusMessage.DeserializeStatusMessage(property.Value);
                    continue;
                }
                if (property.NameEquals("targetResource"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    targetResource = TargetResource.DeserializeTargetResource(property.Value);
                    continue;
                }
                if (property.NameEquals("request"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    request = HttpMessage.DeserializeHttpMessage(property.Value);
                    continue;
                }
                if (property.NameEquals("response"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    response = HttpMessage.DeserializeHttpMessage(property.Value);
                    continue;
                }
            }
            return new ArmDeploymentOperationProperties(Optional.ToNullable(provisioningOperation), provisioningState.Value, Optional.ToNullable(timestamp), Optional.ToNullable(duration), serviceRequestId.Value, statusCode.Value, statusMessage.Value, targetResource.Value, request.Value, response.Value);
        }
    }
}
