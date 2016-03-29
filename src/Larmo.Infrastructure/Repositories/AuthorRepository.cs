using System.Data;
using ServiceStack.OrmLite;
using Larmo.Domain.Domain;
using Larmo.Domain.Repositories;

namespace Larmo.Infrastructure.Repositories
{
    public class AuthorRepository : IAuthorRepository
    {
        private readonly IDbConnection _database;

        public AuthorRepository(IDbConnection databse)
        {
            _database = databse;
        }

        public Author GetByEmail(string authorEmail)
        {
            return _database.Single<Author>(i => i.Email.ToLower() == authorEmail.ToLower());
        }

        public void Add(Author author)
        {
            _database.Insert(author);
        }
    }
}