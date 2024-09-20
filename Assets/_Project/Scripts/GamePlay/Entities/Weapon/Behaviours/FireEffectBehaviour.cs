using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace GamePlay
{
    public sealed class FireEffectBehaviour : IEntityInit, IEntityEnable, IEntityDisable
    {
        private IEntity _entity;
        private EventAction _fireAction;
        private ParticleSystem _fireEffect;
        
        public void Init(IEntity entity)
        {
            _fireEffect = entity.GetFireEffect();
            _fireAction = entity.GetFireAction();
        }
        
        public void Enable(IEntity entity)
        {
            _fireAction.Subscribe(FireAction);
        }

        private void FireAction()
        {
            _fireEffect.Stop();
            _fireEffect.Play();
        }
        
        public void Disable(IEntity entity)
        {
            _fireEffect.Stop();
            _fireAction.Unsubscribe(FireAction);
        }
    }
}