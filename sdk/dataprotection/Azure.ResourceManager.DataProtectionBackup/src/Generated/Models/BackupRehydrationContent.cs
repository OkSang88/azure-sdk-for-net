// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    /// <summary> Azure Backup Rehydrate Request. </summary>
    public partial class BackupRehydrationContent
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="BackupRehydrationContent"/>. </summary>
        /// <param name="recoveryPointId"> Id of the recovery point to be recovered. </param>
        /// <param name="rehydrationRetentionDuration"> Retention duration in ISO 8601 format i.e P10D . </param>
        /// <exception cref="ArgumentNullException"> <paramref name="recoveryPointId"/> is null. </exception>
        public BackupRehydrationContent(string recoveryPointId, TimeSpan rehydrationRetentionDuration)
        {
            if (recoveryPointId == null)
            {
                throw new ArgumentNullException(nameof(recoveryPointId));
            }

            RecoveryPointId = recoveryPointId;
            RehydrationRetentionDuration = rehydrationRetentionDuration;
        }

        /// <summary> Initializes a new instance of <see cref="BackupRehydrationContent"/>. </summary>
        /// <param name="recoveryPointId"> Id of the recovery point to be recovered. </param>
        /// <param name="rehydrationPriority"> Priority to be used for rehydration. Values High or Standard. </param>
        /// <param name="rehydrationRetentionDuration"> Retention duration in ISO 8601 format i.e P10D . </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BackupRehydrationContent(string recoveryPointId, BackupRehydrationPriority? rehydrationPriority, TimeSpan rehydrationRetentionDuration, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            RecoveryPointId = recoveryPointId;
            RehydrationPriority = rehydrationPriority;
            RehydrationRetentionDuration = rehydrationRetentionDuration;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="BackupRehydrationContent"/> for deserialization. </summary>
        internal BackupRehydrationContent()
        {
        }

        /// <summary> Id of the recovery point to be recovered. </summary>
        public string RecoveryPointId { get; }
        /// <summary> Priority to be used for rehydration. Values High or Standard. </summary>
        public BackupRehydrationPriority? RehydrationPriority { get; set; }
        /// <summary> Retention duration in ISO 8601 format i.e P10D . </summary>
        public TimeSpan RehydrationRetentionDuration { get; }
    }
}
