using System;
using Atomic.AI;

namespace GamePlay
{
    [Serializable]
    public sealed class NextWaypointBlackboardAction : IBlackboardAction
    {
        public void Invoke(IBlackboard blackboard)
        {
            ref PatrolData patrolData = ref blackboard.GetPatrolData();
            patrolData.MoveNext();
        }
    }
}