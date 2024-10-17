using System;
using Atomic.AI;
using UnityEngine;

namespace GamePlay
{
    [Serializable]
    public sealed class PatrolDataInstaller : IBlackboardInstaller
    {
        [SerializeField]
        private PatrolData _patrolData;
        
        public void Install(IBlackboard blackboard)
        {
            blackboard.SetStruct(BlackboardAPI.PatrolData, _patrolData);
        }
    }
}