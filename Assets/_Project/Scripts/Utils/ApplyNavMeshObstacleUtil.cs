using System.Linq;
using Sirenix.OdinInspector;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.AI;

namespace Utils
{
    public class ApplyNavMeshObstacleUtil : MonoBehaviour
    {
        [SerializeField] private Transform _root;

        [Button]
        private void Apply()
        {
            var objects = GetComponentsInChildren<Collider>();
            var obstacles = objects.Where(o =>
                o.gameObject.layer == LayerMask.NameToLayer("Obstacle"))
                .Select(o => o.gameObject)
                .ToArray();

            foreach (var obstacle in obstacles)
            {
                obstacle.AddComponent<NavMeshObstacle>();
            }
        }
        
        [Button]
        private void Remove()
        {
            var objects = GetComponentsInChildren<NavMeshObstacle>().Select(o => o.gameObject).ToArray();
            foreach (var obj in objects)
            {
                var obstacle = obj.GetComponent<NavMeshObstacle>();
                DestroyImmediate(obstacle);
            }
        }
    }
}