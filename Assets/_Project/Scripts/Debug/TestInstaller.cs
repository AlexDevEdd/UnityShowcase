using GamePlay;
using UnityEngine;
using Zenject;

namespace Debug
{
    public sealed class TestInstaller : MonoInstaller
    {
        [SerializeField] 
        private SceneEntityWorldCycle _sceneEntityWorldCycle;

        public override void InstallBindings()
        {
            // Container.BindInterfacesAndSelfTo<Character>()
            //     .FromInstance(_character)
            //     .AsSingle()
            //     .NonLazy();
            //
            // Container.BindInterfacesAndSelfTo<MoveController>()
            //     .AsSingle()
            //     .NonLazy();

            InputInstaller.Install(Container);
            
            Container.BindInterfacesAndSelfTo<SceneEntityWorldCycle>()
                .FromInstance(_sceneEntityWorldCycle)
                .AsSingle()
                .NonLazy();
        }
    }
}