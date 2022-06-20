// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The CustomSeasonality. </summary>
    public partial class CustomSeasonality : Seasonality
    {
        /// <summary> Initializes a new instance of CustomSeasonality. </summary>
        /// <param name="value"> [Required] Seasonality value. </param>
        public CustomSeasonality(int value)
        {
            Value = value;
            Mode = SeasonalityMode.Custom;
        }

        /// <summary> Initializes a new instance of CustomSeasonality. </summary>
        /// <param name="mode"> [Required] Seasonality mode. </param>
        /// <param name="value"> [Required] Seasonality value. </param>
        internal CustomSeasonality(SeasonalityMode mode, int value) : base(mode)
        {
            Value = value;
            Mode = mode;
        }

        /// <summary> [Required] Seasonality value. </summary>
        public int Value { get; set; }
    }
}
