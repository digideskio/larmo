using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Larmo.Input.GitHub.Models
{
    [DataContract]
    public class Gollum
    {
        [DataMember(Name = "pages")]
        public IEnumerable<Page> Pages { get; set; }

        [DataMember(Name = "sender")]
        public GitHubUser Sender { get; set; }

        [DataMember(Name = "repository")]
        public Repository Repository { get; set; }
    }
}