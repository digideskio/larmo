using Larmo.Domain.Domain;

namespace Larmo.Input.GitHub
{
    interface IGitHubReceiver
    {
        Message Execute();
    }
}
