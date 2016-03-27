using System.Runtime.Serialization;

namespace Larmo.Input.GitHub.Models
{
    [DataContract]
    public class Repository
    {
        [DataMember(Name = "id")]
        public uint Id { get; set; }

        [DataMember(Name = "full_name")]
        public string Name { get; set; }

        [DataMember(Name = "description")]
        public string Description { get; set; }

        [DataMember(Name = "html_url")]
        public string Url { get; set; }

        [DataMember(Name = "owner")]
        public GitUser Owner { get; set; }
    }
}
