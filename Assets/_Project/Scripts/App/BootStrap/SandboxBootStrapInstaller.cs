using GameCycle;
using UnityEngine;
using Zenject;

namespace App
{
    public sealed class SandboxBootStrapInstaller : MonoInstaller
    {
        [SerializeField] 
        private AppStepConfiguration _appStepConfiguration;
        
        [SerializeField] 
        private LoadingWindow _loadingWindow;
        
        [SerializeField] 
        private Transform _poolsContainer;
        
        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<GameCycleSystem>()
                .AsSingle();
            
            BindAppStepConfiguration();
            BindBootStrapSystem();
            //BindBulletFactory();
            
            SandboxAppStepInstaller.Install(Container);
        }

        private void BindBootStrapSystem()
        {
            Container.BindInterfacesAndSelfTo<BootStrapSystem>()
                .AsSingle()
                .WithArguments(_loadingWindow)
                .NonLazy();
        }
        
        private void BindAppStepConfiguration()
        {
            Container.Bind<AppStepConfiguration>()
                .FromInstance(_appStepConfiguration)
                .AsSingle()
                .NonLazy();
        }

        // private void BindBulletFactory()
        // {
        //     Container.BindInterfacesAndSelfTo<BulletFactory>()
        //         .AsSingle()
        //         .WithArguments(_poolsContainer)
        //         .NonLazy();
        // }
    }
}