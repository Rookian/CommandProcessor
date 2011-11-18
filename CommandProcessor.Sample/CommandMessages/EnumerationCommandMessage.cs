namespace CommandProcessor.Sample.CommandMessages
{
    public class EnumerationCommandMessage<T> : ICommandMessage
    {
        public T Enumeration { get; set; }
        public string Name { get; set; }
    }
}