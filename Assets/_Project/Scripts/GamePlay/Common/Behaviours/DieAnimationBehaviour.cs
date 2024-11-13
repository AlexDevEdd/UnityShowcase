using System;
using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace GamePlay
{
    [Serializable]
    public sealed class DieAnimationBehaviour : IEntityInit, IEntityEnable, IEntityDisable
    {
        private static readonly int Die = Animator.StringToHash("Die");
        
        private Animator _animator;
        private EventAction<IEntity> _dieAction;
        
        public void Init(IEntity entity)
        {
            _dieAction = entity.GetDieAction();
            _animator = entity.GetAnimator();
        }
        
        public void Enable(IEntity entity)
        {
            _dieAction.Subscribe(OnDieAction);
        }

        private void OnDieAction(IEntity entity)
        {
            _animator.SetTrigger(Die);
        }
        
        public void Disable(IEntity entity)
        {
            _dieAction.Unsubscribe(OnDieAction);
        }
    }
}