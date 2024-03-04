// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The MachineLearningFlowModelJobInput. </summary>
    public partial class MachineLearningFlowModelJobInput : MachineLearningJobInput
    {
        /// <summary> Initializes a new instance of <see cref="MachineLearningFlowModelJobInput"/>. </summary>
        /// <param name="uri"> [Required] Input Asset URI. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="uri"/> is null. </exception>
        public MachineLearningFlowModelJobInput(Uri uri)
        {
            if (uri == null)
            {
                throw new ArgumentNullException(nameof(uri));
            }

            Uri = uri;
            JobInputType = JobInputType.MlflowModel;
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningFlowModelJobInput"/>. </summary>
        /// <param name="description"> Description for the input. </param>
        /// <param name="jobInputType"> [Required] Specifies the type of job. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="mode"> Input Asset Delivery Mode. </param>
        /// <param name="uri"> [Required] Input Asset URI. </param>
        internal MachineLearningFlowModelJobInput(string description, JobInputType jobInputType, IDictionary<string, BinaryData> serializedAdditionalRawData, MachineLearningInputDeliveryMode? mode, Uri uri) : base(description, jobInputType, serializedAdditionalRawData)
        {
            Mode = mode;
            Uri = uri;
            JobInputType = jobInputType;
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningFlowModelJobInput"/> for deserialization. </summary>
        internal MachineLearningFlowModelJobInput()
        {
        }

        /// <summary> Input Asset Delivery Mode. </summary>
        public MachineLearningInputDeliveryMode? Mode { get; set; }
        /// <summary> [Required] Input Asset URI. </summary>
        public Uri Uri { get; set; }
    }
}
