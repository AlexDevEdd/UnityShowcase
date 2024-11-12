using System;
using Atomic.AI;
using UnityEngine;

namespace GamePlay
{
    [Serializable]
    public sealed class AssignStoppingDistanceBlackboardAction : IBlackboardAction
    {
        [SerializeField]
        private float _minDistance;
        
        public void Invoke(IBlackboard blackboard)
        {
            blackboard.SetStoppingDistance(_minDistance);
            blackboard.GetAgent().stoppingDistance = _minDistance;
        }
    }
}