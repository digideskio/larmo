using System.IO;
using System.Runtime.Serialization.Json;

namespace Larmo.Common
{
    public static class StreamExtensions
    {
        public static TElement JsonStreamToObject<TElement>(this Stream stream)
        {
            var jsonSerializer = new DataContractJsonSerializer(typeof(TElement));
            return (TElement)jsonSerializer.ReadObject(stream);
        }
    }
}
