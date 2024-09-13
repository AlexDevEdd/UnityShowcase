using Atomic.Elements;
using Atomic.Entities;
using Atomic.Extensions;
using UnityEngine;

namespace GamePlay
{
    public sealed class CharacterInstaller : SceneEntityInstallerBase
    {
        [SerializeField]
        private CharacterController _characterController;
        
        [SerializeField]
        private float _moveSpeed = 5;
        
        [SerializeField]
        private Vector3 _moveDirection;
        
        [SerializeField]
        private Vector2 _lookingDirection;
        
        [SerializeField]
        private LayerMask _aimLayerMask;
        
        [SerializeField]
        private Transform _aimTransform;
        
        
        public override void Install(IEntity entity)
        {
            entity.AddCamera(Camera.main);
            entity.AddLayerMask(_aimLayerMask);
            entity.AddRayHitInfo(new ReactiveVector3());
            entity.AddCharacterController(_characterController);
            
            entity.AddAimTransform(_aimTransform);
            entity.AddBehaviour<AimBehaviour>();
            
            entity.AddTransform(transform);
            entity.AddPosition(new float3Reactive(transform.position));
            entity.AddRotation(new quaternionReactive(transform.rotation));
            
            entity.AddMoveSpeed(_moveSpeed);
            entity.AddMoveDirection(_moveDirection);
            entity.AddBehaviour<CharacterMovementBehaviour>();
            
            entity.AddLookingDirection(_lookingDirection);
            entity.AddBehaviour<CharacterRotationBehaviour>();
        }
    }
}