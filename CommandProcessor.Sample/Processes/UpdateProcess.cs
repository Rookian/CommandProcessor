using System;
using CommandProcessor.Sample.CommandMessages;

namespace CommandProcessor.Sample.Processes
{
    public class UpdateProcess : IProcess<EnumerationCommandMessage<Database>>
    {
        public void Process(EnumerationCommandMessage<Database> argument)
        {
            Console.WriteLine("With argument {0}", argument.Name);
            Console.WriteLine("UpdateProcess");
        }
    }
}