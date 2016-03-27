using System.Runtime.Serialization;

namespace Larmo.Input.GitHub.Models
{
    [DataContract]
    public class GitUser
    {
        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "email")]
        public string Email { get; set; }

        [DataMember(Name = "username")]
        public string Username { get; set; }
    }
}
