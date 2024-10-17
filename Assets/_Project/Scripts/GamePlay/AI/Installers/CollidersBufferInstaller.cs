using System;
using Atomic.AI;
using UnityEngine;

namespace GamePlay
{
    [Serializable]
    public sealed class CollidersBufferInstaller : IBlackboardInstaller
    {
        [SerializeField]
        private int _initialSize;
        
        public void Install(IBlackboard blackboard)
        {
            blackboard.SetStruct(BlackboardAPI.CollidersBuffer, new BufferData<Collider>
            {
                Values = new Collider[_initialSize],
                Size = 0
            });
        }
    }
}