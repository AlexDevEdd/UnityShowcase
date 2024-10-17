using Atomic.AI;
using Atomic.Entities;
using UnityEngine;

namespace GamePlay
{
    public sealed class TriggerSensor : MonoBehaviour
    {
        [SerializeField] 
        private SceneBlackboard _blackboard;

        private void OnTriggerEnter(Collider col)
        {
            if (col.TryGetComponent(out IEntity obj))
            {
                _blackboard.SetTarget(obj);
            }
        }

        private void OnTriggerExit(Collider col)
        {
            if (col.TryGetComponent(out IEntity _))
            {
                _blackboard.DelTarget();
            }
        }
    }
}