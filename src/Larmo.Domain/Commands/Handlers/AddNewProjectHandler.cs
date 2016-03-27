using Larmo.Domain.Domain;
using Larmo.Domain.Repositories;

namespace Larmo.Domain.Commands.Handlers
{
    public class AddNewProjectHandler : ICommandHandler<AddNewProject>
    {
        private readonly IProjectRepository _projectRepository;
        private readonly ITokenGenerator _tokenGenerator;

        public AddNewProjectHandler(IProjectRepository projectRepository, ITokenGenerator tokenGenerator)
        {
            _projectRepository = projectRepository;
            _tokenGenerator = tokenGenerator;
        }

        public void Execute(AddNewProject command)
        {
            _projectRepository.Add(new Project()
            {
                Name =  command.Name,
                Url = command.Url,
                Description = command.Description,
                Token = _tokenGenerator.Generate(command.Name)
            });
        }
    }
}