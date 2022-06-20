// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.AI.TextAnalytics.Legacy.Models;

namespace Azure.AI.TextAnalytics.Legacy
{
    /// <summary> The TasksState. </summary>
    internal partial class TasksState
    {
        /// <summary> Initializes a new instance of TasksState. </summary>
        /// <param name="tasks"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="tasks"/> is null. </exception>
        internal TasksState(TasksStateTasks tasks)
        {
            if (tasks == null)
            {
                throw new ArgumentNullException(nameof(tasks));
            }

            Tasks = tasks;
        }

        /// <summary> Gets the tasks. </summary>
        public TasksStateTasks Tasks { get; }
    }
}
