using ServiceStack.DataAnnotations;

namespace Larmo.Domain.Domain
{
    public class Project
    {
        [AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public string Token { get; set; }

        public void UpdateDetails(string name, string url, string description)
        {
            Name = name;
            Url = url;
            Description = description;
        }
    }
}