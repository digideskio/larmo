using Larmo.Domain.Extensions;
using Larmo.Domain.Repositories;

namespace Larmo.Domain.Commands.Handlers
{
    public class UpdateProjectHandler : ICommandHandler<UpdateProject>
    {
        private readonly IProjectRepository _projectRepository;

        public UpdateProjectHandler(IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }

        public void Execute(UpdateProject command)
        {
            var project = _projectRepository.GetById(command.ProjectId).EnsureExists(command.ProjectId);

            project.UpdateDetails(command.Name, command.Url, command.Description);
            
            _projectRepository.Update(project);
        }
    }
}