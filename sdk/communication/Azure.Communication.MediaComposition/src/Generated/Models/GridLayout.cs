// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Communication.MediaComposition.Models;

namespace Azure.Communication.MediaComposition
{
    /// <summary> Configure the grid layout. </summary>
    public partial class GridLayout : MediaCompositionLayout
    {
        /// <summary> Initializes a new instance of <see cref="GridLayout"/>. </summary>
        /// <param name="rows"> Number of rows. </param>
        /// <param name="columns"> Number of columns. </param>
        /// <param name="inputIds"> Input ids to be included in the layout. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="inputIds"/> is null. </exception>
        public GridLayout(int rows, int columns, IEnumerable<IList<string>> inputIds)
        {
            if (inputIds == null)
            {
                throw new ArgumentNullException(nameof(inputIds));
            }

            Rows = rows;
            Columns = columns;
            InputIds = inputIds.ToList();
            Kind = LayoutType.Grid;
        }

        /// <summary> Initializes a new instance of <see cref="GridLayout"/>. </summary>
        /// <param name="kind"> Kind of layout. </param>
        /// <param name="resolution"> The dimensions of the scene or objects in the scene. </param>
        /// <param name="placeholderImageUri"> Set global placeholder image. </param>
        /// <param name="scalingMode"> The scaling mode for the view of a video stream in a cell. </param>
        /// <param name="rows"> Number of rows. </param>
        /// <param name="columns"> Number of columns. </param>
        /// <param name="inputIds"> Input ids to be included in the layout. </param>
        internal GridLayout(LayoutType kind, LayoutResolution resolution, string placeholderImageUri, ScalingMode? scalingMode, int rows, int columns, IList<IList<string>> inputIds) : base(kind, resolution, placeholderImageUri, scalingMode)
        {
            Rows = rows;
            Columns = columns;
            InputIds = inputIds;
            Kind = kind;
        }

        /// <summary> Number of rows. </summary>
        public int Rows { get; set; }
        /// <summary> Number of columns. </summary>
        public int Columns { get; set; }
        /// <summary> Input ids to be included in the layout. </summary>
        public IList<IList<string>> InputIds { get; }
    }
}
