using System.Collections.Generic;
using System.Linq;
using Atomic.Entities;
using Cysharp.Threading.Tasks;
using GamePlay;
using JetBrains.Annotations;

namespace UI
{
    [UsedImplicitly]
    public sealed class HotBarSlotPresenterFactory
    {
        private const string ID_POSTFIX = "_01_Diagonal";
        private readonly IWeaponIconProvider _weaponIconProvider;
        
        public HotBarSlotPresenterFactory(IWeaponIconProvider weaponIconProvider)
        {
            _weaponIconProvider = weaponIconProvider;
        }
        
        public async UniTask<List<HotBarSlotPresenter>> CreateWeaponSlotPresentersAsync(IList<IEntity> weapons,
            IReadOnlyList<IHotBarSlotView> hotBarSlotViews)
        {
            var slotPresenters = new List<HotBarSlotPresenter>(weapons.Count);
            for (var index = 0; index < weapons.Count; index++)
            {
                var weapon = weapons[index];
                var iconId = $"{weapon.GetWeaponType().ToString()}{ID_POSTFIX}";
                var icon = await _weaponIconProvider.GetIcon(iconId);
                slotPresenters.Add(new HotBarSlotPresenter(icon, weapon.GetHotBarSlotNumber().Value, hotBarSlotViews[index]));
            }

            return slotPresenters;
        }
    }
}