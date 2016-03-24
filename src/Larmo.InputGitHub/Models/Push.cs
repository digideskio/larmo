using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Larmo.Input.GitHub.Models
{
    [DataContract]
    public class Push
    {
        [DataMember(Name = "compare")]
        public string Compare { get; set; }

        [DataMember(Name = "ref")]
        public string Ref { get; set; }

        [DataMember(Name = "pusher")]
        public GitUser Pusher { get; set; }

        [DataMember(Name = "sender")]
        public GitHubUser Sender { get; set; }

        [DataMember(Name = "repository")]
        public Repository Repository { get; set; }

        [DataMember(Name = "commits")]
        public IEnumerable<Commit> Commits { get; set; }
    }
}
