using CommandProcessor.DomainModels;

namespace CommandProcessor.CommandMessages
{
    public class NotificationCommand
    {
        public string Message { get; set; }
        public Employee Employee { get; set; }
    }
}