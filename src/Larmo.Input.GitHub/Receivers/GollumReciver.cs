using System;
using System.Collections;
using System.Linq;
using Larmo.Input.GitHub.Models;
using System.Collections.Generic;

namespace Larmo.Input.GitHub.Receivers
{
    public class GollumReciver : IGitHubReceiver
    {
        private readonly Gollum _data;

        public string AuthorFullName => _data.Sender.Login;
        public string AuthorEmail => null;
        public string AuthorLogin => _data.Sender.Login;
        public string AuthorUrl => _data.Sender.ProfileUrl;

        public string Type => GitHubInput.EventNameGollum;
        public string Content => "Edited " + _data.Pages.Count() + " Wiki page" + (_data.Pages.Count() > 1 ? "s" : "");
        public string Url => _data.Repository.Url + "/wiki";
        public DateTime Timestamp => DateTime.Now;

        public IDictionary Extras
        {
            get
            {
                var extras = new Dictionary<string, string>
                {
                    {"repository", _data.Repository.Name}
                };

                foreach (var page in _data.Pages)
                {
                    extras.Add("page." + page.Id.ToLower() + ".title", page.Title);
                    extras.Add("page." + page.Id.ToLower() + ".url", page.Url);

                    if (page.Summary != null)
                    {
                        extras.Add("page." + page.Id.ToLower() + ".summary", page.Summary);
                    }
                }
                
                return extras;
            }
        }

        public GollumReciver(Gollum data)
        {
            _data = data;
        }
    }
}