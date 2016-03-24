using Larmo.Input.GitHub.Models;

namespace Larmo.Input.GitHub.Commands
{
    public class ReceivePush
    {
        private readonly string _project;
        private readonly Push _data;

        public ReceivePush(string project, Push data)
        {
            _project = project;
            _data = data;
        }
    }
}
