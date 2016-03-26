using Larmo.Domain.Domain;
using Larmo.Input.GitHub.Models;

namespace Larmo.Input.GitHub.Receivers
{
    public class PushReceiver : IReceiver
    {
        private readonly Push _data;

        public PushReceiver(Push data)
        {
            _data = data;
        }

        public Message Execute()
        {
            return new Message()
            {
                Author = new Domain.Domain.Author
                {
                    Name = _data.Pusher.Name,
                    Email = _data.Pusher.Email
                },
                Input = new Domain.Domain.Input
                {
                    Name = "github", // @todo
                    Type = EventName.Push
                }
            };
        }
    }
}
