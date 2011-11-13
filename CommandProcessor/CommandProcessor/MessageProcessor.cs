namespace CommandProcessor.CommandProcessor
{
    public class MessageProcessor : IMessageProcessor
    {
        private readonly ICommandMessageHandlerFactory _commandMessageHandlerFactory;

        public MessageProcessor(ICommandMessageHandlerFactory commandMessageHandlerFactory)
        {
            _commandMessageHandlerFactory = commandMessageHandlerFactory;
        }

        public void Process(object message)
        {
            var handlers = _commandMessageHandlerFactory.GetCommands(message.GetType());
            foreach (var commandMessageHandler in handlers)
            {
                commandMessageHandler.Execute(message);
            }
        }
    }
}