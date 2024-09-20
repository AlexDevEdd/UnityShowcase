using JetBrains.Annotations;
using Zenject;

namespace App
{
    [UsedImplicitly]
    public class AppStepInstaller : Installer<AppStepInstaller>
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<Test_FirstAppStep>()
                .AsSingle()
                .NonLazy();
            
            Container.BindInterfacesAndSelfTo<CreateBulletPoolsAppStep>()
                .AsSingle()
                .NonLazy();
            
            Container.BindInterfacesAndSelfTo<StartGameCycleAppStep>()
                .AsSingle()
                .NonLazy();
            
            Container.BindInterfacesAndSelfTo<SaveLoadAppStep>()
                .AsSingle()
                .NonLazy();
        }
    }
}