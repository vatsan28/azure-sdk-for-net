// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Quota.Models
{
    /// <summary> The OperationDisplay. </summary>
    public partial class OperationDisplay
    {
        /// <summary> Initializes a new instance of OperationDisplay. </summary>
        internal OperationDisplay()
        {
        }

        /// <summary> Initializes a new instance of OperationDisplay. </summary>
        /// <param name="provider"> Provider name. </param>
        /// <param name="resource"> Resource name. </param>
        /// <param name="operation"> Operation name. </param>
        /// <param name="description"> Operation description. </param>
        internal OperationDisplay(string provider, string resource, string operation, string description)
        {
            Provider = provider;
            Resource = resource;
            Operation = operation;
            Description = description;
        }

        /// <summary> Provider name. </summary>
        public string Provider { get; }
        /// <summary> Resource name. </summary>
        public string Resource { get; }
        /// <summary> Operation name. </summary>
        public string Operation { get; }
        /// <summary> Operation description. </summary>
        public string Description { get; }
    }
}
