// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Communication.MediaComposition.Models
{
    /// <summary> An image input. </summary>
    public partial class ImageInput
    {
        /// <summary> Initializes a new instance of ImageInput. </summary>
        /// <param name="uri"> Url of the image file. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="uri"/> is null. </exception>
        public ImageInput(string uri)
        {
            if (uri == null)
            {
                throw new ArgumentNullException(nameof(uri));
            }

            Uri = uri;
        }

        /// <summary> Url of the image file. </summary>
        public string Uri { get; set; }
    }
}
