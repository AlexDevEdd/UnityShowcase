using System;
using Atomic.AI;
using UnityEngine;

namespace GamePlay
{
    [Serializable]
    public sealed class SphereColliderSensor : IAIUpdate
    {
        public void OnUpdate(IBlackboard blackboard, float deltaTime)
        {
            ref SphereSensorData sensorData = ref blackboard.GetSphereSensorData();
            ref BufferData<Collider> buffer = ref blackboard.GetCollidersBuffer();

             int size = Physics.OverlapSphereNonAlloc(
                 sensorData.Center.position,
                 sensorData.Radius,
                 buffer.Values,
                 sensorData.LayerMask
             );
            
             buffer.Size = size;
        }
    }
}