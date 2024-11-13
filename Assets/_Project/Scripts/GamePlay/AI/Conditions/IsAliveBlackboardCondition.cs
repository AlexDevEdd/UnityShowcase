using System;
using Atomic.AI;
using Atomic.Entities;

namespace GamePlay
{
    [Serializable]
    public sealed class IsAliveBlackboardCondition : IBlackboardCondition
    {
        public bool Invoke(IBlackboard blackboard)
        {
            var entity = blackboard.GetSelf();
            var health = entity.GetHealth();
            return !(health.Value <= 0f);
        }
    }
}