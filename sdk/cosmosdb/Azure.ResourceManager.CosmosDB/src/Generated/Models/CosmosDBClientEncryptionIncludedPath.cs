// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> . </summary>
    public partial class CosmosDBClientEncryptionIncludedPath
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

        /// <summary> Initializes a new instance of <see cref="CosmosDBClientEncryptionIncludedPath"/>. </summary>
        /// <param name="path"> Path that needs to be encrypted. </param>
        /// <param name="clientEncryptionKeyId"> The identifier of the Client Encryption Key to be used to encrypt the path. </param>
        /// <param name="encryptionType"> The type of encryption to be performed. Eg - Deterministic, Randomized. </param>
        /// <param name="encryptionAlgorithm"> The encryption algorithm which will be used. Eg - AEAD_AES_256_CBC_HMAC_SHA256. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="path"/>, <paramref name="clientEncryptionKeyId"/>, <paramref name="encryptionType"/> or <paramref name="encryptionAlgorithm"/> is null. </exception>
        public CosmosDBClientEncryptionIncludedPath(string path, string clientEncryptionKeyId, string encryptionType, string encryptionAlgorithm)
        {
            if (path == null)
            {
                throw new ArgumentNullException(nameof(path));
            }
            if (clientEncryptionKeyId == null)
            {
                throw new ArgumentNullException(nameof(clientEncryptionKeyId));
            }
            if (encryptionType == null)
            {
                throw new ArgumentNullException(nameof(encryptionType));
            }
            if (encryptionAlgorithm == null)
            {
                throw new ArgumentNullException(nameof(encryptionAlgorithm));
            }

            Path = path;
            ClientEncryptionKeyId = clientEncryptionKeyId;
            EncryptionType = encryptionType;
            EncryptionAlgorithm = encryptionAlgorithm;
        }

        /// <summary> Initializes a new instance of <see cref="CosmosDBClientEncryptionIncludedPath"/>. </summary>
        /// <param name="path"> Path that needs to be encrypted. </param>
        /// <param name="clientEncryptionKeyId"> The identifier of the Client Encryption Key to be used to encrypt the path. </param>
        /// <param name="encryptionType"> The type of encryption to be performed. Eg - Deterministic, Randomized. </param>
        /// <param name="encryptionAlgorithm"> The encryption algorithm which will be used. Eg - AEAD_AES_256_CBC_HMAC_SHA256. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CosmosDBClientEncryptionIncludedPath(string path, string clientEncryptionKeyId, string encryptionType, string encryptionAlgorithm, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Path = path;
            ClientEncryptionKeyId = clientEncryptionKeyId;
            EncryptionType = encryptionType;
            EncryptionAlgorithm = encryptionAlgorithm;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="CosmosDBClientEncryptionIncludedPath"/> for deserialization. </summary>
        internal CosmosDBClientEncryptionIncludedPath()
        {
        }

        /// <summary> Path that needs to be encrypted. </summary>
        public string Path { get; set; }
        /// <summary> The identifier of the Client Encryption Key to be used to encrypt the path. </summary>
        public string ClientEncryptionKeyId { get; set; }
        /// <summary> The type of encryption to be performed. Eg - Deterministic, Randomized. </summary>
        public string EncryptionType { get; set; }
        /// <summary> The encryption algorithm which will be used. Eg - AEAD_AES_256_CBC_HMAC_SHA256. </summary>
        public string EncryptionAlgorithm { get; set; }
    }
}
