using ServiceStack.DataAnnotations;

namespace Larmo.Domain.Domain
{
    public class Author
    {
        [AutoIncrement]
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public string Url { get; set; }
    }
}