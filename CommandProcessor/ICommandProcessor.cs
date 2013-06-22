namespace CommandProcessor
{
    public interface ICommandProcessor
    {
        void Process<TCommandMessage>(TCommandMessage commandMessage);
    }
}