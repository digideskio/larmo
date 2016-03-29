using System.Linq;
using System.Data;
using System.Collections.Generic;
using ServiceStack.OrmLite;
using Larmo.Domain.Domain;
using Larmo.Infrastructure.DTO;

namespace Larmo.Infrastructure.Queries
{
    public class GetAllSupportedInputs : IQuery<IEnumerable<InputDto>>
    {
        public IEnumerable<InputDto> Execute(IDbConnection database)
        {
            return database.Select<Input>()
                .OrderBy(i => i.Name)
                .Select(p => (InputDto)p);
        }
    }
}