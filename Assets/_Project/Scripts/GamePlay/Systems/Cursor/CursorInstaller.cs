using Zenject;

namespace GamePlay
{
    public class CursorInstaller : Installer<CursorInstaller>
    {
        public override void InstallBindings()
        {
            BindCursorSystem();
        }

        private void BindCursorSystem()
        {
            Container.Bind<CursorSystem>()
                .AsSingle()
                .NonLazy();
        }
    }
}