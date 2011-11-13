using StructureMap;

namespace CommandProcessor.IoC
{
    public class BootsTrapper
    {
        public BootsTrapper()
        {
            ObjectFactory.ResetDefaults();
            ObjectFactory.Initialize(x=>x.AddRegistry(new DependencyRegistry()));
        }
    }
}