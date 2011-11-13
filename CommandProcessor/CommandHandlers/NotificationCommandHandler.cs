using CommandProcessor.CommandMessages;
using CommandProcessor.CommandProcessor;
using CommandProcessor.DomainModels;

namespace CommandProcessor.CommandHandlers
{
    public class SendMailCommandHandler : ICommandHandler<NotificationCommand>
    {
        private readonly INotifier _notifier;

        public SendMailCommandHandler(INotifier notifier)
        {
            _notifier = notifier;
        }

        public void Execute(NotificationCommand commandMessage)
        {
            commandMessage.Employee.SendNotification(commandMessage.Message, _notifier);
        }
    }
}