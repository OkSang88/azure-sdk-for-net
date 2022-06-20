// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Advances setting to customize StackEnsemble run. </summary>
    public partial class StackEnsembleSettings
    {
        /// <summary> Initializes a new instance of StackEnsembleSettings. </summary>
        public StackEnsembleSettings()
        {
        }

        /// <summary> Initializes a new instance of StackEnsembleSettings. </summary>
        /// <param name="stackMetaLearnerKWargs"> Optional parameters to pass to the initializer of the meta-learner. </param>
        /// <param name="stackMetaLearnerTrainPercentage"> Specifies the proportion of the training set (when choosing train and validation type of training) to be reserved for training the meta-learner. Default value is 0.2. </param>
        /// <param name="stackMetaLearnerType"> The meta-learner is a model trained on the output of the individual heterogeneous models. </param>
        internal StackEnsembleSettings(BinaryData stackMetaLearnerKWargs, double? stackMetaLearnerTrainPercentage, StackMetaLearnerType? stackMetaLearnerType)
        {
            StackMetaLearnerKWargs = stackMetaLearnerKWargs;
            StackMetaLearnerTrainPercentage = stackMetaLearnerTrainPercentage;
            StackMetaLearnerType = stackMetaLearnerType;
        }

        /// <summary> Optional parameters to pass to the initializer of the meta-learner. </summary>
        public BinaryData StackMetaLearnerKWargs { get; set; }
        /// <summary> Specifies the proportion of the training set (when choosing train and validation type of training) to be reserved for training the meta-learner. Default value is 0.2. </summary>
        public double? StackMetaLearnerTrainPercentage { get; set; }
        /// <summary> The meta-learner is a model trained on the output of the individual heterogeneous models. </summary>
        public StackMetaLearnerType? StackMetaLearnerType { get; set; }
    }
}
