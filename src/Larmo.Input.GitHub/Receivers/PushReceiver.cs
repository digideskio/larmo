using System;
using System.Collections;
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

        public string Type => GitHubInput.EventNamePush;
        public string Content => "Pushed " + _data.Commits.Count() + " commit" + (_data.Commits.Count() > 1 ? "s" : "");
        public string Url => _data.CompareUrl;
        public DateTime Timestamp => DateTime.Now; // @todo as a di

        public IDictionary Extras
        {
            get
            {
                var extras = _data.Commits.ToDictionary(
                    commit => "commit." + commit.Id, commit => commit.Date + " " + commit.Message
                );

                extras.Add("repository", _data.Repository.Name);
                extras.Add("ref", _data.Ref);

                return extras;
            }
        }

        public PushReceiver(Push data)
        {
            _data = data;
        }
    }
}
