using JetBrains.Annotations;
using Zenject;

namespace App
{
    [UsedImplicitly]
    public class SandboxAppStepInstaller : Installer<SandboxAppStepInstaller>
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<Test_FirstAppStep>()
                .AsSingle()
                .NonLazy();
            
            Container.BindInterfacesAndSelfTo<StartGameCycleAppStep>()
                .AsSingle()
                .NonLazy();
        }
    }
}