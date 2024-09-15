using System;
using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace GamePlay
{
    public sealed class WeaponInstaller : SceneEntityInstallerBase
    {
        [SerializeField] 
        private WeaponData _weaponData;
        
        [SerializeField] 
        private Transform _leftHandIKTarget;
        
        [SerializeField] 
        private int _animLayerIndex;

        
        public override void Install(IEntity entity)
        {
            entity.AddTag(TagAPI.Weapon);
            
            entity.AddWeaponType(_weaponData.WeaponType);
            entity.AddProjectileType(_weaponData.ProjectileType);
            entity.AddDamage(new ReactiveFloat(_weaponData.Damage));
            entity.AddAmmoCapacity(new ReactiveInt(_weaponData.AmmoCapacity));
            entity.AddRemainingAmmo(new ReactiveInt(_weaponData.RemainingAmmo));
            entity.AddRechargeDelay(new ReactiveFloat(_weaponData.RechargeDelay));

            entity.AddLeftHandIKTarget(_leftHandIKTarget);
            entity.AddAnimLayerIndex(_animLayerIndex);
        }
    }

    public enum WeaponType : byte
    {
        Default = 0,
        Pistol = 1,
        Plasma = 2,
        Shotgun = 3,
        Sniper = 4
    }
    
    public enum ProjectileType : byte
    {
        Default = 0,
        Pistol = 1,
        Plasma = 2,
        Shotgun = 3,
        Sniper = 4
    }

    [Serializable]
    public sealed class WeaponData
    {
        [field:SerializeField]
        public WeaponType WeaponType { get; private set; }
        
        [field:SerializeField]
        public ProjectileType ProjectileType { get; private set; }
        
        [field:SerializeField]
        public int AmmoCapacity { get; private set; }
        
        [field:SerializeField]
        public int RemainingAmmo { get; private set; }
        
        [field:SerializeField]
        public float RechargeDelay { get; private set; }
        
        [field:SerializeField]
        public float Damage { get; private set; }
    }
}