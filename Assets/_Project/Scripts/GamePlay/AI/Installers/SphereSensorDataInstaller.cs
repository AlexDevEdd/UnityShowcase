using System;
using Atomic.AI;
using UnityEngine;

namespace GamePlay
{
    [Serializable]
    public sealed class SphereSensorDataInstaller : IBlackboardInstaller
    {
        [SerializeField]
        private SphereSensorData _sensorData;
        
        public void Install(IBlackboard blackboard)
        {
            blackboard.SetSphereSensorData(_sensorData);
        }
    }
}
