using System;
using CommandProcessor.CommandMessages;
using CommandProcessor.CommandProcessor;
using CommandProcessor.Processes;

namespace CommandProcessor.CommandHandlers
{
    public class EnumerationHandler : ICommandHandler<EnumerationCommand<Database>>
    {
        private readonly Func<string, IProcess<EnumerationCommand<Database>>> _process;

        public EnumerationHandler(Func<string, IProcess<EnumerationCommand<Database>>> process)
        {
            _process = process;
        }

        public void Execute(EnumerationCommand<Database> commandMessage)
        {
            var enumerationName = GetEnumerationName(commandMessage);
            var process = _process(enumerationName);
            process.Process(commandMessage);
        }

        private static string GetEnumerationName(EnumerationCommand<Database> commandMessage)
        {
            var enumtype = commandMessage.Enumeration.GetType();
            return Enum.GetName(enumtype, commandMessage.Enumeration);
        }
    }
}