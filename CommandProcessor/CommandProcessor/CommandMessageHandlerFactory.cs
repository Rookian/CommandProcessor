using System;
using System.Collections.Generic;
using System.Linq;

namespace CommandProcessor.CommandProcessor
{
    public class CommandMessageHandlerFactory : ICommandMessageHandlerFactory
    {
        private readonly Func<Type, ICommandHandler[]> _commands;
        private static readonly Type GenericHandler = typeof(ICommandHandler<>);

        public CommandMessageHandlerFactory(Func<Type, ICommandHandler[]> commands)
        {
            _commands = commands;
        }

        public IEnumerable<ICommandMessageHandler> GetCommands(Type messageType)
        {
            var concreteCommandType = GenericHandler.MakeGenericType(messageType);
            return _commands(concreteCommandType).Select(command => new CommandMessageHandlerProxy(command)).ToArray();
        }
    }
}
