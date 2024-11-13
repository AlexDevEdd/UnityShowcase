using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;
using UnityEngine.AI;

namespace GamePlay
{
    public sealed class EnemyInstaller : SceneEntityInstallerBase
    {
        [SerializeField]
        private NavMeshAgent _agent;
        
        [SerializeField]
        private int _initHealth = 20;
        
        public override void Install(IEntity entity)
        {
            entity.AddTag(TagAPI.Enemy);
            entity.AddTag(TagAPI.Damagable);
            entity.AddTransform(transform);
            entity.AddAgent(_agent);
            entity.AddMoveDirection(new ReactiveVector3(Vector3.zero));
            entity.AddHealth(new ReactiveFloat(_initHealth));   
            entity.AddMoveSpeed(new ReactiveFloat(0));
            entity.AddFireAction(new EventAction());

            entity.AddDamageRequest(new EventAction<IEntity, Vector3, float>());
            entity.AddDamageEvent(new EventAction<IEntity, Vector3, float>());
            entity.AddDieAction(new EventAction<IEntity>());
            
            entity.AddBehaviour<DamageRequestBehaviour>();
            entity.AddBehaviour<ApplyDamageBehaviour>();
        }
    }
}