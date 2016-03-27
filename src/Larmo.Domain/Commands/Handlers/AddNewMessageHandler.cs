using Larmo.Domain.Domain;
using Larmo.Domain.Repositories;

namespace Larmo.Domain.Commands.Handlers
{
    public class AddNewMessageHandler : ICommandHandler<AddNewMessage>
    {
        private readonly IMessageRepository _messageRepository;

        public AddNewMessageHandler(IMessageRepository messageRepository)
        {
            _messageRepository = messageRepository;
        }

        public void Execute(AddNewMessage command)
        {
            _messageRepository.Add(new Message());
        }
    }
}