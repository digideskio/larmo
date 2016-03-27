namespace Larmo.Domain.Commands
{
    public interface ICommand
    {
    }

    public interface ICommandDispatcher
    {
        void Execute<TCommand>(TCommand command)
            where TCommand : ICommand;

        TReturn Execute<TCommand, TReturn>(TCommand command)
            where TCommand : ICommand;
    }

    public interface ICommandHandler<in TCommand>
        where TCommand : ICommand
    {
        void Execute(TCommand command);
    }

    public interface ICommandHandler<in TCommand, out TReturn>
        where TCommand : ICommand
    {
        TReturn Execute(TCommand command);
    }
}
