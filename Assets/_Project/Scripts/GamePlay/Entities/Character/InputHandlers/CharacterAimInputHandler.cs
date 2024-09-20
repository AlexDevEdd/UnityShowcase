using Atomic.Elements;
using Atomic.Entities;
using GameCycle;
using JetBrains.Annotations;
using UnityEngine;

namespace GamePlay
{
    [UsedImplicitly]
    public class CharacterAimInputHandler : IGameStart, IGameFinish
    {
        private readonly IEntity _entity;
        private readonly IAimInput _aimInput;

        private IVariable<Vector2> _lookingDirection;

        public CharacterAimInputHandler(IEntity entity, IAimInput aimInput)
        {
            _entity = entity;
            _aimInput = aimInput;
        }
        
        public void OnStart()
        {
            _lookingDirection = _entity.GetLookingDirection();
            _aimInput.OnAimEvent += OnAimEvent;
        }

        private void OnAimEvent(Vector2 direction)
        {
            _lookingDirection.Value = direction;
        }

        public void OnFinish()
        {
            _aimInput.OnAimEvent -= OnAimEvent;
        }
    }
}