// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

namespace CognitiveSearch.Models
{
    /// <summary> Emits the entire input as a single token. This tokenizer is implemented using Apache Lucene. </summary>
    public partial class KeywordTokenizerV2 : Tokenizer
    {
        /// <summary> Initializes a new instance of KeywordTokenizerV2. </summary>
        public KeywordTokenizerV2()
        {
            OdataType = "#Microsoft.Azure.Search.KeywordTokenizerV2";
        }
        /// <summary> The maximum token length. Default is 256. Tokens longer than the maximum length are split. The maximum token length that can be used is 300 characters. </summary>
        public int? MaxTokenLength { get; set; }
    }
}
