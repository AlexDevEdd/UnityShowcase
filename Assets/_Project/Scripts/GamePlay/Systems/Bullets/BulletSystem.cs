using Atomic.Elements;
using Atomic.Entities;
using GameCycle;
using JetBrains.Annotations;
using UnityEngine;

namespace GamePlay
{
    [UsedImplicitly]
    public sealed class BulletSystem : IGameStart, IGameFinish
    {
        private readonly IEntity _entity;
        private readonly IBulletFactory _bulletFactory;

        private EventAction _fireAction;
        private IValue<IEntity> _currentWeapon;
        private Transform _aimTransform;
        
        public BulletSystem(IEntity entity, IBulletFactory bulletFactory)
        {
            _entity = entity;
            _bulletFactory = bulletFactory;
        }

        public void OnStart()
        {
            _aimTransform = _entity.GetAimTransform();
            _currentWeapon = _entity.GetCurrentWeapon();
            _fireAction = _entity.GetFireAction();
            _fireAction.Subscribe(OnFireEvent);
        }

        private void OnFireEvent()
        {
            var currentAmmo = _currentWeapon.Value.GetCurrentAmmo().Value;
            if(currentAmmo == 0) return;
            
            var projectileType = _currentWeapon.Value.GetProjectileType();
            var firePoint = _currentWeapon.Value.GetFirePoint();
            firePoint.LookAt(_aimTransform);
            
            _currentWeapon.Value.GetFireAction().Invoke();
            var direction = (_aimTransform.position - firePoint.position).normalized;
            _bulletFactory.GetOrCreate(projectileType, firePoint, direction);
        }

        public void OnFinish()
        {
            _fireAction.Unsubscribe(OnFireEvent);
        }
    }
}