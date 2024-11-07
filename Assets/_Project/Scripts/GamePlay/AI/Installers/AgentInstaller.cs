using System;
using Atomic.AI;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.AI;

namespace GamePlay
{
    [Serializable, InlineProperty]
    public sealed class AgentInstaller : IBlackboardInstaller
    {
        [HorizontalGroup]
        [SerializeField]
        private NavMeshAgent _agent;
        
        public void Install(IBlackboard blackboard)
        {
            blackboard.SetAgent(_agent);
        }
    }
}