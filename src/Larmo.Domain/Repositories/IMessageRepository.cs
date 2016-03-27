using Larmo.Domain.Domain;

namespace Larmo.Domain.Repositories
{
    public interface IMessageRepository
    {
        Message GetById(int messageId);
        void Add(Message message);
    }
}