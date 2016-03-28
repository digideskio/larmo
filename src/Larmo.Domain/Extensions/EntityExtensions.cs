using Larmo.Domain.Exceptions;

namespace Larmo.Domain.Extensions
{
    public static class EntityExtensions
    {
        public static TElement EnsureExists<TElement>(this TElement element, int id = 0)
        {
            if (element == null)
            {
                throw new EntityNotFoundException<TElement>(id);
            }

            return element;
        }

        public static TElement EnsureExists<TElement>(this TElement element, string token = "")
        {
            if (element == null)
            {
                throw new EntityNotFoundException<TElement>(token);
            }

            return element;
        }
    }
}