// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace xml_service.Models
{
    /// <summary> An enumeration of blobs. </summary>
    public partial class ListBlobsResponse
    {
        /// <summary> Initializes a new instance of ListBlobsResponse. </summary>
        /// <param name="containerName"></param>
        /// <param name="prefix"></param>
        /// <param name="marker"></param>
        /// <param name="maxResults"></param>
        /// <param name="delimiter"></param>
        /// <param name="blobs"></param>
        /// <param name="nextMarker"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="containerName"/>, <paramref name="prefix"/>, <paramref name="marker"/>, <paramref name="delimiter"/>, <paramref name="blobs"/>, or <paramref name="nextMarker"/> is null. </exception>
        internal ListBlobsResponse(string containerName, string prefix, string marker, int maxResults, string delimiter, Blobs blobs, string nextMarker)
        {
            if (containerName == null)
            {
                throw new ArgumentNullException(nameof(containerName));
            }
            if (prefix == null)
            {
                throw new ArgumentNullException(nameof(prefix));
            }
            if (marker == null)
            {
                throw new ArgumentNullException(nameof(marker));
            }
            if (delimiter == null)
            {
                throw new ArgumentNullException(nameof(delimiter));
            }
            if (blobs == null)
            {
                throw new ArgumentNullException(nameof(blobs));
            }
            if (nextMarker == null)
            {
                throw new ArgumentNullException(nameof(nextMarker));
            }

            ContainerName = containerName;
            Prefix = prefix;
            Marker = marker;
            MaxResults = maxResults;
            Delimiter = delimiter;
            Blobs = blobs;
            NextMarker = nextMarker;
        }

        /// <summary> Initializes a new instance of ListBlobsResponse. </summary>
        /// <param name="serviceEndpoint"></param>
        /// <param name="containerName"></param>
        /// <param name="prefix"></param>
        /// <param name="marker"></param>
        /// <param name="maxResults"></param>
        /// <param name="delimiter"></param>
        /// <param name="blobs"></param>
        /// <param name="nextMarker"></param>
        internal ListBlobsResponse(string serviceEndpoint, string containerName, string prefix, string marker, int maxResults, string delimiter, Blobs blobs, string nextMarker)
        {
            ServiceEndpoint = serviceEndpoint;
            ContainerName = containerName;
            Prefix = prefix;
            Marker = marker;
            MaxResults = maxResults;
            Delimiter = delimiter;
            Blobs = blobs;
            NextMarker = nextMarker;
        }

        public string ServiceEndpoint { get; }
        public string ContainerName { get; }
        public string Prefix { get; }
        public string Marker { get; }
        public int MaxResults { get; }
        public string Delimiter { get; }
        public Blobs Blobs { get; }
        public string NextMarker { get; }
    }
}
