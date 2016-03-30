using System.Data;
using ServiceStack.OrmLite;
using Larmo.Domain.Domain;
using Larmo.Domain.Repositories;
using Larmo.Infrastructure.Utilities;

namespace Larmo.Infrastructure.Repositories
{
    public class AuthorRepository : IAuthorRepository
    {
        private readonly IDbConnection _database;

        public AuthorRepository(IDbConnection databse)
        {
            _database = databse;
        }
        
        public Author GetByData(string email, string login, string fullName)
        {
            return _database.SingleOrDefault<Author>(a =>
                a.Email == email && a.Login == login && a.FullName == fullName
            );
        }

        public Author Add(Author author)
        {
            _database.Save(author);

            return author;
        }
    }
}