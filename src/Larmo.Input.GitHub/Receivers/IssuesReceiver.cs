using System;
using System.Collections;
using System.Collections.Generic;
using Larmo.Input.GitHub.Models;

namespace Larmo.Input.GitHub.Receivers
{
    public class IssuesReceiver : IGitHubReceiver
    {
        private readonly Issues _data;

        public string AuthorFullName => _data.Sender.Login;
        public string AuthorEmail => null;
        public string AuthorLogin => _data.Sender.Login;

        public string Type => GitHubInput.EventNameIssues + "." + _data.IssueData.State;
        public string Content => _data.IssueData.Title;
        public string Url => _data.IssueData.Url;
        public DateTime Timestamp => _data.IssueData.CreatedAt;

        public IDictionary Extras => new Dictionary<string, string>
        {
            {"issue.id", _data.IssueData.Id},
            {"issue.body", _data.IssueData.Body},
            {"repository", _data.Repository.Name}
        };

        public IssuesReceiver(Issues data)
        {
            _data = data;
        }
    }
}
