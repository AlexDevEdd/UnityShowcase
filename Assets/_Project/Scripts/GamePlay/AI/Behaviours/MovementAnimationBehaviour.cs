using System;
using Atomic.AI;
using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace GamePlay
{
    [Serializable]
    public class MovementAnimationBehaviour : IAIEnable, IAIDisable
    {
        private static readonly int Speed = Animator.StringToHash("Speed");
        
        private IReactiveValue<float> _moveSpeed;
        private Animator _animator;
        
        public void Enable(IBlackboard blackboard)
        {
            var entity = blackboard.GetSelf();
            _moveSpeed = entity.GetMoveSpeed();
            _moveSpeed.Subscribe(OnMoveSpeedChanged);
            
            _animator = blackboard.GetAnimator();
        }

        private void OnMoveSpeedChanged(float moveSpeed)
        {
            _animator.SetFloat(Speed, moveSpeed);
        }

        public void Disable(IBlackboard blackboard)
        {
            _moveSpeed.Unsubscribe(OnMoveSpeedChanged);
        }
    }
}