using AssetManagement;
using JetBrains.Annotations;
using SceneManagement;
using Zenject;

namespace App
{
    [UsedImplicitly]
    public sealed class GameStarter : IInitializable
    {
        private readonly ISceneLoader _sceneLoader;
        private readonly IAssetProvider _assetProvider;

        public GameStarter(ISceneLoader sceneLoader, IAssetProvider assetProvider)
        {
            _sceneLoader = sceneLoader;
            _assetProvider = assetProvider;
        }

        async void IInitializable.Initialize()
        {
            await _assetProvider.InitializeAsync();
            await _sceneLoader.LoadAsync(AssetKeys.GAME);
        }
    }
}