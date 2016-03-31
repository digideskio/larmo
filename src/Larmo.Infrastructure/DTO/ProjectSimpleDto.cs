using Larmo.Domain.Domain;

namespace Larmo.Infrastructure.DTO
{
    public class ProjectSimpleDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public static explicit operator ProjectSimpleDto(Project from)
        {
            return new ProjectSimpleDto
            {
                Id = from.Id,
                Name = from.Name
            };
        }
    }

    public class ProjectDetailsDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }

        public static explicit operator ProjectDetailsDto(Project from)
        {
            return new ProjectDetailsDto
            {
                Id = from.Id,
                Name = from.Name,
                Url = from.Url,
                Description = from.Description
            };
        }
    }
}
