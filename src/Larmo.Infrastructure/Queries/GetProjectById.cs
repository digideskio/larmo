using System.Data;
using ServiceStack.OrmLite;
using Larmo.Domain.Domain;
using Larmo.Infrastructure.DTO;
using Larmo.Domain.Extensions;

namespace Larmo.Infrastructure.Queries
{
    public class GetProjectById : IQuery<ProjectDetailsDto>
    {
        private readonly int ProjectId;

        public GetProjectById(int projectId)
        {
            ProjectId = projectId;
        }

        public ProjectDetailsDto Execute(IDbConnection database)
        {
            return (ProjectDetailsDto)database.SingleById<Project>(ProjectId).EnsureExists(ProjectId);
        }
    }
}