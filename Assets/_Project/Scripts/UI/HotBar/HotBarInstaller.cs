using UnityEngine;
using Zenject;

namespace UI
{
    public sealed class HotBarInstaller : MonoInstaller
    {
        [SerializeField] private HotBarPanelView _hotBarPanelView;
        
        public override void InstallBindings()
        {
            Container.Bind<HotBarSlotPresenterFactory>()
                .AsSingle()
                .NonLazy();
            
            Container.BindInterfacesAndSelfTo<HotBarPanelPresenter>()
                .AsSingle()
                .WithArguments(_hotBarPanelView)
                .NonLazy();
        }
    }
}