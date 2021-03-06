﻿using Newtonsoft.Json;
using System;

namespace Microsoft.AspNet.WebHooks.Payloads
{
    /// <summary>
    /// Contains information about the commit.
    /// </summary>
    public class GitCommit
    {
        /// <summary>
        /// The Id of the commit
        /// </summary>
        [JsonProperty("commitId")]
        public string CommitId { get; set; }

        /// <summary>
        /// The user that authoried the commit.
        /// </summary>
        [JsonProperty("author")]
        public GitUserInfo Author { get; set; }

        /// <summary>
        /// The user that committed the commit.
        /// </summary>
        [JsonProperty("committer")]
        public GitUserInfo Committer { get; set; }

        /// <summary>
        /// The commit comment.
        /// </summary>
        [JsonProperty("comment")]
        public string Comment { get; set; }

        /// <summary>
        /// The url of the commit.
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; set; }
    }
}