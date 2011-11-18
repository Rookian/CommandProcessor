namespace CommandProcessor.Sample.CommandMessages
{
    public class UpdateEmployeeCommandMessageMessage : ICommandMessage
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}