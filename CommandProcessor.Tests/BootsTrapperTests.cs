using CommandProcessor.Sample.IoC;
using Machine.Specifications;
using StructureMap;

namespace CommandProcessor.Tests
{
    [Subject(typeof(BootsTrapper))]
    public class When_asking_for_message_processor
    {
        static ICommandProcessor _messageProcessor;

        Establish context = () => new BootsTrapper().BootsTrap();

        Because of = () => _messageProcessor = ObjectFactory.GetInstance<ICommandProcessor>();

        It should_retrieve_message_processor = () => _messageProcessor.ShouldBeOfType(typeof(CommandProcessor));
    }

}
