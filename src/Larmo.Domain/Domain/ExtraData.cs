using ServiceStack.DataAnnotations;

namespace Larmo.Domain.Domain
{
    public class ExtraData
    {
        [AutoIncrement]
        public int Id { get; set; }
        public int MessageId { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
    }
}