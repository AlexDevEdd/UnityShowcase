using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace GamePlay
{
    public sealed class BulletInstaller : SceneEntityInstallerBase
    {
        [SerializeField] 
        private ProjectileType _projectileType;
        
        [SerializeField] 
        private Rigidbody _rigidbody;
        
        [SerializeField] 
        private float _moveSpeed = 5;
        
        [SerializeField] 
        private float _lifeTime = 3;

        [SerializeField] 
        private CollisionObserver _collisionObserver;
        
        public override void Install(IEntity entity)
        {
            entity.AddTransform(transform);
            entity.AddProjectileType(_projectileType);
            entity.AddRigidbody(_rigidbody);
            entity.AddMoveSpeed(new ReactiveFloat(_moveSpeed));
            entity.AddLifeTimer(new Countdown(_lifeTime));

            entity.AddDieAction(new EventAction<IEntity>());
            entity.AddCollisionObserver(_collisionObserver);
            
            entity.AddSceneEntity(GetComponent<SceneEntity>());
        }
    }
}