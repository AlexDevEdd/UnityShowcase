using System;
using Atomic.Elements;
using Atomic.Entities;

namespace GamePlay
{
    public sealed class FireBehaviour : IEntityInit, IEntityEnable, IEntityDisable
    {
        private IEntity _entity;
        private EventAction _fireAction;
        private IVariable<int> _currentAmmo;
        
        
        public void Init(IEntity entity)
        {
            _fireAction = entity.GetFireAction();
            _currentAmmo = entity.GetCurrentAmmo();
        }
        
        public void Enable(IEntity entity)
        {
            _fireAction.Subscribe(FireAction);
        }

        private void FireAction()
        {
            if(_currentAmmo.Value == 0) return;
            
            _currentAmmo.Value -= 1;
        }
        
        public void Disable(IEntity entity)
        {
            _fireAction.Unsubscribe(FireAction);
        }
    }
}