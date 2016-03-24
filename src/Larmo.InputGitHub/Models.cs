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

        [DataMember(Name = "sender")] // @todo
        public GithubUser Sender { get; set; }

        [DataMember(Name = "repository")]
        public Repository Repository { get; set; }
        
        [DataMember(Name = "commits")]
        public IEnumerable<Commit> Commits { get; set; }
    }

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

    [DataContract]
    public class GithubUser
    {
        [DataMember(Name = "id")]
        public uint Id { get; set; }

        [DataMember(Name = "login")]
        public string Login { get; set; }

        [DataMember(Name = "avatar_url")]
        public string Avatar { get; set; }

        [DataMember(Name = "html_url")]
        public string ProfileUrl { get; set; }
    }

    [DataContract]
    public class Commit
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "message")]
        public string Message { get; set; }

        //[DataMember(Name = "timestamp")]  // @todo
        //public DateTime Date { get; set; }

        [DataMember(Name = "url")]
        public string Url { get; set; }

        [DataMember(Name = "author")]
        public GitUser Author { get; set; }
    }

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
