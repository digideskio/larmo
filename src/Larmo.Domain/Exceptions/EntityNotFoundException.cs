using System;

namespace Larmo.Domain.Exceptions
{
    public class EntityNotFoundException<TEntity> : Exception
    {
        public EntityNotFoundException(int entityId) : base($"Entity {typeof(TEntity).Name} with given Id: {entityId} could not be found!")
        {
        }

        public EntityNotFoundException(string entityToken) : base($"Entity {typeof(TEntity).Name} with given Token: \"{entityToken}\" could not be found!")
        {
        }
    }
}