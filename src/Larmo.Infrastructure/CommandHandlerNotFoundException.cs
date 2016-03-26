using System;
using Larmo.Domain.Commands;

namespace Larmo.Infrastructure
{
    public class CommandHandlerNotFoundException<TCommand> : Exception
        where TCommand : ICommand
    {
        public CommandHandlerNotFoundException() : base($"Handler for `${typeof(TCommand).Name} was not found!")
        {
        }
    }
}
