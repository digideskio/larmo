using Larmo.Domain.Domain;

namespace Larmo.Input.GitHub
{
    interface IReceiver
    {
        Message Execute();
    }
}
