﻿// Copyright (c) Microsoft Corporation
// The Microsoft Corporation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Microsoft.PowerToys.Settings.UI.Library
{
    public class PluginAdditionalOption
    {
        public string Key { get; set; }

        public string DisplayLabel { get; set; }

        /// <summary>
        /// Gets or sets a value to show a description of this setting in the settings ui. (Optional)
        /// </summary>
        public string DisplayDescription { get; set; }

        public bool Value { get; set; }
    }
}
