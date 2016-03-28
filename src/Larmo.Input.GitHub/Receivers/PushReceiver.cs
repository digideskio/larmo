using System;
using System.Linq;
using Larmo.Input.GitHub.Models;

namespace Larmo.Input.GitHub.Receivers
{
    public class PushReceiver : IGitHubReceiver
    {
        private readonly Push _data;

        public string AuthorFullName => _data.Pusher.Name;
        public string AuthorEmail => _data.Pusher.Email;
        public string AuthorLogin => _data.Pusher.Username;

        public string Type => GitHubEventName.Push;
        public string Content => "Pushed " + _data.Commits.Count() + " commit" + (_data.Commits.Count() > 1 ? "s" : "");
        public string Url => _data.CompareUrl;
        public DateTime Timestamp => DateTime.Now; // @todo

        public PushReceiver(Push data)
        {
            _data = data;
        }
    }
}
