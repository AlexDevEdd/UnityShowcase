using System;
using Atomic.AI;

namespace GamePlay
{
    [Serializable]
    public sealed class AssignStoppingDistanceFromAttackDataBlackboardAction : IBlackboardAction
    {
        public void Invoke(IBlackboard blackboard)
        {
            if (!blackboard.TryGetAttackData(out Ref<AttackData> attackData))
                return;
            
            blackboard.SetStoppingDistance(attackData.value.MinDistance);
            blackboard.GetAgent().stoppingDistance = attackData.value.MinDistance;
        }
    }
}