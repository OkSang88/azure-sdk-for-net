// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ElasticSan.Models
{
    /// <summary> Volume scalability target. </summary>
    public partial class ElasticSanVolumeTierInfo
    {
        /// <summary> Initializes a new instance of ElasticSanVolumeTierInfo. </summary>
        internal ElasticSanVolumeTierInfo()
        {
        }

        /// <summary> Initializes a new instance of ElasticSanVolumeTierInfo. </summary>
        /// <param name="maxSizeGiB"> Maximum volume capacity in GiB. </param>
        /// <param name="minSizeGiB"> Minimum volume capacity in GiB. </param>
        /// <param name="minIncrementSizeGiB"> Increment volume capacity in GiB. </param>
        /// <param name="iopsPerBaseGiB"> Maximum IOPS per GiB. </param>
        /// <param name="maxIops"> Maximum IOPS. </param>
        /// <param name="maxMbps"> Maximum MBps. </param>
        internal ElasticSanVolumeTierInfo(long? maxSizeGiB, long? minSizeGiB, long? minIncrementSizeGiB, long? iopsPerBaseGiB, long? maxIops, long? maxMbps)
        {
            MaxSizeGiB = maxSizeGiB;
            MinSizeGiB = minSizeGiB;
            MinIncrementSizeGiB = minIncrementSizeGiB;
            IopsPerBaseGiB = iopsPerBaseGiB;
            MaxIops = maxIops;
            MaxMbps = maxMbps;
        }

        /// <summary> Maximum volume capacity in GiB. </summary>
        public long? MaxSizeGiB { get; }
        /// <summary> Minimum volume capacity in GiB. </summary>
        public long? MinSizeGiB { get; }
        /// <summary> Increment volume capacity in GiB. </summary>
        public long? MinIncrementSizeGiB { get; }
        /// <summary> Maximum IOPS per GiB. </summary>
        public long? IopsPerBaseGiB { get; }
        /// <summary> Maximum IOPS. </summary>
        public long? MaxIops { get; }
        /// <summary> Maximum MBps. </summary>
        public long? MaxMbps { get; }
    }
}
