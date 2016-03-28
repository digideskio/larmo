using System;
using Larmo.Input.GitHub.Receivers;
using Larmo.Input.GitHub.Models;
using Newtonsoft.Json;

namespace Larmo.Input.GitHub
{
    public class GitHubReceiver
    {
        private readonly string _eventName;
        private readonly string _payload;

        public GitHubReceiver(string eventName, string payload)
        {
            _eventName = eventName;
            _payload = payload;
        }

        public IGitHubReceiver Parse()
        {
            if (_eventName == GitHubEventName.Push)
            {
                return new PushReceiver(JsonConvert.DeserializeObject<Push>(_payload));
            }

            throw new InvalidOperationException("Not supported GitHub event: " + _eventName);
        }
    }
}