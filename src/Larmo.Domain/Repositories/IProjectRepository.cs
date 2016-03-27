using Larmo.Domain.Domain;

namespace Larmo.Domain.Repositories
{
    public interface IProjectRepository
    {
        Project GetById(int projectId);
        Project GetByName(string name);
        void Add(Project project);
    }
}