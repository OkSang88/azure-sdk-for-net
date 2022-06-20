// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Reservations.Models
{
    /// <summary> The ReservationMergeProperties. </summary>
    public partial class ReservationMergeProperties
    {
        /// <summary> Initializes a new instance of ReservationMergeProperties. </summary>
        internal ReservationMergeProperties()
        {
            MergeSources = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of ReservationMergeProperties. </summary>
        /// <param name="mergeDestination"> Reservation Resource Id Created due to the merge. Format of the resource Id is /providers/Microsoft.Capacity/reservationOrders/{reservationOrderId}/reservations/{reservationId}. </param>
        /// <param name="mergeSources"> Resource Ids of the Source Reservation&apos;s merged to form this Reservation. Format of the resource Id is /providers/Microsoft.Capacity/reservationOrders/{reservationOrderId}/reservations/{reservationId}. </param>
        internal ReservationMergeProperties(string mergeDestination, IReadOnlyList<string> mergeSources)
        {
            MergeDestination = mergeDestination;
            MergeSources = mergeSources;
        }

        /// <summary> Reservation Resource Id Created due to the merge. Format of the resource Id is /providers/Microsoft.Capacity/reservationOrders/{reservationOrderId}/reservations/{reservationId}. </summary>
        public string MergeDestination { get; }
        /// <summary> Resource Ids of the Source Reservation&apos;s merged to form this Reservation. Format of the resource Id is /providers/Microsoft.Capacity/reservationOrders/{reservationOrderId}/reservations/{reservationId}. </summary>
        public IReadOnlyList<string> MergeSources { get; }
    }
}
