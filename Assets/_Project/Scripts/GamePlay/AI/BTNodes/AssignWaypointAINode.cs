using System;
using Atomic.AI;
using Unity.Mathematics;

namespace GamePlay
{
    [Serializable]
    public class AssignWaypointAINode : BTNode
    {
        protected override BTResult OnUpdate(IBlackboard blackboard, float deltaTime)
        {
            PatrolData patrolData = blackboard.GetPatrolData();
            float3 movePosition = patrolData.CurrentPosition;
            blackboard.SetMovePosition(movePosition);

            return BTResult.SUCCESS;
        }
    }
    
    // public sealed class FollowToTargetAINode : BTNode
    // {
    //     protected override BTResult OnUpdate(IBlackboard blackboard, float deltaTime)
    //     {
    //         if (!blackboard.TryGetTarget(out IEntity target))
    //         {
    //             return BTResult.FAILURE;
    //         }
    //         
    //         var atomicObject = blackboard.GetTarget();
    //         return BTResult.SUCCESS;
    //     }
    // }
}