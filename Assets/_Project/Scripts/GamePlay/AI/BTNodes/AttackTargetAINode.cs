using System;
using Atomic.AI;
using Atomic.Entities;
using UnityEngine;

namespace GamePlay
{
    [Serializable]
    public sealed class AttackTargetAINode : BTNode
    {
        public override string Name => "Attack Target";

        protected override BTResult OnUpdate(IBlackboard blackboard, float deltaTime)
        {
            if (!blackboard.TryGetSelf(out IEntity entity) ||
                !blackboard.TryGetTarget(out IEntity target) ||
                !blackboard.TryGetAttackData(out Ref<AttackData> attackData))
            {
                return BTResult.FAILURE;
            }

            if (!entity.TryGetTransform(out var characterTransform) || 
                !target.TryGetTransform(out var targetTransform))
            {
                return BTResult.FAILURE;
            }
            
            Vector3 distance = targetTransform.position - characterTransform.position;
            if (distance.sqrMagnitude > attackData.value.MinDistanceSqr)
            {
                return BTResult.FAILURE;
            }
            
            entity.GetFireAction().Invoke();
            return BTResult.RUNNING;
        }
    }
}