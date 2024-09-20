using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace GamePlay
{
    public sealed class ReturnToPoolBehaviour : IEntityInit, IEntityEnable, IEntityDisable
    {
        private IEntity _entity;
        private Countdown _countdown;
        private EventAction<IEntity> _dieAction;
        private CollisionObserver _collisionObserver;
        
        public void Init(IEntity entity)
        {
            _collisionObserver = entity.GetCollisionObserver();
            _countdown = entity.GetLifeTimer();
            _dieAction = entity.GetDieAction();
            _entity = entity;
        }
        
        public void Enable(IEntity entity)
        {
            _collisionObserver.OnEnter += CollisionObserverOnEnter;
            _countdown.OnEnded += CountdownOnEnded;
        }

        private void CollisionObserverOnEnter(Collider col)
        {
            _dieAction?.Invoke(_entity);
        }

        private void CountdownOnEnded()
        {
            _dieAction?.Invoke(_entity);
        }

        public void Disable(IEntity entity)
        {
            _collisionObserver.OnEnter -= CollisionObserverOnEnter;
            _countdown.OnEnded -= CountdownOnEnded;
        }
    }
}