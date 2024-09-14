using System.Collections.Generic;
using Atomic.Elements;
using Atomic.Entities;
using GameCycle;
using JetBrains.Annotations;
using Utils;
using Zenject;

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
            _switchWeaponAction = _entity.GetWeaponIndex();
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

    
    public sealed class WeaponSystem : IInitializable, IGameStart, IGameFinish
    {
        private EventAction<int> _switchWeaponAction;
        
        private readonly IEntity _entity;
        private readonly IEntityWorld _entityWorld;
        
        private IVariable<IEntity> _currentWeapon;
        private List<IEntity> _weapons;

        public WeaponSystem(IEntity entity, IEntityWorld entityWorld)
        {
            _entity = entity;
            _entityWorld = entityWorld;
        }
        
        public void Initialize()
        {
            _switchWeaponAction = _entity.GetWeaponIndex();
            _currentWeapon = _entity.GetCurrentWeapon();
            _weapons = new List<IEntity>(_entityWorld.GetEntitiesWithTag(TagAPI.Weapon));
        }
        
        public void OnStart()
        {
            _switchWeaponAction.Subscribe(OnSwitchWeapon);
            OnSwitchWeapon(1);
        }
        
        private void OnSwitchWeapon(int index)
        {
            foreach (var weapon in _weapons)
            {
                var temp = weapon as SceneEntity;
                temp.SetActive(false);
            }
            
            var current = _weapons[index - 1] as SceneEntity;
            current.SetActive(true);
            _currentWeapon.Value = current;
        }

        public void OnFinish()
        {
            _switchWeaponAction.Unsubscribe(OnSwitchWeapon);
        }
    }
}