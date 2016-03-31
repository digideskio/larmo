using System;
using System.Collections;
using System.Collections.Generic;
using Larmo.Input.GitHub.Models;

namespace Larmo.Input.GitHub.Receivers
{
    public class IssueCommentReceiver : IGitHubReceiver
    {
        private readonly IssueComment _data;

        public string AuthorFullName => _data.Comment.User.Login;
        public string AuthorEmail => null;
        public string AuthorLogin => _data.Comment.User.Login;

        public string Type => GitHubInput.EventNameIssueComment + "." + _data.Action;
        public string Content => "Added comment to issue";
        public string Url => _data.Comment.Url;
        public DateTime Timestamp => _data.Comment.Timestamp;

        public IDictionary Extras => new Dictionary<string, string>
        {
            {"repository", _data.Repository.Name},
            {"issue.id", _data.Issue.Id.ToString()},
            {"issue.title", _data.Issue.Title},
            {"issue.url", _data.Issue.Url},
            {"comment.content", _data.Comment.Content}
        };

        public IssueCommentReceiver(IssueComment data)
        {
            _data = data;
        }
    }
}