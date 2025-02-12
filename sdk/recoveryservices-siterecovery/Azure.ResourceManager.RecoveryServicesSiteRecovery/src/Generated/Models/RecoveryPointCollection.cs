// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.RecoveryServicesSiteRecovery;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Collection of recovery point details. </summary>
    internal partial class RecoveryPointCollection
    {
        /// <summary> Initializes a new instance of RecoveryPointCollection. </summary>
        internal RecoveryPointCollection()
        {
            Value = new ChangeTrackingList<RecoveryPointData>();
        }

        /// <summary> Initializes a new instance of RecoveryPointCollection. </summary>
        /// <param name="value"> The recovery point details. </param>
        /// <param name="nextLink"> The value of next link. </param>
        internal RecoveryPointCollection(IReadOnlyList<RecoveryPointData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The recovery point details. </summary>
        public IReadOnlyList<RecoveryPointData> Value { get; }
        /// <summary> The value of next link. </summary>
        public string NextLink { get; }
    }
}
