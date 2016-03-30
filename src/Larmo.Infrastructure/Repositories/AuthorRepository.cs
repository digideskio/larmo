using System;
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
        
        public Author GetByData(string email, string login, string fullName)
        {
            try
            {
                return _database.Single<Author>(a =>
                    a.Email == email
                    && a.Login == login
                    && a.FullName == fullName
                );
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public Author Add(Author author)
        {
            _database.Save(author);

            return author;
        }
    }
}