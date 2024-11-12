using System;
using Atomic.AI;
using Atomic.Elements;
using Atomic.Entities;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace GamePlay
{
    [Serializable]
    public class AttackAnimationBehaviour : IAIEnable, IAIDisable
    {
        private const float ATTACK_DELAY = 2f;
        private static readonly int Attack = Animator.StringToHash("Attack");
        
        private EventAction _attackAction;
        private Animator _animator;
        private IBlackboard _blackboard;

        public void Enable(IBlackboard blackboard)
        {
            _blackboard = blackboard;
            var entity = blackboard.GetSelf();
            _attackAction = entity.GetFireAction();
            _attackAction.Subscribe(OnAttackAction);
            
            _animator = blackboard.GetAnimator();
        }

        private void OnAttackAction()
        {
            if(_blackboard.GetIsAttacking()) return;
            _animator.SetTrigger(Attack);
            AttackingDelay().Forget();
        }


        public void Disable(IBlackboard blackboard)
        {
            _attackAction.Unsubscribe(OnAttackAction);
        }
        
        private async UniTaskVoid AttackingDelay()
        {
            _blackboard.SetIsAttacking(true);
            await UniTask.Delay(TimeSpan.FromSeconds(ATTACK_DELAY));
            _blackboard.SetIsAttacking(false);
        }
    }
}