using Larmo.Domain.Domain;

namespace Larmo.Domain.Repositories
{
    public interface IAuthorRepository
    {
        Author GetByEmail(string authorEmail);
        void Add(Author author);
    }
}