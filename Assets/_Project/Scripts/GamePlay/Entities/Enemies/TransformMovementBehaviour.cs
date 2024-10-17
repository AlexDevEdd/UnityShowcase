using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace GamePlay
{
    public sealed class TransformMovementBehaviour : IEntityInit, IEntityUpdate
    {
        private Transform _transform;
       
        private IValue<Vector3> _moveDirection;
        private IValue<float> _moveSpeed;

        public void Init(IEntity entity)
        {
            _transform = entity.GetTransform();
            _moveDirection = entity.GetMoveDirection();
            _moveSpeed = entity.GetMoveSpeed();
        }
        
        public void OnUpdate(IEntity entity, float deltaTime)
        {
            _transform.position += (_moveDirection.Value * _moveSpeed.Value) * deltaTime;
        }
    }
}