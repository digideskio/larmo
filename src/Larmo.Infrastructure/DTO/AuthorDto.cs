using Larmo.Domain.Domain;

namespace Larmo.Infrastructure.DTO
{
    public class AuthorDto
    {
        public string FullName {get; set; }
        public string NickName { get; set; }
        public string Email { get; set; }

        public static explicit operator AuthorDto(Author from)
        {
            if (from == null)
            {
                return null;
            }

            return new AuthorDto
            {
                FullName = from.FullName,
                NickName = from.Login,
                Email = from.Email
            };
        }
    }
}