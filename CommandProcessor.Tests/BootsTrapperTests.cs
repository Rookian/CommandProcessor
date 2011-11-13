using CommandProcessor.CommandProcessor;
using CommandProcessor.IoC;
using Machine.Specifications;
using StructureMap;

namespace CommandProcessor.Tests
{
    //[Subject(typeof(BootsTrapper))]
    //public class When_asking_for_message_processor
    //{
    //    private static IMessageProcessor _messageProcessor;

    //    private Establish context = () => new BootsTrapper();

    //    private Because of = () => _messageProcessor = ObjectFactory.GetInstance<IMessageProcessor>();

    //    private It should_retrieve_message_processor = () => _messageProcessor.ShouldBeOfType(typeof(MessageProcessor));
    //}

    //[Subject(typeof(BootsTrapper))]
    //public class When_asking_for_command_factory
    //{
    //    private static ICommandMessageHandlerFactory _commandMessageHandlerFactory;

    //    private Establish context = () => new BootsTrapper();

    //    private Because of = () => _commandMessageHandlerFactory = ObjectFactory.GetInstance<ICommandMessageHandlerFactory>();

    //    private It should_retrieve_command_factory = () => _commandMessageHandlerFactory.ShouldBeOfType(typeof(CommandMessageHandlerFactory));
    //}
}
