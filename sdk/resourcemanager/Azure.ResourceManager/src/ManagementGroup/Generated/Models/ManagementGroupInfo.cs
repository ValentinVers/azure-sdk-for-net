// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Management.Models
{
    /// <summary> The details of a management group. </summary>
    public partial class ManagementGroupInfo
    {
        /// <summary> Initializes a new instance of ManagementGroupInfo. </summary>
        internal ManagementGroupInfo()
        {
            Path = new ChangeTrackingList<ManagementGroupPathElement>();
            ManagementGroupAncestors = new ChangeTrackingList<string>();
            ManagementGroupAncestorChain = new ChangeTrackingList<ManagementGroupPathElement>();
        }

        /// <summary> Initializes a new instance of ManagementGroupInfo. </summary>
        /// <param name="version"> The version number of the object. </param>
        /// <param name="updatedTime"> The date and time when this object was last updated. </param>
        /// <param name="updatedBy"> The identity of the principal or process that updated the object. </param>
        /// <param name="parent"> (Optional) The ID of the parent management group. </param>
        /// <param name="path"> The path from the root to the current group. </param>
        /// <param name="managementGroupAncestors"> The ancestors of the management group. </param>
        /// <param name="managementGroupAncestorChain"> The ancestors of the management group displayed in reversed order, from immediate parent to the root. </param>
        internal ManagementGroupInfo(int? version, DateTimeOffset? updatedTime, string updatedBy, ParentManagementGroupInfo parent, IReadOnlyList<ManagementGroupPathElement> path, IReadOnlyList<string> managementGroupAncestors, IReadOnlyList<ManagementGroupPathElement> managementGroupAncestorChain)
        {
            Version = version;
            UpdatedTime = updatedTime;
            UpdatedBy = updatedBy;
            Parent = parent;
            Path = path;
            ManagementGroupAncestors = managementGroupAncestors;
            ManagementGroupAncestorChain = managementGroupAncestorChain;
        }

        /// <summary> The version number of the object. </summary>
        public int? Version { get; }
        /// <summary> The date and time when this object was last updated. </summary>
        public DateTimeOffset? UpdatedTime { get; }
        /// <summary> The identity of the principal or process that updated the object. </summary>
        public string UpdatedBy { get; }
        /// <summary> (Optional) The ID of the parent management group. </summary>
        public ParentManagementGroupInfo Parent { get; }
        /// <summary> The path from the root to the current group. </summary>
        public IReadOnlyList<ManagementGroupPathElement> Path { get; }
        /// <summary> The ancestors of the management group. </summary>
        public IReadOnlyList<string> ManagementGroupAncestors { get; }
        /// <summary> The ancestors of the management group displayed in reversed order, from immediate parent to the root. </summary>
        public IReadOnlyList<ManagementGroupPathElement> ManagementGroupAncestorChain { get; }
    }
}
