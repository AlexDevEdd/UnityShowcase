using System;
using Atomic.AI;
using UnityEngine;

namespace GamePlay
{
    [Serializable]
    public sealed class DieAnimationBlackboardAction : IBlackboardAction
    {
        private static readonly int Die = Animator.StringToHash("Die");
        
        public void Invoke(IBlackboard blackboard)
        {
            var animator = blackboard.GetAnimator();
            animator.SetTrigger(Die);
           
        }
    }
}