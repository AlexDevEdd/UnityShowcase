using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace GamePlay
{
    public sealed class CharacterMovementBehaviour : IEntityInit, IEntityUpdate
    {
        private const float GRAVITY_SCALE = 9.81f;
        
        private IValue<float> _moveSpeed;
        private IVariable<Vector3> _moveDirection;
        private CharacterController _characterController;

        private float _verticalVelocity;
        
        public void Init(IEntity entity)
        {
            _moveSpeed = entity.GetMoveSpeed();
            _moveDirection = entity.GetMoveDirection();
            _characterController = entity.GetCharacterController();
        }
        
        public void OnUpdate(IEntity entity, float deltaTime)
        {
            ApplyMovement(deltaTime);
            ApplyGravity();
        }

        private void ApplyMovement(float deltaTime)
        {
            if (_moveDirection.Value.magnitude > 0)
            {
                _characterController.Move( _moveDirection.Value * deltaTime * _moveSpeed.Value);
            }
        }

        private void ApplyGravity()
        {
            if (_characterController.isGrounded == false)
            {
                _verticalVelocity -= GRAVITY_SCALE * Time.deltaTime;
                _moveDirection.Value = new Vector3(_moveDirection.Value.x, _verticalVelocity, _moveDirection.Value.z);
            }
            else
            {
                _verticalVelocity = -.5f;
            }
        }
    }
}