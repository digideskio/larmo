namespace Larmo.Input.GitHub
{
    public class ReceiveCommand
    {
        private readonly string _project;
        private readonly string _eventName;
        private readonly string _data;

        public ReceiveCommand(string project, string eventName, string data)
        {
            _project = project;
            _eventName = eventName;
            _data = data;
        }
    }
}
