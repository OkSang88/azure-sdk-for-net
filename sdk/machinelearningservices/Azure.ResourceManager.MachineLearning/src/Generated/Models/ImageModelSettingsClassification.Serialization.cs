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
    public partial class ImageModelSettingsClassification : IUtf8JsonSerializable, IJsonModel<ImageModelSettingsClassification>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ImageModelSettingsClassification>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ImageModelSettingsClassification>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ImageModelSettingsClassification>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ImageModelSettingsClassification)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (TrainingCropSize.HasValue)
            {
                if (TrainingCropSize != null)
                {
                    writer.WritePropertyName("trainingCropSize"u8);
                    writer.WriteNumberValue(TrainingCropSize.Value);
                }
                else
                {
                    writer.WriteNull("trainingCropSize");
                }
            }
            if (ValidationCropSize.HasValue)
            {
                if (ValidationCropSize != null)
                {
                    writer.WritePropertyName("validationCropSize"u8);
                    writer.WriteNumberValue(ValidationCropSize.Value);
                }
                else
                {
                    writer.WriteNull("validationCropSize");
                }
            }
            if (ValidationResizeSize.HasValue)
            {
                if (ValidationResizeSize != null)
                {
                    writer.WritePropertyName("validationResizeSize"u8);
                    writer.WriteNumberValue(ValidationResizeSize.Value);
                }
                else
                {
                    writer.WriteNull("validationResizeSize");
                }
            }
            if (WeightedLoss.HasValue)
            {
                if (WeightedLoss != null)
                {
                    writer.WritePropertyName("weightedLoss"u8);
                    writer.WriteNumberValue(WeightedLoss.Value);
                }
                else
                {
                    writer.WriteNull("weightedLoss");
                }
            }
            if (AdvancedSettings != null)
            {
                if (AdvancedSettings != null)
                {
                    writer.WritePropertyName("advancedSettings"u8);
                    writer.WriteStringValue(AdvancedSettings);
                }
                else
                {
                    writer.WriteNull("advancedSettings");
                }
            }
            if (AmsGradient.HasValue)
            {
                if (AmsGradient != null)
                {
                    writer.WritePropertyName("amsGradient"u8);
                    writer.WriteBooleanValue(AmsGradient.Value);
                }
                else
                {
                    writer.WriteNull("amsGradient");
                }
            }
            if (Augmentations != null)
            {
                if (Augmentations != null)
                {
                    writer.WritePropertyName("augmentations"u8);
                    writer.WriteStringValue(Augmentations);
                }
                else
                {
                    writer.WriteNull("augmentations");
                }
            }
            if (Beta1.HasValue)
            {
                if (Beta1 != null)
                {
                    writer.WritePropertyName("beta1"u8);
                    writer.WriteNumberValue(Beta1.Value);
                }
                else
                {
                    writer.WriteNull("beta1");
                }
            }
            if (Beta2.HasValue)
            {
                if (Beta2 != null)
                {
                    writer.WritePropertyName("beta2"u8);
                    writer.WriteNumberValue(Beta2.Value);
                }
                else
                {
                    writer.WriteNull("beta2");
                }
            }
            if (CheckpointFrequency.HasValue)
            {
                if (CheckpointFrequency != null)
                {
                    writer.WritePropertyName("checkpointFrequency"u8);
                    writer.WriteNumberValue(CheckpointFrequency.Value);
                }
                else
                {
                    writer.WriteNull("checkpointFrequency");
                }
            }
            if (CheckpointModel != null)
            {
                if (CheckpointModel != null)
                {
                    writer.WritePropertyName("checkpointModel"u8);
                    writer.WriteObjectValue(CheckpointModel);
                }
                else
                {
                    writer.WriteNull("checkpointModel");
                }
            }
            if (CheckpointRunId != null)
            {
                if (CheckpointRunId != null)
                {
                    writer.WritePropertyName("checkpointRunId"u8);
                    writer.WriteStringValue(CheckpointRunId);
                }
                else
                {
                    writer.WriteNull("checkpointRunId");
                }
            }
            if (Distributed.HasValue)
            {
                if (Distributed != null)
                {
                    writer.WritePropertyName("distributed"u8);
                    writer.WriteBooleanValue(Distributed.Value);
                }
                else
                {
                    writer.WriteNull("distributed");
                }
            }
            if (EarlyStopping.HasValue)
            {
                if (EarlyStopping != null)
                {
                    writer.WritePropertyName("earlyStopping"u8);
                    writer.WriteBooleanValue(EarlyStopping.Value);
                }
                else
                {
                    writer.WriteNull("earlyStopping");
                }
            }
            if (EarlyStoppingDelay.HasValue)
            {
                if (EarlyStoppingDelay != null)
                {
                    writer.WritePropertyName("earlyStoppingDelay"u8);
                    writer.WriteNumberValue(EarlyStoppingDelay.Value);
                }
                else
                {
                    writer.WriteNull("earlyStoppingDelay");
                }
            }
            if (EarlyStoppingPatience.HasValue)
            {
                if (EarlyStoppingPatience != null)
                {
                    writer.WritePropertyName("earlyStoppingPatience"u8);
                    writer.WriteNumberValue(EarlyStoppingPatience.Value);
                }
                else
                {
                    writer.WriteNull("earlyStoppingPatience");
                }
            }
            if (EnableOnnxNormalization.HasValue)
            {
                if (EnableOnnxNormalization != null)
                {
                    writer.WritePropertyName("enableOnnxNormalization"u8);
                    writer.WriteBooleanValue(EnableOnnxNormalization.Value);
                }
                else
                {
                    writer.WriteNull("enableOnnxNormalization");
                }
            }
            if (EvaluationFrequency.HasValue)
            {
                if (EvaluationFrequency != null)
                {
                    writer.WritePropertyName("evaluationFrequency"u8);
                    writer.WriteNumberValue(EvaluationFrequency.Value);
                }
                else
                {
                    writer.WriteNull("evaluationFrequency");
                }
            }
            if (GradientAccumulationStep.HasValue)
            {
                if (GradientAccumulationStep != null)
                {
                    writer.WritePropertyName("gradientAccumulationStep"u8);
                    writer.WriteNumberValue(GradientAccumulationStep.Value);
                }
                else
                {
                    writer.WriteNull("gradientAccumulationStep");
                }
            }
            if (LayersToFreeze.HasValue)
            {
                if (LayersToFreeze != null)
                {
                    writer.WritePropertyName("layersToFreeze"u8);
                    writer.WriteNumberValue(LayersToFreeze.Value);
                }
                else
                {
                    writer.WriteNull("layersToFreeze");
                }
            }
            if (LearningRate.HasValue)
            {
                if (LearningRate != null)
                {
                    writer.WritePropertyName("learningRate"u8);
                    writer.WriteNumberValue(LearningRate.Value);
                }
                else
                {
                    writer.WriteNull("learningRate");
                }
            }
            if (LearningRateScheduler.HasValue)
            {
                writer.WritePropertyName("learningRateScheduler"u8);
                writer.WriteStringValue(LearningRateScheduler.Value.ToString());
            }
            if (ModelName != null)
            {
                if (ModelName != null)
                {
                    writer.WritePropertyName("modelName"u8);
                    writer.WriteStringValue(ModelName);
                }
                else
                {
                    writer.WriteNull("modelName");
                }
            }
            if (Momentum.HasValue)
            {
                if (Momentum != null)
                {
                    writer.WritePropertyName("momentum"u8);
                    writer.WriteNumberValue(Momentum.Value);
                }
                else
                {
                    writer.WriteNull("momentum");
                }
            }
            if (Nesterov.HasValue)
            {
                if (Nesterov != null)
                {
                    writer.WritePropertyName("nesterov"u8);
                    writer.WriteBooleanValue(Nesterov.Value);
                }
                else
                {
                    writer.WriteNull("nesterov");
                }
            }
            if (NumberOfEpochs.HasValue)
            {
                if (NumberOfEpochs != null)
                {
                    writer.WritePropertyName("numberOfEpochs"u8);
                    writer.WriteNumberValue(NumberOfEpochs.Value);
                }
                else
                {
                    writer.WriteNull("numberOfEpochs");
                }
            }
            if (NumberOfWorkers.HasValue)
            {
                if (NumberOfWorkers != null)
                {
                    writer.WritePropertyName("numberOfWorkers"u8);
                    writer.WriteNumberValue(NumberOfWorkers.Value);
                }
                else
                {
                    writer.WriteNull("numberOfWorkers");
                }
            }
            if (Optimizer.HasValue)
            {
                writer.WritePropertyName("optimizer"u8);
                writer.WriteStringValue(Optimizer.Value.ToString());
            }
            if (RandomSeed.HasValue)
            {
                if (RandomSeed != null)
                {
                    writer.WritePropertyName("randomSeed"u8);
                    writer.WriteNumberValue(RandomSeed.Value);
                }
                else
                {
                    writer.WriteNull("randomSeed");
                }
            }
            if (StepLRGamma.HasValue)
            {
                if (StepLRGamma != null)
                {
                    writer.WritePropertyName("stepLRGamma"u8);
                    writer.WriteNumberValue(StepLRGamma.Value);
                }
                else
                {
                    writer.WriteNull("stepLRGamma");
                }
            }
            if (StepLRStepSize.HasValue)
            {
                if (StepLRStepSize != null)
                {
                    writer.WritePropertyName("stepLRStepSize"u8);
                    writer.WriteNumberValue(StepLRStepSize.Value);
                }
                else
                {
                    writer.WriteNull("stepLRStepSize");
                }
            }
            if (TrainingBatchSize.HasValue)
            {
                if (TrainingBatchSize != null)
                {
                    writer.WritePropertyName("trainingBatchSize"u8);
                    writer.WriteNumberValue(TrainingBatchSize.Value);
                }
                else
                {
                    writer.WriteNull("trainingBatchSize");
                }
            }
            if (ValidationBatchSize.HasValue)
            {
                if (ValidationBatchSize != null)
                {
                    writer.WritePropertyName("validationBatchSize"u8);
                    writer.WriteNumberValue(ValidationBatchSize.Value);
                }
                else
                {
                    writer.WriteNull("validationBatchSize");
                }
            }
            if (WarmupCosineLRCycles.HasValue)
            {
                if (WarmupCosineLRCycles != null)
                {
                    writer.WritePropertyName("warmupCosineLRCycles"u8);
                    writer.WriteNumberValue(WarmupCosineLRCycles.Value);
                }
                else
                {
                    writer.WriteNull("warmupCosineLRCycles");
                }
            }
            if (WarmupCosineLRWarmupEpochs.HasValue)
            {
                if (WarmupCosineLRWarmupEpochs != null)
                {
                    writer.WritePropertyName("warmupCosineLRWarmupEpochs"u8);
                    writer.WriteNumberValue(WarmupCosineLRWarmupEpochs.Value);
                }
                else
                {
                    writer.WriteNull("warmupCosineLRWarmupEpochs");
                }
            }
            if (WeightDecay.HasValue)
            {
                if (WeightDecay != null)
                {
                    writer.WritePropertyName("weightDecay"u8);
                    writer.WriteNumberValue(WeightDecay.Value);
                }
                else
                {
                    writer.WriteNull("weightDecay");
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

        ImageModelSettingsClassification IJsonModel<ImageModelSettingsClassification>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ImageModelSettingsClassification>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ImageModelSettingsClassification)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeImageModelSettingsClassification(document.RootElement, options);
        }

        internal static ImageModelSettingsClassification DeserializeImageModelSettingsClassification(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int? trainingCropSize = default;
            int? validationCropSize = default;
            int? validationResizeSize = default;
            int? weightedLoss = default;
            string advancedSettings = default;
            bool? amsGradient = default;
            string augmentations = default;
            float? beta1 = default;
            float? beta2 = default;
            int? checkpointFrequency = default;
            MachineLearningFlowModelJobInput checkpointModel = default;
            string checkpointRunId = default;
            bool? distributed = default;
            bool? earlyStopping = default;
            int? earlyStoppingDelay = default;
            int? earlyStoppingPatience = default;
            bool? enableOnnxNormalization = default;
            int? evaluationFrequency = default;
            int? gradientAccumulationStep = default;
            int? layersToFreeze = default;
            float? learningRate = default;
            LearningRateScheduler? learningRateScheduler = default;
            string modelName = default;
            float? momentum = default;
            bool? nesterov = default;
            int? numberOfEpochs = default;
            int? numberOfWorkers = default;
            StochasticOptimizer? optimizer = default;
            int? randomSeed = default;
            float? stepLRGamma = default;
            int? stepLRStepSize = default;
            int? trainingBatchSize = default;
            int? validationBatchSize = default;
            float? warmupCosineLRCycles = default;
            int? warmupCosineLRWarmupEpochs = default;
            float? weightDecay = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("trainingCropSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        trainingCropSize = null;
                        continue;
                    }
                    trainingCropSize = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("validationCropSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        validationCropSize = null;
                        continue;
                    }
                    validationCropSize = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("validationResizeSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        validationResizeSize = null;
                        continue;
                    }
                    validationResizeSize = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("weightedLoss"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        weightedLoss = null;
                        continue;
                    }
                    weightedLoss = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("advancedSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        advancedSettings = null;
                        continue;
                    }
                    advancedSettings = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("amsGradient"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        amsGradient = null;
                        continue;
                    }
                    amsGradient = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("augmentations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        augmentations = null;
                        continue;
                    }
                    augmentations = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("beta1"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        beta1 = null;
                        continue;
                    }
                    beta1 = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("beta2"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        beta2 = null;
                        continue;
                    }
                    beta2 = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("checkpointFrequency"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        checkpointFrequency = null;
                        continue;
                    }
                    checkpointFrequency = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("checkpointModel"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        checkpointModel = null;
                        continue;
                    }
                    checkpointModel = MachineLearningFlowModelJobInput.DeserializeMachineLearningFlowModelJobInput(property.Value, options);
                    continue;
                }
                if (property.NameEquals("checkpointRunId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        checkpointRunId = null;
                        continue;
                    }
                    checkpointRunId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("distributed"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        distributed = null;
                        continue;
                    }
                    distributed = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("earlyStopping"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        earlyStopping = null;
                        continue;
                    }
                    earlyStopping = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("earlyStoppingDelay"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        earlyStoppingDelay = null;
                        continue;
                    }
                    earlyStoppingDelay = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("earlyStoppingPatience"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        earlyStoppingPatience = null;
                        continue;
                    }
                    earlyStoppingPatience = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("enableOnnxNormalization"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        enableOnnxNormalization = null;
                        continue;
                    }
                    enableOnnxNormalization = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("evaluationFrequency"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        evaluationFrequency = null;
                        continue;
                    }
                    evaluationFrequency = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("gradientAccumulationStep"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        gradientAccumulationStep = null;
                        continue;
                    }
                    gradientAccumulationStep = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("layersToFreeze"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        layersToFreeze = null;
                        continue;
                    }
                    layersToFreeze = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("learningRate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        learningRate = null;
                        continue;
                    }
                    learningRate = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("learningRateScheduler"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    learningRateScheduler = new LearningRateScheduler(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("modelName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        modelName = null;
                        continue;
                    }
                    modelName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("momentum"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        momentum = null;
                        continue;
                    }
                    momentum = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("nesterov"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        nesterov = null;
                        continue;
                    }
                    nesterov = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("numberOfEpochs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        numberOfEpochs = null;
                        continue;
                    }
                    numberOfEpochs = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("numberOfWorkers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        numberOfWorkers = null;
                        continue;
                    }
                    numberOfWorkers = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("optimizer"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    optimizer = new StochasticOptimizer(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("randomSeed"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        randomSeed = null;
                        continue;
                    }
                    randomSeed = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("stepLRGamma"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        stepLRGamma = null;
                        continue;
                    }
                    stepLRGamma = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("stepLRStepSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        stepLRStepSize = null;
                        continue;
                    }
                    stepLRStepSize = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("trainingBatchSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        trainingBatchSize = null;
                        continue;
                    }
                    trainingBatchSize = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("validationBatchSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        validationBatchSize = null;
                        continue;
                    }
                    validationBatchSize = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("warmupCosineLRCycles"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        warmupCosineLRCycles = null;
                        continue;
                    }
                    warmupCosineLRCycles = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("warmupCosineLRWarmupEpochs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        warmupCosineLRWarmupEpochs = null;
                        continue;
                    }
                    warmupCosineLRWarmupEpochs = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("weightDecay"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        weightDecay = null;
                        continue;
                    }
                    weightDecay = property.Value.GetSingle();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ImageModelSettingsClassification(
                advancedSettings,
                amsGradient,
                augmentations,
                beta1,
                beta2,
                checkpointFrequency,
                checkpointModel,
                checkpointRunId,
                distributed,
                earlyStopping,
                earlyStoppingDelay,
                earlyStoppingPatience,
                enableOnnxNormalization,
                evaluationFrequency,
                gradientAccumulationStep,
                layersToFreeze,
                learningRate,
                learningRateScheduler,
                modelName,
                momentum,
                nesterov,
                numberOfEpochs,
                numberOfWorkers,
                optimizer,
                randomSeed,
                stepLRGamma,
                stepLRStepSize,
                trainingBatchSize,
                validationBatchSize,
                warmupCosineLRCycles,
                warmupCosineLRWarmupEpochs,
                weightDecay,
                serializedAdditionalRawData,
                trainingCropSize,
                validationCropSize,
                validationResizeSize,
                weightedLoss);
        }

        BinaryData IPersistableModel<ImageModelSettingsClassification>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ImageModelSettingsClassification>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ImageModelSettingsClassification)} does not support '{options.Format}' format.");
            }
        }

        ImageModelSettingsClassification IPersistableModel<ImageModelSettingsClassification>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ImageModelSettingsClassification>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeImageModelSettingsClassification(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ImageModelSettingsClassification)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ImageModelSettingsClassification>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
