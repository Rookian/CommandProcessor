using System;
using CommandProcessor.Sample.CommandMessages;
using CommandProcessor.Sample.IoC;
using CommandProcessor.Sample.Processes;
using StructureMap;

namespace CommandProcessor.Sample
{
    public class Program
    {
        public static void Main()
        {
            new BootsTrapper().BootsTrap();

            Console.WriteLine("Switch");
            BigBallOfMud();

            Console.WriteLine("MessageBased");
            MessageBasedInvocation();

            Console.WriteLine("Ende");
            Console.ReadLine();

        }

        private static void MessageBasedInvocation()
        {
            var messageProcessor = ObjectFactory.GetInstance<ICommandProcessor>();

            messageProcessor.Process(new UpdateEmployeeCommandMessageMessage());

            messageProcessor.Process(new EnumerationCommandMessage<Database> { Enumeration = Database.Create, Name = "Test123" });
        }

        private static void BigBallOfMud()
        {
            Database database = Database.Create;

            switch (database)
            {
                case Database.Create:
                    new CreateProcess().Process(new EnumerationCommandMessage<Database> { Enumeration = database, Name = "Test1234" });
                    break;
                case Database.Read:
                    new ReadProcess().Process(new EnumerationCommandMessage<Database> { Enumeration = database, Name = "Test12345" });
                    break;
                case Database.Update:
                    new UpdateProcess().Process(new EnumerationCommandMessage<Database> { Enumeration = database, Name = "Test12356" });
                    break;
                case Database.Delete:
                    new DeleteProcess().Process(new EnumerationCommandMessage<Database> { Enumeration = database, Name = "Test1234567" });
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
