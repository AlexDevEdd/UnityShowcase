using JetBrains.Annotations;
using UnityEngine;
using Zenject;

namespace UI
{
    [UsedImplicitly]
    public sealed class HealthBarInstaller : MonoInstaller
    {
        [SerializeField]
        private HealthBarView _healthBarView;
        
        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<HealthBarPresenter>()
                .AsSingle()
                .WithArguments(_healthBarView)
                .NonLazy();
        }
    }
}