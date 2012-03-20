namespace CommandProcessor
{
    public interface IUndoCommandProcessor
    {
        void Process<TCommandMessage>(TCommandMessage commandMessage) where TCommandMessage : ICommandMessage;
        TCommandMessage Undo<TCommandMessage>() where TCommandMessage : ICommandMessage;
    }
}