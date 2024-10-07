using Atomic.Elements;
using Atomic.Entities;
using GameCycle;
using JetBrains.Annotations;

namespace GamePlay
{
    [UsedImplicitly]
    public class WeaponReloadInputHandler : IGameStart, IGameFinish
    {
        private readonly IEntity _entity;
        private readonly IReloadInput _reloadInput;
        
        private EventAction _reloadWeaponRequest;
        
        public WeaponReloadInputHandler(IEntity entity, IReloadInput reloadInput)
        {
            _entity = entity;
            _reloadInput = reloadInput;
        }
        
        public void OnStart()
        {
            _reloadWeaponRequest = _entity.GetReloadWeaponRequest();
            _reloadInput.OnReloadEvent += OnReloadEvent;
        }

        private void OnReloadEvent()
        {
            _reloadWeaponRequest?.Invoke();
        }

        public void OnFinish()
        {
            _reloadInput.OnReloadEvent -= OnReloadEvent;
        }
    }
}