using Larmo.Domain.Domain;

namespace Larmo.Domain.Repositories
{
    public interface IAuthorRepository
    {
        Author GetByData(string email, string login, string fullName);
        Author Add(Author author);
    }
}