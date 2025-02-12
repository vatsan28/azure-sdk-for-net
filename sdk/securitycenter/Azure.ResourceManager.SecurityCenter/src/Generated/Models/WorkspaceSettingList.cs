// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.SecurityCenter;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> List of workspace settings response. </summary>
    internal partial class WorkspaceSettingList
    {
        /// <summary> Initializes a new instance of WorkspaceSettingList. </summary>
        /// <param name="value"> List of workspace settings. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal WorkspaceSettingList(IEnumerable<SecurityWorkspaceSettingData> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of WorkspaceSettingList. </summary>
        /// <param name="value"> List of workspace settings. </param>
        /// <param name="nextLink"> The URI to fetch the next page. </param>
        internal WorkspaceSettingList(IReadOnlyList<SecurityWorkspaceSettingData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of workspace settings. </summary>
        public IReadOnlyList<SecurityWorkspaceSettingData> Value { get; }
        /// <summary> The URI to fetch the next page. </summary>
        public string NextLink { get; }
    }
}
