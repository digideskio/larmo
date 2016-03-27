using System.Linq;
using System.Data;
using System.Collections.Generic;
using ServiceStack.OrmLite;
using Larmo.Domain.Domain;
using Larmo.Infrastructure.DTO;

namespace Larmo.Infrastructure.Queries
{
    public class GetAllProjects : IQuery<IEnumerable<ProjectDto>>
    {
        public IEnumerable<ProjectDto> Execute(IDbConnection database)
        {
            return database.Select<Project>()
                .OrderBy(p => p.Id)
                .Select(p => (ProjectDto)p);
        }
    }
}