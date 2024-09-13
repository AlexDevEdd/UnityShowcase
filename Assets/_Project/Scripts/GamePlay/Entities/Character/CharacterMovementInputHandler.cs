using Atomic.Elements;
using Atomic.Entities;
using GameCycle;
using JetBrains.Annotations;
using UnityEngine;

namespace GamePlay
{
    [UsedImplicitly]
    public class CharacterMovementInputHandler : IGameStart, IGameFinish
    {
        private readonly IEntity _entity;
        private readonly IMoveInput _moveInput;
        
        private IVariable<Vector3> _moveDirection;

        public CharacterMovementInputHandler(IEntity entity, IMoveInput moveInput)
        {
            _entity = entity;
            _moveInput = moveInput;
        }
        
        public void OnStart()
        {
            _moveDirection = _entity.GetMoveDirection();
            _moveInput.OnMoveEvent += OnMoveEvent;
        }

        private void OnMoveEvent(Vector2 direction)
        {
            _moveDirection.Value = new Vector3(direction.x, 0, direction.y);
        }

        public void OnFinish()
        {
            _moveInput.OnMoveEvent -= OnMoveEvent;
        }
    }
}