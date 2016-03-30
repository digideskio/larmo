using Larmo.Domain.Domain;

namespace Larmo.Infrastructure.DTO
{
    public class MessageDto
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string Content { get; set; }
        public AuthorDto Author { get; set; }

        public static explicit operator MessageDto(Message from)
        {
            return new MessageDto
            {
                Id = from.Id,
                Url = from.Url,
                Content = from.Content,
                Author = (AuthorDto)from.Author
            };
        }
    }
}