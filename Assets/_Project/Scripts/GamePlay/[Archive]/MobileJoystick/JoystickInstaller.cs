using JetBrains.Annotations;
using Zenject;

namespace MobileJoystick
{
    [UsedImplicitly]
    public sealed class JoystickInstaller : Installer<JoystickInstaller>
    {
        public override void InstallBindings()
        {
            Container.Bind<FloatingJoystick>()
                .FromComponentsInHierarchy()
                .AsSingle()
                .NonLazy();
        
            Container.BindInterfacesAndSelfTo<JoystickController>()
                .AsSingle()
                .NonLazy();
        }
    }
}