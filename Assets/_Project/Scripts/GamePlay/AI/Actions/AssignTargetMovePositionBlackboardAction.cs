using System;
using Atomic.AI;
using Atomic.Entities;
using Unity.Mathematics;

namespace GamePlay
{
    [Serializable]
    public sealed class AssignTargetMovePositionBlackboardAction : IBlackboardAction
    {
        public void Invoke(IBlackboard blackboard)
        {
            IEntity target = blackboard.GetTarget();
            float3 targetPosition = target.GetTransform().position;
            blackboard.SetMovePosition(targetPosition);

        }
    }

}