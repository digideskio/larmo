using Larmo.Input.GitHub.Models;

namespace Larmo.Input.GitHub.Commands
{
    public class ReceivePush
    {
        private readonly string _project;
        private readonly string _eventName;
        private readonly Push _data;

        public ReceivePush(string project, string eventName, Push data)
        {
            _project = project;
            _eventName = eventName;
            _data = data;
        }
    }
}
