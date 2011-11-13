using System;
using CommandProcessor.CommandMessages;
using CommandProcessor.CommandProcessor;

namespace CommandProcessor.CommandHandlers
{
    public class UpdateEmployeeCommandHandler : ICommandHandler<UpdateEmployeeCommandMessage>
    {
        public void Execute(UpdateEmployeeCommandMessage commandMessage)
        {
            Console.WriteLine("Handle command for UpdateEmployeeCommandMessage1");
        }
    }
}