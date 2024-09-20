using System.Collections.Generic;
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
    public sealed class WeaponSystem : IInitializable, IGameStart, IGameFinish
    {
        private EventAction<int> _switchWeaponAction;
        
        private readonly IEntity _entity;
        private readonly IEntityWorld _entityWorld;
        
        private Transform _currentLeftHandIKTarget;
        private IVariable<IEntity> _currentWeapon;
        private List<IEntity> _weapons;

        public WeaponSystem(IEntity entity, IEntityWorld entityWorld)
        {
            _entity = entity;
            _entityWorld = entityWorld;
        }
        
        public void Initialize()
        {
            _currentLeftHandIKTarget = _entity.GetLeftHandIKTarget();
            _switchWeaponAction = _entity.GetSwitchWeaponEvent();
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
            
            var leftHandIKTarget = current.GetLeftHandIKTarget();
            _currentLeftHandIKTarget.localPosition = leftHandIKTarget.localPosition;
            _currentLeftHandIKTarget.localRotation = leftHandIKTarget.localRotation;
            
            _currentWeapon.Value = current;
        }

        public void OnFinish()
        {
            _switchWeaponAction.Unsubscribe(OnSwitchWeapon);
        }
    }
}