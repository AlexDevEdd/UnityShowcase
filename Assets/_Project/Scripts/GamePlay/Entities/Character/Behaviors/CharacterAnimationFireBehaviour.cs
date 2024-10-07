using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace GamePlay
{
    public sealed class CharacterAnimationFireBehaviour : IEntityInit, IEntityEnable, IEntityDisable
    {
        private static readonly int Fire = Animator.StringToHash("Fire");
        
        private IValue<IEntity> _currentWeapon;
        private Animator _animator;
        private EventAction _fireAction;
        
        public void Init(IEntity entity)
        {
            _currentWeapon = entity.GetCurrentWeapon();
            _animator = entity.GetAnimator();
            _fireAction = entity.GetFireAction();
        }
        
        public void Enable(IEntity entity)
        {
            _fireAction.Subscribe(OnFire);
        }

        private void OnFire()
        {
            //TODO: костыль
            if(_currentWeapon.Value.GetCurrentAmmo().Value == 0) return;
            // костыль закончился
            
            _animator.SetTrigger(Fire);
        }

        public void Disable(IEntity entity)
        {
            _fireAction.Unsubscribe(OnFire);
        }
    }
}