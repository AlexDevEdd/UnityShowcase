using System;
using Atomic.AI;
using Atomic.Entities;

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
                return BTResult.FAILURE;

            if(blackboard.GetIsAttacking())
                return BTResult.RUNNING;
            
            if (!entity.TryGetTransform(out var characterTransform) || 
                !target.TryGetTransform(out var targetTransform))
                return BTResult.FAILURE;
            
            characterTransform.LookAt(targetTransform);
            
            var distance = targetTransform.position - characterTransform.position;
            if (distance.sqrMagnitude > attackData.value.MinDistance)
                return BTResult.SUCCESS;
            
            entity.GetFireAction().Invoke();
            return BTResult.RUNNING;
            
        }
    }
}