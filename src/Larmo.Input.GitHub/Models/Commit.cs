using System;
using System.Runtime.Serialization;

namespace Larmo.Input.GitHub.Models
{
    [DataContract]
    public class Commit
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "message")]
        public string Message { get; set; }

        [DataMember(Name = "timestamp")]
        public DateTime Date { get; set; }

        [DataMember(Name = "url")]
        public string Url { get; set; }

        [DataMember(Name = "author")]
        public GitUser Author { get; set; }

        [DataMember(Name = "committer")]
        public GitUser Committer { get; set; }
    }
}
