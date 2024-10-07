using System.Collections.Generic;
using Atomic.Elements;
using Atomic.Entities;
using GameCycle;
using GamePlay;
using JetBrains.Annotations;
using Zenject;

namespace UI
{
    [UsedImplicitly]
    public sealed class HotBarPanelPresenter : IInitializable, IGameFinish
    {
        private readonly WeaponSystem _weaponSystem;
        private readonly HotBarSlotPresenterFactory _slotPresenterFactory;
        private readonly HotBarPanelView _hotBarPanelView;

        private List<HotBarSlotPresenter> _slotPresenters;
        private IReactiveList<IEntity> _weapons;
        
        public HotBarPanelPresenter(WeaponSystem weaponSystem, HotBarSlotPresenterFactory slotPresenterFactory,
            HotBarPanelView hotBarPanelView)
        {
            _weaponSystem = weaponSystem;
            _slotPresenterFactory = slotPresenterFactory;
            _hotBarPanelView = hotBarPanelView;
        }
        
        public async void Initialize()
        {
            _weaponSystem.SwitchWeaponAction.Subscribe(OnSwitchWeaponAction);
            _slotPresenters = await _slotPresenterFactory.CreateWeaponSlotPresentersAsync(_weaponSystem.GetWeapons(),
                _hotBarPanelView.SlotViews);
            
            _slotPresenters.ForEach(s =>
            {
                s.SetSlotNumber();
                s.SetIcon();
            });
        }

        private void OnSwitchWeaponAction(int index)
        {
            _slotPresenters.ForEach(s => s.Deselect());
            _slotPresenters[index - 1].Select();
        }
        
        public void OnFinish()
        {
            _weaponSystem.SwitchWeaponAction.Unsubscribe(OnSwitchWeaponAction);
        }
    }
}