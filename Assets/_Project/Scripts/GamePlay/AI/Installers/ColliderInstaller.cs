using System;
using Atomic.AI;
using UnityEngine;

namespace GamePlay
{
    [Serializable]
    public sealed class ColliderInstaller : IBlackboardInstaller
    {
        [SerializeField]
        private Collider _collider;
        
        public void Install(IBlackboard blackboard)
        {
            blackboard.SetHandCollider(_collider);
        }
    }
}