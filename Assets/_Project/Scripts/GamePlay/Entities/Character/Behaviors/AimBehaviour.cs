using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace GamePlay
{
    public sealed class AimBehaviour : IEntityInit, IEntityUpdate
    {
        private const float Y_OFFSET = 1f;

        private IValue<RaycastHit> _rayHitInfo;
        private Transform _aim;
        private Transform _characterTransform;

        public void Init(IEntity entity)
        {
            _aim = entity.GetAimTransform();
            _rayHitInfo = entity.GetRayHitInfo();
            _characterTransform = entity.GetTransform();
        }

        public void OnUpdate(IEntity entity, float deltaTime)
        {
            if (_rayHitInfo != null && _rayHitInfo.Value.collider)
            {
                // _aim.position = _rayHitInfo.Value.collider.gameObject.layer == GameLayers.GROUND_LAYER
                //     ? new Vector3(_rayHitInfo.Value.point.x, _characterTransform.position.y + Y_OFFSET,
                //         _rayHitInfo.Value.point.z)
                //     : new Vector3(_rayHitInfo.Value.point.x, _rayHitInfo.Value.point.y, _rayHitInfo.Value.point.z);
                
                _aim.position =
                     new Vector3(_rayHitInfo.Value.point.x, _rayHitInfo.Value.point.y, _rayHitInfo.Value.point.z);
            }
        }
    }
}