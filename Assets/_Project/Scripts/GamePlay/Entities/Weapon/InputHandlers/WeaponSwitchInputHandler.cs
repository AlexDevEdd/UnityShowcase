using Atomic.Elements;
using Atomic.Entities;
using GameCycle;
using JetBrains.Annotations;

namespace GamePlay
{
    [UsedImplicitly]
    public class WeaponSwitchInputHandler : IGameStart, IGameFinish
    {
        private readonly IEntity _entity;
        private readonly ISwitchWeaponInput _switchWeaponInput;

        private IEvent<int> _switchWeaponAction;

        public WeaponSwitchInputHandler(IEntity entity, ISwitchWeaponInput switchWeaponInput)
        {
            _entity = entity;
            _switchWeaponInput = switchWeaponInput;
        }
        
        public void OnStart()
        {
            _switchWeaponAction = _entity.GetSwitchWeaponEvent();
            _switchWeaponInput.OnWeaponChanged += OnWeaponChanged;
        }

        private void OnWeaponChanged(int keyValue)
        {
            _switchWeaponAction?.Invoke(keyValue);
        }
        
        public void OnFinish()
        {
            _switchWeaponInput.OnWeaponChanged -= OnWeaponChanged;
        }
    }
}