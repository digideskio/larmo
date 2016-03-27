using System.Linq;
using System.Data;
using System.Collections.Generic;
using ServiceStack.OrmLite;
using Larmo.Infrastructure.DTO;

namespace Larmo.Infrastructure.Queries
{
    public class GetAllProjects : IQuery<IEnumerable<Project>>
    {
        public IEnumerable<Project> Execute(IDbConnection database)
        {
            return database.Select<Domain.Domain.Project>()
                .OrderBy(p => p.Id)
                .Select(p => new Project
                {
                    Id = p.Id,
                    Name = p.Name,
                    Url = p.Url
                });
        }
    }
}