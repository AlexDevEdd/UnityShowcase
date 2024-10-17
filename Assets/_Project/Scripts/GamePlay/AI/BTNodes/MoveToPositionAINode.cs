using System;
using Atomic.AI;
using Atomic.Entities;
using Unity.Mathematics;

namespace GamePlay
{
    [Serializable]
    public sealed class MoveToPositionAINode : BTNode
    {
        protected override void OnEnable(IBlackboard blackboard)
        {
            if (blackboard.TryGetSelf(out IEntity entity))
            {
                entity.GetMoveDirection().Value = float3.zero;
            }
        }

        protected override void OnDisable(IBlackboard blackboard)
        {
            if (blackboard.TryGetSelf(out IEntity entity))
            {
                entity.GetMoveDirection().Value = float3.zero;
            }
        }

        protected override BTResult OnUpdate(IBlackboard blackboard, float deltaTime)
        {
            if (!blackboard.TryGetSelf(out IEntity entity) ||
                !blackboard.TryGetMovePosition(out float3 targetPosition) ||
                !blackboard.TryGetStoppingDistance(out float stoppingDistance))
            {
                return BTResult.FAILURE;
            }

            float3 myPosition = entity.GetTransform().position;
            float3 distance = targetPosition - myPosition;

            if (math.lengthsq(distance) <= stoppingDistance * stoppingDistance)
            {
                return BTResult.SUCCESS;
            }

            var moveDirection = math.normalize(distance);
            entity.GetMoveDirection().Value = moveDirection;
            return BTResult.RUNNING;
        }
    }
}