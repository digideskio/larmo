using System.Runtime.Serialization;

namespace Larmo.Input.GitHub.Models
{
    [DataContract]
    public class IssueComment
    {
        [DataMember(Name = "action")]
        public string Action { get; set; }

        [DataMember(Name = "issue")]
        public IssueData Issue { get; set; }

        [DataMember(Name = "comment")]
        public Comment Comment { get; set; }

        [DataMember(Name = "sender")]
        public GitHubUser Sender { get; set; }

        [DataMember(Name = "repository")]
        public Repository Repository { get; set; }
    }
}