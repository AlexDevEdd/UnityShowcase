using System;
using Atomic.AI;

namespace GamePlay
{
    [Serializable]
    public sealed class HasTargetBlackboardCondition : IBlackboardCondition
    {
        public bool Invoke(IBlackboard blackboard)
        {
            return blackboard.HasTarget();
        }
    }
}