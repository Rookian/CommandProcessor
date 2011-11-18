using System;
using CommandProcessor.Sample.CommandMessages;

namespace CommandProcessor.Sample.CommandHandlers
{
    public class CreateEmployeeCommandHandler : ICommandHandler<UpdateEmployeeCommandMessageMessage>
    {
        public void Execute(UpdateEmployeeCommandMessageMessage commandMessage)
        {
            Console.WriteLine("Handle command for UpdateEmployeeCommandMessage2");
        }
    }
}