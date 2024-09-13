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
        private float _moveSpeed = 2;
        
        [SerializeField]
        private float _runSpeed = 3;
        
        [SerializeField]
        private Vector3 _moveDirection;
        
        [SerializeField]
        private Vector2 _lookingDirection;
        
        [SerializeField]
        private LayerMask _aimLayerMask;
        
        [SerializeField]
        private Transform _aimTransform;

        [SerializeField] 
        private Animator _animator;
        
        
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
            entity.AddRunSpeed(_runSpeed);
            entity.AddMoveDirection(_moveDirection);
            entity.AddIsRunning(new ReactiveBool(false));
            entity.AddBehaviour<CharacterMovementBehaviour>();
            
            entity.AddLookingDirection(_lookingDirection);
            entity.AddBehaviour<CharacterRotationBehaviour>();

            entity.AddAnimator(_animator);
            entity.AddBehaviour<CharacterAnimationMovementBehaviour>();

            entity.AddFireEvent(new EventAction());
            entity.AddBehaviour<CharacterAnimationFireBehaviour>();
        }
    }
}