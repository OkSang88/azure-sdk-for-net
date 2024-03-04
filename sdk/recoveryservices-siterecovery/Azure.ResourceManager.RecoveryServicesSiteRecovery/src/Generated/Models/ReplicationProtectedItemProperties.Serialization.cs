// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class ReplicationProtectedItemProperties : IUtf8JsonSerializable, IJsonModel<ReplicationProtectedItemProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ReplicationProtectedItemProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ReplicationProtectedItemProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReplicationProtectedItemProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ReplicationProtectedItemProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (FriendlyName != null)
            {
                writer.WritePropertyName("friendlyName"u8);
                writer.WriteStringValue(FriendlyName);
            }
            if (ProtectedItemType != null)
            {
                writer.WritePropertyName("protectedItemType"u8);
                writer.WriteStringValue(ProtectedItemType);
            }
            if (ProtectableItemId != null)
            {
                writer.WritePropertyName("protectableItemId"u8);
                writer.WriteStringValue(ProtectableItemId);
            }
            if (RecoveryServicesProviderId != null)
            {
                writer.WritePropertyName("recoveryServicesProviderId"u8);
                writer.WriteStringValue(RecoveryServicesProviderId);
            }
            if (PrimaryFabricFriendlyName != null)
            {
                writer.WritePropertyName("primaryFabricFriendlyName"u8);
                writer.WriteStringValue(PrimaryFabricFriendlyName);
            }
            if (PrimaryFabricProvider != null)
            {
                writer.WritePropertyName("primaryFabricProvider"u8);
                writer.WriteStringValue(PrimaryFabricProvider);
            }
            if (RecoveryFabricFriendlyName != null)
            {
                writer.WritePropertyName("recoveryFabricFriendlyName"u8);
                writer.WriteStringValue(RecoveryFabricFriendlyName);
            }
            if (RecoveryFabricId != null)
            {
                writer.WritePropertyName("recoveryFabricId"u8);
                writer.WriteStringValue(RecoveryFabricId);
            }
            if (PrimaryProtectionContainerFriendlyName != null)
            {
                writer.WritePropertyName("primaryProtectionContainerFriendlyName"u8);
                writer.WriteStringValue(PrimaryProtectionContainerFriendlyName);
            }
            if (RecoveryProtectionContainerFriendlyName != null)
            {
                writer.WritePropertyName("recoveryProtectionContainerFriendlyName"u8);
                writer.WriteStringValue(RecoveryProtectionContainerFriendlyName);
            }
            if (ProtectionState != null)
            {
                writer.WritePropertyName("protectionState"u8);
                writer.WriteStringValue(ProtectionState);
            }
            if (ProtectionStateDescription != null)
            {
                writer.WritePropertyName("protectionStateDescription"u8);
                writer.WriteStringValue(ProtectionStateDescription);
            }
            if (ActiveLocation != null)
            {
                writer.WritePropertyName("activeLocation"u8);
                writer.WriteStringValue(ActiveLocation);
            }
            if (TestFailoverState != null)
            {
                writer.WritePropertyName("testFailoverState"u8);
                writer.WriteStringValue(TestFailoverState);
            }
            if (TestFailoverStateDescription != null)
            {
                writer.WritePropertyName("testFailoverStateDescription"u8);
                writer.WriteStringValue(TestFailoverStateDescription);
            }
            if (SwitchProviderState != null)
            {
                writer.WritePropertyName("switchProviderState"u8);
                writer.WriteStringValue(SwitchProviderState);
            }
            if (SwitchProviderStateDescription != null)
            {
                writer.WritePropertyName("switchProviderStateDescription"u8);
                writer.WriteStringValue(SwitchProviderStateDescription);
            }
            if (!(AllowedOperations is ChangeTrackingList<string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("allowedOperations"u8);
                writer.WriteStartArray();
                foreach (var item in AllowedOperations)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (ReplicationHealth != null)
            {
                writer.WritePropertyName("replicationHealth"u8);
                writer.WriteStringValue(ReplicationHealth);
            }
            if (FailoverHealth != null)
            {
                writer.WritePropertyName("failoverHealth"u8);
                writer.WriteStringValue(FailoverHealth);
            }
            if (!(HealthErrors is ChangeTrackingList<SiteRecoveryHealthError> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("healthErrors"u8);
                writer.WriteStartArray();
                foreach (var item in HealthErrors)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (PolicyId != null)
            {
                writer.WritePropertyName("policyId"u8);
                writer.WriteStringValue(PolicyId);
            }
            if (PolicyFriendlyName != null)
            {
                writer.WritePropertyName("policyFriendlyName"u8);
                writer.WriteStringValue(PolicyFriendlyName);
            }
            if (LastSuccessfulFailoverOn.HasValue)
            {
                writer.WritePropertyName("lastSuccessfulFailoverTime"u8);
                writer.WriteStringValue(LastSuccessfulFailoverOn.Value, "O");
            }
            if (LastSuccessfulTestFailoverOn.HasValue)
            {
                writer.WritePropertyName("lastSuccessfulTestFailoverTime"u8);
                writer.WriteStringValue(LastSuccessfulTestFailoverOn.Value, "O");
            }
            if (CurrentScenario != null)
            {
                writer.WritePropertyName("currentScenario"u8);
                writer.WriteObjectValue(CurrentScenario);
            }
            if (FailoverRecoveryPointId != null)
            {
                writer.WritePropertyName("failoverRecoveryPointId"u8);
                writer.WriteStringValue(FailoverRecoveryPointId);
            }
            if (ProviderSpecificDetails != null)
            {
                writer.WritePropertyName("providerSpecificDetails"u8);
                writer.WriteObjectValue(ProviderSpecificDetails);
            }
            if (RecoveryContainerId != null)
            {
                writer.WritePropertyName("recoveryContainerId"u8);
                writer.WriteStringValue(RecoveryContainerId);
            }
            if (EventCorrelationId.HasValue)
            {
                writer.WritePropertyName("eventCorrelationId"u8);
                writer.WriteStringValue(EventCorrelationId.Value);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        ReplicationProtectedItemProperties IJsonModel<ReplicationProtectedItemProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReplicationProtectedItemProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ReplicationProtectedItemProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeReplicationProtectedItemProperties(document.RootElement, options);
        }

        internal static ReplicationProtectedItemProperties DeserializeReplicationProtectedItemProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string friendlyName = default;
            string protectedItemType = default;
            ResourceIdentifier protectableItemId = default;
            string recoveryServicesProviderId = default;
            string primaryFabricFriendlyName = default;
            string primaryFabricProvider = default;
            string recoveryFabricFriendlyName = default;
            ResourceIdentifier recoveryFabricId = default;
            string primaryProtectionContainerFriendlyName = default;
            string recoveryProtectionContainerFriendlyName = default;
            string protectionState = default;
            string protectionStateDescription = default;
            string activeLocation = default;
            string testFailoverState = default;
            string testFailoverStateDescription = default;
            string switchProviderState = default;
            string switchProviderStateDescription = default;
            IReadOnlyList<string> allowedOperations = default;
            string replicationHealth = default;
            string failoverHealth = default;
            IReadOnlyList<SiteRecoveryHealthError> healthErrors = default;
            ResourceIdentifier policyId = default;
            string policyFriendlyName = default;
            DateTimeOffset? lastSuccessfulFailoverTime = default;
            DateTimeOffset? lastSuccessfulTestFailoverTime = default;
            CurrentScenarioDetails currentScenario = default;
            ResourceIdentifier failoverRecoveryPointId = default;
            ReplicationProviderSpecificSettings providerSpecificDetails = default;
            ResourceIdentifier recoveryContainerId = default;
            Guid? eventCorrelationId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("friendlyName"u8))
                {
                    friendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("protectedItemType"u8))
                {
                    protectedItemType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("protectableItemId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    protectableItemId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("recoveryServicesProviderId"u8))
                {
                    recoveryServicesProviderId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("primaryFabricFriendlyName"u8))
                {
                    primaryFabricFriendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("primaryFabricProvider"u8))
                {
                    primaryFabricProvider = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recoveryFabricFriendlyName"u8))
                {
                    recoveryFabricFriendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recoveryFabricId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryFabricId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("primaryProtectionContainerFriendlyName"u8))
                {
                    primaryProtectionContainerFriendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recoveryProtectionContainerFriendlyName"u8))
                {
                    recoveryProtectionContainerFriendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("protectionState"u8))
                {
                    protectionState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("protectionStateDescription"u8))
                {
                    protectionStateDescription = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("activeLocation"u8))
                {
                    activeLocation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("testFailoverState"u8))
                {
                    testFailoverState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("testFailoverStateDescription"u8))
                {
                    testFailoverStateDescription = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("switchProviderState"u8))
                {
                    switchProviderState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("switchProviderStateDescription"u8))
                {
                    switchProviderStateDescription = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("allowedOperations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    allowedOperations = array;
                    continue;
                }
                if (property.NameEquals("replicationHealth"u8))
                {
                    replicationHealth = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("failoverHealth"u8))
                {
                    failoverHealth = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("healthErrors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SiteRecoveryHealthError> array = new List<SiteRecoveryHealthError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SiteRecoveryHealthError.DeserializeSiteRecoveryHealthError(item, options));
                    }
                    healthErrors = array;
                    continue;
                }
                if (property.NameEquals("policyId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    policyId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("policyFriendlyName"u8))
                {
                    policyFriendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastSuccessfulFailoverTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastSuccessfulFailoverTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastSuccessfulTestFailoverTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastSuccessfulTestFailoverTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("currentScenario"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    currentScenario = CurrentScenarioDetails.DeserializeCurrentScenarioDetails(property.Value, options);
                    continue;
                }
                if (property.NameEquals("failoverRecoveryPointId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    failoverRecoveryPointId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("providerSpecificDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    providerSpecificDetails = ReplicationProviderSpecificSettings.DeserializeReplicationProviderSpecificSettings(property.Value, options);
                    continue;
                }
                if (property.NameEquals("recoveryContainerId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryContainerId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("eventCorrelationId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    eventCorrelationId = property.Value.GetGuid();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ReplicationProtectedItemProperties(
                friendlyName,
                protectedItemType,
                protectableItemId,
                recoveryServicesProviderId,
                primaryFabricFriendlyName,
                primaryFabricProvider,
                recoveryFabricFriendlyName,
                recoveryFabricId,
                primaryProtectionContainerFriendlyName,
                recoveryProtectionContainerFriendlyName,
                protectionState,
                protectionStateDescription,
                activeLocation,
                testFailoverState,
                testFailoverStateDescription,
                switchProviderState,
                switchProviderStateDescription,
                allowedOperations ?? new ChangeTrackingList<string>(),
                replicationHealth,
                failoverHealth,
                healthErrors ?? new ChangeTrackingList<SiteRecoveryHealthError>(),
                policyId,
                policyFriendlyName,
                lastSuccessfulFailoverTime,
                lastSuccessfulTestFailoverTime,
                currentScenario,
                failoverRecoveryPointId,
                providerSpecificDetails,
                recoveryContainerId,
                eventCorrelationId,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ReplicationProtectedItemProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReplicationProtectedItemProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ReplicationProtectedItemProperties)} does not support '{options.Format}' format.");
            }
        }

        ReplicationProtectedItemProperties IPersistableModel<ReplicationProtectedItemProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReplicationProtectedItemProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeReplicationProtectedItemProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ReplicationProtectedItemProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ReplicationProtectedItemProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
