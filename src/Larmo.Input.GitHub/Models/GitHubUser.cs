using System.Runtime.Serialization;

namespace Larmo.Input.GitHub.Models
{
    [DataContract]
    public class GitHubUser
    {
        [DataMember(Name = "id")]
        public uint Id { get; set; }

        [DataMember(Name = "login")]
        public string Login { get; set; }

        [DataMember(Name = "avatar_url")]
        public string AvatarUrl { get; set; }

        [DataMember(Name = "html_url")]
        public string ProfileUrl { get; set; }
    }
}
