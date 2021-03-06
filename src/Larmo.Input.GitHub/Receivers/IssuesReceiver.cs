﻿using System;
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
        public string AuthorUrl => _data.Sender.ProfileUrl;

        public string Type => GitHubInput.EventNameIssues + "." + _data.IssueData.State;
        public string Content => _data.IssueData.State + " issue";
        public string Url => _data.IssueData.Url;
        public DateTime Timestamp => _data.IssueData.CreatedAt;

        public IDictionary Extras => new Dictionary<string, string>
        {
            {"issue.id", _data.IssueData.Id.ToString()},
            {"issue.title", _data.IssueData.Title},
            {"issue.content", _data.IssueData.Content},
            {"repository", _data.Repository.Name}
        };

        public IssuesReceiver(Issues data)
        {
            _data = data;
        }
    }
}
