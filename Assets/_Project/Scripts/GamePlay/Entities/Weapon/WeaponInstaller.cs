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
        
        [SerializeField] 
        private Transform _firePoint;

        [SerializeField] 
        private ParticleSystem _fireEffect;

        [SerializeField] 
        private int _slotNumber;

        public override void Install(IEntity entity)
        {
            entity.AddTag(TagAPI.Weapon);
            entity.AddHotBarSlotNumber(new ReactiveInt(_slotNumber));
                
            entity.AddWeaponType(_weaponData.WeaponType);
            entity.AddProjectileType(_weaponData.ProjectileType);
            entity.AddDamage(new ReactiveFloat(_weaponData.Damage));
            
            entity.AddTotalCapacity(new ReactiveInt(_weaponData.TotalCapacity));
            entity.AddTotalAmmo(new ReactiveInt(_weaponData.TotalAmmo));
            
            entity.AddMagazineCapacity(new ReactiveInt(_weaponData.MagazineCapacity));
            entity.AddCurrentAmmo(new ReactiveInt(_weaponData.CurrentAmmo));
            
            entity.AddRechargeDelay(new ReactiveFloat(_weaponData.RechargeDelay));

            entity.AddLeftHandIKTarget(_leftHandIKTarget);
            entity.AddAnimLayerIndex(_animLayerIndex);

            entity.AddFirePoint(_firePoint);
            entity.AddFireEffect(_fireEffect);
            entity.AddFireAction(new EventAction());
            entity.AddBehaviour<FireEffectBehaviour>();
            entity.AddBehaviour<FireBehaviour>();
        }
    }
}