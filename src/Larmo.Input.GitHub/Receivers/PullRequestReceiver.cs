using System;
using System.Collections;
using System.Collections.Generic;
using Larmo.Input.GitHub.Models;

namespace Larmo.Input.GitHub.Receivers
{
    public class PullRequestReceiver : IGitHubReceiver
    {
        private readonly PullRequest _data;

        public string AuthorFullName => _data.Sender.Login;
        public string AuthorEmail => null;
        public string AuthorLogin => _data.Sender.Login;

        public string Type => GitHubInput.EventNamePullRequest + "." + _data.Action;
        public string Content => _data.PullRequestData.Title;
        public string Url => _data.PullRequestData.Url;
        public DateTime Timestamp => _data.PullRequestData.CreatedAt;

        public IDictionary Extras => new Dictionary<string, string>
        {
            {"head", _data.PullRequestData.HeadBranch.Ref},
            {"base", _data.PullRequestData.BaseBranch.Ref},
            {"repository", _data.Repository.Name}
        };

        public PullRequestReceiver(PullRequest data)
        {
            _data = data;
        }
    }
}
