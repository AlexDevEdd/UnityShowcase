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
        
        private EventAction _shootEvent;
        
        public CharacterFireInputHandler(IEntity entity, IFireInput fireInput)
        {
            _entity = entity;
            _fireInput = fireInput;
        }
        
        public void OnStart()
        {
            _shootEvent = _entity.GetFireEvent();
            _fireInput.OnFireEvent += OnFireEvent;
        }

        private void OnFireEvent()
        {
            _shootEvent?.Invoke();
            Debug.Log("Fire");
        }

        public void OnFinish()
        {
            _fireInput.OnFireEvent -= OnFireEvent;
        }
    }
}