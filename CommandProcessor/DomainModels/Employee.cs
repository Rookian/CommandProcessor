namespace CommandProcessor.DomainModels
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void SendNotification(string message, INotifier notifier)
        {
            notifier.SendMessage(string.Format("Message for customer '{0}' ({1}): {2}", Name, Id, message));
        }
    }
}