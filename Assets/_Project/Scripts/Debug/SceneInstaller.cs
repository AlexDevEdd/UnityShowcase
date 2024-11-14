using Atomic.Entities;
using GamePlay;
using UnityEngine;
using Zenject;

namespace Debug
{
    public sealed class SceneInstaller : MonoInstaller
    {
        [SerializeField] 
        private SceneEntityWorldCycle _sceneEntityWorldCycle;
        
        [SerializeField] 
        private SceneEntityWorld _sceneEntityWorld;

        public override void InstallBindings()
        {
            InputInstaller.Install(Container);
            WeaponSystemInstaller.Install(Container);
            
            Container.BindInterfacesAndSelfTo<SceneEntityWorldCycle>()
                .FromInstance(_sceneEntityWorldCycle)
                .AsSingle()
                .NonLazy();
            
            Container.BindInterfacesAndSelfTo<SceneEntityWorld>()
                .FromInstance(_sceneEntityWorld)
                .AsSingle()
                .NonLazy();
            
            SaveLoadInstaller.Install(Container);
        }
    }
}