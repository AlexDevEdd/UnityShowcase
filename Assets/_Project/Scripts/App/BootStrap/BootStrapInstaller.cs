using GameCycle;
using UnityEngine;
using Zenject;

namespace App
{
    public sealed class BootStrapInstaller : MonoInstaller
    {
        [SerializeField] 
        private AppStepConfiguration _appStepConfiguration;
        
        [SerializeField] 
        private LoadingWindow _loadingWindow;
        
        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<GameCycleSystem>()
                .AsSingle();
            
            BindAppStepConfiguration();
            BindBootStrapSystem();
            
            AppStepInstaller.Install(Container);
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
    }
}