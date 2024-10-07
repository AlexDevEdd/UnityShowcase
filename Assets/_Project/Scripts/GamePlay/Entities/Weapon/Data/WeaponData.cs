using System;
using UnityEngine;

namespace GamePlay
{
    [Serializable]
    public sealed class WeaponData
    {
        [field:SerializeField]
        public WeaponType WeaponType { get; private set; }
        
        [field:SerializeField]
        public ProjectileType ProjectileType { get; private set; }
        
        [field:SerializeField]
        public int TotalCapacity { get; private set; }

        [field:SerializeField]
        public int TotalAmmo { get; private set; }

        [field:SerializeField]
        public int MagazineCapacity { get; private set; }

        [field:SerializeField]
        public int CurrentAmmo { get; private set; }

        [field:SerializeField]
        public float RechargeDelay { get; private set; }
        
        [field:SerializeField]
        public float Damage { get; private set; }
    }
}