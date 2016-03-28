﻿using Larmo.Domain.Domain;
using Larmo.Domain.Extensions;
using Larmo.Domain.Repositories;

namespace Larmo.Domain.Commands.Handlers
{
    public class AddNewMessageHandler : ICommandHandler<AddNewMessage>
    {
        private readonly IMessageRepository _messageRepository;
        private readonly IProjectRepository _projectRepository;
        private readonly IInputRepository _inputRepository;

        public AddNewMessageHandler(IMessageRepository messageRepository, IProjectRepository projectRepository,
            IInputRepository inputRepository)
        {
            _messageRepository = messageRepository;
            _projectRepository = projectRepository;
            _inputRepository = inputRepository;
        }

        public void Execute(AddNewMessage command)
        {
            var project = _projectRepository.GetByToken(command.ProjectToken).EnsureExists(command.ProjectToken);
            var input = _inputRepository.GetByName(command.Input.Name).EnsureExists(command.Input.Name);

            _messageRepository.Add(new Message
            {
                InputType = command.Input.ToString(),
                InputId = input.Id,
                ProjectId = project.Id,
                Content = command.Content,
                Url = command.Url,
                Timestamp = command.Timestamp
            });
        }
    }
}