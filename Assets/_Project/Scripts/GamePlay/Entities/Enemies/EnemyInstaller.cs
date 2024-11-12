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
        
        public override void Install(IEntity entity)
        {
            entity.AddTag(TagAPI.Enemy);
            entity.AddTransform(transform);
            entity.AddAgent(_agent);
            entity.AddMoveDirection(new ReactiveVector3(Vector3.zero));
            entity.AddMoveSpeed(new ReactiveFloat(0));
            entity.AddFireAction(new EventAction());
        }
    }
}