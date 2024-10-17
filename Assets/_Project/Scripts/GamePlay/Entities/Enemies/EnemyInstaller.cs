using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace GamePlay
{
    public sealed class EnemyInstaller : SceneEntityInstallerBase
    {
        public override void Install(IEntity entity)
        {
            //entity.AddTag(TagAPI.);
            entity.AddTransform(transform);
            entity.AddMoveDirection(new ReactiveVector3(Vector3.zero));
            entity.AddMoveSpeed(new ReactiveFloat(5));
            entity.AddBehaviour<TransformMovementBehaviour>();
        }
    }
}