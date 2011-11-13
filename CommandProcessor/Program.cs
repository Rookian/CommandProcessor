using System;
using CommandProcessor.CommandMessages;
using CommandProcessor.CommandProcessor;
using CommandProcessor.DomainModels;
using CommandProcessor.IoC;
using CommandProcessor.Processes;
using StructureMap;

namespace CommandProcessor
{
    public class Controller
    {
        private readonly IMessageProcessor _messageProcessor;

        public Controller(IMessageProcessor messageProcessor)
        {
            _messageProcessor = messageProcessor;
        }

        public void SendNotification (Employee employee, string message)
        {
            var notificationCommand = new NotificationCommand
            {
                Employee = employee,
                Message = message
            };

            _messageProcessor.Process(notificationCommand);
        }
    }

    public class Program
    {
        public static void Main()
        {
            new BootsTrapper();

            Console.WriteLine("Switch");
            Console.WriteLine("MessageBased");
            MessageBasedInvocation();

            Console.WriteLine("Ende");
            Console.ReadLine();

        }

        private static void MessageBasedInvocation()
        {
            var messageProcessor = ObjectFactory.GetInstance<IMessageProcessor>();

            messageProcessor.Process(new UpdateEmployeeCommandMessage());

            messageProcessor.Process(new EnumerationCommand<Database> { Enumeration = Database.Create, Name = "Test123" });
        }

        private static void BigBallOfMud()
        {
            Database database = Database.Create;

            switch (database)
            {
                case Database.Create:
                    new CreateProcess().Process(new EnumerationCommand<Database> { Enumeration = database, Name = "Test1234" });
                    break;
                case Database.Read:
                    new ReadProcess().Process(new EnumerationCommand<Database> { Enumeration = database, Name = "Test12345" });
                    break;
                case Database.Update:
                    new UpdateProcess().Process(new EnumerationCommand<Database> { Enumeration = database, Name = "Test12356" });
                    break;
                case Database.Delelte:
                    new DeleteProcess().Process(new EnumerationCommand<Database> { Enumeration = database, Name = "Test1234567" });
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
