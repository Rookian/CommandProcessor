using System;
using CommandProcessor.Sample.CommandMessages;
using CommandProcessor.Sample.Processes;

namespace CommandProcessor.Sample.CommandHandlers
{
    public class EnumerationCommandHandler : ICommandHandler<EnumerationCommandMessage<Database>>
    {
        private readonly Func<string, IProcess<EnumerationCommandMessage<Database>>> _process;

        public EnumerationCommandHandler(Func<string, IProcess<EnumerationCommandMessage<Database>>> process)
        {
            _process = process;
        }

        public void Execute(EnumerationCommandMessage<Database> commandMessage)
        {
            var enumerationName = GetEnumerationName(commandMessage);
            var process = _process(enumerationName);
            process.Process(commandMessage);
        }

        private static string GetEnumerationName(EnumerationCommandMessage<Database> commandMessage)
        {
            var enumtype = commandMessage.Enumeration.GetType();
            return Enum.GetName(enumtype, commandMessage.Enumeration);
        }
    }
}