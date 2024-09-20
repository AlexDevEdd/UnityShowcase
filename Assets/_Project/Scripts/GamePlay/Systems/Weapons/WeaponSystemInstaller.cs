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

        }

        private void BindWeaponSystem()
        {
            Container.BindInterfacesAndSelfTo<WeaponSystem>()
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