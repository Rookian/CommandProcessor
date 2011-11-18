namespace CommandProcessor
{
    public interface ICommandHandler<in TCommand> : ICommandHandler where TCommand : ICommandMessage 
    {
        void Execute(TCommand commandMessage);
    }

    public interface ICommandHandler{}
}