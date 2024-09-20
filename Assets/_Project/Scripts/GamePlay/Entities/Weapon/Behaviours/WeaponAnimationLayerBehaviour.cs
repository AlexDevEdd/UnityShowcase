using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace GamePlay
{
    public sealed class WeaponAnimationLayerBehaviour : IEntityInit, IEntityEnable, IEntityDisable
    {
        private IReactiveVariable<IEntity> _currentWeapon;
        private Animator _animator;
        
        
        public void Init(IEntity entity)
        {
            _animator = entity.GetAnimator();
            _currentWeapon = entity.GetCurrentWeapon();
        }
        
        public void Enable(IEntity entity)
        {
            _currentWeapon.Subscribe(OnWeaponSwitched);
        }

        private void OnWeaponSwitched(IEntity weapon)
        {
            for (var i = 1; i < _animator.layerCount; i++) 
                _animator.SetLayerWeight(i,0);
            
            _animator.SetLayerWeight(weapon.GetAnimLayerIndex(), 1);
        }

        public void Disable(IEntity entity)
        {
            _currentWeapon.Unsubscribe(OnWeaponSwitched);
        }
    }
}