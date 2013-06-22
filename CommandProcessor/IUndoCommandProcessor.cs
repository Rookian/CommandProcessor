namespace CommandProcessor
{
    public interface IUndoCommandProcessor
    {
        void Process<TCommandMessage>(TCommandMessage commandMessage);
        TCommandMessage Undo<TCommandMessage>();
    }
}