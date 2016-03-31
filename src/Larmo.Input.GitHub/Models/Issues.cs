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
}