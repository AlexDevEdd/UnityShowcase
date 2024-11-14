using JetBrains.Annotations;
using Zenject;

namespace GamePlay
{
    [UsedImplicitly]
    public sealed class InputHandlerInstaller : Installer<InputHandlerInstaller>
    {
        public override void InstallBindings()
        {
            BindCharacterMovementInputHandler(); 
            BindCharacterAimInputHandler();
            BindCharacterFireInputHandler(); 
            BindWeaponReloadInputHandler();
            BindWeaponSwitchInputHandler();
            BindInputDisabler();
        }

        private void BindWeaponSwitchInputHandler()
        {
            Container.BindInterfacesAndSelfTo<WeaponSwitchInputHandler>()
                .AsSingle()
                .NonLazy();
        }

        private void BindWeaponReloadInputHandler()
        {
            Container.BindInterfacesAndSelfTo<WeaponReloadInputHandler>()
                .AsSingle()
                .NonLazy();
        }

        private void BindCharacterFireInputHandler()
        {
            Container.BindInterfacesAndSelfTo<CharacterFireInputHandler>()
                .AsSingle()
                .NonLazy();
        }

        private void BindCharacterAimInputHandler()
        {
            Container.BindInterfacesAndSelfTo<CharacterAimInputHandler>()
                .AsSingle()
                .NonLazy();
        }

        private void BindCharacterMovementInputHandler()
        {
            Container.BindInterfacesAndSelfTo<CharacterMovementInputHandler>()
                .AsSingle()
                .NonLazy();
        }
        private void BindInputDisabler()
        {
            Container.BindInterfacesAndSelfTo<InputDisabler>()
                .AsSingle()
                .NonLazy();
        }
    }
}