using System;
using System.Runtime.Serialization;

namespace Larmo.Input.GitHub.Models
{
    [DataContract]
    public class IssueData
    {
        [DataMember(Name = "number")]
        public uint Id { get; set; }

        [DataMember(Name = "html_url")]
        public string Url { get; set; }

        [DataMember(Name = "title")]
        public string Title { get; set; }

        [DataMember(Name = "state")]
        public string State { get; set; }

        [DataMember(Name = "created_at")]
        public DateTime CreatedAt { get; set; }

        [DataMember(Name = "body")]
        public string Content { get; set; }
    }
}
