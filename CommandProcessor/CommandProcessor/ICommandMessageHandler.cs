namespace CommandProcessor.CommandProcessor
{
    public interface ICommandMessageHandler : ICommandMessageHandler<object> { }

    public interface ICommandMessageHandler<in TCommand>
    {
        void Execute(TCommand commandMessage);
    }
}