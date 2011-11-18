using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using CommandProcessor.Sample.CommandHandlers;
using CommandProcessor.Sample.CommandMessages;
using CommandProcessor.Sample.Processes;
using StructureMap;
using StructureMap.Configuration.DSL;

namespace CommandProcessor.Sample.IoC
{
    public class DependencyRegistry : Registry
    {

        public DependencyRegistry()
        {
            Scan(x =>
            {
                x.AddAllTypesOf(typeof(IProcess<>)).NameBy(ProcessNamingConvention());
                x.AssemblyContainingType(typeof(UpdateEmployeeCommandMessageMessage));
                x.ConnectImplementationsToTypesClosing(typeof(ICommandHandler<>));
            });

            For<ICommandProcessor>().Use<CommandProcessor>();

            For<Func<string, IProcess<EnumerationCommandMessage<Database>>>>()
                .Use(ObjectFactory.GetNamedInstance<IProcess<EnumerationCommandMessage<Database>>>);

            For<IRepository>().Use<Repository>();

            For<Func<Type, IEnumerable<ICommandHandler>>>().Use(type => ObjectFactory.GetAllInstances(type).Cast<ICommandHandler>());
        }

        private static Func<Type, string> ProcessNamingConvention()
        {
            return type => type.Name.Replace("Process", "");
        }
    }
}