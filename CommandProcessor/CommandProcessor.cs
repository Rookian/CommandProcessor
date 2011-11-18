using System;
using System.Collections.Generic;

namespace CommandProcessor
{
    public class CommandProcessor : ICommandProcessor
    {
        private readonly Func<Type, IEnumerable<ICommandHandler<ICommandMessage>>> _commandHandlerDelegate;

        public CommandProcessor(Func<Type, IEnumerable<ICommandHandler<ICommandMessage>>> commandHandlerDelegate)
        {
            _commandHandlerDelegate = commandHandlerDelegate;
        }

        public void Process<TCommandMessage>(TCommandMessage commandMessage) where TCommandMessage : ICommandMessage
        {
            var commandHandlerType = typeof (ICommandHandler<>).MakeGenericType(typeof (TCommandMessage));
            var commandHandlers = _commandHandlerDelegate(commandHandlerType);

            foreach (var commandHandler in commandHandlers)
            {
                commandHandler.Execute(commandMessage);   
            }
        }
    }
}