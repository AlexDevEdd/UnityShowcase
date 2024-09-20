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
        private readonly IRunInput _runInput;
        private readonly IMoveInput _moveInput;
        
        private IVariable<Vector3> _moveDirection;
        private IVariable<bool> _isRunning;

        public CharacterMovementInputHandler(IEntity entity, IMoveInput moveInput, IRunInput runInput)
        {
            _entity = entity;
            _runInput = runInput;
            _moveInput = moveInput;
        }
        
        public void OnStart()
        {
            _moveDirection = _entity.GetMoveDirection();
            _isRunning = _entity.GetIsRunning();
            
            _moveInput.OnMoveEvent += OnMoveEvent;
            _runInput.OnRunEvent += OnRunEvent;
        }

        private void OnMoveEvent(Vector2 direction)
        {
            _moveDirection.Value = new Vector3(direction.x, 0, direction.y);
        }

        private void OnRunEvent(bool isRunning)
        {
            _isRunning.Value = isRunning;
        }

        public void OnFinish()
        {
            _moveInput.OnMoveEvent -= OnMoveEvent;
            _runInput.OnRunEvent -= OnRunEvent;
        }
    }
}