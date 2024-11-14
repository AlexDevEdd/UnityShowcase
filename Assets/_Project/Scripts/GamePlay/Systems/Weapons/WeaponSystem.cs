using System.Linq;
using Atomic.Elements;
using Atomic.Entities;
using GameCycle;
using JetBrains.Annotations;
using UnityEngine;
using Utils;
using Zenject;

namespace GamePlay
{
    [UsedImplicitly]
    public sealed class WeaponSystem : IInitializable, IGameFinish
    {
        public IEvent<int> SwitchWeaponAction;
        
        private readonly IEntity _entity;
        private readonly IEntityWorld _entityWorld;
        
        private Transform _currentLeftHandIKTarget;
        private IVariable<IEntity> _currentWeapon;
        private IReactiveList<IEntity> _weapons;

        public IValue<IEntity> CurrentWeapon => _currentWeapon;

        public WeaponSystem(IEntity entity, IEntityWorld entityWorld)
        {
            _entity = entity;
            _entityWorld = entityWorld;
        }

        public void Initialize()
        {
            _currentLeftHandIKTarget = _entity.GetLeftHandIKTarget();
            SwitchWeaponAction = _entity.GetSwitchWeaponEvent();
            _currentWeapon = _entity.GetCurrentWeapon();
            _weapons = new ReactiveList<IEntity>(_entityWorld.GetEntitiesWithTag(TagAPI.Weapon)
                .OrderBy(entity => entity.GetHotBarSlotNumber().Value));
            
            SwitchWeaponAction.Subscribe(OnSwitchWeapon);
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
            
            var leftHandIKTarget = current.GetLeftHandIKTarget();
            _currentLeftHandIKTarget.localPosition = leftHandIKTarget.localPosition;
            _currentLeftHandIKTarget.localRotation = leftHandIKTarget.localRotation;
            
            _currentWeapon.Value = current;
        }

        public IReactiveList<IEntity> GetWeapons()
        {
            return _weapons;
        }

        public void OnFinish()
        {
            SwitchWeaponAction.Unsubscribe(OnSwitchWeapon);
        }
    }
}