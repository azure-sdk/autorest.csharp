// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

namespace CognitiveSearch.Models
{
    /// <summary> Output field mapping for a skill. </summary>
    public partial class OutputFieldMappingEntry
    {
        /// <summary> The name of the output defined by the skill. </summary>
        public string Name { get; set; }
        /// <summary> The target name of the output. It is optional and default to name. </summary>
        public string TargetName { get; set; }
    }
}
