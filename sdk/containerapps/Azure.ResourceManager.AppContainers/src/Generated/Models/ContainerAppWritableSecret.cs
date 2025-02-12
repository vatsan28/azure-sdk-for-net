// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> Secret definition. </summary>
    public partial class ContainerAppWritableSecret
    {
        /// <summary> Initializes a new instance of ContainerAppWritableSecret. </summary>
        public ContainerAppWritableSecret()
        {
        }

        /// <summary> Initializes a new instance of ContainerAppWritableSecret. </summary>
        /// <param name="name"> Secret Name. </param>
        /// <param name="value"> Secret Value. </param>
        internal ContainerAppWritableSecret(string name, string value)
        {
            Name = name;
            Value = value;
        }

        /// <summary> Secret Name. </summary>
        public string Name { get; set; }
        /// <summary> Secret Value. </summary>
        public string Value { get; set; }
    }
}
