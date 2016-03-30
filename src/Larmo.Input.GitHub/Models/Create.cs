using System.Runtime.Serialization;

namespace Larmo.Input.GitHub.Models
{
    [DataContract]
    public class Create
    {
        [DataMember(Name = "ref")]
        public string Ref { get; set; }
        
        [DataMember(Name = "ref_type")]
        public string RefType { get; set; }

        [DataMember(Name = "master_branch")]
        public string MasterBranch { get; set; }

        [DataMember(Name = "description")]
        public string Description { get; set; }
        
        [DataMember(Name = "repository")]
        public Repository Repository { get; set; }

        [DataMember(Name = "sender")]
        public GitHubUser Sender { get; set; }
    }
}
