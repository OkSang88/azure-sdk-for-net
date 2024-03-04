// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    /// <summary> Class encapsulating restore as files target parameters. </summary>
    public partial class RestoreFilesTargetInfo : RestoreTargetInfoBase
    {
        /// <summary> Initializes a new instance of <see cref="RestoreFilesTargetInfo"/>. </summary>
        /// <param name="recoverySetting"> Recovery Option. </param>
        /// <param name="targetDetails"> Destination of RestoreAsFiles operation, when destination is not a datasource. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="targetDetails"/> is null. </exception>
        public RestoreFilesTargetInfo(RecoverySetting recoverySetting, RestoreFilesTargetDetails targetDetails) : base(recoverySetting)
        {
            if (targetDetails == null)
            {
                throw new ArgumentNullException(nameof(targetDetails));
            }

            TargetDetails = targetDetails;
            ObjectType = "RestoreFilesTargetInfo";
        }

        /// <summary> Initializes a new instance of <see cref="RestoreFilesTargetInfo"/>. </summary>
        /// <param name="objectType"> Type of Datasource object, used to initialize the right inherited type. </param>
        /// <param name="recoverySetting"> Recovery Option. </param>
        /// <param name="restoreLocation"> Target Restore region. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="targetDetails"> Destination of RestoreAsFiles operation, when destination is not a datasource. </param>
        internal RestoreFilesTargetInfo(string objectType, RecoverySetting recoverySetting, AzureLocation? restoreLocation, IDictionary<string, BinaryData> serializedAdditionalRawData, RestoreFilesTargetDetails targetDetails) : base(objectType, recoverySetting, restoreLocation, serializedAdditionalRawData)
        {
            TargetDetails = targetDetails;
            ObjectType = objectType ?? "RestoreFilesTargetInfo";
        }

        /// <summary> Initializes a new instance of <see cref="RestoreFilesTargetInfo"/> for deserialization. </summary>
        internal RestoreFilesTargetInfo()
        {
        }

        /// <summary> Destination of RestoreAsFiles operation, when destination is not a datasource. </summary>
        public RestoreFilesTargetDetails TargetDetails { get; }
    }
}
