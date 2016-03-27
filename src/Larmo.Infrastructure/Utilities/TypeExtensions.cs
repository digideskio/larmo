using System;

namespace Larmo.Infrastructure.Utilities
{
    public static class TypeExtensions
    {
        public static bool IsInstanceOfGenericType(this Type type, Type genericType)
        {
            // http://stackoverflow.com/a/982540
            while (type != null)
            {
                if (type.IsGenericType &&
                    type.GetGenericTypeDefinition() == genericType)
                {
                    return true;
                }
                type = type.BaseType;
            }
            return false;
        }
    }
}