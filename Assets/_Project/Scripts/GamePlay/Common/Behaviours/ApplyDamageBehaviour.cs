using System;
using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace GamePlay
{
    [Serializable]
    public sealed class ApplyDamageBehaviour : IEntityInit, IEntityEnable, IEntityDisable
    {
        private EventAction<IEntity, Vector3, float> _damageEvent;
        private EventAction<IEntity> _dieAction;
        
        public void Init(IEntity entity)
        {
            _damageEvent = entity.GetDamageEvent();
            _dieAction = entity.GetDieAction();
        }
        
        public void Enable(IEntity entity)
        {
            _damageEvent.Subscribe(OnDamageEvent);
        }

        private void OnDamageEvent(IEntity entity, Vector3 firstContact, float damage)
        {
            var health = entity.GetHealth();
            if (health.Value >= 0) 
                health.Value = Math.Max(0, health.Value - damage);
            
            if(health.Value == 0)
                _dieAction?.Invoke(entity);
               
        }
        
        public void Disable(IEntity entity)
        {
            _damageEvent.Unsubscribe(OnDamageEvent);
        }
    }
}