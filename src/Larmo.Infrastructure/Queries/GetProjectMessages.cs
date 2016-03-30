using System.Linq;
using System.Data;
using System.Collections.Generic;
using ServiceStack.OrmLite;
using Larmo.Domain.Domain;
using Larmo.Infrastructure.DTO;

namespace Larmo.Infrastructure.Queries
{
    public class GetProjectMessages : IQuery<IEnumerable<MessageDto>>
    {
        private readonly int _projectId;
        private readonly int _takeLimit;

        public GetProjectMessages(int projectId, int takeLimit = 50)
        {
            _projectId = projectId;
            _takeLimit = takeLimit;
        }

        public IEnumerable<MessageDto> Execute(IDbConnection database)
        {
            return database.LoadSelect<Message>(m => m.ProjectId == _projectId)
                .OrderByDescending(i => i.Timestamp)
                .Take(_takeLimit)
                .Select(m => (MessageDto)m);
        }
    }
}