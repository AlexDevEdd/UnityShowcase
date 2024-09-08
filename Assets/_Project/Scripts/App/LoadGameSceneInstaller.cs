using SceneManagement;
using Zenject;

namespace App
{
    public sealed class LoadGameSceneInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            BindGameStarter();
        }

        private void BindGameStarter()
        {
            Container.BindInterfacesAndSelfTo<GameStarter>()
                .AsSingle();
        }
    }
}