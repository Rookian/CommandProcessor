using StructureMap;

namespace CommandProcessor.Sample.IoC
{
    public class BootsTrapper
    {
        public void BootsTrap()
        {
            ObjectFactory.ResetDefaults();
            ObjectFactory.Initialize(x => x.AddRegistry(new DependencyRegistry()));
        }
    }
}