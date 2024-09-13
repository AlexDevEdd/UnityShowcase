using Atomic.Entities;
using UnityEngine;
using Zenject;

namespace GamePlay
{
    public class CharacterSceneEntityInstaller: MonoInstaller
    {
        [SerializeField] 
        private SceneEntity _sceneEntity;
        
        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<SceneEntity>()
                .FromInstance(_sceneEntity)
                .AsSingle()
                .NonLazy();
            
            Container.BindInterfacesAndSelfTo<CharacterMovementInputHandler>()
                .AsSingle()
                .NonLazy(); 
            
            Container.BindInterfacesAndSelfTo<CharacterAimInputHandler>()
                .AsSingle()
                .NonLazy();
            
            Container.BindInterfacesAndSelfTo<CharacterFireInputHandler>()
                .AsSingle()
                .NonLazy();
        }
    }
}