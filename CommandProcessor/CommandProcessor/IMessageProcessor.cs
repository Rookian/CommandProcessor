namespace CommandProcessor.CommandProcessor
{
    public interface IMessageProcessor
    {
        void Process(object message);
    }
}