using System.Data;
using ServiceStack.OrmLite;
using Larmo.Domain.Domain;
using Larmo.Infrastructure.DTO;
using Larmo.Domain.Extensions;

namespace Larmo.Infrastructure.Queries
{
    public class GetProjectById : IQuery<ProjectDto>
    {
        private readonly int ProjectId;

        public GetProjectById(int projectId)
        {
            ProjectId = projectId;
        }

        public ProjectDto Execute(IDbConnection database)
        {
            return (ProjectDto)database.SingleById<Project>(ProjectId).EnsureExists(ProjectId);
        }
    }
}