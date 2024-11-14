using System.Linq;
using Atomic.Entities;
using JetBrains.Annotations;
using SaveLoad;

namespace GamePlay
{
    [UsedImplicitly]
    public sealed class WeaponSaveLoader : SaveLoader<CharacterWeaponsData, WeaponSystem>
    {
        public WeaponSaveLoader(GameDataStorage gameDataStorage, WeaponSystem weaponSystem) 
            : base(gameDataStorage, weaponSystem) { }
    
        protected override CharacterWeaponsData ConvertToData(WeaponSystem weaponSystem)
        {
            var weapons = weaponSystem.GetWeapons();
            var currentWeaponIndex = weaponSystem.CurrentWeapon.Value.GetHotBarSlotNumber();
            var weaponsData = new CharacterWeaponsData(currentWeaponIndex.Value);
           
            foreach (var weapon in weapons)
            {
                var type = weapon.GetWeaponType();
                var currentAmmo = weapon.GetCurrentAmmo().Value;
                var totalAmmo = weapon.GetTotalAmmo().Value;
                var weaponData = new CharacterWeaponData(type, currentAmmo, totalAmmo);
                weaponsData.CharacterWeaponDatas.Add(weaponData);
            }
           
            return weaponsData;
        }
    
        protected override void SetUpData(CharacterWeaponsData data, WeaponSystem weaponSystem)
        {
            weaponSystem.SwitchWeaponAction?.Invoke(1);
            if(data.CharacterWeaponDatas.Count == 0) return;
           
            var weapons = weaponSystem.GetWeapons();
            foreach (var weaponData in data.CharacterWeaponDatas)
            {
                var weapon = weapons.FirstOrDefault(weapon => weapon.GetWeaponType() == weaponData.WeaponType);
                if(weapon == default)
                    continue;
                
                weapon.GetCurrentAmmo().Value = weaponData.CurrentAmmo;
                weapon.GetTotalAmmo().Value = weaponData.TotalAmmo;
            }
           
            weaponSystem.SwitchWeaponAction?.Invoke(data.CurrentWeaponIndex);
        }
    }
}