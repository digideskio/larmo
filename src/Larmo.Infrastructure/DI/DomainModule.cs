using Autofac;
using Larmo.Domain.Commands;

namespace Larmo.Infrastructure.DI
{
    public class DomainModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            RegisterCommanding(builder);
        }

        private void RegisterCommanding(ContainerBuilder builder)
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
    }
}