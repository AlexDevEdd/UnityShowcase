using Atomic.Entities;
using GamePlay;
using UnityEngine;
using Zenject;

namespace Debug
{
    public sealed class TestInstaller : MonoInstaller
    {
        [SerializeField] 
        private SceneEntityWorldCycle _sceneEntityWorldCycle;
        
        [SerializeField] 
        private SceneEntityWorld _sceneEntityWorld;

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
            //
            Container.BindInterfacesAndSelfTo<WeaponSystem>()
                .AsSingle()
                .NonLazy();

            InputInstaller.Install(Container);
            
            Container.BindInterfacesAndSelfTo<SceneEntityWorldCycle>()
                .FromInstance(_sceneEntityWorldCycle)
                .AsSingle()
                .NonLazy();
            
            Container.BindInterfacesAndSelfTo<SceneEntityWorld>()
                .FromInstance(_sceneEntityWorld)
                .AsSingle()
                .NonLazy();
        }
    }
}