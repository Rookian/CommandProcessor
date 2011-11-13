using System;
using System.Linq;
using CommandProcessor.CommandMessages;
using CommandProcessor.CommandProcessor;
using CommandProcessor.Processes;
using StructureMap;
using StructureMap.Configuration.DSL;

namespace CommandProcessor.IoC
{
    public class DependencyRegistry : Registry
    {

        public DependencyRegistry()
        {
            Scan(x =>
            {
                x.AddAllTypesOf(typeof(IProcess<>)).NameBy(ProcessNamingConvention());
                x.AssemblyContainingType(typeof(UpdateEmployeeCommandMessage));
                x.ConnectImplementationsToTypesClosing(typeof(ICommandHandler<>));
            });

            For<IMessageProcessor>().Use<MessageProcessor>();
            For<ICommandMessageHandlerFactory>().Use<CommandMessageHandlerFactory>();
            For<Func<string, IProcess<EnumerationCommand<Database>>>>().Use(ObjectFactory.GetNamedInstance<IProcess<EnumerationCommand<Database>>>);
            For<Func<Type, ICommandHandler[]>>().Use(type => ObjectFactory.GetAllInstances(type).Cast<ICommandHandler>().ToArray());
        }

        private static Func<Type, string> ProcessNamingConvention()
        {
            return type => type.Name.Replace("Process", "");
        }
    }
}