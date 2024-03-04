// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Communication.MediaComposition;
using Azure.Core;

namespace Azure.Communication.MediaComposition.Models
{
    public partial class MediaInput : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
            if (PlaceholderImageUri != null)
            {
                writer.WritePropertyName("placeholderImageUri"u8);
                writer.WriteStringValue(PlaceholderImageUri);
            }
            writer.WriteEndObject();
        }

        internal static MediaInput DeserializeMediaInput(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("kind", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "activePresenter": return ActivePresenter.DeserializeActivePresenter(element);
                    case "dominantSpeaker": return DominantSpeaker.DeserializeDominantSpeaker(element);
                    case "groupCall": return GroupCallInput.DeserializeGroupCallInput(element);
                    case "image": return ImageInput.DeserializeImageInput(element);
                    case "participant": return ParticipantInput.DeserializeParticipantInput(element);
                    case "room": return RoomInput.DeserializeRoomInput(element);
                    case "rtmp": return RtmpInput.DeserializeRtmpInput(element);
                    case "screenShare": return ScreenShare.DeserializeScreenShare(element);
                    case "srt": return SrtInput.DeserializeSrtInput(element);
                    case "teamsMeeting": return TeamsMeetingInput.DeserializeTeamsMeetingInput(element);
                }
            }
            return UnknownMediaInput.DeserializeUnknownMediaInput(element);
        }
    }
}
