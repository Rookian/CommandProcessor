using System;
using CommandProcessor.Sample.CommandMessages;

namespace CommandProcessor.Sample.CommandHandlers
{
    public class CreateEmployeeCommandHandler : ICommandHandler<UpdateEmployeeCommandMessageMessage>
    {
        private readonly IRepository _repository;

        public CreateEmployeeCommandHandler(IRepository repository)
        {
            _repository = repository;
        }

        public void Execute(UpdateEmployeeCommandMessageMessage commandMessage)
        {
            _repository.Save(commandMessage);
            Console.WriteLine("Handle command for UpdateEmployeeCommandMessage2");
        }
    }

    public interface IRepository
    {
        void Save(UpdateEmployeeCommandMessageMessage commandMessage);
    }

    class Repository : IRepository
    {
        public void Save(UpdateEmployeeCommandMessageMessage commandMessage)
        {
            
        }
    }
}