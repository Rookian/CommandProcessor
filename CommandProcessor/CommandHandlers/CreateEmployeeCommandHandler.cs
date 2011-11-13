using System;
using CommandProcessor.CommandMessages;
using CommandProcessor.CommandProcessor;

namespace CommandProcessor.CommandHandlers
{
    public class CreateEmployeeCommandHandler : ICommandHandler<UpdateEmployeeCommandMessage>
    {
        public void Execute(UpdateEmployeeCommandMessage commandMessage)
        {
            Console.WriteLine("Handle command for UpdateEmployeeCommandMessage2");
        }
    }
}