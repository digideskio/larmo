namespace Larmo.Domain.Commands
{
    public class UpdateProject : ICommand
    {
        public readonly int ProjectId;
        public readonly string Name;
        public readonly string Url;
        public readonly string Description;

        public UpdateProject(int projectId, string name, string url = null, string description = null)
        {
            ProjectId = projectId;
            Name = name;
            Url = url;
            Description = description;
        }
    }
}