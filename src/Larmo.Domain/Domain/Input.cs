using ServiceStack.DataAnnotations;

namespace Larmo.Domain.Domain
{
    public class Input
    {
        [AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
