using Atomic.Entities;
using UnityEngine;
using Zenject;

namespace GamePlay
{
    public sealed class CharacterSceneEntityInstaller: MonoInstaller
    {
        [SerializeField] 
        private SceneEntity _sceneEntity;
        
        public override void InstallBindings()
        {
            BindCharacter();
            InputHandlerInstaller.Install(Container);
        }

        private void BindCharacter()
        {
            Container.BindInterfacesAndSelfTo<SceneEntity>()
                .FromInstance(_sceneEntity)
                .AsSingle()
                .NonLazy();
        }
    }
}