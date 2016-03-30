using System;
using Larmo.Input.GitHub.Receivers;
using Larmo.Input.GitHub.Models;
using Newtonsoft.Json;

namespace Larmo.Input.GitHub
{
    public class GitHubReceiver
    {
        private readonly string _eventName;
        private readonly string _json;

        public GitHubReceiver(string eventName, string json)
        {
            _eventName = eventName;
            _json = json;
        }

        public IGitHubReceiver Parse()
        {
            if (_eventName == GitHubInput.EventNamePush)
            {
                return new PushReceiver(JsonConvert.DeserializeObject<Push>(_json));
            }

            if (_eventName == GitHubInput.EventNameCreate)
            {
                return new CreateReceiver(JsonConvert.DeserializeObject<Create>(_json));
            }

            throw new InvalidOperationException("Not supported GitHub event: " + _eventName);
        }
    }
}