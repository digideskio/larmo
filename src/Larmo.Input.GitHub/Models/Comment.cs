using System;
using System.Runtime.Serialization;

namespace Larmo.Input.GitHub.Models
{
    [DataContract]
    public class Comment
    {
        [DataMember(Name = "id")]
        public uint Id { get; set; }

        [DataMember(Name = "html_url")]
        public string Url { get; set; }

        [DataMember(Name = "user")]
        public GitHubUser User { get; set; }

        [DataMember(Name = "created_at")]
        public DateTime Timestamp { get; set; }
      
        [DataMember(Name = "body")]
        public string Content { get; set; }
    }
}