namespace CommandProcessor
{
    public interface ICommandHandler<in TCommand> : ICommandHandler
    {
        void Execute(TCommand commandMessage);
    }

    public interface ICommandHandler{}
}