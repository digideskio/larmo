﻿namespace Larmo.Input.GitHub
{
    public class GitHubInput
    {
        public static string Name = "github";
        public static string EventNameHeader = "HTTP_X_GITHUB_EVENT";
        public static string EventNamePush = "push";
        public static string EventNameCreate = "create";
        public static string EventNamePullRequest = "pull_request";
        public static string EventNameDelete = "delete";
        public static string EventNameIssues = "issues";
        public static string EventNameIssueComment = "issue_comment";
        public static string EventNameGollum = "gollum";
    }
}