namespace CommandProcessor.Processes
{
    public interface IProcess<in T> : IProcess
    {
        void Process(T argument);
    }

    public interface  IProcess{}
}