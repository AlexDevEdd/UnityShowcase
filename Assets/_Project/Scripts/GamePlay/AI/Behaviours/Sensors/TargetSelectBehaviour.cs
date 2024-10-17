using System;
using Atomic.AI;
using Atomic.Entities;
using UnityEngine;

namespace GamePlay
{
    [Serializable]
    public sealed class TargetSelectBehaviour : IAIUpdate
    {
        public void OnUpdate(IBlackboard blackboard, float deltaTime)
        {
            if (SelectClosestTarget(blackboard, out IEntity target))
            {
                blackboard.SetTarget(target);
            }
            else
            {
                blackboard.DelTarget();
            }
        }

        private static bool SelectClosestTarget(IBlackboard blackboard, out IEntity target)
        {
            target = null;

            ref var buffer = ref blackboard.GetCollidersBuffer();
            int count = buffer.Size;
            
            Collider[] colliders = buffer.Values;

            Vector3 selfPosition = blackboard.GetSelf().GetTransform().position;
            
            float minDistance = float.MaxValue;

            for (int i = 0; i < count; i++)
            {
                Collider collider = colliders[i];
                if (!collider.TryGetComponent(out IEntity obj))
                {
                    continue;
                }

                // if (!obj.TryGet(HealthAPI.IsAlive, out IAtomicValue<bool> isAlive) ||
                //     !isAlive.Value)
                // {
                //     continue;
                // }

                Vector3 targetPosition = obj.GetTransform().position;

                Vector3 distanceVector = targetPosition - selfPosition;
                float targetDistance = distanceVector.sqrMagnitude;

                if (targetDistance < minDistance * minDistance)
                {
                    target = obj;
                    minDistance = targetDistance;
                }
            }

            return target != null;
        }
    }
}