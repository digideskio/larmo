using Larmo.Domain.Domain;

namespace Larmo.Infrastructure.DTO
{
    public class ProjectDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }

        public static explicit operator ProjectDto(Project from)
        {
            return new ProjectDto
            {
                Id = from.Id,
                Name = from.Name,
                Url = from.Url
            };
        }
    }
}
