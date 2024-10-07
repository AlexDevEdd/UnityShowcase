using JetBrains.Annotations;
using UnityEngine;
using Zenject;

namespace UI
{
    [UsedImplicitly]
    public sealed class WeaponPanelInstaller : MonoInstaller
    {
        [SerializeField]
        private WeaponPanelView _weaponPanelView;
        
        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<WeaponPanelPresenter>()
                .AsSingle()
                .WithArguments(_weaponPanelView)
                .NonLazy();
        }
    }
}