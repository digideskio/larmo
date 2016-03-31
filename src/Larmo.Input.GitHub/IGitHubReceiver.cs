using System;
using System.Collections;

namespace Larmo.Input.GitHub
{
    public interface IGitHubReceiver
    {
        string AuthorFullName { get; }
        string AuthorEmail { get; }
        string AuthorLogin { get; }
        string AuthorUrl { get; }

        string Type { get; }
        string Content { get; }
        string Url { get; }
        DateTime Timestamp { get; }

        IDictionary Extras { get; }
    }
}
