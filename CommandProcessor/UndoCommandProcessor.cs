using System.Collections.Generic;

namespace CommandProcessor
{
    public class UndoCommandProcessor : IUndoCommandProcessor
    {
        private readonly ICommandProcessor _commandProcessor;
        private readonly Stack<object> _commandMessages = new Stack<object>();
        
        public UndoCommandProcessor(ICommandProcessor commandProcessor)
        {
            _commandProcessor = commandProcessor;
        }

        public void Process<TCommandMessage>(TCommandMessage commandMessage)
        {
            _commandMessages.Push(commandMessage);
            _commandProcessor.Process(commandMessage);
        }

        public TCommandMessage Undo<TCommandMessage>()
        {
            return (TCommandMessage)_commandMessages.Pop();
        }
    }
}