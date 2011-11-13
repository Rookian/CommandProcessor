using System;
using CommandProcessor.CommandMessages;

namespace CommandProcessor.Processes
{
    public class UpdateProcess : IProcess<EnumerationCommand<Database>>
    {
        public void Process(EnumerationCommand<Database> argument)
        {
            Console.WriteLine("With argument {0}", argument.Name);
            Console.WriteLine("UpdateProcess");
        }
    }
}