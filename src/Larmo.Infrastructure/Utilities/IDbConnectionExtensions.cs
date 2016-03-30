using System;
using System.Data;
using System.Linq.Expressions;
using ServiceStack.OrmLite;

namespace Larmo.Infrastructure.Utilities
{
    static class IDbConnectionExtensions
    {
        public static TType SingleOrDefault<TType>(this IDbConnection database, Expression<Func<TType, bool>> expression)
        {
            try
            {
                return database.Single<TType>(expression);
            }
            catch
            {
                return default(TType);
            }
        }
    }
}
