using System;
using System.Runtime.Serialization;

namespace Larmo.Input.GitHub.Models
{
    [DataContract]
    public class PullRequest
    {
        [DataMember(Name = "number")]
        public uint Id { get; set; }

        [DataMember(Name = "action")]
        public string Action { get; set; }

        [DataMember(Name = "pull_request")]
        public PullRequestData PullRequestData { get; set; }

        [DataMember(Name = "repository")]
        public Repository Repository { get; set; }

        [DataMember(Name = "sender")]
        public GitHubUser Sender { get; set; }
    }

    [DataContract]
    public class PullRequestData
    {
        [DataMember(Name = "title")]
        public string Title { get; set; }

        [DataMember(Name = "html_url")]
        public string Url { get; set; }

        [DataMember(Name = "created_at")]
        public DateTime CreatedAt { get; set; }

        [DataMember(Name = "head")]
        public PullRequestDataBranch HeadBranch { get; set; }

        [DataMember(Name = "base")]
        public PullRequestDataBranch BaseBranch { get; set; }
    }

    public class PullRequestDataBranch
    {
        [DataMember(Name = "ref")]
        public string Ref { get; set; }

        [DataMember(Name = "repo")]
        public Repository Repository { get; set; }
    }
}
