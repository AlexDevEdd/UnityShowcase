using System;
using System.Threading;
using Atomic.Elements;
using Atomic.Entities;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.Animations.Rigging;

namespace GamePlay
{
    public sealed class WeaponReloadAnimationBehaviour : IEntityInit, IEntityEnable, IEntityDisable, IEntityDispose
    {
        private const int DISABLE_IK_VALUE = 0;
        private const int ENABLE_IK_VALUE = 1;
        private const float RELOAD_DELAY = 3f;
        
        private static readonly int Reload = Animator.StringToHash("Reload");
        
        private Animator _animator;
        private EventAction _reloadWeaponEvent;
        private Rig _rig;
        
        private bool _isReloading;
        private CancellationTokenSource _token;
        
        public void Init(IEntity entity)
        {
            _rig = entity.GetRig();
            _animator = entity.GetAnimator();
            _reloadWeaponEvent = entity.GetReloadWeaponEvent();
        }
        
        public void Enable(IEntity entity)
        {
            _reloadWeaponEvent.Subscribe(OnReload);
        }

        private void OnReload()
        {
            if(_isReloading) return;

            _isReloading = true;
            _animator.SetTrigger(Reload);
            ReloadingProcess().Forget();
        }

        private async UniTaskVoid ReloadingProcess()
        {
            _rig.weight = DISABLE_IK_VALUE;
            _token = new CancellationTokenSource();
            
            await UniTask.Delay(TimeSpan.FromSeconds(RELOAD_DELAY), cancellationToken: _token.Token);
            
            _rig.weight = ENABLE_IK_VALUE;
            _isReloading = false;
        }

        public void Disable(IEntity entity)
        {
            _reloadWeaponEvent.Unsubscribe(OnReload);
            _token?.Dispose();
        }

        public void Dispose(IEntity entity)
        {
            _token?.Dispose();
        }
    }
}