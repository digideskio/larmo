namespace Larmo.Domain.Commands
{
    public class AddNewProject : ICommand
    {
        public readonly string Name;
        public readonly string Url;
        public readonly string Description;

        public AddNewProject(string name, string url = null, string description = null)
        {
            Name = name;
            Url = url;
            Description = description;
        }
    }
}
