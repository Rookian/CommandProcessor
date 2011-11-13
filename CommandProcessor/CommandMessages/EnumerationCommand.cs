namespace CommandProcessor.CommandMessages
{
    public class EnumerationCommand<T>
    {
        public T Enumeration { get; set; }
        public string Name { get; set; }
    }
}