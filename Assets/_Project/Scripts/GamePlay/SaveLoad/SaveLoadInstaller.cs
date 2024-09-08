using JetBrains.Annotations;
using SaveLoad;
using Zenject;

namespace GamePlay
{
    [UsedImplicitly]
    public sealed class SaveLoadInstaller : Installer<SaveLoadInstaller>
    {
        public override void InstallBindings()
        {
            BindSaveSystem();
            BindGameRepository();
            BindSaveLoadSerializerFactory();
            //BindCurrencySaveLoader();
            //BindAudioSettingsSaveLoader();
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
                .NonLazy();
        }
        private void BindSaveLoadSerializerFactory()
        {
            Container.Bind<SaveLoadSerializerFactory>()
                .AsSingle()
                .NonLazy();
        }

        // private void BindCurrencySaveLoader()
        // {
        //     Container.BindInterfacesAndSelfTo<CurrencySaveLoader>()
        //         .AsSingle()
        //         .NonLazy();
        // } 
        
        // private void BindAudioSettingsSaveLoader()
        // {
        //     Container.BindInterfacesAndSelfTo<AudioSettingsSaveLoader>()
        //         .AsSingle()
        //         .NonLazy();
        // }
    }
}