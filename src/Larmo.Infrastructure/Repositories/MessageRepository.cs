using System.Data;
using Larmo.Domain.Domain;
using Larmo.Domain.Repositories;
using ServiceStack.OrmLite;

namespace Larmo.Infrastructure.Repositories
{
    public class MessageRepository : IMessageRepository
    {
        private readonly IDbConnection _database;

        public MessageRepository(IDbConnection databse)
        {
            _database = databse;
        }

        public Message GetById(int messageId)
        {
            return _database.SingleById<Message>(messageId);
        }

        public void Add(Message message)
        {
            _database.Save(message, true);
        }
    }
}