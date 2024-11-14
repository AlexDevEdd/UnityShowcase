using JetBrains.Annotations;
using SaveLoad;
using Zenject;

namespace GamePlay
{
    [UsedImplicitly]
    public sealed class SaveLoadInstaller : Installer<SaveLoadInstaller>
    {
        private const string SAVE_KEY = "GAME_STATE"; 
        public override void InstallBindings()
        {
            BindSaveSystem();
            BindGameRepository();
            BindSaveLoadSerializerFactory();
            BindCharacterSaveLoader();
            BindWeaponSaveLoader();
        }

        private void BindSaveSystem()
        {
            Container.BindInterfacesAndSelfTo<SaveLoadSystem>()
                .AsSingle()
                .NonLazy();
        }

        private void BindGameRepository()
        {
            Container.Bind<GameDataStorage>()
                .AsSingle()
                .WithArguments(SAVE_KEY)
                .NonLazy();
        }

        private void BindSaveLoadSerializerFactory()
        {
            Container.Bind<SaveLoadSerializerFactory>()
                .AsSingle()
                .NonLazy();
        }

        private void BindCharacterSaveLoader()
        {
            Container.BindInterfacesAndSelfTo<CharacterSaveLoader>()
                .AsSingle()
                .NonLazy();
        }

        private void BindWeaponSaveLoader()
        {
            Container.BindInterfacesAndSelfTo<WeaponSaveLoader>()
                .AsSingle()
                .NonLazy();
        }
    }
}