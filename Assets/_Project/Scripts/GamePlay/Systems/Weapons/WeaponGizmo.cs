using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace GamePlay
{
    public sealed class WeaponGizmo : IEntityGizmos
    {
        private Transform _aim;
        private ReactiveVariable<IEntity> _weapon;

        public void Init(IEntity entity)
        {
            
            
        }
        public void OnGizmosDraw(IEntity entity)
        {
            _weapon = entity.GetCurrentWeapon();
            _aim = entity.GetAimTransform();
            var firePoint = _weapon.Value.GetFirePoint();
            Gizmos.color = Color.red;
            Gizmos.DrawLine(firePoint.position, _aim.position);
        }
    }
}