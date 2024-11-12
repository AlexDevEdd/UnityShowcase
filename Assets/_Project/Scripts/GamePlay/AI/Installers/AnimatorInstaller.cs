using System;
using Atomic.AI;
using Sirenix.OdinInspector;
using UnityEngine;

namespace GamePlay
{
    [Serializable, InlineProperty]
    public sealed class AnimatorInstaller : IBlackboardInstaller
    {
        [HorizontalGroup]
        [SerializeField]
        private Animator _animator;
        
        public void Install(IBlackboard blackboard)
        {
            blackboard.SetAnimator(_animator);
        }
    }
}