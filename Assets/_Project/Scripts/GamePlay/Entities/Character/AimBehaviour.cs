using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace GamePlay
{
    public sealed class AimBehaviour : IEntityInit, IEntityUpdate
    {
        private IValue<Vector3> _rayHitInfo; 
        private Transform _aim; 
        
        public void Init(IEntity entity)
        {
            _rayHitInfo = entity.GetRayHitInfo();
            _aim = entity.GetAimTransform();
        }
        
        public void OnUpdate(IEntity entity, float deltaTime)
        {
            _aim.position = _rayHitInfo.Value;
        }
    }
}