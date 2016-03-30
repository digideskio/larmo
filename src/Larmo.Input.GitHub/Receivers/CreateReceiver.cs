using System;
using System.Collections;
using System.Collections.Generic;
using Larmo.Input.GitHub.Models;

namespace Larmo.Input.GitHub.Receivers
{
    public class CreateReceiver : IGitHubReceiver
    {
        private readonly Create _data;

        public string AuthorFullName => _data.Sender.Login;
        public string AuthorEmail => null;
        public string AuthorLogin => _data.Sender.Login;

        public string Type => GitHubInput.EventNameCreate + "." + _data.RefType;
        public string Content => "Created " + _data.RefType;
        public string Url => _data.Repository.Url + "/" + _data.Ref;
        public DateTime Timestamp => DateTime.Now; // @todo as a di

        public IDictionary Extras => new Dictionary<string, string>
        {
            {"repository", _data.Repository.Name},
            {"ref", _data.Ref}
        };

        public CreateReceiver(Create data)
        {
            _data = data;
        }
    }
}
