using UnityEngine;
using Zenject;

namespace Debug
{
    public sealed class TestInstaller : MonoInstaller
    {
        // [SerializeField] 
        // private Character _character;

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
        }
    }
}