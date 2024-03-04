// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class MachineLearningKubernetesOnlineDeployment : IUtf8JsonSerializable, IJsonModel<MachineLearningKubernetesOnlineDeployment>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineLearningKubernetesOnlineDeployment>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MachineLearningKubernetesOnlineDeployment>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningKubernetesOnlineDeployment>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningKubernetesOnlineDeployment)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (ContainerResourceRequirements != null)
            {
                if (ContainerResourceRequirements != null)
                {
                    writer.WritePropertyName("containerResourceRequirements"u8);
                    writer.WriteObjectValue(ContainerResourceRequirements);
                }
                else
                {
                    writer.WriteNull("containerResourceRequirements");
                }
            }
            if (AppInsightsEnabled.HasValue)
            {
                writer.WritePropertyName("appInsightsEnabled"u8);
                writer.WriteBooleanValue(AppInsightsEnabled.Value);
            }
            if (DataCollector != null)
            {
                if (DataCollector != null)
                {
                    writer.WritePropertyName("dataCollector"u8);
                    writer.WriteObjectValue(DataCollector);
                }
                else
                {
                    writer.WriteNull("dataCollector");
                }
            }
            if (EgressPublicNetworkAccess.HasValue)
            {
                writer.WritePropertyName("egressPublicNetworkAccess"u8);
                writer.WriteStringValue(EgressPublicNetworkAccess.Value.ToString());
            }
            writer.WritePropertyName("endpointComputeType"u8);
            writer.WriteStringValue(EndpointComputeType.ToString());
            if (InstanceType != null)
            {
                if (InstanceType != null)
                {
                    writer.WritePropertyName("instanceType"u8);
                    writer.WriteStringValue(InstanceType);
                }
                else
                {
                    writer.WriteNull("instanceType");
                }
            }
            if (LivenessProbe != null)
            {
                if (LivenessProbe != null)
                {
                    writer.WritePropertyName("livenessProbe"u8);
                    writer.WriteObjectValue(LivenessProbe);
                }
                else
                {
                    writer.WriteNull("livenessProbe");
                }
            }
            if (Model != null)
            {
                if (Model != null)
                {
                    writer.WritePropertyName("model"u8);
                    writer.WriteStringValue(Model);
                }
                else
                {
                    writer.WriteNull("model");
                }
            }
            if (ModelMountPath != null)
            {
                if (ModelMountPath != null)
                {
                    writer.WritePropertyName("modelMountPath"u8);
                    writer.WriteStringValue(ModelMountPath);
                }
                else
                {
                    writer.WriteNull("modelMountPath");
                }
            }
            if (options.Format != "W" && ProvisioningState.HasValue)
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (ReadinessProbe != null)
            {
                if (ReadinessProbe != null)
                {
                    writer.WritePropertyName("readinessProbe"u8);
                    writer.WriteObjectValue(ReadinessProbe);
                }
                else
                {
                    writer.WriteNull("readinessProbe");
                }
            }
            if (RequestSettings != null)
            {
                if (RequestSettings != null)
                {
                    writer.WritePropertyName("requestSettings"u8);
                    writer.WriteObjectValue(RequestSettings);
                }
                else
                {
                    writer.WriteNull("requestSettings");
                }
            }
            if (ScaleSettings != null)
            {
                if (ScaleSettings != null)
                {
                    writer.WritePropertyName("scaleSettings"u8);
                    writer.WriteObjectValue(ScaleSettings);
                }
                else
                {
                    writer.WriteNull("scaleSettings");
                }
            }
            if (CodeConfiguration != null)
            {
                if (CodeConfiguration != null)
                {
                    writer.WritePropertyName("codeConfiguration"u8);
                    writer.WriteObjectValue(CodeConfiguration);
                }
                else
                {
                    writer.WriteNull("codeConfiguration");
                }
            }
            if (Description != null)
            {
                if (Description != null)
                {
                    writer.WritePropertyName("description"u8);
                    writer.WriteStringValue(Description);
                }
                else
                {
                    writer.WriteNull("description");
                }
            }
            if (EnvironmentId != null)
            {
                if (EnvironmentId != null)
                {
                    writer.WritePropertyName("environmentId"u8);
                    writer.WriteStringValue(EnvironmentId);
                }
                else
                {
                    writer.WriteNull("environmentId");
                }
            }
            if (!(EnvironmentVariables is ChangeTrackingDictionary<string, string> collection && collection.IsUndefined))
            {
                if (EnvironmentVariables != null)
                {
                    writer.WritePropertyName("environmentVariables"u8);
                    writer.WriteStartObject();
                    foreach (var item in EnvironmentVariables)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteStringValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("environmentVariables");
                }
            }
            if (!(Properties is ChangeTrackingDictionary<string, string> collection0 && collection0.IsUndefined))
            {
                if (Properties != null)
                {
                    writer.WritePropertyName("properties"u8);
                    writer.WriteStartObject();
                    foreach (var item in Properties)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteStringValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("properties");
                }
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

        MachineLearningKubernetesOnlineDeployment IJsonModel<MachineLearningKubernetesOnlineDeployment>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningKubernetesOnlineDeployment>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningKubernetesOnlineDeployment)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningKubernetesOnlineDeployment(document.RootElement, options);
        }

        internal static MachineLearningKubernetesOnlineDeployment DeserializeMachineLearningKubernetesOnlineDeployment(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            MachineLearningContainerResourceRequirements containerResourceRequirements = default;
            bool? appInsightsEnabled = default;
            DataCollector dataCollector = default;
            MachineLearningEgressPublicNetworkAccessType? egressPublicNetworkAccess = default;
            MachineLearningEndpointComputeType endpointComputeType = default;
            string instanceType = default;
            MachineLearningProbeSettings livenessProbe = default;
            string model = default;
            string modelMountPath = default;
            MachineLearningDeploymentProvisioningState? provisioningState = default;
            MachineLearningProbeSettings readinessProbe = default;
            MachineLearningOnlineRequestSettings requestSettings = default;
            MachineLearningOnlineScaleSettings scaleSettings = default;
            MachineLearningCodeConfiguration codeConfiguration = default;
            string description = default;
            string environmentId = default;
            IDictionary<string, string> environmentVariables = default;
            IDictionary<string, string> properties = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("containerResourceRequirements"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        containerResourceRequirements = null;
                        continue;
                    }
                    containerResourceRequirements = MachineLearningContainerResourceRequirements.DeserializeMachineLearningContainerResourceRequirements(property.Value, options);
                    continue;
                }
                if (property.NameEquals("appInsightsEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    appInsightsEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("dataCollector"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        dataCollector = null;
                        continue;
                    }
                    dataCollector = DataCollector.DeserializeDataCollector(property.Value, options);
                    continue;
                }
                if (property.NameEquals("egressPublicNetworkAccess"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    egressPublicNetworkAccess = new MachineLearningEgressPublicNetworkAccessType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("endpointComputeType"u8))
                {
                    endpointComputeType = new MachineLearningEndpointComputeType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("instanceType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        instanceType = null;
                        continue;
                    }
                    instanceType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("livenessProbe"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        livenessProbe = null;
                        continue;
                    }
                    livenessProbe = MachineLearningProbeSettings.DeserializeMachineLearningProbeSettings(property.Value, options);
                    continue;
                }
                if (property.NameEquals("model"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        model = null;
                        continue;
                    }
                    model = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("modelMountPath"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        modelMountPath = null;
                        continue;
                    }
                    modelMountPath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new MachineLearningDeploymentProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("readinessProbe"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        readinessProbe = null;
                        continue;
                    }
                    readinessProbe = MachineLearningProbeSettings.DeserializeMachineLearningProbeSettings(property.Value, options);
                    continue;
                }
                if (property.NameEquals("requestSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        requestSettings = null;
                        continue;
                    }
                    requestSettings = MachineLearningOnlineRequestSettings.DeserializeMachineLearningOnlineRequestSettings(property.Value, options);
                    continue;
                }
                if (property.NameEquals("scaleSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        scaleSettings = null;
                        continue;
                    }
                    scaleSettings = MachineLearningOnlineScaleSettings.DeserializeMachineLearningOnlineScaleSettings(property.Value, options);
                    continue;
                }
                if (property.NameEquals("codeConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        codeConfiguration = null;
                        continue;
                    }
                    codeConfiguration = MachineLearningCodeConfiguration.DeserializeMachineLearningCodeConfiguration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        description = null;
                        continue;
                    }
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("environmentId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        environmentId = null;
                        continue;
                    }
                    environmentId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("environmentVariables"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        environmentVariables = null;
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    environmentVariables = dictionary;
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        properties = null;
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    properties = dictionary;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MachineLearningKubernetesOnlineDeployment(
                codeConfiguration,
                description,
                environmentId,
                environmentVariables ?? new ChangeTrackingDictionary<string, string>(),
                properties ?? new ChangeTrackingDictionary<string, string>(),
                serializedAdditionalRawData,
                appInsightsEnabled,
                dataCollector,
                egressPublicNetworkAccess,
                endpointComputeType,
                instanceType,
                livenessProbe,
                model,
                modelMountPath,
                provisioningState,
                readinessProbe,
                requestSettings,
                scaleSettings,
                containerResourceRequirements);
        }

        BinaryData IPersistableModel<MachineLearningKubernetesOnlineDeployment>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningKubernetesOnlineDeployment>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MachineLearningKubernetesOnlineDeployment)} does not support '{options.Format}' format.");
            }
        }

        MachineLearningKubernetesOnlineDeployment IPersistableModel<MachineLearningKubernetesOnlineDeployment>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningKubernetesOnlineDeployment>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMachineLearningKubernetesOnlineDeployment(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MachineLearningKubernetesOnlineDeployment)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MachineLearningKubernetesOnlineDeployment>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
