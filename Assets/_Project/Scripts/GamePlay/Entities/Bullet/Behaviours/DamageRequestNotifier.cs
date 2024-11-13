using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace GamePlay
{
    public sealed class DamageRequestNotifier : IEntityInit, IEntityEnable, IEntityDisable
    {
        private CollisionObserver _collisionObserver;
        private IValue<float> _damage;
        
        public void Init(IEntity entity)
        {
            _collisionObserver = entity.GetCollisionObserver();
            _damage = entity.GetDamage();
        }
        
        public void Enable(IEntity entity)
        {
            _collisionObserver.OnEnter += CollisionObserverOnEnter;
        }

        private void CollisionObserverOnEnter(Collision col)
        {
            if (col.gameObject.TryGetComponent(out IEntity entity) && entity.HasTag(TagAPI.Damagable))
            {
                entity.GetDamageRequest()?.Invoke(entity, col.contacts[0].point, _damage.Value);
            }
        }
        
        public void Disable(IEntity entity)
        {
            _collisionObserver.OnEnter -= CollisionObserverOnEnter;
        }
    }
}