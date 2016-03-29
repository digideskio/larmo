using Larmo.Domain.Domain;

namespace Larmo.Infrastructure.DTO
{
    public class InputDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }

        public static explicit operator InputDto(Input from)
        {
            return new InputDto
            {
                Id = from.Id,
                Name = from.Name,
                Url = "inputs/" + from.Name.ToLower() + "/{projectToken}"
            };
        }
    }
}