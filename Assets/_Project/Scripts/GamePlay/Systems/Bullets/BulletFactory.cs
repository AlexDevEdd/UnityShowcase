using System;
using System.Collections.Generic;
using System.Threading;
using AssetManagement;
using Atomic.Entities;
using Cysharp.Threading.Tasks;
using JetBrains.Annotations;
using UnityEngine;

namespace GamePlay
{
    [UsedImplicitly]
    public sealed class BulletFactory : IBulletFactory, IDisposable
    {
        private readonly Dictionary<ProjectileType, MonoPool<SceneEntity>> _bulletPoolMap = 
            new (Enum.GetValues(typeof(ProjectileType)).Length);
        
        private readonly Transform _poolContainer;
        private readonly IAssetProvider _assetProvider;
        private readonly SceneEntityWorld _sceneEntityWorld;

        private CancellationTokenSource _tokenSource;
        
        public BulletFactory(IAssetProvider assetProvider, SceneEntityWorld sceneEntityWorld, Transform poolContainer)
        {
            _assetProvider = assetProvider;
            _sceneEntityWorld = sceneEntityWorld;
            _poolContainer = poolContainer;
        }

        public async UniTask CreatePoolsAsync()
        {
            _tokenSource = new CancellationTokenSource();
            
            var taskList = new List<UniTask>
            {
                CreatePoolAsync(AssetKeys.PISTOL_BULLET, 10),
                CreatePoolAsync(AssetKeys.PLAZMA_BULLET, 10),
                CreatePoolAsync(AssetKeys.SNIPER_BULLET, 10),
                CreatePoolAsync(AssetKeys.SHOTGUN_BULLET, 10)
            };
            
            await UniTask.WhenAll(taskList).AttachExternalCancellation(_tokenSource.Token);
        }

        public SceneEntity GetOrCreate(ProjectileType type, Transform firePoint, Vector3 direction)
        {
            if (_bulletPoolMap.TryGetValue(type, out var bulletPool))
            {
               var bullet = bulletPool.Spawn();
               bullet.Install();
               var transform = bullet.GetTransform();
               transform.position = firePoint.position;
               transform.rotation = Quaternion.LookRotation(direction);
               
               bullet.AddBehaviour<RigidBodyMovementBehaviour>();
               bullet.AddBehaviour<ReturnToPoolBehaviour>();
               _sceneEntityWorld.AddEntity(bullet);
               
               bullet.GetDieAction().Subscribe(OnDespawn);
               bullet.Enable();
               
               return bullet;
            }

            throw new KeyNotFoundException($"key {type} doesn't exit");
        }

        private void OnDespawn(IEntity entity)
        {
            var type = entity.GetProjectileType();
            if (_bulletPoolMap.TryGetValue(type, out var bulletPool))
            {
                bulletPool.DeSpawn(entity.GetSceneEntity());
                return;
            }
            
            throw new KeyNotFoundException($"key {type} doesn't exit");
        }

        private async UniTask CreatePoolAsync(string key, int size)
        {
           var bullet = await _assetProvider.LoadAsync<GameObject>(key);

           var bulletEntity = bullet.GetComponent<SceneEntity>();
           var type =  bulletEntity.GetProjectileType();
           _bulletPoolMap.Add(type, new MonoPool<SceneEntity>(bulletEntity, size, _poolContainer));
        }
        
        public void Dispose()
        {
            _tokenSource?.Cancel();
            _tokenSource?.Dispose();
        }
    }
}