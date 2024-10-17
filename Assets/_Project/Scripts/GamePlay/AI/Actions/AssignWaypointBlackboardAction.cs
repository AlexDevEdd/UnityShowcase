using System;
using Atomic.AI;
using Unity.Mathematics;

namespace GamePlay
{
    [Serializable]
    public sealed class AssignWaypointBlackboardAction : IBlackboardAction
    {
        public void Invoke(IBlackboard blackboard)
        {
            PatrolData patrolData = blackboard.GetPatrolData();
            float3 movePosition = patrolData.CurrentPosition;
            blackboard.SetMovePosition(movePosition);
        }
    }
}