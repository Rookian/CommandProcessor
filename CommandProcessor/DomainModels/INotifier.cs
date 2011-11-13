namespace CommandProcessor.DomainModels
{
    public interface INotifier
    {
        void SendMessage(string message);
    }

    class EmailNotifier : INotifier
    {
        public void SendMessage(string message)
        {
            // SmtpClient...
        }
    }

    class SMSNotifier : INotifier
    {
        public void SendMessage(string message)
        {
            // SMS ...
        }
    }
}