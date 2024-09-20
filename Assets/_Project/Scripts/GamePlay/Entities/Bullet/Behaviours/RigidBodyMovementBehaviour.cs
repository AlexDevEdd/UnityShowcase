using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace GamePlay
{
    public sealed class RigidBodyMovementBehaviour : IEntityInit, IEntityEnable
    {
        private Rigidbody _rigidbody;
        private IValue<float> _moveSpeed;
        
        private float _verticalVelocity;
        
        public void Init(IEntity entity)
        {
            _moveSpeed = entity.GetMoveSpeed();
            _rigidbody = entity.GetRigidbody();
        }
        
        public void Enable(IEntity entity)
        {
            _rigidbody.velocity = _rigidbody.transform.forward * _moveSpeed.Value;
        }
    }
}