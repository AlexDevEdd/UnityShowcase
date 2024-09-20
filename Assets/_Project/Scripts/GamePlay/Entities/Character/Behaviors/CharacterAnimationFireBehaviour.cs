using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace GamePlay
{
    public sealed class CharacterAnimationFireBehaviour : IEntityInit, IEntityEnable, IEntityDisable
    {
        private static readonly int Fire = Animator.StringToHash("Fire");
       
        
        private Animator _animator;
        private EventAction _fireAction;
        
        public void Init(IEntity entity)
        {
            _animator = entity.GetAnimator();
            _fireAction = entity.GetFireAction();
        }
        
        public void Enable(IEntity entity)
        {
            _fireAction.Subscribe(OnFire);
        }

        private void OnFire()
        {
            _animator.SetTrigger(Fire);
        }

        public void Disable(IEntity entity)
        {
            _fireAction.Unsubscribe(OnFire);
        }
    }
}