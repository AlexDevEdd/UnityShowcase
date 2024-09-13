using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace GamePlay
{
    public sealed class CharacterRotationBehaviour : IEntityInit, IEntityUpdate
    {
        private LayerMask _aimLayerMask;
        private Camera _camera;
        
        private IVariable<Vector2> _lookingDirection;
        private IVariable<Vector3> _rayHitInfo; 
        
        private Transform _transform;
        private Vector3 _direction;
        
        public void Init(IEntity entity)
        {
            _camera = entity.GetCamera();
            _transform = entity.GetTransform();
            _aimLayerMask = entity.GetLayerMask();
            _lookingDirection = entity.GetLookingDirection();
            _rayHitInfo = entity.GetRayHitInfo();
        }
        
        public void OnUpdate(IEntity entity, float deltaTime)
        {
            if (_lookingDirection.Value.Equals(Vector3.zero))
            {
                return;
            }
            
            var ray = _camera.ScreenPointToRay(_lookingDirection.Value);
           
            if (Physics.Raycast(ray, out var hitInfo, Mathf.Infinity, _aimLayerMask))
            {
                _direction = hitInfo.point - _transform.position;
                _direction.y = 0f; 
                _direction.Normalize();
                
                _transform.forward = _direction;
                _rayHitInfo.Value = new Vector3(hitInfo.point.x, hitInfo.point.y, hitInfo.point.z);
            }
        }
    }
}