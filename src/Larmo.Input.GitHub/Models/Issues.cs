using System;
using System.Runtime.Serialization;
using System.Security.Policy;

namespace Larmo.Input.GitHub.Models
{
    [DataContract]
    public class Issues
    {
        [DataMember(Name = "action")]
        public string Action { get; set; }

        [DataMember(Name = "issue")]
        public IssueData IssueData { get; set; }

        [DataMember(Name = "repository")]
        public Repository Repository { get; set; }

        [DataMember(Name = "sender")]
        public GitHubUser Sender { get; set; }
    }

    [DataContract]
    public class IssueData
    {
        [DataMember(Name = "number")]
        public string Id { get; set; }

        [DataMember(Name = "html_url")]
        public string Url { get; set; }

        [DataMember(Name = "title")]
        public string Title { get; set; }

        [DataMember(Name = "state")]
        public string State { get; set; }

        [DataMember(Name = "created_at")]
        public DateTime CreatedAt { get; set; }

        [DataMember(Name = "body")]
        public string Body { get; set; }
    }
}