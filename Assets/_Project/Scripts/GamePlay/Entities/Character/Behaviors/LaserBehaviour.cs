using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace GamePlay
{
    public sealed class LaserBehaviour : IEntityInit, IEntityUpdate, IEntityDispose
    {
        private const float DEFAULT_LASER_TIP_LENGHT = 0.5f;
        private const float ZERO_LASER_TIP_LENGHT = 0f;
        
        private LineRenderer _laser;
        private Transform _aim;
        private ReactiveVariable<IEntity> _weapon;
        private IValue<float> _laserDistance;
        private IVariable<bool> _isReloading;
        
        private float _laserTipLenght;
        private Transform _firePoint;
        
        public void Init(IEntity entity)
        {
            _isReloading = entity.GetIsReloading();
            
            _weapon = entity.GetCurrentWeapon();
            _weapon.Subscribe(OnWeaponSwitched);
            _firePoint = _weapon.Value.GetFirePoint();
            
            _aim = entity.GetAimTransform();
            
            _laser = entity.GetLaser();
            _laserDistance = entity.GetLaserDistance();
        }

        private void OnWeaponSwitched(IEntity entity)
        {
            _firePoint = _weapon.Value.GetFirePoint();
        }

        public void OnUpdate(IEntity entity, float deltaTime)
        {
            if (_isReloading.Value)
            {
                _laser.SetPosition(0, _firePoint.position);
                _laser.SetPosition(1, _firePoint.position );
                _laser.SetPosition(2, _firePoint.position);
                return;
            }
            
            _laserTipLenght = DEFAULT_LASER_TIP_LENGHT;
            var direction = (_aim.position - _firePoint.position).normalized;
            
            var endPoint = _firePoint.position + direction * _laserDistance.Value;
            if (Physics.Raycast(_firePoint.position, direction, out var hit, _laserDistance.Value));
            {
                endPoint = hit.point;
                _laserTipLenght = ZERO_LASER_TIP_LENGHT;
            }
            
            _laser.SetPosition(0, _firePoint.position);
            _laser.SetPosition(1, endPoint );
            _laser.SetPosition(2, endPoint + direction * _laserTipLenght);
        }

        public void Dispose(IEntity entity)
        {
            _weapon.Unsubscribe(OnWeaponSwitched);
        }
    }
}