using Atomic.Entities;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace GamePlay
{
    public interface IBulletFactory
    {
        public UniTask CreatePoolsAsync();
        public SceneEntity GetOrCreate(ProjectileType type, Transform firePoint, Vector3 direction);
    }
}