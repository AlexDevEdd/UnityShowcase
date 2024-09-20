using JetBrains.Annotations;
using Zenject;

namespace GamePlay
{
    [UsedImplicitly]
    public sealed class CursorInstaller : Installer<CursorInstaller>
    {
        public override void InstallBindings()
        {
            BindCursorSystem();
        }

        private void BindCursorSystem()
        {
            Container.BindInterfacesAndSelfTo<CursorSystem>()
                .AsSingle()
                .NonLazy();
        }
    }
}