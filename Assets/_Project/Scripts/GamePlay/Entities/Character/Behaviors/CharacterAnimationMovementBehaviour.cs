using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace GamePlay
{
    public sealed class CharacterAnimationMovementBehaviour : IEntityInit, IEntityUpdate
    {
        private static readonly int XVelocity = Animator.StringToHash("xVelocity");
        private static readonly int ZVelocity = Animator.StringToHash("zVelocity");
        private static readonly int IsRunning = Animator.StringToHash("isRunning");
        
        private Animator _animator;
        private Transform _transform;
        private IVariable<Vector3> _moveDirection;
        private IReactiveVariable<bool> _isRunning;
        
        public void Init(IEntity entity)
        {
            _animator = entity.GetAnimator();
            _moveDirection = entity.GetMoveDirection();
            _transform = entity.GetTransform();
            _isRunning = entity.GetIsRunning();
            
            _isRunning.OnValueChanged += IsRunningValueChanged;
        }

        private void IsRunningValueChanged(bool isRunning)
        {
            _animator.SetBool(IsRunning, _moveDirection.Value.magnitude > 0 && isRunning);
        }

        public void OnUpdate(IEntity entity, float deltaTime)
        {
            if (_moveDirection.Value.magnitude > 0)
            {
                var xVelocity = Vector3.Dot(_moveDirection.Value.normalized, _transform.right);
                var zVelocity = Vector3.Dot(_moveDirection.Value.normalized, _transform.forward);

                _animator.SetFloat(XVelocity, xVelocity, 0.1f, deltaTime);
                _animator.SetFloat(ZVelocity, zVelocity, 0.1f, deltaTime);
            }
            else
            {
                _animator.SetFloat(XVelocity, 0);
                _animator.SetFloat(ZVelocity, 0);
            }
        }
    }
}