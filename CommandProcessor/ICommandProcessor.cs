namespace CommandProcessor
{
    public interface ICommandProcessor
    {
        void Process<TCommandMessage>(TCommandMessage commandMessage) where TCommandMessage : ICommandMessage;
    }
}