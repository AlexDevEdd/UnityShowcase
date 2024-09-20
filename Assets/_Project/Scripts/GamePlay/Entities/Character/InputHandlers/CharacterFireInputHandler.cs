using Atomic.Elements;
using Atomic.Entities;
using GameCycle;
using JetBrains.Annotations;
using UnityEngine;

namespace GamePlay
{
    [UsedImplicitly]
    public class CharacterFireInputHandler : IGameStart, IGameFinish
    {
        private readonly IEntity _entity;
        private readonly IFireInput _fireInput;
        
        private EventAction _fireAction;
        
        public CharacterFireInputHandler(IEntity entity, IFireInput fireInput)
        {
            _entity = entity;
            _fireInput = fireInput;
        }
        
        public void OnStart()
        {
            _fireAction = _entity.GetFireAction();
            _fireInput.OnFireEvent += OnFireEvent;
        }

        private void OnFireEvent()
        {
            _fireAction?.Invoke();
        }

        public void OnFinish()
        {
            _fireInput.OnFireEvent -= OnFireEvent;
        }
    }
}