using System;
using Atomic.AI;

namespace GamePlay
{
    [Serializable]
    public sealed class NextWaypointAINode : BTNode
    {
        protected override BTResult OnUpdate(IBlackboard blackboard, float deltaTime)
        {
            ref PatrolData patrolData = ref blackboard.GetPatrolData();
            patrolData.MoveNext();
            return BTResult.SUCCESS;
        }
    }
}