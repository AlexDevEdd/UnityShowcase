using JetBrains.Annotations;
using Zenject;

namespace GamePlay
{
    [UsedImplicitly]
    public sealed class WeaponSystemInstaller : Installer<WeaponSystemInstaller>
    {
        public override void InstallBindings()
        {
            BindWeaponSystem();
            BindBulletSystem();
            BindWeaponReloadingSystem();
        }

        private void BindWeaponSystem()
        {
            Container.BindInterfacesAndSelfTo<WeaponSystem>()
                .AsSingle()
                .NonLazy();
        }
        private void BindWeaponReloadingSystem()
        {
            Container.BindInterfacesAndSelfTo<WeaponReloadingSystem>()
                .AsSingle()
                .NonLazy();
        }
        
        private void BindBulletSystem()
        {
            Container.BindInterfacesAndSelfTo<BulletSystem>()
                .AsSingle()
                .NonLazy();;
        }
    }
}