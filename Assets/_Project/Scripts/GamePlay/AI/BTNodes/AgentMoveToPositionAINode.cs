using System;
using Atomic.AI;
using Atomic.Entities;
using Unity.Mathematics;
using UnityEngine;

namespace GamePlay
{
    [Serializable]
    public sealed class AgentMoveToPositionAINode : BTNode
    {
        public override string Name => "Move To Position";
        
        protected override BTResult OnUpdate(IBlackboard blackboard, float deltaTime)
        {
            if (!blackboard.TryGetSelf(out IEntity entity) ||
                !blackboard.TryGetAgent(out var agent) ||
                !blackboard.TryGetMovePosition(out float3 targetPosition))
                return BTResult.FAILURE;

            if (!entity.TryGetTransform(out var characterTransform))
                return BTResult.FAILURE;
            
            if(blackboard.GetIsAttacking())
                return BTResult.RUNNING;
            
            var targetPos = new Vector3(targetPosition.x, targetPosition.y, targetPosition.z);
            var distance =  targetPos - characterTransform.position;
            if (distance.sqrMagnitude <= agent.stoppingDistance)
            {
                agent.SetDestination(characterTransform.position);
                return BTResult.SUCCESS;
            }
            
            agent.SetDestination(targetPosition);
            return BTResult.RUNNING;
        }
    }
}