using System.Data;

namespace Larmo.Infrastructure.Queries
{
    public interface IQuery<out TResult>
    {
        TResult Execute(IDbConnection database);
    }

    public interface IQueryDispatcher
    {
        TResult Execute<TResult>(IQuery<TResult> query);
    }

    public class QueryDispatcher : IQueryDispatcher
    {
        private readonly IDbConnection _database;

        public QueryDispatcher(IDbConnection database)
        {
            _database = database;
        }

        public TResult Execute<TResult>(IQuery<TResult> query)
        {
            return query.Execute(_database);
        }
    }
}
