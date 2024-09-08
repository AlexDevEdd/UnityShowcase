using AssetManagement;
using SceneManagement;
using Zenject;

namespace GamePlay
{
    public class ProjectInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            // Container.BindInterfacesAndSelfTo<CurrencyBank>()
            //     .AsSingle()
            //     .NonLazy();
            //
            // Container.BindInterfacesAndSelfTo<AudioSystem>()
            //     .AsSingle()
            //     .NonLazy();
            
            AssetProviderInstaller.Install(Container);
            SceneLoaderInstaller.Install(Container);
            SaveLoadInstaller.Install(Container);
        }
    }
}