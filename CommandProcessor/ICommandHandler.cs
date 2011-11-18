namespace CommandProcessor
{
    public interface ICommandHandler<in TCommand>  where TCommand : ICommandMessage
    {
        void Execute(TCommand commandMessage);
    }
}