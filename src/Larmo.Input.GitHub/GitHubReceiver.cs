﻿using System;
using Larmo.Domain.Domain;
using Larmo.Input.GitHub.Receivers;
using Larmo.Input.GitHub.Models;
using Newtonsoft.Json;

namespace Larmo.Input.GitHub
{
    public class GitHubReceiver
    {
        private readonly string _eventName;
        private readonly string _payload;
        private readonly IGitHubReceiver _receiver;

        public GitHubReceiver(string eventName, string payload)
        {
            _eventName = eventName;
            _payload = payload;

            _receiver = GetReceiver();
        }

        private IGitHubReceiver GetReceiver()
        {
            if (_eventName == EventName.Push)
            {
                return new PushReceiver(JsonConvert.DeserializeObject<Push>(_payload));
            }

            throw new InvalidOperationException("Not supported GitHub event: " + _eventName);
        }

        public Message GetMessage()
        {
            return _receiver.Execute();
        }
    }
}