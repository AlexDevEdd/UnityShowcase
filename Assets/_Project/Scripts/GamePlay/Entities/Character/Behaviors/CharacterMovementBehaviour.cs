using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace GamePlay
{
    public sealed class CharacterMovementBehaviour : IEntityInit, IEntityUpdate
    {
        private const float GRAVITY_SCALE = 9.81f;
        
        private IVariable<bool> _isRunning;
        private IValue<float> _moveSpeed;
        private IValue<float> _runSpeed;
        private IVariable<Vector3> _moveDirection;
        private CharacterController _characterController;
        
        private float _verticalVelocity;
        
        public void Init(IEntity entity)
        {
            _runSpeed = entity.GetRunSpeed();
            _moveSpeed = entity.GetMoveSpeed();
            _isRunning = entity.GetIsRunning();
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
                var moveSpeed = _isRunning.Value ? _runSpeed.Value : _moveSpeed.Value;
                _characterController.Move( _moveDirection.Value * deltaTime * moveSpeed);
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