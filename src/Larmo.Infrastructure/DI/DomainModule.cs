using Autofac;
using Larmo.Domain.Commands;
using Larmo.Infrastructure.Repositories;

namespace Larmo.Infrastructure.DI
{
    public class DomainModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            RegisterCommands(builder);
            RegisterRepositories(builder);
        }

        private void RegisterCommands(ContainerBuilder builder)
        {
            var commandDispatcherKey = "commandDispatcher";

            // builder.RegisterType<CommandDispatcher>().Named<ICommandDispatcher>(commandDispatcherKey);
            
            builder.RegisterType<CommandDispatcher>()
                .WithParameter(
                    (pi, _) => pi.ParameterType == typeof(ICommandDispatcher),
                    (_, ctx) => ctx.ResolveNamed<ICommandDispatcher>(commandDispatcherKey))
                .As<ICommandDispatcher>();

            builder.RegisterAssemblyTypes(typeof(ICommand).Assembly)
                   .AsClosedTypesOf(typeof(ICommandHandler<>))
                   .AsImplementedInterfaces();

            builder.RegisterAssemblyTypes(typeof(ICommand).Assembly)
                   .AsClosedTypesOf(typeof(ICommandHandler<,>))
                   .AsImplementedInterfaces();
        }

        private void RegisterRepositories(ContainerBuilder builder)
        {
            builder.RegisterType<MessageRepository>().AsImplementedInterfaces();
        }
    }
}