using System;
using System.Collections;
using System.Collections.Generic;
using Larmo.Input.GitHub.Models;

namespace Larmo.Input.GitHub.Receivers
{
    public class DeleteReceiver : IGitHubReceiver
    {
        private readonly Delete _data;

        public string AuthorFullName => _data.Sender.Login;
        public string AuthorEmail => null;
        public string AuthorLogin => _data.Sender.Login;
        public string AuthorUrl => _data.Sender.ProfileUrl;

        public string Type => GitHubInput.EventNameDelete + "." + _data.RefType;
        public string Content => "Deleted " + _data.RefType;
        public string Url => null;
        public DateTime Timestamp => DateTime.Now; // @todo as a di

        public IDictionary Extras => new Dictionary<string, string>
        {
            {"repository", _data.Repository.Name},
            {"ref", _data.Ref}
        };

        public DeleteReceiver(Delete data)
        {
            _data = data;
        }
    }
}