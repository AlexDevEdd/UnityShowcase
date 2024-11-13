using System;
using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace GamePlay
{
    [Serializable]
    public sealed class DamageRequestBehaviour : IEntityInit, IEntityEnable, IEntityDisable
    {
        private EventAction<IEntity, Vector3, float> _damageRequest;
        private EventAction<IEntity, Vector3, float> _damageEvent;
        
        public void Init(IEntity entity)
        {
            _damageRequest = entity.GetDamageRequest();
            _damageEvent = entity.GetDamageEvent();
        }
        
        public void Enable(IEntity entity)
        {
            _damageRequest.Subscribe(OnDamageRequest);
        }

        private void OnDamageRequest(IEntity entity, Vector3 firstContact, float damage)
        {
            var health = entity.GetHealth();
            if (health.Value >= 0)
            {
                _damageEvent?.Invoke(entity, firstContact, damage);
            }
        }
        
        public void Disable(IEntity entity)
        {
            _damageRequest.Unsubscribe(OnDamageRequest);
        }
    }
}