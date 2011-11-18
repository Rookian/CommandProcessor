using System;
using System.Collections.Generic;
using System.Linq;

namespace CommandProcessor
{
    public class CommandProcessor : ICommandProcessor
    {
        private readonly Func<Type, IEnumerable<ICommandHandler>> _commandHandlerFactory;

        public CommandProcessor(Func<Type, IEnumerable<ICommandHandler>> commandHandlerFactory)
        {
            _commandHandlerFactory = commandHandlerFactory;
        }

        public void Process<TCommandMessage>(TCommandMessage commandMessage) where TCommandMessage : ICommandMessage
        {
            var commandHandlerType = typeof (ICommandHandler<>).MakeGenericType(typeof (TCommandMessage));
            var commandHandlers = _commandHandlerFactory(commandHandlerType).Cast<ICommandHandler<TCommandMessage>>();

            foreach (var commandHandler in commandHandlers)
            {
                commandHandler.Execute(commandMessage);
            }
        }
    }
}