using Zenject;

namespace AutoInjector.Examples
{
    public class SampleClassInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<SampleClass>().AsTransient();
        }
    }
}