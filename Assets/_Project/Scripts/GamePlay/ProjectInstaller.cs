using AssetManagement;
using SceneManagement;
using Zenject;

namespace GamePlay
{
    public class ProjectInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            AssetProviderInstaller.Install(Container);
            SceneLoaderInstaller.Install(Container);
            CursorInstaller.Install(Container);
            
             Container.BindInterfacesAndSelfTo<WeaponIconProvider>()
                 .AsSingle()
                 .NonLazy();
        }
    }
}