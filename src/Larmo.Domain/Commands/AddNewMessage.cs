namespace Larmo.Domain.Commands
{
    public class AddNewMessage : ICommand
    {
        public readonly string ProjectKey;
        public readonly string InputName;

        public AddNewMessage(string projectKey, string inputName)
        {
            ProjectKey = projectKey;
            InputName = inputName;
        }
    }
}