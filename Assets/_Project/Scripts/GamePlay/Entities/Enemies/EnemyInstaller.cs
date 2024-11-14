﻿using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Serialization;

namespace GamePlay
{
    public sealed class EnemyInstaller : SceneEntityInstallerBase
    {
        [SerializeField]
        private NavMeshAgent _agent;
        
        [SerializeField]
        private int _initHealth = 20;
        
        [SerializeField] 
        private CollisionObserver _collisionObserver;
        
        public override void Install(IEntity entity)
        {
            //tags
            entity.AddTag(TagAPI.Enemy);
            entity.AddTag(TagAPI.Damagable);
            
            //components
            entity.AddTransform(transform);
            entity.AddAgent(_agent);
            entity.AddCollisionObserver(_collisionObserver);
           
            //params
            entity.AddDamage(new ReactiveFloat(20));
            entity.AddMoveDirection(new ReactiveVector3(Vector3.zero));
            entity.AddHealth(new ReactiveFloat(_initHealth));   
            entity.AddMoveSpeed(new ReactiveFloat(0));
            
            //behaviours
            entity.AddBehaviour<DamageRequestNotifier>();
            entity.AddBehaviour<DamageRequestBehaviour>();
            entity.AddBehaviour<ApplyDamageBehaviour>();

            //events & requests
            entity.AddFireAction(new EventAction());
            entity.AddDieAction(new EventAction<IEntity>());
            
            entity.AddDamageRequest(new EventAction<IEntity, Vector3, float>());
            entity.AddDamageEvent(new EventAction<IEntity, Vector3, float>());      
        }
    }
}