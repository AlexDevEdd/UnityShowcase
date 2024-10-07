using System;
using System.Threading;
using Atomic.Elements;
using Atomic.Entities;
using Cysharp.Threading.Tasks;
using GameCycle;
using JetBrains.Annotations;

namespace GamePlay
{
    [UsedImplicitly]
    public sealed class WeaponReloadingSystem : IGameStart, IGameFinish
    {
        private readonly IEntity _entity;
        
        private EventAction _reloadWeaponEvent;
        private EventAction _reloadWeaponRequest;
        private IValue<IEntity> _currentWeapon;
        private IVariable<bool> _isReloading;
        
        private CancellationTokenSource _token;
        
        public WeaponReloadingSystem(IEntity entity)
        {
            _entity = entity;
        }

        public void OnStart()
        {
            _currentWeapon = _entity.GetCurrentWeapon();
            _reloadWeaponEvent = _entity.GetReloadWeaponEvent();
            
            _reloadWeaponRequest = _entity.GetReloadWeaponRequest();
            _reloadWeaponRequest.Subscribe(OnReloadRequest);

            _isReloading = _entity.GetIsReloading();
        }
        
        private void OnReloadRequest()
        {
            if(_isReloading.Value) return;
            
            var currentAmmo = _currentWeapon.Value.GetCurrentAmmo();
            var totalAmmo = _currentWeapon.Value.GetTotalAmmo();
            var magazineCapacity = _currentWeapon.Value.GetMagazineCapacity();
            
            if(currentAmmo.Value >= magazineCapacity.Value || totalAmmo.Value == 0) return;
            
            ReloadingProcess(currentAmmo, totalAmmo, magazineCapacity).Forget();
        }
        
        private async UniTaskVoid ReloadingProcess(IVariable<int> currentAmmo, IVariable<int> totalAmmo,
            IVariable<int> magazineCapacity)
        {
            _token = new CancellationTokenSource();
            
            _isReloading.Value = true;
            _reloadWeaponEvent?.Invoke();
            
            currentAmmo.Value = 0;
            
            var reloadDelay = _currentWeapon.Value.GetRechargeDelay();
            await UniTask.Delay(TimeSpan.FromSeconds(reloadDelay.Value), cancellationToken: _token.Token);
            
            if (totalAmmo.Value >= magazineCapacity.Value)
            {
                currentAmmo.Value = magazineCapacity.Value;
                totalAmmo.Value -= magazineCapacity.Value;
            }
            else
            {
                currentAmmo.Value = totalAmmo.Value;
                totalAmmo.Value = 0;
            }
           
            _isReloading.Value = false;
        }

        public void OnFinish()
        {
            _reloadWeaponRequest.Unsubscribe(OnReloadRequest);
            _token?.Dispose();
        }
    }
}