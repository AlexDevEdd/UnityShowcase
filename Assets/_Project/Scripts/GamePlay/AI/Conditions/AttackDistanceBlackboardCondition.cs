using System;
using Atomic.AI;
using Atomic.Entities;
using Unity.Mathematics;
using UnityEngine;

namespace GamePlay
{
    [Serializable]
    public sealed class AttackDistanceBlackboardCondition : IBlackboardCondition
    {
        private enum ComparisonType
        {
            LESS = 0,
            LESS_OR_EQUALS = 1,
            MORE = 2,
            MORE_OR_EQUALS = 3
        }
        
        [SerializeField, BlackboardKey]
        private int _attackDataKey;

        [SerializeField]
        private ComparisonType _comparisonType;

        public bool Invoke(IBlackboard blackboard)
        {
            if (!blackboard.TryGetSelf(out IEntity self) ||
                !blackboard.TryGetTarget(out IEntity target) ||
                !blackboard.TryGetAttackData(out var attackData))
            {
                return false;
            }

            if (!self.TryGetTransform(out var selfTransform) ||
                !target.TryGetTransform(out var targetTransform))
            {
                return false;
            }

            float3 distance = selfTransform.position - targetTransform.position;

            float currentDistance = math.dot(distance, distance);
            float targetDistance = attackData.value.MinDistance;

            return _comparisonType switch
            {
                ComparisonType.LESS => currentDistance < targetDistance,
                ComparisonType.LESS_OR_EQUALS => currentDistance <= targetDistance,
                ComparisonType.MORE => currentDistance > targetDistance,
                ComparisonType.MORE_OR_EQUALS => currentDistance >= targetDistance,
                _ => throw new Exception($"Equation of type {_comparisonType} is not found!")
            };
        }
    }
}