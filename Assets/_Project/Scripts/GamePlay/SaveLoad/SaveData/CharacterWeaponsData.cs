using System;
using System.Collections.Generic;

namespace GamePlay
{
    [Serializable]
    public class CharacterWeaponsData
    {
        public readonly List<CharacterWeaponData> CharacterWeaponDatas;
        public readonly int CurrentWeaponIndex;
        
        public CharacterWeaponsData(int currentWeaponIndex)
        {
            CharacterWeaponDatas = new List<CharacterWeaponData>();
            CurrentWeaponIndex = currentWeaponIndex;
        }
    }
    
    [Serializable]
    public readonly struct CharacterWeaponData
    {
        public readonly WeaponType WeaponType;
        public readonly int CurrentAmmo;
        public readonly int TotalAmmo;

        public CharacterWeaponData(WeaponType weaponType, int currentAmmo, int totalAmmo)
        {
            WeaponType = weaponType;
            CurrentAmmo = currentAmmo;
            TotalAmmo = totalAmmo;
        }
    }
}