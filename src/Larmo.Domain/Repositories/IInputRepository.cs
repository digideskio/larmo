using Larmo.Domain.Domain;

namespace Larmo.Domain.Repositories
{
    public interface IInputRepository
    {
        Input GetByName(string name);
    }
}