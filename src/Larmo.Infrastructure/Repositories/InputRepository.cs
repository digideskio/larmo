using System.Data;
using ServiceStack.OrmLite;
using Larmo.Domain.Domain;
using Larmo.Domain.Repositories;

namespace Larmo.Infrastructure.Repositories
{
    public class InputRepository : IInputRepository
    {
        private readonly IDbConnection _database;

        public InputRepository(IDbConnection databse)
        {
            _database = databse;
        }

        public Input GetByName(string name)
        {
            return _database.Single<Input>(i => i.Name.ToLower() == name.ToLower());
        }
    }
}