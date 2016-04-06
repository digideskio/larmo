using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Larmo.Domain.Domain;
using Larmo.Domain.Extensions;
using Larmo.Domain.Repositories;

namespace Larmo.Domain.Commands.Handlers
{
    public class AddNewMessageHandler : ICommandHandler<AddNewMessage>
    {
        private readonly IMessageRepository _messageRepository;
        private readonly IProjectRepository _projectRepository;
        private readonly IInputRepository _inputRepository;
        private readonly IAuthorRepository _authorRepository;

        public AddNewMessageHandler(IMessageRepository messageRepository, IProjectRepository projectRepository,
            IInputRepository inputRepository, IAuthorRepository authorRepository)
        {
            _messageRepository = messageRepository;
            _projectRepository = projectRepository;
            _inputRepository = inputRepository;
            _authorRepository = authorRepository;
        }

        public void Execute(AddNewMessage command)
        {
            var project = _projectRepository.GetByToken(command.ProjectToken).EnsureExists(command.ProjectToken);
            var input = _inputRepository.GetByName(command.Input.Name).EnsureExists(command.Input.Name);
            var extras = GetExtras(command.Extras);
            var author = GetAuthor(command.Author);
            
            _messageRepository.Add(new Message
            {
                InputType = command.Input.ToString(),
                InputId = input.Id,
                ProjectId = project.Id,
                AuthorId = author.Id,
                Content = command.Content,
                Url = command.Url,
                Timestamp = command.Timestamp,
                ExtraData = extras
            });
        }

        private List<ExtraData> GetExtras(IDictionary extras)
        {
            return (from object key in extras.Keys select new ExtraData
                {
                    Key = key.ToString(),
                    Value = extras[key].ToString()
                }).ToList();
        }

        private Author GetAuthor(AddNewMessageAuthor messageAuthor)
        {
            var email = messageAuthor.Email?.ToLower();
            var fullName = messageAuthor.FullName?.ToLower();
            var login = messageAuthor.Login?.ToLower();
            var url = messageAuthor.Url?.ToLower();

            var author = _authorRepository.GetByData(email, login, fullName);

            if (author != null)
            {
                return author;
            }

            return _authorRepository.Add(new Author
                {
                    Email = email,
                    FullName = fullName,
                    Login = login,
                    Url = url
                });    
        }
    }
}