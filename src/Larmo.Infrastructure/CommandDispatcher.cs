using Autofac;
using Larmo.Domain.Commands;

namespace Larmo.Infrastructure
{
    public class CommandDispatcher : ICommandDispatcher
    {
        private readonly ILifetimeScope _scope;

        public CommandDispatcher(ILifetimeScope scope)
        {
            _scope = scope;
        }

        public void Execute<TCommand>(TCommand command) where TCommand : ICommand
        {
            var handler = _scope.Resolve<ICommandHandler<TCommand>>();

            if (handler == null)
            {
                throw new CommandHandlerNotFoundException<TCommand>();
            }

            handler.Execute(command);
        }

        public TReturn Execute<TCommand, TReturn>(TCommand command) where TCommand : ICommand
        {
            var handler = _scope.Resolve<ICommandHandler<TCommand, TReturn>>();

            if (handler == null)
            {
                throw new CommandHandlerNotFoundException<TCommand>();
            }

            return handler.Execute(command);
        }
    }
}
