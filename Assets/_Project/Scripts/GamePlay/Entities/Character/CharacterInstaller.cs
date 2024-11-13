using Atomic.Elements;
using Atomic.Entities;
using Atomic.Extensions;
using UnityEngine;
using UnityEngine.Animations.Rigging;
using UnityEngine.Serialization;
using Utils;

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
        private float _health = 100;
        
        [SerializeField]
        private int _maxHealth = 100;
        
        [SerializeField]
        private Vector3 _moveDirection;
        
        [SerializeField]
        private Vector2 _lookingDirection;
        
        [SerializeField]
        private LayerMask _aimLayerMask;
        
        [SerializeField]
        private Transform _aimTransform;

        [SerializeField] 
        private Transform _currentLeftHandIKTarget;
        
        [SerializeField] 
        private Transform _weaponHolder;
        
        [SerializeField] 
        private Animator _animator;
        
        [SerializeField] 
        private Rig _rig;
        
        [SerializeField] 
        private SceneEntity _defaultWeapon;
        
        [SerializeField] 
        private LineRenderer _lineRenderer;
        
        [SerializeField]
        private float _laserDistance = 4f;
        
        public override void Install(IEntity entity)
        {
            //tags
            entity.AddTag(TagAPI.Character);
            entity.AddTag(TagAPI.Damagable);
            
            //components
            entity.AddRig(_rig);
            entity.AddCamera(Camera.main);
            entity.AddAnimator(_animator);
            entity.AddRayHitInfo(new ReactiveVariable<RaycastHit>());
            entity.AddCharacterController(_characterController);
            entity.AddLaser(_lineRenderer);
            
            entity.AddTransform(transform);
            entity.AddAimTransform(_aimTransform);
            entity.AddLeftHandIKTarget(_currentLeftHandIKTarget);
            entity.AddWeaponHolder(_weaponHolder);
            
            entity.AddCurrentWeapon(new ReactiveVariable<IEntity>(_defaultWeapon));
            
            //params
            entity.AddMoveSpeed(new ReactiveFloat(_moveSpeed));
            entity.AddRunSpeed(new ReactiveFloat(_runSpeed));
            entity.AddHealth(new ReactiveFloat(_health));
            entity.AddMaxHealth(new ReactiveInt(_maxHealth));
            entity.AddLaserDistance(new ReactiveFloat(_laserDistance));
            
            entity.AddLayerMask(_aimLayerMask);
            entity.AddMoveDirection(new ReactiveVector3(_moveDirection));
            entity.AddLookingDirection(new ReactiveVector2(_lookingDirection));
            entity.AddPosition(new float3Reactive(transform.position));
            entity.AddRotation(new quaternionReactive(transform.rotation));
            
            //behaviors
            entity.AddBehaviour<AimBehaviour>();
            entity.AddBehaviour<CharacterMovementBehaviour>();
            entity.AddBehaviour<CharacterRotationBehaviour>();
            entity.AddBehaviour<CharacterAnimationMovementBehaviour>();
            entity.AddBehaviour<CharacterAnimationFireBehaviour>();
            entity.AddBehaviour<WeaponAnimationLayerBehaviour>();
            entity.AddBehaviour<WeaponReloadAnimationBehaviour>();
            entity.AddBehaviour<LaserBehaviour>();
            
            entity.AddBehaviour<DamageRequestBehaviour>();
            entity.AddBehaviour<ApplyDamageBehaviour>();
            entity.AddBehaviour<DieAnimationBehaviour>();
            
            //flags
            entity.AddIsRunning(new ReactiveBool(false));
            entity.AddIsReloading(new ReactiveBool(false));
            
            //Events & Requests
            entity.AddFireAction(new EventAction());
            entity.AddSwitchWeaponEvent(new EventAction<int>());
            entity.AddReloadWeaponEvent(new EventAction());
            entity.AddReloadWeaponRequest(new EventAction());
            
            entity.AddDamageRequest(new EventAction<IEntity, Vector3, float>());
            entity.AddDamageEvent(new EventAction<IEntity, Vector3, float>());
            entity.AddDieAction(new EventAction<IEntity>());
            


            
        }
    }
}