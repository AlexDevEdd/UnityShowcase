using System;
using Atomic.AI;
using Atomic.Entities;

namespace GamePlay
{
    [Serializable]
    public sealed class HasTargetBlackboardCondition : IBlackboardCondition
    {
        public bool Invoke(IBlackboard blackboard)
        {
            if (!blackboard.HasTarget()) return false;
           
            var target = blackboard.GetTarget();
            return target != null && target.GetHealth().Value > 0f;
        }
    }
}