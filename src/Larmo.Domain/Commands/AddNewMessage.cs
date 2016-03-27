namespace Larmo.Domain.Commands
{
    public class AddNewMessage : ICommand
    {
        public readonly string ProjectToken;
        public readonly string InputName;

        public AddNewMessage(string projectToken, string inputName)
        {
            ProjectToken = projectToken;
            InputName = inputName;
        }
    }
}