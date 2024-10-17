using System;
using Atomic.AI;
using Unity.Mathematics;

namespace GamePlay
{
    [Serializable]
    public sealed class AssignStoppingDistanceFromAttackDataBlackboardAction : IBlackboardAction
    {
        public void Invoke(IBlackboard blackboard)
        {
            AttackData attackData = blackboard.GetAttackData();
            blackboard.SetStoppingDistance(attackData.MinDistance);
        }
    }
}