using Atomic.Elements;
using Atomic.Entities;
using Atomic.Extensions;
using UnityEngine;

namespace GamePlay
{
    public sealed class CharacterAnimationMovementBehaviour : IEntityInit, IEntityUpdate
    {
        private static readonly int XVelocity = Animator.StringToHash("xVelocity");
        private static readonly int ZVelocity = Animator.StringToHash("zVelocity");
        
        private Animator _animator;
        private Transform _transform;
        private IVariable<Vector3> _moveDirection;
        
        public void Init(IEntity entity)
        {
            _animator = entity.GetAnimator();
            _moveDirection = entity.GetMoveDirection();
            _transform = entity.GetTransform();
        }
        
        public void OnUpdate(IEntity entity, float deltaTime)
        {
            var xVelocity = Vector3.Dot(_moveDirection.Value.normalized, _transform.right);
            var zVelocity = Vector3.Dot(_moveDirection.Value.normalized, _transform.forward);
            
            _animator.SetFloat(XVelocity, xVelocity, 0.1f, deltaTime);
            _animator.SetFloat(ZVelocity, zVelocity, 0.1f, deltaTime);
        }
    }
}