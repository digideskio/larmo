using System;

namespace Larmo.Domain.Exceptions
{
    public class EntityNotFoundException<TEntity> : Exception
    {
        public EntityNotFoundException(int entityId) : base($"Entity {typeof(TEntity).Name} with given Id: {entityId} could not be found!")
        {
        }
    }
}