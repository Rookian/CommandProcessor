using System.Collections.Generic;

namespace CommandProcessor
{
    public class UndoCommandProcessor : IUndoCommandProcessor
    {
        private readonly ICommandProcessor _commandProcessor;
        private readonly Stack<ICommandMessage> _commandMessages = new Stack<ICommandMessage>();
        
        public UndoCommandProcessor(ICommandProcessor commandProcessor)
        {
            _commandProcessor = commandProcessor;
        }

        public void Process<TCommandMessage>(TCommandMessage commandMessage) where TCommandMessage : ICommandMessage
        {
            _commandMessages.Push(commandMessage);
            _commandProcessor.Process(commandMessage);
        }

        public TCommandMessage Undo<TCommandMessage>() where TCommandMessage : ICommandMessage
        {
            return (TCommandMessage)_commandMessages.Pop();
        }
    }
}