using System;
using System.IO;
using Larmo.Common;
using Larmo.Input.GitHub.Models;

namespace Larmo.Input.GitHub.Commands
{
    public class Message
    {
        public string Content { get; set; }
    }

    interface IReceiver
    {
        Message Execute();
    }

    public class PushReceiver : IReceiver
    {
        private readonly string _project;
        private readonly Push _data;

        public PushReceiver(string project, Push data)
        {
            _project = project;
            _data = data;
        }

        public Message Execute()
        {
            return new Message()
            {
                Content = "Test mesage"
            };
        }
    }

    public class Receiver
    {
        private readonly string _project;
        private readonly string _eventName;
        private readonly Stream _payload;
        private IReceiver _receiver;

        public Receiver(string project, string eventName, Stream payload)
        {
            _project = project;
            _eventName = eventName;
            _payload = payload;

            SetupReceiver();
        }

        private void SetupReceiver()
        {
            if (_eventName == EventName.Push)
            {
                _receiver = new PushReceiver(_project, _payload.JsonStreamToObject<Push>());
            }
        }

        public Message GetMessage()
        {
            if (_receiver == null)
            {
                throw new InvalidOperationException("Not supported GitHub event: " + _eventName);
            }
            
            return _receiver.Execute();
        }
    }
}
